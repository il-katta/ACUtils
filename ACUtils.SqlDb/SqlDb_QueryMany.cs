
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ACUtils
{
    public static class SqlDb_QueryMany
    {
        public static List<T> QueryMany<T>(this SqlDb self, string sql, params KeyValuePair<string, object>[] queryParams) where T : ACUtils.DBModel<T>, new()
        {
            var dt = self.QueryDataTable(sql, queryParams);
            return ACUtils.DBModel<T>.Idrate(dt);
        }

        public static async IAsyncEnumerable<T> QueryManyAsync<T>(this SqlDb self, string sql, params KeyValuePair<string, object>[] queryParams) where T : ACUtils.DBModel<T>, new()
        {
            var dt = self.QueryDataTable(sql, queryParams);
            await foreach (var q in ACUtils.DBModel<T>.IdrateAsyncGenerator(dt))
            {
                yield return q;
            }
        }

        public static List<T> QueryMany<T>(this SqlDb self, SqlConnection connection, string sql, params KeyValuePair<string, object>[] queryParams) where T : ACUtils.DBModel<T>, new()
        {
            var dt = self.QueryDataTable(connection, sql, queryParams);
            return ACUtils.DBModel<T>.Idrate(dt);
        }
    }
}
