using ACUtils.AXRepository.Attributes;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace ACUtils.AXRepository
{
    public abstract class AXModel<T> : DBModel<T> where T : AXModel<T>, new()
    {
        #region properties

        [AxField(ax_field: "DOCNUMBER")]
        public int? DOCNUMBER { get; set; }

        public string FilePath { get; set; }

        [AxField(ax_field: "DATA7_3")]
        public DateTime? DataUltimaModifica { get; set; }

        [AxField(ax_field: "From")]
        public virtual string User { get; set; }

        /// <summary>
        /// campo usato per popolare l'oggetto del documento
        /// </summary>
        private string _docname;
        public virtual string DOCNAME { get => _docname ?? GetArxivarAttribute()?.Description; set => _docname = value; }

        /// <summary>
        /// campo usato per settare la data documento su arxivar
        /// eseguire l'override per modificare il campo
        /// </summary>
        private DateTime? _dataDoc;
        public virtual DateTime? DataDoc { get => _dataDoc ?? DataUltimaModifica; set => _dataDoc = value; }

        public List<string> Allegati { get; set; }

        #endregion

        #region setters

        public override void idrate(DataRow dr)
        {
            // popola i campi che corrispondono ai nomi delle property
            base.idrate(dr);

            // popola i campi che corrispondono ai nome deninito del Attribute della property
            PropertyInfo[] properties = this.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (!dr.Table.Columns.Contains(property.Name))
                {
                    var attr = this.GetArxivarAttribute(property.Name);
                    if (attr?.DbField == null) continue;
                    if (dr.Table.Columns.Contains(attr.DbField))
                    {
                        try
                        {
                            setValue(property.Name, dr[attr.DbField], dr.Table.Columns[attr.DbField].DataType);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"{attr.DbField} -> {property.Name} - {dr[attr.DbField]}: {e?.Message}"); // TODO: write log entry
                            //throw;
                        }
                    }
                }
            }
        }

        public static T Idrate(ArxivarNext.Model.EditProfileSchemaDTO model)
        {
            var obj = new T();
            var properties = obj.GetType().GetProperties();
            foreach (var field in model.Fields)
            {
                if (obj.HasAXField(field.Name))
                {
                    foreach (var property in properties)
                    {
                        if (field.Name == obj.GetArxivarAttribute(property.Name)?.AXField)
                        {
                            dynamic dfiled = field;
                            obj.setValue(property.Name, dfiled.Value);
                        }

                    }
                }
            }
            obj.DOCNUMBER = model.ProfileInfo.DocNumber;
            return obj;
        }

        public static T Idrate(ArxivarNext.Model.RowSearchResult model)
        {
            var obj = new T();
            var properties = obj.GetType().GetProperties();
            foreach (var col in model.Columns)
            {
                if (obj.HasAXField(col.Id))
                {
                    foreach (var property in properties)
                    {
                        if (col.Id == obj.GetArxivarAttribute(property.Name)?.AXField)
                            obj.setValue(property.Name, col.Value);

                    }
                }
            }
            return obj;
        }


        public static List<T> Idrate(List<ArxivarNext.Model.RowSearchResult> results) 
        {
            return (from result in results select Idrate(result)).ToList();
        }

        #endregion

        #region testers
        public bool HasAS400Field(string field)
        {
            return this.GetType().GetProperties().Where(property =>
                GetArxivarAttribute(property.Name)?.DbField == field
            ).Any();
        }

        public bool HasAXField(string field)
        {
            return this.GetType().GetProperties().Where(property => GetArxivarAttribute(property.Name)?.AXField == field).Any();
        }
        #endregion

        #region getters

        public AxClassAttribute GetArxivarAttribute()
        {
            var attrs = GetType().GetCustomAttributes(typeof(AxClassAttribute), true);
            return attrs.LastOrDefault() as AxClassAttribute;
        }

        public AxDbFieldAttribute GetArxivarAttribute(string propertyName)
        {
            var propr = GetType().GetProperty(propertyName);
            var attrs = propr.GetCustomAttributes(typeof(AxDbFieldAttribute), true);
            return attrs.LastOrDefault() as AxDbFieldAttribute;
        }

        public List<AxDbFieldAttribute> GetArxivarAttributes()
        {
            return (
                from attr in (
                    from prop in GetType().GetProperties()
                    select GetArxivarAttribute(prop.Name)
                )
                where attr != null
                select attr
            ).ToList();
        }

        public Tm GetValueByAS400Field<Tm>(string field)
        {
            return GetValueBy<Tm>(field, property => GetArxivarAttribute(property.Name)?.DbField);
        }

        public Tm GetValueByAXField<Tm>(string field)
        {
            return GetValueBy<Tm>(field, property => GetArxivarAttribute(property.Name)?.AXField);
        }

        public new object this[string fieldName]
        {
            get
            {
                if (HasProperty(fieldName))
                {
                    return GetValueByPropertyName<object>(fieldName);
                }
                if (HasAS400Field(fieldName))
                {
                    return GetValueByAS400Field<object>(fieldName);
                }
                if (HasAXField(fieldName))
                {
                    return GetValueByAXField<object>(fieldName);
                }
                throw new ArgumentException($"'{fieldName}' field not found");
            }
        }

        public Dictionary<string, object> GetArxivarFields()
        {
            Dictionary<string, object> fields = new Dictionary<string, object>();
            foreach (var property in GetType().GetProperties())
            {
                var ax = GetArxivarAttribute(property.Name);
                if (ax != null && !string.IsNullOrEmpty(ax.AXField))
                {
                    fields.Add(ax.AXField, this[ax.AXField]);
                }
            }
            return fields;
        }

        private static object get_type_default(Type type)
        {
            //if (type.IsValueType)
            if (type?.GetTypeInfo()?.IsValueType ?? false)
            {
                return Activator.CreateInstance(type);
            }
            return null;
        }

        /// <summary>
        /// ritorna le primary key per l'interrogazione su ARXIVAR 
        /// ( possono essere differenti dai campi per la tabella AXARX1F0 )
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> GetPrimaryKeys()
        {
            Dictionary<string, object> fields = new Dictionary<string, object>();
            foreach (var property in GetType().GetProperties())
            {
                var ax = GetArxivarAttribute(property.Name);
                if (ax != null && !string.IsNullOrEmpty(ax.AXField))
                {
                    if (ax.IsPrimaryKey)
                    {
                        var value = this[ax.AXField];
                        var default_value = get_type_default(value?.GetType());
                        if (value is null || value == default_value)
                        {
                            throw new ArgumentException($"il valore chiave di '{property.Name}' ( '{ax.AXField}' ) non può essere '{default_value ?? "NULL"}'");
                        }

                        fields.Add(ax.AXField, value);
                    }
                }
            }
            return fields;
        }

        #endregion
    }
}
