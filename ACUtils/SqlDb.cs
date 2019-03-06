using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Transactions;

namespace ACUtils
{
    public class SqlDb : IDisposable
    {
        public string ConnectionString { get; }
        public ILogger logger { get; protected set; }
        private TransactionScope scope;

        private MissingSchemaAction? missingSchemaAction;

        public MissingSchemaAction MissingSchemaAction
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

        public SqlDb(string connectionString, ILogger logger)
        {
            this.ConnectionString = connectionString;
            this.logger = logger;
            scope = null;
        }

        public SqlDb(string connectionString, Serilog.ILogger logger)
        {
            this.ConnectionString = connectionString;
            this.logger = new SerilogWrapper(logger);
            scope = null;
        }

        public SqlDb(string connectionString)
        {
            this.ConnectionString = connectionString;
            this.logger = null;
            scope = null;
        }

        /// <summary>
        /// Eseque la query e restituisce il DataTable del risultato
        /// </summary>
        /// <example>
        /// db.QueryDataTable("SELECT * FROM A WHERE B = @B", "@B".WithValue("1"));
        /// </example>
        /// <param name="queryString">stringa contenente la stringa di interrogazione SQL</param>
        /// <param name="queryParams">nomi dei parametri associati a i loro valori. utilizzare <see cref="KeyValuePairExt"/> come helper </param>
        /// <returns></returns>
        public DataTable QueryDataTable(string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            DataSet ds = QueryDataSet(queryString, queryParams);
            return ds.Tables[0];
        }

        public DataTable QueryDataTable(string queryString, params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
        {
            DataSet ds = QueryDataSet(queryString, queryParams);
            return ds.Tables[0];
        }


        public DataTable QueryDataTable(string queryString)
        {
            DataSet ds = QueryDataSet(queryString);
            return ds.Tables[0];
        }

        public DataSet QueryDataSet(string queryString, params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand selectCommand = GenerateCommand(connection, queryString, queryParams);
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
                DataSet ds = new DataSet();
                adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                adapter.Fill(ds);
                connection.Close();
                return ds;
            }
        }

        public DataSet QueryDataSet(string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand selectCommand = GenerateCommand(connection, queryString, queryParams);
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
                DataSet ds = new DataSet();
                adapter.MissingSchemaAction = this.MissingSchemaAction;
                adapter.Fill(ds);
                connection.Close();
                return ds;
            }
        }

