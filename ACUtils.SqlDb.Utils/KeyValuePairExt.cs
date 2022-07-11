using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return new KeyValuePair<string, object>(key, value?.Truncate(maxLenght));
        }
    }
}
