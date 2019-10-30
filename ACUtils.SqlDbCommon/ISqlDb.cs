using System;
using System.Globalization;

namespace ACUtils.SqlDbCommon
{
    public partial class ISqlDb
    {


        public ILogger logger { get; protected set; }

        #region log
        private static string SqlTypeToString(SqlDbType type)
        {
            switch (type)
            {
                case SqlDbType.NVarChar:
                    return "NVarChar(250)";
                case SqlDbType.Char:
                    return "Char(250)";
                default:
                    return type.ToString();
            }
        }

        private class TypeSwitch
        {
            private Dictionary<Type, Func<object, string>> matches = new Dictionary<Type, Func<object, string>>();
            public TypeSwitch Case<T>(Func<T, string> action) { matches.Add(typeof(T), (x) => action((T)x)); return this; }
            public string Switch(object x)
            {
                if (x == null)
                {
                    return "NULL";
                }

                try
                {
                    return matches[x.GetType()](x);
                }
                catch
                {
                    return $"'{x}'";
                }
            }
        }

        private static string ValueToString(object obj)
        {
            TypeSwitch ts = new TypeSwitch()
                .Case((bool x) => x ? "1" : "0")
                .Case((string x) => $"'{x}'")
                .Case((int x) => x.ToString(CultureInfo.InvariantCulture))
                .Case((float x) => x.ToString(CultureInfo.InvariantCulture))
                .Case((decimal x) => x.ToString(CultureInfo.InvariantCulture))
                .Case((long x) => x.ToString(CultureInfo.InvariantCulture))
                .Case((short x) => x.ToString(CultureInfo.InvariantCulture))
                .Case((DateTime x) => $"'{x.ToString(CultureInfo.InvariantCulture)}'")// TODO: forzare formattazione
                .Case((char x) => $"'{x.ToString(CultureInfo.InvariantCulture)}'")
            ;
            return ts.Switch(obj);
        }

        private void WriteLog(string queryString)
        {
            if (logger == null)
            {
                return;
            }
            string callerStack = GetCallerStack(4, 3);
            logger.Debug($"SQL {callerStack}{Environment.NewLine}{queryString}");
        }

        private void WriteLog(Exception exception, string queryString)
        {
            if (logger == null)
            {
                return;
            }
            string callerStack = GetCallerStack(4, 3);
            logger.Error($"SQL {callerStack} : {exception}");
        }

        private void WriteLog(string queryString, KeyValuePair<string, object>[] queryParams)
        {
            if (logger == null)
            {
                return;
            }
            string declares = string.Join(
                Environment.NewLine,
                from p in queryParams select $"DECLARE {p.Key} VARCHAR(250) = {ValueToString(p.Value)}"
            );
            string callerStack = GetCallerStack(4, 3);
            logger.Debug($"SQL {callerStack}{Environment.NewLine}{declares}{Environment.NewLine}{queryString}");
        }

        private void WriteLog(Exception exception, string queryString, KeyValuePair<string, object>[] queryParams)
        {
            if (logger == null)
            {
                return;
            }
            string callerStack = GetCallerStack(4, 3);
            logger.Error($"SQL {callerStack} : {exception}");
        }

        private void WriteLog(string queryString, KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
        {
            if (logger == null)
            {
                return;
            }

            string declares = string.Join(
                    Environment.NewLine,
                    from p in queryParams select $"DECLARE {p.Key} {SqlTypeToString(p.Value.Key)} = {ValueToString(p.Value.Value)}"
            );
            string callerStack = GetCallerStack(4, 3);
            logger.Debug($"SQL {callerStack}{Environment.NewLine}{declares}{Environment.NewLine}{queryString}");
        }

        private void WriteLog(Exception exception, string queryString, KeyValuePair<string, KeyValuePair<SqlDbType, object>>[] queryParams)
        {
            if (logger == null)
            {
                return;
            }
            string callerStack = GetCallerStack(4, 3);
            logger.Error($"SQL {callerStack} : {exception}");
        }

        private string GetCallerStack(int start, int count)
        {
            string callerStack = "";

            foreach (int i in Enumerable.Range(start, count))
            {
                try
                {
                    System.Diagnostics.StackFrame stack = new System.Diagnostics.StackFrame(i, true);
                    callerStack += $" < {stack.GetMethod().DeclaringType}.{stack.GetMethod().Name}";
                }
                catch { }
            }

            return callerStack;
        }
        #endregion
    }
}
