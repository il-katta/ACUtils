
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ACUtils
{
    public static class SqlDb_QueryMany
    {

        #region static without params
        public static List<T> QueryMany<T>(SqlConnection connection, string queryString) where T : ACUtils.DBModel<T>, new()
        {
            return QueryMany<T>(connection, queryString, new KeyValuePair<string, object>[0]);
        }
        #endregion
        #region static with simple params
        public static List<T> QueryMany<T>(SqlConnection connection, string queryString, params KeyValuePair<string, object>[] queryParams) where T : ACUtils.DBModel<T>, new()
        {
            return _return<T>(SqlDb_QueryDataTable.QueryDataTable(connection, queryString, queryParams));
        }
        #endregion
        #region static with typed params
        public static List<T> QueryMany<T>(SqlConnection connection, string queryString, params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams) where T : ACUtils.DBModel<T>, new()
        {
            return _return<T>(SqlDb_QueryDataTable.QueryDataTable(connection: connection, queryString: queryString, queryParams: queryParams));
        }
        #endregion

        #region without params
        public static List<T> QueryMany<T>(this SqlDb self, string queryString) where T : ACUtils.DBModel<T>, new()
        {
            return self.QueryMany<T>(queryString, new KeyValuePair<string, object>[0]);
        }
        #endregion
        #region with simple params
        public static List<T> QueryMany<T>(this SqlDb self, string queryString, params KeyValuePair<string, object>[] queryParams) where T : ACUtils.DBModel<T>, new()
        {
            return _return<T>(self.QueryDataTable(queryString: queryString, queryParams: queryParams));
        }
        #endregion
        #region whit typed params
        public static List<T> QueryMany<T>(this SqlDb self, string queryString, params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams) where T : ACUtils.DBModel<T>, new()
        {
            return _return<T>(self.QueryDataTable(queryString: queryString, queryParams: queryParams));
        }
        #endregion

        private static List<T> _return<T>(DataTable dt) where T : ACUtils.DBModel<T>, new()
        {
            return ACUtils.DBModel<T>.Idrate(dt);
        }
    }
}
