using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ACUtils
{
    public static class SqlDb_QueryManyAsync
    {
        #region static without params
        public static async IAsyncEnumerable<T> QueryManyAsync<T>(SqlConnection connection, string queryString) where T : ACUtils.DBModel<T>, new()
        {
            await foreach (var q in QueryManyAsync<T>(connection, queryString, new KeyValuePair<string, object>[0]))
            {
                yield return q;
            }
        }
        #endregion
        #region static with simple params 
        public static async IAsyncEnumerable<T> QueryManyAsync<T>(SqlConnection connection, string queryString, params KeyValuePair<string, object>[] queryParams) where T : ACUtils.DBModel<T>, new()
        {
            using (SqlCommand selectCommand = SqlDb.generateCommand(connection, queryString, queryParams))
            {
                using (var dr = selectCommand.ExecuteReader())
                {
                    await foreach (var q in _return<T>(dr))
                    {
                        yield return q;
                    }
                }
            }
        }
        #endregion
        #region static with typed params
        public static async IAsyncEnumerable<T> QueryManyAsync<T>(SqlConnection connection, string queryString, params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams) where T : ACUtils.DBModel<T>, new()
        {
            using (SqlCommand selectCommand = SqlDb.generateCommand(connection, queryString, queryParams))
            {
                using (var dr = selectCommand.ExecuteReader())
                {
                    await foreach (var q in _return<T>(dr))
                    {
                        yield return q;
                    }
                }
            }
        }
        #endregion

        #region without params
        public static async IAsyncEnumerable<T> QueryManyAsync<T>(this SqlDb self, string queryString) where T : ACUtils.DBModel<T>, new()
        {
            await foreach (var q in self.QueryManyAsync<T>(queryString, new KeyValuePair<string, object>[0]))
            {
                yield return q;
            }
        }
        #endregion
        #region with simple params
        public static async IAsyncEnumerable<T> QueryManyAsync<T>(this SqlDb self, string queryString, params KeyValuePair<string, object>[] queryParams) where T : ACUtils.DBModel<T>, new()
        {
            using (var connection = await self._getConnectionAsync(newConnection: true))
            {
                self.WriteLog(queryString, queryParams);
                await foreach (var q in QueryManyAsync<T>(connection.Connection, queryString, queryParams))
                {
                    yield return q;
                }
            }
        }
        #endregion
        #region whit typed params
        public static async IAsyncEnumerable<T> QueryManyAsync<T>(this SqlDb self, string queryString, params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams) where T : ACUtils.DBModel<T>, new()
        {
            using (var connection = await self._getConnectionAsync(newConnection: true))
            {
                self.WriteLog(queryString, queryParams);
                await foreach (var q in QueryManyAsync<T>(connection.Connection, queryString, queryParams))
                {
                    yield return q;
                }
            }
        }
        #endregion

        private static IAsyncEnumerable<T> _return<T>(SqlDataReader dr) where T : ACUtils.DBModel<T>, new()
        {
            return ACUtils.DBModel<T>.IdrateAsync(dr);
        }
    }
}
