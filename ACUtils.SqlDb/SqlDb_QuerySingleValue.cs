
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ACUtils
{
    public static class SqlDb_QuerySingleValue
    {
        public static T QuerySingleValue<T>(this SqlDb self, string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            using (SqlConnection connection = new SqlConnection(self.ConnectionString))
            {
                try
                {
                    connection.Open();
                    self.WriteLog(queryString, queryParams);
                    var value = self.QuerySingleValue<T>(connection, queryString, queryParams);
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
        public static T QuerySingleValue<T>(this SqlDb self, SqlConnection connection, string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            using (SqlCommand selectCommand = SqlDb.generateCommand(connection, queryString, queryParams))
            {
                object value = selectCommand.ExecuteScalar();
                return SqlDb._changeType<T>(value);
            }
        }

        public static Nullable<T> QueryNullableSingleValue<T>(this SqlDb self, SqlConnection connection, string queryString, params KeyValuePair<string, object>[] queryParams) where T : struct
        {
            using (SqlCommand selectCommand = SqlDb.generateCommand(connection, queryString, queryParams))
            {
                object value = selectCommand.ExecuteScalar();
                if (value == null || value == DBNull.Value || value is DBNull)
                {
                    return null;
                }
                // conversione variabile da object a type specificato
                //return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFrom(value);
                return SqlDb._changeType<T?>(value);
            }
        }

        public static T QuerySingleValue<T>(this SqlDb self, string queryString, params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
        {
            using (SqlConnection connection = new SqlConnection(self.ConnectionString))
            {
                try
                {
                    connection.Open();
                    self.WriteLog(queryString, queryParams);
                    var value = self.QuerySingleValue<T>(connection, queryString, queryParams);
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

        public static T QuerySingleValue<T>(this SqlDb self, SqlConnection connection, string queryString, params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
        {
            using (SqlCommand selectCommand = SqlDb.generateCommand(connection, queryString, queryParams))
            {
                object value = selectCommand.ExecuteScalar();
                return SqlDb._changeType<T>(value);
            }
        }


        public static T QuerySingleValue<T>(this SqlDb self, string queryString)
        {
            using (SqlConnection connection = new SqlConnection(self.ConnectionString))
            {
                try
                {
                    connection.Open();
                    var value = self.QuerySingleValue<T>(connection, queryString);
                    return SqlDb._changeType<T>(value);
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


        public static T QuerySingleValue<T>(this SqlDb self, SqlConnection connection, string queryString)
        {
            using (SqlCommand selectCommand = SqlDb.generateCommand(connection, queryString))
            {
                object value = selectCommand.ExecuteScalar();
                return SqlDb._changeType<T>(value);
            }
        }
    }
}
