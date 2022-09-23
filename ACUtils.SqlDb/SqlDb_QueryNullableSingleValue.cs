using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ACUtils
{
    public static class SqlDb_QueryNullableSingleValue
    {
        public static T? QueryNullableSingleValue<T>(this SqlDb self, string queryString, params KeyValuePair<string, object>[] queryParams) where T : struct
        {
            using (SqlConnection connection = new SqlConnection(self.ConnectionString))
            {
                try
                {
                    connection.Open();
                    self.WriteLog(queryString, queryParams);
                    var value = self.QueryNullableSingleValue<T>(connection, queryString, queryParams);
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
    }
}
