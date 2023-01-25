using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ACUtils
{
    public static class SqlDb_QueryDictionary
    {
        #region static without params
        public static Dictionary<KT,VT> QueryDictionary<KT, VT>(SqlConnection connection, string queryString, string keyField = "key", string valueField = "value")
        {
            return QueryDictionary<KT, VT>(connection, queryString, keyField, valueField, new KeyValuePair<string, object>[0]);
        }
        #endregion
        #region static with simple params 
        public static Dictionary<KT, VT> QueryDictionary<KT, VT>(SqlConnection connection, string queryString, string keyField = "key", string valueField = "value", params KeyValuePair<string, object>[] queryParams)
        {
            return _return<KT, VT>(
                SqlDb_QueryDataTable.QueryDataTable(connection, queryString,  queryParams),
                keyField,
                valueField
             );
        }
        #endregion
        #region static with typed params
        public static Dictionary<KT, VT> QueryDictionary<KT, VT>(SqlConnection connection, string queryString, string keyField = "key", string valueField = "value", params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
        {
            return _return<KT, VT>(
                SqlDb_QueryDataTable.QueryDataTable(connection, queryString, queryParams),
                keyField,
                valueField
             );
        }
        #endregion

        #region without params
        public static Dictionary<KT, VT> QueryDictionary<KT, VT>(this SqlDb self, string queryString, string keyField = "key", string valueField = "value")
        {
            return self.QueryDictionary<KT, VT>(queryString, keyField, valueField, new KeyValuePair<string, object>[0]);
        }
        #endregion
        #region with simple params
        public static Dictionary<KT, VT> QueryDictionary<KT, VT>(this SqlDb self, string queryString, string keyField = "key", string valueField = "value", params KeyValuePair<string, object>[] queryParams)
        {
            return _return<KT, VT>(
                self.QueryDataTable(queryString, queryParams),
                keyField,
                valueField
            );
        }
        #endregion
        #region whit typed params
        public static Dictionary<KT, VT> QueryDictionary<KT, VT>(this SqlDb self, string queryString, string keyField = "key", string valueField = "value", params KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
        {
            return _return<KT, VT>(
                 self.QueryDataTable(queryString, queryParams),
                 keyField,
                 valueField
             );
        }
        #endregion

        private static Dictionary<KT, VT> _return<KT, VT>(DataTable dt, string keyField, string valueField)
        {
            return dt.AsEnumerable().ToDictionary(d => d.Field<KT>(keyField), d => d.Field<VT>(valueField));
        }
    }
}
