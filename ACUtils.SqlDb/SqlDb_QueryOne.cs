using System.Collections.Generic;
using System.Data.SqlClient;

namespace ACUtils
{
    public static class SqlDb_QueryOne
    {
        public static T QueryOne<T>(
            this SqlDb self,
            string sql,
            params KeyValuePair<string, object>[] queryParams
        ) where T : ACUtils.DBModel<T>, new()
        {
            var dr = self.QueryDataRow(sql, queryParams);
            return ACUtils.DBModel<T>.Idrate(dr);
        }


        public static T QueryOne<T>(
            this SqlDb self,
            SqlConnection connection,
            string sql,
            params KeyValuePair<string, object>[] queryParams
        ) where T : ACUtils.DBModel<T>, new()
        {
            var dr = self.QueryDataRow(connection, sql, queryParams);
            return ACUtils.DBModel<T>.Idrate(dr);
        }
    }
}
