using ACUtils.AXRepository.ArxivarNext.Model;
using ACUtils.AXRepository.Exceptions;

using System;
using System.Collections.Generic;
using System.Linq;

namespace ACUtils.AXRepository
{
    public static class AxExt
    {

        public static EditProfileSchemaDTO SetState(this EditProfileSchemaDTO self, string stateName)
        {
            self.Fields.SetState(stateName);
            return self;
        }
        public static MaskProfileSchemaDTO SetState(this MaskProfileSchemaDTO self, string stateName)
        {
            self.Fields.SetState(stateName);
            return self;
        }
        public static void SetState(this List<FieldBaseDTO> fields, string stateName)
        {
            var stateFiled = ((StateFieldDTO)fields.FirstOrDefault(i =>
                i.Name.Equals("Stato", StringComparison.CurrentCultureIgnoreCase)
            ));
            stateFiled.Value = stateName;
        }

        public static DocumentTypeBaseDTO SetDocumentType(this MaskProfileSchemaDTO self, ArxivarNext.Client.Configuration configuration, string aooCode, string docType)
        {
            return self.Fields.SetDocumentType(
                configuration: configuration,
                aooCode: aooCode,
                docType: docType
            );
        }
        public static DocumentTypeBaseDTO SetDocumentType(this List<FieldBaseDTO> fields, ArxivarNext.Client.Configuration configuration, string aooCode, string docType)
        {
            var docTypesApi = new ArxivarNext.Api.DocumentTypesApi(configuration);
            var doctypes = docTypesApi.DocumentTypesGetOld(1, aooCode); // TODO: deprecated method
            try
            {
                DocumentTypeBaseDTO classeDoc = doctypes.First(i =>
                    i.Key.Equals(docType, StringComparison.CurrentCultureIgnoreCase)
                );
                fields.SetDocumentType(classeDoc.Id.Value);
                return classeDoc;
            }
            catch (InvalidOperationException e)
            {
                throw new ApiError($"classe doc '{docType}' non trovata", e);
            }
        }

        public static void SetDocumentType(this List<FieldBaseDTO> fields, int doc_type)
        {
            var docTypeField = fields.FirstOrDefault(i => i.Name.Equals("DocumentType")) as DocumentTypeFieldDTO;
            docTypeField.Value = doc_type;
        }

        public static string GetDocumentType(this EditProfileSchemaDTO self)
        {
            return self.Fields.GetDocumentType();
        }

        public static string GetDocumentType(this List<FieldBaseDTO> fields)
        {
            var docTypeField = fields.GetField<DocumentTypeFieldDTO>("DocumentType");
            return docTypeField.DisplayValue;
        }

        public static T GetField<T>(this List<FieldBaseDTO> fields, string name) where T : FieldBaseDTO
        {
            return fields.GetField(name) as T;
        }

        public static FieldBaseDTO GetField(this List<FieldBaseDTO> fields, string name)
        {
            var field = fields.FirstOrDefault(i =>
                i.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase)
            );
            return field;
        }

        public static T GetFieldValue<T>(this List<FieldBaseDTO> fields, string name)
        {
            var field = fields.GetField(name);

            if (field == null)
            {
                throw new Exception($"'{name}': campo Arxivar non trovato");
            }
            if (field?.ClassName == "SubjectFieldDTO")
            {
                return (T)Convert.ChangeType((field as SubjectFieldDTO).Value, typeof(T));
            }
            else if (field?.ClassName == "DocumentDateFieldDTO")
            {
                return (T)Convert.ChangeType((field as DocumentDateFieldDTO).Value, typeof(T));
            }
            else if (field?.ClassName == "AdditionalFieldStringDTO")
            {
                return (T)Convert.ChangeType((field as AdditionalFieldStringDTO).Value, typeof(T));
            }
            else if (field?.ClassName == "AdditionalFieldComboDTO")
            {
                return (T)Convert.ChangeType((field as AdditionalFieldComboDTO).Value, typeof(T));
            }
            else if (field?.ClassName == "AdditionalFieldDoubleDTO")
            {
                return (T)Convert.ChangeType((field as AdditionalFieldDoubleDTO).Value, typeof(T));
            }
            else if (field?.ClassName == "AdditionalFieldIntDTO")
            {
                return (T)Convert.ChangeType((field as AdditionalFieldIntDTO).Value, typeof(T));
            }
            else if (field?.ClassName == "AdditionalFieldBooleanDTO")
            {
                return (T)Convert.ChangeType((field as AdditionalFieldBooleanDTO).Value, typeof(T));
            }
            else if (field?.ClassName == "AdditionalFieldDateTimeDTO")
            {
                return (T)Convert.ChangeType((field as AdditionalFieldDateTimeDTO).Value, typeof(T));
            }
            else if (field?.ClassName == "AdditionalFieldMultivalueDTO")
            {
                return (T)Convert.ChangeType((field as AdditionalFieldMultivalueDTO).Value, typeof(T));
            }
            else if (field?.ClassName == "DocumentTypeFieldDTO")
            {
                return (T)Convert.ChangeType((field as DocumentTypeFieldDTO).Value, typeof(T));
            }
            else
            {
                throw new Exception($"'{name}' - type '{field?.ClassName}': not permitted ");
            }
        }

