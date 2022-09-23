using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ACUtils
{
    public static class SqlDb_QueryDataSet
    {
        public static DataSet QueryDataSet(this SqlDb self, string queryString, params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
        {
            using (SqlConnection connection = new SqlConnection(self.ConnectionString))
            {
                try
                {
                    connection.Open();
                    self.WriteLog(queryString, queryParams);
                    var ds = self.QueryDataSet(connection, queryString, queryParams);
                    return ds;
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

        public static DataSet QueryDataSet(this SqlDb self, SqlConnection connection, string queryString, params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
        {
            using (SqlCommand selectCommand = SqlDb.generateCommand(connection, queryString, queryParams))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(selectCommand))
                {
                    DataSet ds = new DataSet();
                    adapter.MissingSchemaAction = SqlDb.MissingSchemaAction;
                    adapter.Fill(ds);
                    return ds;
                }
            }
        }

        public static DataSet QueryDataSet(this SqlDb self, string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            using (SqlConnection connection = new SqlConnection(self.ConnectionString))
            {
                try
                {
                    connection.Open();
                    self.WriteLog(queryString, queryParams);
                    var ds = self.QueryDataSet(connection, queryString, queryParams);
                    return ds;
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

        public static DataSet QueryDataSet(this SqlDb self, SqlConnection connection, string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            using (SqlCommand selectCommand = SqlDb.generateCommand(connection, queryString, queryParams))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(selectCommand))
                {
                    DataSet ds = new DataSet();
                    adapter.MissingSchemaAction = SqlDb.MissingSchemaAction;
                    adapter.Fill(ds);
                    return ds;
                }
            }
        }

        public static DataSet QueryDataSet(this SqlDb self, string queryString)
        {
            using (SqlConnection connection = new SqlConnection(self.ConnectionString))
            {
                try
                {
                    connection.Open();
                    self.WriteLog(queryString);
                    var ds = self.QueryDataSet(connection, queryString);
                    return ds;
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

        public static DataSet QueryDataSet(this SqlDb self, SqlConnection connection, string queryString)
        {
            using (SqlCommand selectCommand = SqlDb.generateCommand(connection, queryString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(selectCommand))
                {
                    DataSet ds = new DataSet();
                    adapter.MissingSchemaAction = SqlDb.MissingSchemaAction;
                    adapter.Fill(ds);
                    return ds;
                }
            }
        }
    }
}
