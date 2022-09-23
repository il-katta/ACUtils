
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ACUtils
{
    public static class SqlDb_QuerySingleValue
    {
        #region static without params
        public static T QuerySingleValue<T>(SqlConnection connection, string queryString)
        {
            return QuerySingleValue<T>(connection, queryString, new KeyValuePair<string, object>[0]);
        }
        #endregion
        #region static with simple params 
        public static T QuerySingleValue<T>(SqlConnection connection, string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            using (SqlCommand selectCommand = SqlDb.generateCommand(connection, queryString, queryParams))
            {
                return _return<T>(selectCommand.ExecuteScalar());
            }
        }
        #endregion
        #region static with typed params
        public static T QuerySingleValue<T>(SqlConnection connection, string queryString, params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
        {
            using (SqlCommand selectCommand = SqlDb.generateCommand(connection, queryString, queryParams))
            {
                return _return<T>(selectCommand.ExecuteScalar());
            }
        }
        #endregion

        #region without params
        public static T QuerySingleValue<T>(this SqlDb self, string queryString)
        {
            return self.QuerySingleValue<T>(queryString, new KeyValuePair<string, object>[0]);
        }
        #endregion
        #region with simple params
        public static T QuerySingleValue<T>(this SqlDb self, string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            using (var connection = self._getConnection())
            {
                self.WriteLog(queryString, queryParams);
                try
                {
                    return QuerySingleValue<T>(connection.Connection, queryString, queryParams);
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
        public static T QuerySingleValue<T>(this SqlDb self, string queryString, params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
        {
            using (var connection = self._getConnection())
            {
                self.WriteLog(queryString, queryParams);
                try
                {
                    return QuerySingleValue<T>(connection.Connection, queryString, queryParams);
                }
                catch (Exception ex)
                {
                    self.WriteLog(ex, queryString, queryParams);
                    throw;
                }
            }
        }
        #endregion

        private static T _return<T>(object value)
        {
            return SqlDb._changeType<T>(value);
        }
    }
}