        public DataSet QueryDataSet(string queryString)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand selectCommand = GenerateCommand(connection, queryString);
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
                DataSet ds = new DataSet();
                adapter.MissingSchemaAction = this.MissingSchemaAction;
                adapter.Fill(ds);
                connection.Close();
                return ds;
            }
        }


        public DataRow QueryDataRow(string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            DataTable dt = QueryDataTable(
                queryString,
                queryParams
            );

            if (dt.Rows.Count == 0)
            {
                throw new NotFoundException("nessun risultato ottenuto");
            }

            if (dt.Rows.Count > 1)
            {
                throw new TooMuchResultsException("ottenuto più valori");
            }
            return dt.Rows[0];
        }

        public T QuerySingleValue<T>(string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand selectCommand = GenerateCommand(connection, queryString, queryParams);
                object value = selectCommand.ExecuteScalar();
                connection.Close();
                // conversione variabile da object a type specificato
                //return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFrom(value);
                return (T)Convert.ChangeType(value, typeof(T));
            }
        }

        public T QuerySingleValue<T>(string queryString, params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand selectCommand = GenerateCommand(connection, queryString, queryParams);
                object value = selectCommand.ExecuteScalar();
                connection.Close();
                return (T)Convert.ChangeType(value, typeof(T));
            }
        }

        public T QuerySingleValue<T>(string queryString)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand selectCommand = GenerateCommand(connection, queryString);
                object value = selectCommand.ExecuteScalar();
                return (T)Convert.ChangeType(value, typeof(T));
            }
        }

        public bool Execute(string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            //queryString = queryString.Trim().Replace(System.Environment.NewLine, " ");
            //queryString = System.Text.RegularExpressions.Regex.Replace(queryString, @"\s+", " ");
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand selectCommand = GenerateCommand(connection, queryString, queryParams);
                return selectCommand.ExecuteNonQuery() > 0;
            }
        }

        public bool Execute(string queryString, params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand selectCommand = GenerateCommand(connection, queryString, queryParams);
                return selectCommand.ExecuteNonQuery() > 0;
            }
        }

        public void ToCSV(string queryString, string csvFilePath, char Escape = '"', char Quote = '"', string Delimiter = ";", bool BoolToIntConvert = false, params KeyValuePair<string, object>[] queryParams)
        {
            DataTable dt = this.QueryDataTable(queryString, queryParams);
            ToCsv(
                dataTable: dt,
                csvFilePath: csvFilePath,
                Escape: Escape,
                Quote: Quote,
                Delimiter: Delimiter,
                BoolToIntConvert: BoolToIntConvert
          );
        }

        public void ToCsv(DataTable dataTable, string csvFilePath, char Escape = '"', char Quote = '"', string Delimiter = ";", bool BoolToIntConvert = false)
        {

            CsvHelper.Configuration.Configuration csvConf = new CsvHelper.Configuration.Configuration()
            {
                TrimOptions = CsvHelper.Configuration.TrimOptions.InsideQuotes,
                Escape = Escape,
                Quote = Quote,
                Delimiter = Delimiter,
                TypeConverterCache = null
            };

            if (BoolToIntConvert)
            {
                csvConf.TypeConverterCache = new CsvHelper.TypeConversion.TypeConverterCache();
                csvConf.TypeConverterCache.AddConverter<bool>(new CsvBooleanConverter());
            }

            using (System.IO.StreamWriter textWriter = System.IO.File.CreateText(csvFilePath))
            {
                using (CsvHelper.CsvWriter csv = new CsvHelper.CsvWriter(textWriter, csvConf))
                {
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        csv.WriteField(column.ColumnName);
                    }
                    csv.NextRecord();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        for (int i = 0; i < dataTable.Columns.Count; i++)
                        {
                            csv.WriteField(row[i]);
                        }
                        csv.NextRecord();
                    }
                    csv.Flush();
                }
                textWriter.Close();
            }
        }

        public bool Execute(string queryString)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand selectCommand = GenerateCommand(connection, queryString);
                return selectCommand.ExecuteNonQuery() > 0;
            }
        }


        public static T GetColVal<T>(DataRow dataRow, string columName)
        {
            // dataRow.Field<T>(columName)
            object val = dataRow[columName];
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

        private SqlCommand GenerateCommand(SqlConnection connection, string queryString)
        {
            SqlCommand command = new SqlCommand(queryString, connection);
            return command;
        }

        private SqlCommand GenerateCommand(SqlConnection connection, string queryString, KeyValuePair<string, object>[] queryParams)
        {
            WriteLog(queryString, queryParams);
            SqlCommand command = new SqlCommand(queryString, connection);
            foreach (KeyValuePair<string, object> param in queryParams)
            {
                command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
            }
            return command;
        }

        private SqlCommand GenerateCommand(SqlConnection connection, string queryString, KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
        {
            WriteLog(queryString, queryParams);
            SqlCommand command = new SqlCommand(queryString, connection);
            foreach (KeyValuePair<string, KeyValuePair<SqlDbType, object>> param in queryParams)
            {
                command.Parameters.Add(param.Key, param.Value.Key).Value = param.Value.Value ?? DBNull.Value;
            }
            return command;
        }

        #region log
        private static string SqlTypeToString(SqlDbType type)
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
            logger.Debug($"SQL {callerStack}{Environment.NewLine}{declares}{Environment.NewLine}{queryString}");
        }

        private void WriteLog(string queryString, KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
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
        #endregion

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
            if (Transaction.Current.TransactionInformation.Status == TransactionStatus.Active)
            {
                scope?.Dispose();
            }
        }

        public void Dispose()
        {
            AbortTransaction();
        }
    }
}
