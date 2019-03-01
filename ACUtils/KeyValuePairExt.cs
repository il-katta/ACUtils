using System.Collections.Generic;
using System.Data;

namespace ACUtils
{
    public static class KeyValuePairExt
    {
        public static KeyValuePair<string, object> WithValue(this string key, object value)
        {
            return new KeyValuePair<string, object>(key, value);
        }

        public static KeyValuePair<string, object> WithValue(this string key, string value, int maxLenght)
        {
            return new KeyValuePair<string, object>(key, value.Truncate(maxLenght));
        }

        public static KeyValuePair<string, KeyValuePair<SqlDbType, object>> WithValue(this string key, object value, SqlDbType type)
        {
            return WithValueType(key, value, type);
        }

        public static KeyValuePair<string, KeyValuePair<SqlDbType, object>> WithValueType(this string key, object value, SqlDbType type)
        {
            return new KeyValuePair<string, KeyValuePair<SqlDbType, object>>(key, new KeyValuePair<SqlDbType, object>(type, value));
        }
    }
}
