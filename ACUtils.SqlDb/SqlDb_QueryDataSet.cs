using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ACUtils
{
    public static class SqlDb_QueryDataSet
    {
        #region static without params
        public static DataSet QueryDataSet(SqlConnection connection, string queryString)
        {
            return QueryDataSet(connection, queryString, new KeyValuePair<string, object>[0]);
        }
        #endregion
        #region static with simple params 
        public static DataSet QueryDataSet(SqlConnection connection, string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            using (SqlCommand selectCommand = SqlDb.generateCommand(connection, queryString, queryParams))
            {
                return _return(selectCommand);
            }
        }
        #endregion
        #region static with typed params
        public static DataSet QueryDataSet(SqlConnection connection, string queryString, params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
        {
            using (SqlCommand selectCommand = SqlDb.generateCommand(connection, queryString, queryParams))
            {
                return _return(selectCommand);
            }
        }
        #endregion

        #region without params
        public static DataSet QueryDataSet(this SqlDb self, string queryString)
        {
            return self.QueryDataSet(queryString, new KeyValuePair<string, object>[0]);
        }
        #endregion
        #region with simple params
        public static DataSet QueryDataSet(this SqlDb self, string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            using (var connection = self._getConnection())
            {
                self.WriteLog(queryString, queryParams);
                try
                {
                    var ds = QueryDataSet(connection.Connection, queryString, queryParams);
                    return ds;
                }
                catch (Exception ex)
                {
                    self.WriteLog(ex, queryString, queryParams);
                    throw;
                }
            }
        }
        #endregion
        #region whit typed params
        public static DataSet QueryDataSet(this SqlDb self, string queryString, params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
        {
            using (var connection = self._getConnection())
            {
                self.WriteLog(queryString, queryParams);
                try
                {
                    var ds = QueryDataSet(connection.Connection, queryString, queryParams);
                    return ds;
                }
                catch (Exception ex)
                {
                    self.WriteLog(ex, queryString, queryParams);
                    throw;
                }
            }
        }
        #endregion

        private static DataSet _return(SqlCommand selectCommand)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(selectCommand))
            {
                DataSet ds = new DataSet();
                ds.EnforceConstraints = SqlDb.EnforceConstraints;
                adapter.MissingSchemaAction = SqlDb.MissingSchemaAction;
                adapter.Fill(ds);
                return ds;
            }
        }
    }
}
