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
        public virtual int? DOCNUMBER { get; set; }

        public string FilePath { get; set; }

        private string _stato;
        [AxField(ax_field: "Stato")]
        public virtual string STATO
        {
            get => _stato ?? GetArxivarAttribute()?.Stato;
            set => _stato = value;
        }

        [AxField(ax_field: "From")]
        public virtual string User { get; set; }

        [AxFromExternalIdField]
        public virtual string MittenteCodiceRubrica { get; set; }

        [AxField(ax_field: "From")]
        public virtual int? MittenteId { get; protected set; }

        //[AxField(ax_field: "From_IdRubrica")]
        public virtual int? MittenteIdRubrica { get; set; }

        [AxToExternalIdField]
        public virtual IEnumerable<string> DestinatariCodiceRubrica { get; set; }

        [AxField(ax_field: "To")]
        public virtual IEnumerable<int?> DestinatariId { get; protected set; }

        [AxField(ax_field: "To")]
        public virtual IEnumerable<string> Destinatari { get; protected set; }

        //[AxField(ax_field: "To_IdRubrica")]
        public virtual int? DestinatariIdRubrica { get; set; }

        /// <summary>
        /// campo usato per popolare l'oggetto del documento
        /// </summary>
        private string _docname;
        public virtual string DOCNAME { get => _docname ?? GetArxivarAttribute()?.Description; set => _docname = value; }

        /// <summary>
        /// campo usato per settare la data documento su arxivar
        /// eseguire l'override per modificare il campo
        /// </summary>

        [AxField(ax_field: "DataDoc")]
        public virtual DateTime? DataDoc { get; set; }

        [AxField(ax_field: "WORKFLOW")]
        public virtual bool? Workflow { get; set; }

        public List<string> Allegati { get; set; }

        #endregion

        #region setters

        protected override void setValue(string key, object value, Type colType = null)
        {
            var property = this.GetType().GetProperty(key);
            var sourceType = value?.GetType();
            var targetType = property.PropertyType;
            if (sourceType == typeof(ArxivarNext.Model.UserProfileDTO))
            {
                if (targetType == typeof(string))
                {
                    value = ((ArxivarNext.Model.UserProfileDTO)value).Description;
                }
                if (targetType == typeof(int) || targetType == typeof(int?))
                {
                    value = ((ArxivarNext.Model.UserProfileDTO)value).AddressBookId;
                }
            }

            if (sourceType == typeof(ArxivarNextManagement.Model.UserProfileDTO))
            {
                if (targetType == typeof(string))
                {
                    value = ((ArxivarNextManagement.Model.UserProfileDTO)value).Description;
                }
                if (targetType == typeof(int) || targetType == typeof(int?))
                {
                    value = ((ArxivarNextManagement.Model.UserProfileDTO)value).AddressBookId;
                }
            }
            if (sourceType == typeof(List<ArxivarNext.Model.UserProfileDTO>))
            {
                var source = (List<ArxivarNext.Model.UserProfileDTO>)value;
                if (targetType == typeof(List<string>) || targetType == typeof(IEnumerable<string>))
                {
                    value = source.Select(e => e.Description).ToList();
                }
                if (
                    targetType == typeof(List<int>) || targetType == typeof(List<int?>) ||
                    targetType == typeof(IEnumerable<int>) || targetType == typeof(IEnumerable<int?>)
                    )
                {
                    value = source.Select(e => e.AddressBookId).ToList();
                }
            }

            base.setValue(key, value, colType);
        }

        public void idrate(DataRow dr)
        {
            // popola i campi che corrispondono ai nomi delle property
            base.idrate(dr);

            // popola i campi che corrispondono al nome definito nel Attribute della property
            PropertyInfo[] properties = this.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (!dr.Table.Columns.Contains(property.Name))
                {
                    var attr = this.GetDbAttribute(property.Name);
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
                            throw;
                        }
                    }
                }
            }
        }

        public static T Idrate(ArxivarNext.Model.EditProfileSchemaDTO model)
        {
            var obj = new T();
            foreach (var field in model.Fields)
            {
                if (field.GetType().GetProperty("Value") != null)
                {
                    dynamic dfiled = field; // per poter accedere alla property Value
                    obj.SetPropertyIfExists(field.Name, dfiled.Value);
                }
            }

            obj.SetPropertyIfExists("DOCNUMBER", model.ProfileInfo.DocNumber);

            var mittente = model.Fields.GetField<ArxivarNext.Model.ToFieldDTO>("TO");
            obj.SetPropertyIfExists(AxToExternalIdFieldAttribute.AX_KEY, mittente.Value?.Select(m => m.ExternalId));

            var destinatario = model.Fields.GetField<ArxivarNext.Model.FromFieldDTO>("FROM");
            obj.SetPropertyIfExists(AxFromExternalIdFieldAttribute.AX_KEY, destinatario.Value?.ExternalId);
            return obj;
        }

        public static T Idrate(ArxivarNext.Model.RowSearchResult searchresult)
        {
            var obj = new T();
            foreach (var col in searchresult.Columns)
            {
                obj.SetPropertyIfExists(col.Id, col.Value);
            }
            return obj;
        }

        public bool SetPropertyIfExists(string axField, object value)
        {
            bool found = false;
            if (this.HasAXField(axField))
            {
                var properties = this.GetType().GetProperties();
                foreach (var property in properties)
                {
                    if (axField == this.GetArxivarAttribute(property.Name)?.AXField)
                    {
                        this.setValue(property.Name, value);
                        found = true;
                    }

                }
            }
#if DEBUG
            else
            {
                //System.Diagnostics.Debugger.Break();
            }
#endif
            return found;
        }

        public static List<T> Idrate(List<ArxivarNext.Model.RowSearchResult> results)
        {
            return (from result in results select Idrate(result)).ToList();
        }

        #endregion

        #region testers
        public new bool HasDbField(string field)
        {
            return this.GetType().GetProperties().Where(property =>
                GetAxDbAttribute(property.Name)?.DbField == field
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

        public AxFieldAttribute GetArxivarAttribute(string propertyName)
        {
            var propr = GetType().GetProperty(propertyName);
            var attrs = propr.GetCustomAttributes(typeof(AxFieldAttribute), true);
            return attrs.LastOrDefault() as AxFieldAttribute;
        }

        public AxDbFieldAttribute GetAxDbAttribute(string propertyName)
        {
            var propr = GetType().GetProperty(propertyName);
            var attrs = propr.GetCustomAttributes(typeof(AxDbFieldAttribute), true);
            return attrs.LastOrDefault() as AxDbFieldAttribute;
        }

        public List<AxFieldAttribute> GetArxivarAttributes()
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

        public Tm GetValueByDbField<Tm>(string field)
        {
            return GetValueBy<Tm>(field, property => GetDbAttribute(property.Name)?.DbField);
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
                if (HasDbField(fieldName))
                {
                    return GetValueByDbField<object>(fieldName);
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
                    if (!fields.Keys.Contains(ax.AXField))
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
