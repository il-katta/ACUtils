using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace ACUtils
{
    public static class SqlDb_Execute
    {
        public static bool Execute(this SqlDb self, string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            //queryString = queryString.Trim().Replace(System.Environment.NewLine, " ");
            //queryString = System.Text.RegularExpressions.Regex.Replace(queryString, @"\s+", " ");
            using (SqlConnection connection = new SqlConnection(self.ConnectionString))
            {
                try
                {
                    connection.Open();
                    var value = self.Execute(connection, queryString, queryParams);
                    return value;
                }
                catch (Exception ex)
                {
                    self.WriteLog(ex, queryString, queryParams);
                    throw;
                }
                finally
                {
                    try { connection.Close(); } catch { }
                }
            }
        }

        public static bool Execute(this SqlDb self, SqlConnection connection, string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            //queryString = queryString.Trim().Replace(System.Environment.NewLine, " ");
            //queryString = System.Text.RegularExpressions.Regex.Replace(queryString, @"\s+", " ");
            using (SqlCommand selectCommand = SqlDb.generateCommand(connection, queryString, queryParams))
            {
                var value = selectCommand.ExecuteNonQuery() > 0;
                return value;
            }
        }

        public static bool Execute(this SqlDb self, string queryString, params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
        {
            using (SqlConnection connection = new SqlConnection(self.ConnectionString))
            {
                try
                {
                    connection.Open();
                    var value = self.Execute(connection, queryString, queryParams);
                    return value;
                }
                catch (Exception ex)
                {
                    self.WriteLog(ex, queryString, queryParams);
                    throw;
                }
                finally
                {
                    try { connection.Close(); } catch { }
                }
            }
        }

        public static bool Execute(this SqlDb self, SqlConnection connection, string queryString, params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
        {
            using (SqlCommand selectCommand = SqlDb.generateCommand(connection, queryString, queryParams))
            {
                var value = selectCommand.ExecuteNonQuery() > 0;
                return value;
            }
        }

        public static bool Execute(this SqlDb self, string queryString)
        {
            using (SqlConnection connection = new SqlConnection(self.ConnectionString))
            {
                try
                {
                    connection.Open();
                    self.WriteLog(queryString);
                    var value = self.Execute(connection, queryString);
                    return value;
                }
                catch (Exception ex)
                {
                    self.WriteLog(ex, queryString);
                    throw;
                }
                finally
                {
                    try { connection.Close(); } catch { }
                }
            }
        }

        public static bool Execute(this SqlDb self, SqlConnection connection, string queryString)
        {
            using (SqlCommand selectCommand = SqlDb.generateCommand(connection, queryString))
            {
                return selectCommand.ExecuteNonQuery() > 0;
            }
        }
    }
}
