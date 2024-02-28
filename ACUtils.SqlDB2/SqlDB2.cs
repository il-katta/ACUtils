using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Data;
using IBM.Data.DB2.iSeries;
using ACUtils.Exceptions;

namespace ACUtils
{
    public class SqlDB2 : IDisposable
    {

        public ILogger logger { get; protected set; }
        string ConnectionString;
        bool connectionPersist;
        bool useTransaction = false;
        private iDB2Transaction _transaction;
        private iDB2Connection _connection;
        public SqlDB2(string connectionString, ILogger logger, bool connectionPersist = false)
        {
            ConnectionString = connectionString;
            this.connectionPersist = connectionPersist;
            this.logger = logger;
        }
        public SqlDB2(string connectionString, bool connectionPersist = false)
        {
            ConnectionString = connectionString;
            this.connectionPersist = connectionPersist;
        }


        public DataTable QueryDataTable(string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            DataSet ds = QueryDataSet(queryString, queryParams);
            return ds.Tables[0];
        }

        public DataTable QueryDataTable(string queryString, params KeyValuePair<string, KeyValuePair<iDB2DbType, object>>[] queryParams)
        {
            DataSet ds = QueryDataSet(queryString, queryParams);
            return ds.Tables[0];
        }

        public DataTable QueryDataTable(string queryString)
        {
            DataSet ds = QueryDataSet(queryString);
            return ds.Tables[0];
        }


