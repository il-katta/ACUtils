using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ACUtils
{
    public static class SqlDb_QueryDataTable
    {
        /// <summary>
        /// Esegue la query e restituisce il DataTable del risultato
        /// </summary>
        /// <example>
        /// db.QueryDataTable("SELECT * FROM A WHERE B = @B", "@B".WithValue("1"));
        /// </example>
        /// <param name="queryString">stringa contenente la stringa di interrogazione SQL</param>
        /// <param name="queryParams">nomi dei parametri associati a i loro valori. utilizzare <see cref="KeyValuePairExt"/> come helper </param>
        /// <returns></returns>
        public static DataTable QueryDataTable(this SqlDb self, string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            DataSet ds = self.QueryDataSet(queryString, queryParams);
            return ds.Tables[0];
        }

        public static DataTable QueryDataTable(this SqlDb self, SqlConnection connection, string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            DataSet ds = self.QueryDataSet(connection, queryString, queryParams);
            return ds.Tables[0];
        }

        public static DataTable QueryDataTable(this SqlDb self, string queryString, params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
        {
            DataSet ds = self.QueryDataSet(queryString, queryParams);
            return ds.Tables[0];
        }

        public static DataTable QueryDataTable(this SqlDb self, SqlConnection connection, string queryString, params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
        {
            DataSet ds = self.QueryDataSet(connection, queryString, queryParams);
            return ds.Tables[0];
        }

        public static DataTable QueryDataTable(this SqlDb self, string queryString)
        {
            DataSet ds = self.QueryDataSet(queryString);
            return ds.Tables[0];
        }

        public static DataTable QueryDataTable(this SqlDb self, SqlConnection connection, string queryString)
        {
            DataSet ds = self.QueryDataSet(connection, queryString);
            return ds.Tables[0];
        }

    }
}
