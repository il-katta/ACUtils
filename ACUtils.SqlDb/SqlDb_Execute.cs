using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace ACUtils
{
    public static class SqlDb_Execute
    {
        #region static without params
        public static int Execute(SqlConnection connection, string queryString)
        {
            return Execute(connection, queryString, new KeyValuePair<string, object>[0]);
        }
        #endregion
        #region static with simple params 
        public static int Execute(SqlConnection connection, string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            //queryString = queryString.Trim().Replace(System.Environment.NewLine, " ");
            //queryString = System.Text.RegularExpressions.Regex.Replace(queryString, @"\s+", " ");
            using (SqlCommand selectCommand = SqlDb.generateCommand(connection, queryString, queryParams))
            {
                return selectCommand.ExecuteNonQuery();
            }
        }
        #endregion
        #region static with typed params
        public static int Execute(SqlConnection connection, string queryString, params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
        {
            using (SqlCommand selectCommand = SqlDb.generateCommand(connection, queryString, queryParams))
            {
                return selectCommand.ExecuteNonQuery();
            }
        }
        #endregion

        #region without params
        public static int Execute(this SqlDb self, string queryString)
        {
            return self.Execute(queryString, new KeyValuePair<string, object>[0]);
        }
        #endregion
        #region with simple params
        public static int Execute(this SqlDb self, string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            //queryString = queryString.Trim().Replace(System.Environment.NewLine, " ");
            //queryString = System.Text.RegularExpressions.Regex.Replace(queryString, @"\s+", " ");
            using (var connection = self._getConnection())
            {
                self.WriteLog(queryString, queryParams);
                try
                {
                    return Execute(connection.Connection, queryString, queryParams);
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
        public static int Execute(this SqlDb self, string queryString, params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
        {
            using (var connection = self._getConnection())
            {
                self.WriteLog(queryString, queryParams);
                try
                {
                    return Execute(connection.Connection, queryString, queryParams);
                }
                catch (Exception ex)
                {
                    self.WriteLog(ex, queryString, queryParams);
                    throw;
                }
            }
        }

        #endregion
    }
}