        public DataSet QueryDataSet(string queryString, params KeyValuePair<string, KeyValuePair<iDB2DbType, object>>[] queryParams)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    iDB2Command selectCommand = GenerateCommand(connection.Connection, queryString, queryParams);
                    iDB2DataAdapter adapter = new iDB2DataAdapter(selectCommand);
                    DataSet ds = new DataSet();
                    // adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
                    adapter.Fill(ds);
                    return ds;
                }
                catch (Exception ex)
                {
                    WriteLog(ex, queryString, queryParams);
                    throw;
                }
                finally
                {
                    ConnectionClose(connection);
                }
            }
        }

        public DataSet QueryDataSet(string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    iDB2Command selectCommand = GenerateCommand(connection.Connection, queryString, queryParams);
                    iDB2DataAdapter adapter = new iDB2DataAdapter(selectCommand);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "table");
                    return ds;
                }
                catch (Exception ex)
                {
                    WriteLog(ex, queryString, queryParams);
                    throw;
                }
                finally
                {
                    ConnectionClose(connection);
                }
            }
        }

        public DataSet QueryDataSet(string queryString)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    iDB2Command selectCommand = GenerateCommand(connection, queryString);
                    iDB2DataAdapter adapter = new iDB2DataAdapter(selectCommand);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "table");
                    return ds;
                }
                catch (Exception ex)
                {
                    WriteLog(ex, queryString);
                    throw;
                }
                finally
                {
                    ConnectionClose(connection);
                }
            }
        }

        public DataRow QueryDataRow(string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            DataTable dt = QueryDataTable(queryString, queryParams);

            if (dt.Rows.Count == 0)
                throw new NotFoundException("nessun risultato ottenuto");

            if (dt.Rows.Count > 1)
                throw new TooMuchResultsException("ottenuto più valori");

            return dt.Rows[0];
        }
        #region QuerySingleValue
        public T QuerySingleValue<T>(string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    iDB2Command selectCommand = GenerateCommand(connection.Connection, queryString, queryParams);
                    object value = selectCommand.ExecuteScalar();
                    try
                    {
                        return (T)Convert.ChangeType(value, typeof(T));
                    }
                    catch
                    {
                        return default(T);
                    }
                }
                catch (Exception ex)
                {
                    WriteLog(ex, queryString, queryParams);
                    throw;
                }
                finally
                {
                    ConnectionClose(connection);
                }
            }
        }

        public T QuerySingleValue<T>(iDB2Connection connection, string queryString, params KeyValuePair<string, KeyValuePair<iDB2DbType, object>>[] queryParams)
        {
            iDB2Command selectCommand = GenerateCommand(connection, queryString, queryParams);
            object value = selectCommand.ExecuteScalar();
            return (T)Convert.ChangeType(value, typeof(T));
        }

        public T QuerySingleValue<T>(ConnectionWrapper connection, string queryString)
        {
            iDB2Command selectCommand = GenerateCommand(connection, queryString);
            object value = selectCommand.ExecuteScalar();
            return (T)Convert.ChangeType(value, typeof(T));
        }

        #endregion

        #region QueryReader

        public IEnumerable<iDB2DataReader> _queryReader(string queryString)
        {
            using (var connection = GetConnection())
            {
                using (iDB2DataReader reader = GenerateCommand(connection, queryString).ExecuteReader())
                {
                    while (reader.Read()) yield return reader;
                }
            }
        }

        public IEnumerable<iDB2DataReader> QueryReader(string queryString)
        {
            try
            {
                return _queryReader(queryString);
            }
            catch (Exception ex)
            {
                WriteLog(ex, queryString);
                throw;
            }
        }

        public IEnumerable<iDB2DataReader> _queryReader(string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            using (var connection = GetConnection())
            {
                using (iDB2DataReader reader = GenerateCommand(connection.Connection, queryString, queryParams).ExecuteReader())
                {
                    while (reader.Read()) yield return reader;
                }
            }
        }

        public IEnumerable<iDB2DataReader> QueryReader(string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            try
            {
                return _queryReader(queryString, queryParams);
            }
            catch (Exception ex)
            {
                WriteLog(ex, queryString, queryParams);
                throw;
            }
        }

        public IEnumerable<iDB2DataReader> _queryReader(iDB2Connection connection, string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            using (iDB2DataReader reader = GenerateCommand(connection, queryString, queryParams).ExecuteReader())
            {
                while (reader.Read()) yield return reader;
            }
        }

        public IEnumerable<iDB2DataReader> QueryReader(iDB2Connection connection, string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            try
            {
                return _queryReader(connection, queryString, queryParams);
            }
            catch (Exception ex)
            {
                WriteLog(ex, queryString, queryParams);
                throw;
            }
        }

        public IEnumerable<iDB2DataReader> _queryReader(ConnectionWrapper connection, string queryString)
        {
            using (iDB2DataReader reader = GenerateCommand(connection, queryString).ExecuteReader())
            {
                while (reader.Read()) yield return reader;
            }
        }

        public IEnumerable<iDB2DataReader> QueryReader(iDB2Connection connection, string queryString)
        {
            try
            {
                return _queryReader(connection, queryString);
            }
            catch (Exception ex)
            {
                WriteLog(ex, queryString);
                throw;
            }
        }

        #endregion

        #region Execute

        public bool Execute(string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    var selectCommand = GenerateCommand(connection.Connection, queryString, queryParams);
                    var value = selectCommand.ExecuteNonQuery() > 0;
                    return value;
                }
                catch (Exception ex)
                {
                    WriteLog(ex, queryString, queryParams);
                    throw;
                }
                finally
                {
                    ConnectionClose(connection);
                }
            }
        }

        public bool Execute(string queryString, params KeyValuePair<string, KeyValuePair<iDB2DbType, object>>[] queryParams)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    var selectCommand = GenerateCommand(connection.Connection, queryString, queryParams);
                    var value = selectCommand.ExecuteNonQuery() > 0;
                    return value;
                }
                catch (Exception ex)
                {
                    WriteLog(ex, queryString, queryParams);
                    throw;
                }
                finally
                {
                    ConnectionClose(connection);
                }
            }
        }

        public bool Execute(string queryString)
        {
            using (var connection = GetConnection())
            {
                try
                {

                    var selectCommand = GenerateCommand(connection, queryString);
                    var value = selectCommand.ExecuteNonQuery() > 0;
                    return value;
                }
                catch (Exception ex)
                {
                    WriteLog(ex, queryString);
                    throw;
                }
                finally
                {
                    ConnectionClose(connection);
                }
            }
        }

        #endregion

        #region GenerateCommand

        public iDB2Command GenerateCommand(ConnectionWrapper connection, string queryString)
        {
            WriteLog(queryString);
            var command = new iDB2Command(queryString, connection.Connection);
            if (useTransaction)
            {
                command.Transaction = _transaction;
            }
            command.CommandTimeout = 0;
            return command;
        }

        public iDB2Command GenerateCommand(iDB2Connection connection, string queryString, KeyValuePair<string, object>[] queryParams)
        {
            WriteLog(queryString, queryParams);
            var command = new iDB2Command(queryString, connection);
            if (useTransaction)
            {
                command.Transaction = _transaction;
            }
            foreach (KeyValuePair<string, object> param in queryParams)
                command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
            command.CommandTimeout = 0;
            return command;
        }

        public iDB2Command GenerateCommand(iDB2Connection connection, string queryString, KeyValuePair<string, KeyValuePair<iDB2DbType, object>>[] queryParams)
        {
            WriteLog(queryString, queryParams);
            iDB2Command command = new iDB2Command(queryString, connection);
            if (useTransaction)
            {
                command.Transaction = _transaction;
            }
            foreach (KeyValuePair<string, KeyValuePair<iDB2DbType, object>> param in queryParams)
                command.Parameters.Add(param.Key, param.Value.Key).Value = param.Value.Value ?? DBNull.Value;
            command.CommandTimeout = 0;
            return command;
        }

        #endregion

        public ConnectionWrapper GetConnection()
        {
            return _getConnection();
        }

        private iDB2Connection _rawConnection()
        {
            if (connectionPersist)
            {
                if (_connection == null)
                {
                    _connection = new iDB2Connection(ConnectionString);
                }

                return _connection;
            }
            var newConn = new iDB2Connection(ConnectionString);
            return newConn;
        }

        internal ConnectionWrapper _getConnection()
        {
            var conn = _rawConnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            return new ConnectionWrapper(conn, !this.connectionPersist);

        }

        public void ConnectionClose(ConnectionWrapper connection, bool force = false)
        {
            ConnectionClose(connection.Connection);
        }

        public void ConnectionClose(iDB2Connection connection, bool force = false)
        {
            if (!connectionPersist || force)
            {
                try
                {
                    connection.Close();
                }
                catch { }
            }
        }

        public void BeginTransaction()
        {
            useTransaction = true;
            connectionPersist = true;
            _transaction = GetConnection().Connection.BeginTransaction();
        }

        public void CompleteTransaction()
        {
            useTransaction = false;
            _transaction.Commit();
            _transaction.Dispose();
            _transaction = null;
        }

        public void AbortTransaction()
        {
            useTransaction = false;
            _transaction?.Rollback();
            _transaction?.Dispose();
            _transaction = null;
        }


        public void Dispose()
        {
            if (_transaction != null)
            {
                try
                {
                    _transaction.Dispose();
                }
                catch { }
            }
            if (connectionPersist && _connection != null)
            {
                ConnectionClose(_connection, force: true);
            }
        }

        #region log
        private void WriteLog(string queryString)
        {
            if (logger == null)
            {
                return;
            }
            string callerStack = GetCallerStack(4, 3);
            logger?.Debug($"SQL {callerStack}{Environment.NewLine}{queryString}");
        }

        private void WriteLog(Exception exception, string queryString)
        {
            if (logger == null)
            {
                return;
            }
            string callerStack = GetCallerStack(4, 3);
            logger?.Error($"SQL {callerStack} : {exception}");
        }

        private void WriteLog(string queryString, KeyValuePair<string, object>[] queryParams)
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
            logger?.Debug($"SQL {callerStack}{Environment.NewLine}{declares}{Environment.NewLine}{queryString}");
        }

        private void WriteLog(Exception exception, string queryString, KeyValuePair<string, object>[] queryParams)
        {
            if (logger == null)
            {
                return;
            }
            string callerStack = GetCallerStack(4, 3);
            logger?.Error($"SQL {callerStack} : {exception}");
        }

        private void WriteLog(string queryString, KeyValuePair<string, KeyValuePair<iDB2DbType, object>>[] queryParams)
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
            logger?.Debug($"SQL {callerStack}{Environment.NewLine}{declares}{Environment.NewLine}{queryString}");
        }

        private void WriteLog(Exception exception, string queryString, KeyValuePair<string, KeyValuePair<iDB2DbType, object>>[] queryParams)
        {
            if (logger == null)
            {
                return;
            }
            string callerStack = GetCallerStack(4, 3);
            logger?.Error($"SQL {callerStack} : {exception}");
        }


        private static string SqlTypeToString(iDB2DbType type)
        {
            switch (type)
            {
                case iDB2DbType.iDB2VarChar:
                    return "iDB2VarChar(250)";
                case iDB2DbType.iDB2Char:
                    return "iDB2Char(250)";
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

        private string GetCallerStack(int start, int count)
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



        #endregion

    }
}