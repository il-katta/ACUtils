using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ACUtils
{
    public static class SqlDb_QueryDataRow
    {
        public static DataRow QueryDataRow(this SqlDb self, string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            DataTable dt = self.QueryDataTable(
                queryString,
                queryParams
            );

            if (dt.Rows.Count == 0)
            {
                throw new Exceptions.NotFoundException("nessun risultato ottenuto");
            }

            if (dt.Rows.Count > 1)
            {
                throw new Exceptions.TooMuchResultsException("ottenuto più valori");
            }
            return dt.Rows[0];
        }

        public static DataRow QueryDataRow(this SqlDb self, SqlConnection connection, string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            DataTable dt = self.QueryDataTable(
                connection,
                queryString,
                queryParams
            );

            if (dt.Rows.Count == 0)
            {
                throw new Exceptions.NotFoundException("nessun risultato ottenuto");
            }

            if (dt.Rows.Count > 1)
            {
                throw new Exceptions.TooMuchResultsException("ottenuto più valori");
            }

            return dt.Rows[0];
        }

    }
}