        public static EditProfileSchemaDTO SetField(this EditProfileSchemaDTO self, string name, object value)
        {
            self.Fields.SetField(name, value);
            return self;
        }
        public static MaskProfileSchemaDTO SetField(this MaskProfileSchemaDTO self, string name, object value)
        {
            self.Fields.SetField(name, value);
            return self;
        }

        public static void SetField(this List<FieldBaseDTO> fields, string name, object value)
        {
            if (name == "WORKFLOW")
            {
                return;
            }
            if (name == "DOCNUMBER")
            {
                return;
            }
            var field = fields.FirstOrDefault(i =>
                i.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase)
            );
            if (field == null)
            {
                throw new Exception($"'{name}': campo Arxivar non trovato");
            }
            if (field?.ClassName == "SubjectFieldDTO")
            {
                (field as SubjectFieldDTO).Value = Convert.ToString(value);
            }
            else if (field?.ClassName == "DocumentDateFieldDTO")
            {
                (field as DocumentDateFieldDTO).Value = Convert.ToDateTime(value);
            }
            else if (field?.ClassName == "AdditionalFieldStringDTO")
            {
                (field as AdditionalFieldStringDTO).Value = Convert.ToString(value);
            }
            else if (field?.ClassName == "AdditionalFieldComboDTO")
            {
                (field as AdditionalFieldComboDTO).Value = Convert.ToString(value);
            }
            else if (field?.ClassName == "AdditionalFieldDoubleDTO")
            {
                (field as AdditionalFieldDoubleDTO).Value = Convert.ToDouble(value);
            }
            else if (field?.ClassName == "AdditionalFieldIntDTO")
            {
                (field as AdditionalFieldIntDTO).Value = Convert.ToInt32(value);
            }
            else if (field?.ClassName == "AdditionalFieldBooleanDTO")
            {
                (field as AdditionalFieldBooleanDTO).Value = Convert.ToBoolean(value);
            }
            else if (field?.ClassName == "AdditionalFieldDateTimeDTO")
            {
                (field as AdditionalFieldDateTimeDTO).Value = Convert.ToDateTime(value);
            }
            else if (field?.ClassName == "AdditionalFieldMultivalueDTO")
            {
                (field as AdditionalFieldMultivalueDTO).Value = (List<string>)Convert.ChangeType(value, typeof(List<string>));
            }
            else if (field?.ClassName == "FromFieldDTO")
            {
                (field as FromFieldDTO).Value = (UserProfileDTO)value;
            }
            else if (field?.ClassName == "StateFieldDTO")
            {
                (field as StateFieldDTO).Value = (string)value;
            }
            else
            {
                throw new Exception($"'{name}' - type '{field?.ClassName}': not permitted ");
            }
        }

        public static MaskProfileSchemaDTO SetToField(this MaskProfileSchemaDTO self, UserProfileDTO value)
        {
            self.Fields.SetToField(value);
            return self;
        }

        public static void SetToField(this List<FieldBaseDTO> fields, UserProfileDTO value)
        {
            var field = ((ToFieldDTO)fields.FirstOrDefault(i =>
                i.Name.Equals("To", StringComparison.CurrentCultureIgnoreCase)
            ));
            if (field.Value == null)
            {
                field.Value = new List<UserProfileDTO>();
            }
            field.Value.Add(value);
        }

        public static MaskProfileSchemaDTO SetFromField(this MaskProfileSchemaDTO self, UserProfileDTO value)
        {
            self.Fields.SetFromField(value);
            return self;
        }
        public static void SetFromField(this List<FieldBaseDTO> fields, UserProfileDTO value)
        {
            fields.SetField("From", value);
        }

        public static UserSearchDTO SetString(this UserSearchDTO self, string name, string value, int operator_ = 3)
        {
            self.StringFields.Set(name: name, value: value, operator_: operator_);
            return self;
        }
        public static void Set(this List<FieldBaseForSearchStringDto> fields, string name, string value, int operator_ = 3)
        {
            var field = fields.First(i => i.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));
            field.Operator = operator_;
            field.Valore1 = value;
        }

        public static UserSearchDTO SetInt(this UserSearchDTO self, string name, int? value, int operator_ = 3)
        {
            self.IntFields.Set(name: name, value: value, operator_: operator_);
            return self;
        }
        public static void Set(this List<FieldBaseForSearchIntDto> fields, string name, int? value, int operator_ = 3)
        {
            var field = fields.First(i => i.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));
            field.Operator = operator_;
            field.Valore1 = value;
        }
        public static SearchDTO Set(this SearchDTO self, string name, object value, int operator_ = 3)
        {
            self.Fields.Set(name: name, value: value, operator_: operator_);
            return self;
        }
        public static void Set(this List<FieldBaseForSearchDTO> fields, string name, object value, int operator_ = 3)
        {
            var field = fields.First(i => i.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));
            switch (field.ClassName)
            {
                case "FieldBaseForSearchStringDto":
                    ((FieldBaseForSearchStringDto)field).Operator = operator_;
                    ((FieldBaseForSearchStringDto)field).Valore1 = Convert.ToString(value);
                    break;
                case "FieldBaseForSearchDocumentTypeDto":
                    ((FieldBaseForSearchDocumentTypeDto)field).Operator = operator_;
                    ((FieldBaseForSearchDocumentTypeDto)field).Valore1 = (DocumentTypeSearchFilterDto)value;
                    break;
                case "FieldBaseForSearchIntDto":
                    ((FieldBaseForSearchIntDto)field).Operator = operator_;
                    ((FieldBaseForSearchIntDto)field).Valore1 = Convert.ToInt32(value);
                    break;
                case "FieldBaseForSearchDateTimeDto":
                    ((FieldBaseForSearchDateTimeDto)field).Operator = operator_;
                    ((FieldBaseForSearchDateTimeDto)field).Valore1 = Convert.ToDateTime(value);
                    break;
                default:
                    throw new ArgumentException($"{field.ClassName}: invalid ClassName");
            }
        }

        public static ColumnSearchResult Get(this RowSearchResult self, string name)
        {
            return self.Columns.Get(name);
        }
        public static ColumnSearchResult Get(this List<ColumnSearchResult> results, string name)
        {
            return results.First(i => i.Id.Equals(name, StringComparison.CurrentCultureIgnoreCase));
        }

        public static T GetValue<T>(this RowSearchResult self, string name)
        {
            return self.Columns.GetValue<T>(name);
        }
        public static T GetValue<T>(this List<ColumnSearchResult> results, string name)
        {
            try
            {
                return (T)results.Get(name).Value;
            }
            catch
            {
                return (T)System.Convert.ChangeType(results.Get(name).Value, typeof(T));
            }
        }

        public static SelectDTO Select(this SelectDTO self, string name)
        {
            self.Fields.Select(name);
            return self;
        }

        public static List<FieldBaseForSelectDTO> Select(this List<FieldBaseForSelectDTO> fields, string name)
        {
            fields.First(i => i.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase)).Selected = true;
            return fields;
        }

        public static List<RubricaFieldDTO> Select(this List<RubricaFieldDTO> fields, string name)
        {
            fields.First(i => i.KeyField.Equals(name, StringComparison.CurrentCultureIgnoreCase)).Selected = true;
            return fields;
        }
    }
}
