
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

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
            return _return<T>(SqlDb_QueryManyAsync.QueryManyAsync<T>(connection, queryString, queryParams)).Result;
        }
        #endregion
        #region static with typed params
        public static List<T> QueryMany<T>(SqlConnection connection, string queryString, params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams) where T : ACUtils.DBModel<T>, new()
        {
            return _return<T>(SqlDb_QueryManyAsync.QueryManyAsync<T>(connection: connection, queryString: queryString, queryParams: queryParams)).Result;
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
            return _return<T>(SqlDb_QueryManyAsync.QueryManyAsync<T>(self, queryString: queryString, queryParams: queryParams)).Result;
        }
        #endregion
        #region whit typed params
        public static List<T> QueryMany<T>(this SqlDb self, string queryString, params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams) where T : ACUtils.DBModel<T>, new()
        {
            return _return<T>(SqlDb_QueryManyAsync.QueryManyAsync<T>(self, queryString: queryString, queryParams: queryParams)).Result;
        }
        #endregion

        private static async Task<List<T>> _return<T>(IAsyncEnumerable<T> asyncReturn) where T : ACUtils.DBModel<T>, new()
        {

           var list = new List<T>();
            await foreach(var el in asyncReturn)
            {
                list.Add(el);
            }
            return list;
        }
    }
}
