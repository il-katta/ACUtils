using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ACUtils
{
    public static class SqlDb_QueryOne
    {
        #region static without params
        public static T QueryOne<T>(
            SqlConnection connection,
            string queryString
        ) where T : ACUtils.DBModel<T>, new()
        {
            return QueryOne<T>(connection, queryString, new KeyValuePair<string, object>[0]);
        }
        #endregion
        #region static with simple params 
        public static T QueryOne<T>(
            SqlConnection connection,
            string queryString,
            params KeyValuePair<string, object>[] queryParams
        ) where T : ACUtils.DBModel<T>, new()
        {
            return _return<T>(SqlDb_QueryDataRow.QueryDataRow(connection, queryString, queryParams));
        }
        #endregion
        #region static with typed params
        public static T QueryOne<T>(
            SqlConnection connection,
            string queryString,
            params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams
        ) where T : DBModel<T>, new()
        {
            return _return<T>(SqlDb_QueryDataRow.QueryDataRow(connection, queryString, queryParams));
        }
        #endregion

        #region without params
        public static T QueryOne<T>(
            this SqlDb self,
            string queryString
        ) where T : DBModel<T>, new()
        {
            return _return<T>(self.QueryDataRow(queryString, new KeyValuePair<string, object>[0]));
        }
        #endregion
        #region with simple params
        public static T QueryOne<T>(
            this SqlDb self,
            string queryString,
            params KeyValuePair<string, object>[] queryParams
        ) where T : DBModel<T>, new()
        {
            return _return<T>(self.QueryDataRow(queryString, queryParams));
        }
        #endregion
        #region whit typed params
        public static T QueryOne<T>(
            this SqlDb self,
            string queryString,
            params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams
        ) where T : DBModel<T>, new()
        {
            return _return<T>(self.QueryDataRow(queryString, queryParams));
        }
        #endregion

        private static T _return<T>(DataRow dr) where T : ACUtils.DBModel<T>, new()
        {
            return ACUtils.DBModel<T>.Idrate(dr);
        }
    }
}
