using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ACUtils
{

    public partial class DBModel<T> : DBModel where T : DBModel<T>, new()
    {
        #region setter
        public static T Idrate(DataRow dr)
        {
            var obj = new T();
            obj.idrate(dr);
            return obj;
        }

        public static async Task<T[]> IdrateAsync(DataTable dt)
        {
            return await Task.WhenAll(
                dt.AsEnumerable()
                    .Select(dr => Task.Run(() => Idrate(dr)))
                    .ToArray()
           );
        }

        public static IEnumerable<T> IdrateGenerator(DataTable dt)
        {
            foreach (var dr in dt.AsEnumerable())
            {
                yield return Idrate(dr);
            }
        }

        public async static IAsyncEnumerable<T> IdrateAsyncGenerator(DataTable dt)
        {
            foreach (var dr in dt.AsEnumerable())
            {
                yield return await Task.Run(() => Idrate(dr));
            }
        }

        public static List<T> Idrate(DataTable dt)
        {
            // return IdrateAsync(dt).Result.ToList();
            return IdrateGenerator(dt).ToList();
        }

        public static IEnumerable<T> Idrate(IDataReader reader)
        {
            while (reader.Read())
            {
                yield return _returnIdrate(reader);
            }
        }

        public async static IAsyncEnumerable<T> IdrateAsync(SqlDataReader reader)
        {
            while (await reader.ReadAsync())
            {
                yield return _returnIdrate(reader);
            }
        }

        private static T _returnIdrate(IDataReader reader)
        {
            var obj = new T();
            obj.idrate(reader);
            return obj;
        }


        #endregion

        #region getter
        /// <summary>
        /// getter generico
        /// </summary>
        /// <param name="field"></param>
        /// <param name="tester">deve ritornare il valore per la comparazione con il parametro field passato alla funzione</param>
        /// <returns></returns>
        public Q GetValueBy<Q>(string field, Func<PropertyInfo, string> tester)
        {
            foreach (var property in this.GetType().GetProperties())
            {
                if (tester(property) == field)
                {
                    var value = property.GetValue(this);
                    if (value == null)
                    {
                        return default(Q);
                    }
                    try
                    {
                        if (typeof(Q) != value?.GetType())
                        {
                            value = Convert.ChangeType(value, typeof(Q), null);
                        }
                    }
                    catch { }
                    return (Q)value;
                }
            }
            return default(Q);
        }

        public Q GetValueByPropertyName<Q>(string field)
        {
            return GetValueBy<Q>(field, property => property.Name);
        }

        public Q GetValueByDbAttribute<Q>(string field)
        {
            return GetValueBy<Q>(field, property => GetDbAttribute(property.Name)?.DbField);
        }
        
        public object this[string fieldName]
        {
            get
            {
                if (HasProperty(fieldName))
                {
                    return GetValueByPropertyName<object>(fieldName);
                }
                if (HasDbField(fieldName))
                {
                    return GetValueByDbAttribute<object>(fieldName);
                }
                throw new ArgumentException($"'{fieldName}' field not found");
            }
        }

        #endregion
    }


    public partial class DBModel
    {
        public virtual void idrate(DataRow dr)
        {
            PropertyInfo[] properties = this.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (dr.Table.Columns.Contains(property.Name))
                {
                    var col = dr.Table.Columns[property.Name];
                    setValue(property.Name, dr[property.Name], col.DataType);
                }
                else
                {
                    var attr = GetDbAttribute(property.Name);
                    if (attr?.DbField == null) continue;
                    if (dr.Table.Columns.Contains(attr.DbField))
                    {
                        setValue(property.Name, dr[attr.DbField], dr.Table.Columns[attr.DbField].DataType);
                    }
                }
            }
        }

        public virtual void idrate(IDataRecord dataRecord)
        {
            PropertyInfo[] properties = this.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (dataRecord.HasCol(property.Name))
                {
                    var i = dataRecord.GetOrdinal(property.Name);
                    var coltype = dataRecord.GetFieldType(i);
                    var colvalue = dataRecord[i];
                    setValue(property.Name, colvalue, coltype);
                }else
                {
                    var attr = GetDbAttribute(property.Name);
                    if (attr?.DbField == null) continue;
                    if (dataRecord.HasCol(attr.DbField))
                    {
                        var i = dataRecord.GetOrdinal(attr.DbField);
                        var coltype = dataRecord.GetFieldType(i);
                        var colvalue = dataRecord[i];
                        setValue(property.Name, colvalue, coltype);
                    }
                }
            }
        }


        public static DateTime? ConvertToDatetime(object value)
        {
            if (value.GetType().Equals(typeof(DateTime)))
            {
                return (DateTime)value;
            }
            if (value.GetType().Equals(typeof(DateTime?)))
            {
                return (DateTime?)value;
            }
            try
            {
                return DateTime.ParseExact(value.ToString(), "yyyyMMdd", CultureInfo.InvariantCulture);
            }
            catch
            {
                return DateTime.Parse(value.ToString());
            }

        }

        protected virtual void setValue(string key, object value, Type colType = null)
        {
            var property = this.GetType().GetProperty(key);
            var sourceType = value?.GetType();
            var targetType = property.PropertyType;

            if (!property.CanWrite)
                return;

            // NULL value
            if (value == DBNull.Value || value == null)
            {
                property.SetValue(this, null);
            }
            else if (targetType.IsAssignableFrom(sourceType))
            {
                property.SetValue(this, value);
            }
            // boolean
            else if (targetType == typeof(bool) || targetType == typeof(bool?))
            {
                property.SetValue(this, Convert.ToBoolean(value));
            }
            // datetime
            else if (targetType == typeof(DateTime) || targetType == typeof(DateTime?))
            {
                if (sourceType == typeof(decimal)) // converte le date Decimal con formato yyyyMMdd
                {
                    if (((decimal)value) == 0)
                    {
                        // set default
                        if (targetType.IsValueType)
                            property.SetValue(this, Activator.CreateInstance(targetType));
                        else
                            property.SetValue(this, null);
                    }
                    else
                    {
                        property.SetValue(this, ConvertToDatetime(value));
                    }
                }
                else
                {
                    property.SetValue(this, ConvertToDatetime(value));
                }
            }
            // automatic conversion
            else if (targetType != colType)
            {
                var utype = Nullable.GetUnderlyingType(targetType) ?? targetType;
                var targetValue = Convert.ChangeType(value, utype);
                if (utype != targetType) // è un Nullable
                {
                    //targetValue = Convert.ChangeType(targetValue, targetType, null);
                    property.SetValue(this, targetValue, null);
                }
                else
                {
                    property.SetValue(this, targetValue);
                }

            }
            // default
            else
            {
                property.SetValue(this, value);
            }
        }

        public bool HasProperty(string field)
        {
            return this.GetType().GetProperties().Where(property => property.Name == field).Any();
        }

        public bool HasDbField(string field)
        {
            return this.GetType().GetProperties().Where(property => GetDbAttribute(property.Name)?.DbField == field).Any();
        }

        public IDbFieldAttribute GetDbAttribute(string propertyName)
        {
            var propr = GetType().GetProperty(propertyName);
            var attrs = propr.GetCustomAttributes(typeof(IDbFieldAttribute), true);
            return attrs.LastOrDefault() as IDbFieldAttribute;
        }

        public static IDbFieldAttribute GetDbAttribute<T>(string propertyName)
        {
            var type = typeof(T);
            var propr = type.GetProperty(propertyName);
            var attrs = propr?.GetCustomAttributes(typeof(IDbFieldAttribute), true);
            return attrs?.LastOrDefault() as IDbFieldAttribute;
        }

    }


    public static class Ext
    {
        public static bool HasCol(this IDataRecord dataRecord, string name)
        {
            try
            {
                dataRecord.GetOrdinal(name);
                return true;
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }
        }
    }
}
