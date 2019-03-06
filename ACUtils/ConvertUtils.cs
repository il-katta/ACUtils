using System;

namespace ACUtils
{
    public static class ConvertUtils
    {
        public static string ToString(DateTime dateTime)
        {
            return dateTime.ToUniversalTime().ToString("o", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        public static string ToString(DateTime? dateTime)
        {
            if (dateTime.HasValue)
            {
                return ToString(dateTime.Value);
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// converte una stringa in oggetto DateTime utilizzando il formato impostato nella configurazione del sistema
        /// </summary>
        /// <param name="dateString"></param>
        /// <returns></returns>
        public static DateTime? ToDateTimeLocal(string dateString)
        {
            if (string.IsNullOrEmpty(dateString))
            {
                return null;
            }
            try
            {
                return DateTime.Parse(dateString, System.Globalization.DateTimeFormatInfo.CurrentInfo);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// converte una stringa in oggetto DateTime utilizzando il formato standard
        /// </summary>
        /// <param name="dateString"></param>
        /// <returns></returns>
        public static DateTime? ToDateTime(string dateString)
        {
            if (string.IsNullOrEmpty(dateString))
            {
                return null;
            }
            try
            {
                return DateTime.Parse(dateString, System.Globalization.DateTimeFormatInfo.InvariantInfo);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// converte la stringa in decimale utilizzando la configurazione standard
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static decimal? ToDecimal(string str)
        {
            try
            {
                return Convert.ToDecimal(str, System.Globalization.CultureInfo.InvariantCulture);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// converte la stringa in decimale utilizzando il formato impostato nella configurazione del sistema
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static decimal? ToDecimalLocal(string str)
        {
            try
            {
                return Convert.ToDecimal(str, System.Globalization.CultureInfo.CurrentCulture);
            }
            catch
            {
                return null;
            }
        }

        public static DateTime? ToDecimal(string dateString, string format)
        {
            if (string.IsNullOrEmpty(dateString))
            {
                return null;
            }

            return DateTime.ParseExact(dateString, format, System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
