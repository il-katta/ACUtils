using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace ACUtils
{
    public class SqlDb : IDisposable
    {
        public string ConnectionString { get; }
        public ILogger logger { get; protected set; }
        private TransactionScope scope;

        private static MissingSchemaAction? missingSchemaAction;

        private bool _persistentConnection = false;
        private SqlConnection _connection = null;
        public static MissingSchemaAction MissingSchemaAction
        {
            get
            {
                if (missingSchemaAction == null)
                {
                    missingSchemaAction = MissingSchemaAction.AddWithKey;
                }
                return missingSchemaAction.GetValueOrDefault();
            }
            set => missingSchemaAction = value;
        }

        #region constructor
        public SqlDb(string connectionString, ILogger logger, bool persistentConnection = false)
        {
            this.ConnectionString = connectionString;
            this.logger = logger;
            scope = null;
            this._persistentConnection = persistentConnection;
        }

        public SqlDb(string connectionString, Serilog.ILogger logger, bool persistentConnection = false)
        {
            this.ConnectionString = connectionString;
            this.logger = new SerilogWrapper(logger);
            scope = null;
            this._persistentConnection = persistentConnection;
        }

        public SqlDb(string connectionString, bool persistentConnection = false)
        {
            this.ConnectionString = connectionString;
            this.logger = null;
            scope = null;
            this._persistentConnection = persistentConnection;
        }
        #endregion

        #region generateCommand
        internal static SqlCommand generateCommand(SqlConnection connection, string queryString)
        {
            return new SqlCommand(queryString, connection);
        }

        internal static SqlCommand generateCommand(SqlConnection connection, string queryString, KeyValuePair<string, object>[] queryParams)
        {
            SqlCommand command = new SqlCommand(queryString, connection);
            foreach (KeyValuePair<string, object> param in queryParams)
            {
                command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
            }
            return command;
        }

        internal static SqlCommand generateCommand(SqlConnection connection, string queryString, KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
        {
            SqlCommand command = new SqlCommand(queryString, connection);
            foreach (KeyValuePair<string, KeyValuePair<SqlDbType, object>> param in queryParams)
            {
                command.Parameters.Add(param.Key, param.Value.Key).Value = param.Value.Value ?? DBNull.Value;
            }
            return command;
        }
        #endregion

        #region log
        internal static string SqlTypeToString(SqlDbType type)
        {
            switch (type)
            {
                case SqlDbType.NVarChar:
                    return "NVarChar(250)";
                case SqlDbType.Char:
                    return "Char(250)";
                default:
                    return type.ToString();
            }
        }

        private class TypeSwitch
        {
            private Dictionary<Type, Func<object, string>> matches = new Dictionary<Type, Func<object, string>>();
            public TypeSwitch Case<T>(Func<T, string> action) { matches.Add(typeof(T), (x) => action((T)x)); return this; }
            public string Switch(object x)
            {
                if (x == null)
                {
                    return "NULL";
                }

                try
                {
                    return matches[x.GetType()](x);
                }
                catch
                {
                    return $"'{x}'";
                }
            }
        }

        private static string ValueToString(object obj)
        {
            TypeSwitch ts = new TypeSwitch()
                .Case((bool x) => x ? "1" : "0")
                .Case((string x) => $"'{x}'")
                .Case((int x) => x.ToString(CultureInfo.InvariantCulture))
                .Case((float x) => x.ToString(CultureInfo.InvariantCulture))
                .Case((decimal x) => x.ToString(CultureInfo.InvariantCulture))
                .Case((long x) => x.ToString(CultureInfo.InvariantCulture))
                .Case((short x) => x.ToString(CultureInfo.InvariantCulture))
                .Case((DateTime x) => $"'{x.ToString(CultureInfo.InvariantCulture)}'")// TODO: forzare formattazione
                .Case((char x) => $"'{x.ToString(CultureInfo.InvariantCulture)}'")
            ;
            return ts.Switch(obj);
        }

        internal void WriteLog(string queryString, KeyValuePair<string, object>[] queryParams)
        {
            if (logger == null)
            {
                return;
            }
            string declares = string.Join(
                Environment.NewLine,
                from p in queryParams select $"DECLARE {p.Key} VARCHAR(250) = {ValueToString(p.Value)}"
            );
            string callerStack = GetCallerStack(4, 3);
            logger.Debug($"SQL {callerStack}{Environment.NewLine}{declares}{Environment.NewLine}{queryString}");
        }

        internal void WriteLog(Exception exception, string queryString, KeyValuePair<string, object>[] queryParams)
        {
            if (logger == null)
            {
                return;
            }
            string callerStack = GetCallerStack(4, 3);
            logger.Error($"SQL {callerStack} : {exception}");
        }

        internal void WriteLog(string queryString, KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
        {
            if (logger == null)
            {
                return;
            }

            string declares = string.Join(
                    Environment.NewLine,
                    from p in queryParams select $"DECLARE {p.Key} {SqlTypeToString(p.Value.Key)} = {ValueToString(p.Value.Value)}"
            );
            string callerStack = GetCallerStack(4, 3);
            logger.Debug($"SQL {callerStack}{Environment.NewLine}{declares}{Environment.NewLine}{queryString}");
        }

        internal void WriteLog(Exception exception, string queryString, KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
        {
            if (logger == null)
            {
                return;
            }
            string callerStack = GetCallerStack(4, 3);
            logger.Error($"SQL {callerStack} : {exception}");
        }

        internal string GetCallerStack(int start, int count)
        {
            string callerStack = "";

            foreach (int i in Enumerable.Range(start, count))
            {
                try
                {
                    System.Diagnostics.StackFrame stack = new System.Diagnostics.StackFrame(i, true);
                    callerStack += $" < {stack.GetMethod().DeclaringType}.{stack.GetMethod().Name}";
                }
                catch { }
            }

            return callerStack;
        }
        #endregion

        #region transaction
        public TransactionScope BeginTransaction()
        {
            scope = new TransactionScope();
            return scope;
        }

        public void CompleteTransaction()
        {
            if (Transaction.Current.TransactionInformation.Status == TransactionStatus.Active)
            {
                scope?.Complete();
            }
        }

        public void AbortTransaction()
        {
            if (Transaction.Current?.TransactionInformation?.Status == TransactionStatus.Active)
            {
                scope?.Dispose();
            }
        }

        #endregion

        #region datatable generation
        ///###############################################################
        /// <summary>
        /// Convert a List to a DataTable.
        /// </summary>
        /// <remarks>
        /// Based on MIT-licensed code presented at http://www.chinhdo.com/20090402/convert-list-to-datatable/ as "ToDataTable"
        /// <para/>Code modifications made by Nick Campbell.
        /// <para/>Source code provided on this web site (chinhdo.com) is under the MIT license.
        /// <para/>Copyright © 2010 Chinh Do
        /// <para/>Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
        /// <para/>The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
        /// <para/>THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
        /// <para/>(As per http://www.chinhdo.com/20080825/transactional-file-manager/)
        /// </remarks>
        /// <typeparam name="T">Type representing the type to convert.</typeparam>
        /// <param name="l_oItems">List of requested type representing the values to convert.</param>
        /// <returns></returns>
        ///###############################################################
        /// <LastUpdated>February 15, 2010</LastUpdated>
        public static DataTable ToDataTable<T>(IEnumerable<T> l_oItems)
        {
            DataTable oReturn = new DataTable(typeof(T).Name);
            object[] a_oValues;
            int i;

            //#### Collect the a_oProperties for the passed T
            System.Reflection.PropertyInfo[] a_oProperties = typeof(T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);

            //#### Traverse each oProperty, .Add'ing each .Name/.BaseType into our oReturn value
            //####     NOTE: The call to .BaseType is required as DataTables/DataSets do not support nullable types, so it's non-nullable counterpart Type is required in the .Column definition
            foreach (System.Reflection.PropertyInfo oProperty in a_oProperties)
            {
                oReturn.Columns.Add(oProperty.Name, BaseType(oProperty.PropertyType));
            }

            //#### Traverse the l_oItems
            foreach (T oItem in l_oItems)
            {
                //#### Collect the a_oValues for this loop
                a_oValues = new object[a_oProperties.Length];

                //#### Traverse the a_oProperties, populating each a_oValues as we go
                for (i = 0; i < a_oProperties.Length; i++)
                {
                    a_oValues[i] = a_oProperties[i].GetValue(oItem, null);
                }

                //#### .Add the .Row that represents the current a_oValues into our oReturn value
                oReturn.Rows.Add(a_oValues);
            }

            //#### Return the above determined oReturn value to the caller
            return oReturn;
        }

        ///###############################################################
        /// <summary>
        /// Returns the underlying/base type of nullable types.
        /// </summary>
        /// <remarks>
        /// Based on MIT-licensed code presented at http://www.chinhdo.com/20090402/convert-list-to-datatable/ as "GetCoreType"
        /// <para/>Code modifications made by Nick Campbell.
        /// <para/>Source code provided on this web site (chinhdo.com) is under the MIT license.
        /// <para/>Copyright © 2010 Chinh Do
        /// <para/>Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
        /// <para/>The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
        /// <para/>THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
        /// <para/>(As per http://www.chinhdo.com/20080825/transactional-file-manager/)
        /// </remarks>
        /// <param name="oType">Type representing the type to query.</param>
        /// <returns>Type representing the underlying/base type.</returns>
        ///###############################################################
        /// <LastUpdated>February 15, 2010</LastUpdated>
        public static Type BaseType(Type oType)
        {
            //#### If the passed oType is valid, .IsValueType and is logicially nullable, .Get(its)UnderlyingType
            if (oType != null && oType.IsValueType &&
                oType.IsGenericType && oType.GetGenericTypeDefinition() == typeof(Nullable<>)
            )
            {
                return Nullable.GetUnderlyingType(oType);
            }
            //#### Else the passed oType was null or was not logicially nullable, so simply return the passed oType
            else
            {
                return oType;
            }
        }
        #endregion

        #region IDisposable
        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            try
            {
                AbortTransaction();
            }
            catch { }

            try
            {
                if (_connection?.State == ConnectionState.Open)
                {
                    _connection.Close();
                    SqlConnection.ClearPool(_connection);
                }
            }
            catch { }
        }
        #endregion

        private SqlConnection _rawConnection()
        {
            if (_persistentConnection)
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection(ConnectionString);
                }

                return _connection;
            }
            var newConn = new SqlConnection(ConnectionString);
            return newConn;
        }

        internal ConnectionWrapper _getConnection()
        {
            var conn = _rawConnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            return new ConnectionWrapper(conn, !this._persistentConnection);

        }

        internal async Task<ConnectionWrapper> _getConnectionAsync(System.Threading.CancellationToken? cancellationToken = null)
        {
            var conn = _rawConnection();
            if (conn.State != ConnectionState.Open)
            {
                if (cancellationToken.HasValue)
                {
                    await conn.OpenAsync(cancellationToken.Value);

                }
                else
                {
                    await conn.OpenAsync();
                }
            }
            return new ConnectionWrapper(conn, !this._persistentConnection);
        }

        public static T GetColVal<T>(DataRow dataRow, string columnName)
        {
            // dataRow.Field<T>(columnName)
            object val = dataRow[columnName];
            switch (val.GetType().Name)
            {
                case "DBNull":
                    return default(T);
            }
            switch (typeof(T).Name)
            {
                case "String":
                case "string":
                    return (T)(object)val.ToString().Trim(); // OMFG!
                case "Int32":
                    if (val.GetType().Name.Equals("Decimal"))
                    {
                        return (T)(object)decimal.ToInt32((decimal)val);
                    }
                    return (T)val;
                case "Int64":
                    if (val.GetType().Name == "Int32")
                    {
                        return (T)(object)(int)val;
                    }

                    return (T)val;
                default:
                    return (T)val;
            }
        }
        internal static T _changeType<T>(object value)
        {
            // conversione variabile da object a type specificato
            //return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFrom(value);
            var type = typeof(T);
            if (Nullable.GetUnderlyingType(typeof(T)) != null)
            {
                type = Nullable.GetUnderlyingType(type);
                if (value == null || value == DBNull.Value)
                {
                    return default(T);
                }
            }
            return (T)Convert.ChangeType(value, type);
        }
    }
}
