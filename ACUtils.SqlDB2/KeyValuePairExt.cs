using IBM.Data.DB2.iSeries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACUtils
{
    public static class DB2KeyValuePairExt
    {
        public static KeyValuePair<string, KeyValuePair<iDB2DbType, object>> WithValue(this string key, object value, iDB2DbType type)
        {
            return WithValueType(key, value, type);
        }

        public static KeyValuePair<string, KeyValuePair<iDB2DbType, object>> WithValueType(this string key, object value, iDB2DbType type)
        {
            return new KeyValuePair<string, KeyValuePair<iDB2DbType, object>>(key, new KeyValuePair<iDB2DbType, object>(type, value));
        }
    }
}
