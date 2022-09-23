using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ACUtils
{
    public static class SqlDb_QueryDataTable
    {
        #region static without params
        public static DataTable QueryDataTable(SqlConnection connection, string queryString)
        {
            return QueryDataTable(connection, queryString, new KeyValuePair<string, object>[0]);
        }
        #endregion
        #region static with simple params 
        public static DataTable QueryDataTable(SqlConnection connection, string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            DataSet ds = SqlDb_QueryDataSet.QueryDataSet(connection, queryString, queryParams);
            return _return(ds);
        }
        #endregion
        #region static with typed params
        public static DataTable QueryDataTable(SqlConnection connection, string queryString, params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
        {
            DataSet ds = SqlDb_QueryDataSet.QueryDataSet(connection, queryString, queryParams);
            return _return(ds);
        }
        #endregion

        #region without params
        public static DataTable QueryDataTable(this SqlDb self, string queryString)
        {
            return self.QueryDataTable(queryString, new KeyValuePair<string, object>[0]);
        }
        #endregion
        #region with simple params
        public static DataTable QueryDataTable(this SqlDb self, string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            return _return(self.QueryDataSet(queryString, queryParams));
        }
        #endregion
        #region whit typed params
        public static DataTable QueryDataTable(this SqlDb self, string queryString, params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
        {
            return _return(self.QueryDataSet(queryString, queryParams));
        }
        #endregion

        private static DataTable _return(DataSet ds)
        {
            return ds.Tables[0];
        }
    }
}
