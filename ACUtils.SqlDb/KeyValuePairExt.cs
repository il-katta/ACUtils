using System.Collections.Generic;
using System.Data;

namespace ACUtils
{
    public static class KeyValuePairSqlDbExt
    {
        public static KeyValuePair<string, KeyValuePair<SqlDbType, object>> WithValue(this string key, string value, SqlDbType type, int maxLenght)
        {
            return WithValueType(key, value.Truncate(maxLenght), type);
        }

        public static KeyValuePair<string, KeyValuePair<SqlDbType, object>> WithValueType(this string key, object value, SqlDbType type)
        {
            return new KeyValuePair<string, KeyValuePair<SqlDbType, object>>(key, new KeyValuePair<SqlDbType, object>(type, value));
        }
    }
}
