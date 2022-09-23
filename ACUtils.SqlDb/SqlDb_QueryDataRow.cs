using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ACUtils
{
    public static class SqlDb_QueryDataRow
    {

        #region static without params
        public static DataRow QueryDataRow(SqlConnection connection, string queryString)
        {
            return QueryDataRow(
                connection,
                queryString,
                new KeyValuePair<string, object>[0]
            );
        }
        #endregion
        #region static with simple params 
        public static DataRow QueryDataRow(SqlConnection connection, string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            DataTable dt = SqlDb_QueryDataTable.QueryDataTable(
                connection,
                queryString,
                queryParams
            );
            return _return(dt);
        }
        #endregion
        #region static with typed params
        public static DataRow QueryDataRow(SqlConnection connection, string queryString, params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
        {
            DataTable dt = SqlDb_QueryDataTable.QueryDataTable(
                connection,
                queryString,
                queryParams
            );
            return _return(dt);
        }
        #endregion

        #region without params
        public static DataRow QueryDataRow(this SqlDb self, string queryString)
        {
            return self.QueryDataRow(queryString, new KeyValuePair<string, object>[0]);
        }
        #endregion
        #region with simple params
        public static DataRow QueryDataRow(this SqlDb self, string queryString, params KeyValuePair<string, object>[] queryParams)
        {
            return _return(self.QueryDataTable(queryString, queryParams));
        }
        #endregion
        #region whit typed params
        public static DataRow QueryDataRow(this SqlDb self, string queryString, params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
        {
            return _return(self.QueryDataTable(queryString, queryParams));
        }
        #endregion

        private static DataRow _return(DataTable dt)
        {
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
