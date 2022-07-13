/* 
 * WebAPI - Area Management
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: management
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = ACUtils.AXRepository.ArxivarNextManagement.Client.SwaggerDateConverter;

namespace ACUtils.AXRepository.ArxivarNextManagement.Model
{
    /// <summary>
    /// Class of Ix Document type field
    /// </summary>
    [DataContract]
    public partial class IxDocumentTypeFieldDTO :  IEquatable<IxDocumentTypeFieldDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IxDocumentTypeFieldDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="name">Name.</param>
        /// <param name="description">Description.</param>
        /// <param name="group">Group.</param>
        /// <param name="defaultValue">Default value.</param>
        /// <param name="constraints">Constraints.</param>
        /// <param name="validationExpr">Validation expression.</param>
        /// <param name="useSource">Use source.</param>
        /// <param name="values">Values.</param>
        /// <param name="sourceIdentifier">Source identifier.</param>
        /// <param name="formulas">Formulas.</param>
        /// <param name="valueType">Possible values:  0: GenericString  1: GenericDatetime  2: GenericDate  3: GenericInt16  4: GenericInt32  5: GenericInt64  6: GenericBoolean  7: GenericDouble  8: TypedStringIdentifier  9: TypedIntRevision  10: TypedDateRefDate  11: TypedDateRetentionDate  12: TypedIntYear  13: PaIpaCodeString  14: PaOfficeCodeString  15: EntityNameString  16: EntitySurnameString  17: EntityFiscalCodeString  18: EntityBusinessNameString  19: EntityVatCodeString  20: EntityIpaCodeString  21: EntityOfficeCodeString  22: PrivacyCryptoKeyString  23: PrivacyCryptoAlgorithmString  24: ViewerStringIdentifier  25: ViewerStringProducer  26: ViewerStringName  27: ViewerStringVersion  28: ViewerStringUrl  29: FolderStringIdentifier  30: FolderDateClosingDate .</param>
        /// <param name="type">Possible values:  0: String  1: Int16  2: Int32  3: Int64  4: Datetime  5: Boolean  6: Double  7: Date .</param>
        /// <param name="inputType">Possible values:  0: Single  1: Multiple  2: SingleWithChoice  3: MultipleWithChoice  4: SingleWithDefault .</param>
        /// <param name="privacy">Possible values:  0: Generic  1: Individual  2: Sensitive  3: Judicial .</param>
        /// <param name="validation">Possible values:  0: None  1: FiscalCode  2: VatCode  3: Custom  4: Match  5: Length .</param>
        /// <param name="required">Is required.</param>
        /// <param name="readOnly">Read only.</param>
        public IxDocumentTypeFieldDTO(string id = default(string), string name = default(string), string description = default(string), string group = default(string), string defaultValue = default(string), List<IxDocumentTypeFieldConstraintDTO> constraints = default(List<IxDocumentTypeFieldConstraintDTO>), string validationExpr = default(string), bool? useSource = default(bool?), List<string> values = default(List<string>), string sourceIdentifier = default(string), List<IxDocumentTypeFieldFormulaDTO> formulas = default(List<IxDocumentTypeFieldFormulaDTO>), int? valueType = default(int?), int? type = default(int?), int? inputType = default(int?), int? privacy = default(int?), int? validation = default(int?), bool? required = default(bool?), bool? readOnly = default(bool?))
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Group = group;
            this.DefaultValue = defaultValue;
            this.Constraints = constraints;
            this.ValidationExpr = validationExpr;
            this.UseSource = useSource;
            this.Values = values;
            this.SourceIdentifier = sourceIdentifier;
            this.Formulas = formulas;
            this.ValueType = valueType;
            this.Type = type;
            this.InputType = inputType;
            this.Privacy = privacy;
            this.Validation = validation;
            this.Required = required;
            this.ReadOnly = readOnly;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Group
        /// </summary>
        /// <value>Group</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public string Group { get; set; }

        /// <summary>
        /// Default value
        /// </summary>
        /// <value>Default value</value>
        [DataMember(Name="defaultValue", EmitDefaultValue=false)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Constraints
        /// </summary>
        /// <value>Constraints</value>
        [DataMember(Name="constraints", EmitDefaultValue=false)]
        public List<IxDocumentTypeFieldConstraintDTO> Constraints { get; set; }

        /// <summary>
        /// Validation expression
        /// </summary>
        /// <value>Validation expression</value>
        [DataMember(Name="validationExpr", EmitDefaultValue=false)]
        public string ValidationExpr { get; set; }

        /// <summary>
        /// Use source
        /// </summary>
        /// <value>Use source</value>
        [DataMember(Name="useSource", EmitDefaultValue=false)]
        public bool? UseSource { get; set; }

        /// <summary>
        /// Values
        /// </summary>
        /// <value>Values</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }

        /// <summary>
        /// Source identifier
        /// </summary>
        /// <value>Source identifier</value>
        [DataMember(Name="sourceIdentifier", EmitDefaultValue=false)]
        public string SourceIdentifier { get; set; }

        /// <summary>
        /// Formulas
        /// </summary>
        /// <value>Formulas</value>
        [DataMember(Name="formulas", EmitDefaultValue=false)]
        public List<IxDocumentTypeFieldFormulaDTO> Formulas { get; set; }

        /// <summary>
        /// Possible values:  0: GenericString  1: GenericDatetime  2: GenericDate  3: GenericInt16  4: GenericInt32  5: GenericInt64  6: GenericBoolean  7: GenericDouble  8: TypedStringIdentifier  9: TypedIntRevision  10: TypedDateRefDate  11: TypedDateRetentionDate  12: TypedIntYear  13: PaIpaCodeString  14: PaOfficeCodeString  15: EntityNameString  16: EntitySurnameString  17: EntityFiscalCodeString  18: EntityBusinessNameString  19: EntityVatCodeString  20: EntityIpaCodeString  21: EntityOfficeCodeString  22: PrivacyCryptoKeyString  23: PrivacyCryptoAlgorithmString  24: ViewerStringIdentifier  25: ViewerStringProducer  26: ViewerStringName  27: ViewerStringVersion  28: ViewerStringUrl  29: FolderStringIdentifier  30: FolderDateClosingDate 
        /// </summary>
        /// <value>Possible values:  0: GenericString  1: GenericDatetime  2: GenericDate  3: GenericInt16  4: GenericInt32  5: GenericInt64  6: GenericBoolean  7: GenericDouble  8: TypedStringIdentifier  9: TypedIntRevision  10: TypedDateRefDate  11: TypedDateRetentionDate  12: TypedIntYear  13: PaIpaCodeString  14: PaOfficeCodeString  15: EntityNameString  16: EntitySurnameString  17: EntityFiscalCodeString  18: EntityBusinessNameString  19: EntityVatCodeString  20: EntityIpaCodeString  21: EntityOfficeCodeString  22: PrivacyCryptoKeyString  23: PrivacyCryptoAlgorithmString  24: ViewerStringIdentifier  25: ViewerStringProducer  26: ViewerStringName  27: ViewerStringVersion  28: ViewerStringUrl  29: FolderStringIdentifier  30: FolderDateClosingDate </value>
        [DataMember(Name="valueType", EmitDefaultValue=false)]
        public int? ValueType { get; set; }

        /// <summary>
        /// Possible values:  0: String  1: Int16  2: Int32  3: Int64  4: Datetime  5: Boolean  6: Double  7: Date 
        /// </summary>
        /// <value>Possible values:  0: String  1: Int16  2: Int32  3: Int64  4: Datetime  5: Boolean  6: Double  7: Date </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int? Type { get; set; }

        /// <summary>
        /// Possible values:  0: Single  1: Multiple  2: SingleWithChoice  3: MultipleWithChoice  4: SingleWithDefault 
        /// </summary>
        /// <value>Possible values:  0: Single  1: Multiple  2: SingleWithChoice  3: MultipleWithChoice  4: SingleWithDefault </value>
        [DataMember(Name="inputType", EmitDefaultValue=false)]
        public int? InputType { get; set; }

        /// <summary>
        /// Possible values:  0: Generic  1: Individual  2: Sensitive  3: Judicial 
        /// </summary>
        /// <value>Possible values:  0: Generic  1: Individual  2: Sensitive  3: Judicial </value>
        [DataMember(Name="privacy", EmitDefaultValue=false)]
        public int? Privacy { get; set; }

        /// <summary>
        /// Possible values:  0: None  1: FiscalCode  2: VatCode  3: Custom  4: Match  5: Length 
        /// </summary>
        /// <value>Possible values:  0: None  1: FiscalCode  2: VatCode  3: Custom  4: Match  5: Length </value>
        [DataMember(Name="validation", EmitDefaultValue=false)]
        public int? Validation { get; set; }

        /// <summary>
        /// Is required
        /// </summary>
        /// <value>Is required</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; set; }

        /// <summary>
        /// Read only
        /// </summary>
        /// <value>Read only</value>
        [DataMember(Name="readOnly", EmitDefaultValue=false)]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IxDocumentTypeFieldDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  Constraints: ").Append(Constraints).Append("\n");
            sb.Append("  ValidationExpr: ").Append(ValidationExpr).Append("\n");
            sb.Append("  UseSource: ").Append(UseSource).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  SourceIdentifier: ").Append(SourceIdentifier).Append("\n");
            sb.Append("  Formulas: ").Append(Formulas).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  InputType: ").Append(InputType).Append("\n");
            sb.Append("  Privacy: ").Append(Privacy).Append("\n");
            sb.Append("  Validation: ").Append(Validation).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as IxDocumentTypeFieldDTO);
        }

        /// <summary>
        /// Returns true if IxDocumentTypeFieldDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of IxDocumentTypeFieldDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IxDocumentTypeFieldDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.DefaultValue == input.DefaultValue ||
                    (this.DefaultValue != null &&
                    this.DefaultValue.Equals(input.DefaultValue))
                ) && 
                (
                    this.Constraints == input.Constraints ||
                    this.Constraints != null &&
                    this.Constraints.SequenceEqual(input.Constraints)
                ) && 
                (
                    this.ValidationExpr == input.ValidationExpr ||
                    (this.ValidationExpr != null &&
                    this.ValidationExpr.Equals(input.ValidationExpr))
                ) && 
                (
                    this.UseSource == input.UseSource ||
                    (this.UseSource != null &&
                    this.UseSource.Equals(input.UseSource))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(input.Values)
                ) && 
                (
                    this.SourceIdentifier == input.SourceIdentifier ||
                    (this.SourceIdentifier != null &&
                    this.SourceIdentifier.Equals(input.SourceIdentifier))
                ) && 
                (
                    this.Formulas == input.Formulas ||
                    this.Formulas != null &&
                    this.Formulas.SequenceEqual(input.Formulas)
                ) && 
                (
                    this.ValueType == input.ValueType ||
                    (this.ValueType != null &&
                    this.ValueType.Equals(input.ValueType))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.InputType == input.InputType ||
                    (this.InputType != null &&
                    this.InputType.Equals(input.InputType))
                ) && 
                (
                    this.Privacy == input.Privacy ||
                    (this.Privacy != null &&
                    this.Privacy.Equals(input.Privacy))
                ) && 
                (
                    this.Validation == input.Validation ||
                    (this.Validation != null &&
                    this.Validation.Equals(input.Validation))
                ) && 
                (
                    this.Required == input.Required ||
                    (this.Required != null &&
                    this.Required.Equals(input.Required))
                ) && 
                (
                    this.ReadOnly == input.ReadOnly ||
                    (this.ReadOnly != null &&
                    this.ReadOnly.Equals(input.ReadOnly))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.DefaultValue != null)
                    hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                if (this.Constraints != null)
                    hashCode = hashCode * 59 + this.Constraints.GetHashCode();
                if (this.ValidationExpr != null)
                    hashCode = hashCode * 59 + this.ValidationExpr.GetHashCode();
                if (this.UseSource != null)
                    hashCode = hashCode * 59 + this.UseSource.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                if (this.SourceIdentifier != null)
                    hashCode = hashCode * 59 + this.SourceIdentifier.GetHashCode();
                if (this.Formulas != null)
                    hashCode = hashCode * 59 + this.Formulas.GetHashCode();
                if (this.ValueType != null)
                    hashCode = hashCode * 59 + this.ValueType.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.InputType != null)
                    hashCode = hashCode * 59 + this.InputType.GetHashCode();
                if (this.Privacy != null)
                    hashCode = hashCode * 59 + this.Privacy.GetHashCode();
                if (this.Validation != null)
                    hashCode = hashCode * 59 + this.Validation.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.ReadOnly != null)
                    hashCode = hashCode * 59 + this.ReadOnly.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}