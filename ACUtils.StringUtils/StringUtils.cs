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
    }
}
