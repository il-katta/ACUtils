using System.Globalization;

namespace ACUtils
{
    public static class StringUtils
    {
        public static string Truncate(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value))
            {
                return value;
            }

            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }

        public static string DecodeBase64(string encodedString)
        {
            byte[] data = System.Convert.FromBase64String(encodedString);
            return System.Text.Encoding.UTF8.GetString(data);
        }

        public static decimal Normalize(this decimal value)
        {
            return value / 1.000000000000000000000000000000000m;
        }

        public static string ToNormalizedString(this decimal value, string culture = "it-IT")
        {
            return value.Normalize().ToString(CultureInfo.CreateSpecificCulture(culture));
        }
    }
}
