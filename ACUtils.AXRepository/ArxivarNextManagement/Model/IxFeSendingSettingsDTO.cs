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
    /// Class of IX-FE sending settings
    /// </summary>
    [DataContract]
    public partial class IxFeSendingSettingsDTO :  IEquatable<IxFeSendingSettingsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IxFeSendingSettingsDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="businessUnitCode">Arxivar Business unit code.</param>
        /// <param name="search">Search.</param>
        /// <param name="documentType">Arxivar document type.</param>
        /// <param name="enabled">Boolean which is true if the configuration is active.</param>
        /// <param name="priority">Priority.</param>
        /// <param name="autoFind">Enable automatic send with search.</param>
        /// <param name="autoFindMinutes">Timing for automatic send with search.</param>
        /// <param name="ixVatField">Arxivar Field for Vat sectional mapping.</param>
        /// <param name="ixSdiField">Arxivar field for SDI code mapping.</param>
        /// <param name="idVersamentoIxCeField">Arxivar field for IdVersamento IX CE mapping.</param>
        /// <param name="idDocumentoIxCeField">Arxivar field for IdDocumento IX CE code mapping.</param>
        /// <param name="sendingMode">Possible values:  0: OnlySend  1: P7mComposition .</param>
        /// <param name="hasCustomCredentials">Has custome credentials.</param>
        public IxFeSendingSettingsDTO(int? id = default(int?), string businessUnitCode = default(string), FindSimpleDTO search = default(FindSimpleDTO), DocumentTypeSimpleDTO documentType = default(DocumentTypeSimpleDTO), bool? enabled = default(bool?), int? priority = default(int?), bool? autoFind = default(bool?), int? autoFindMinutes = default(int?), FieldManagementDTO ixVatField = default(FieldManagementDTO), FieldManagementDTO ixSdiField = default(FieldManagementDTO), FieldManagementDTO idVersamentoIxCeField = default(FieldManagementDTO), FieldManagementDTO idDocumentoIxCeField = default(FieldManagementDTO), int? sendingMode = default(int?), bool? hasCustomCredentials = default(bool?))
        {
            this.Id = id;
            this.BusinessUnitCode = businessUnitCode;
            this.Search = search;
            this.DocumentType = documentType;
            this.Enabled = enabled;
            this.Priority = priority;
            this.AutoFind = autoFind;
            this.AutoFindMinutes = autoFindMinutes;
            this.IxVatField = ixVatField;
            this.IxSdiField = ixSdiField;
            this.IdVersamentoIxCeField = idVersamentoIxCeField;
            this.IdDocumentoIxCeField = idDocumentoIxCeField;
            this.SendingMode = sendingMode;
            this.HasCustomCredentials = hasCustomCredentials;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Arxivar Business unit code
        /// </summary>
        /// <value>Arxivar Business unit code</value>
        [DataMember(Name="businessUnitCode", EmitDefaultValue=false)]
        public string BusinessUnitCode { get; set; }

        /// <summary>
        /// Search
        /// </summary>
        /// <value>Search</value>
        [DataMember(Name="search", EmitDefaultValue=false)]
        public FindSimpleDTO Search { get; set; }

        /// <summary>
        /// Arxivar document type
        /// </summary>
        /// <value>Arxivar document type</value>
        [DataMember(Name="documentType", EmitDefaultValue=false)]
        public DocumentTypeSimpleDTO DocumentType { get; set; }

        /// <summary>
        /// Boolean which is true if the configuration is active
        /// </summary>
        /// <value>Boolean which is true if the configuration is active</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Priority
        /// </summary>
        /// <value>Priority</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// Enable automatic send with search
        /// </summary>
        /// <value>Enable automatic send with search</value>
        [DataMember(Name="autoFind", EmitDefaultValue=false)]
        public bool? AutoFind { get; set; }

        /// <summary>
        /// Timing for automatic send with search
        /// </summary>
        /// <value>Timing for automatic send with search</value>
        [DataMember(Name="autoFindMinutes", EmitDefaultValue=false)]
        public int? AutoFindMinutes { get; set; }

        /// <summary>
        /// Arxivar Field for Vat sectional mapping
        /// </summary>
        /// <value>Arxivar Field for Vat sectional mapping</value>
        [DataMember(Name="ixVatField", EmitDefaultValue=false)]
        public FieldManagementDTO IxVatField { get; set; }

        /// <summary>
        /// Arxivar field for SDI code mapping
        /// </summary>
        /// <value>Arxivar field for SDI code mapping</value>
        [DataMember(Name="ixSdiField", EmitDefaultValue=false)]
        public FieldManagementDTO IxSdiField { get; set; }

        /// <summary>
        /// Arxivar field for IdVersamento IX CE mapping
        /// </summary>
        /// <value>Arxivar field for IdVersamento IX CE mapping</value>
        [DataMember(Name="idVersamentoIxCeField", EmitDefaultValue=false)]
        public FieldManagementDTO IdVersamentoIxCeField { get; set; }

        /// <summary>
        /// Arxivar field for IdDocumento IX CE code mapping
        /// </summary>
        /// <value>Arxivar field for IdDocumento IX CE code mapping</value>
        [DataMember(Name="idDocumentoIxCeField", EmitDefaultValue=false)]
        public FieldManagementDTO IdDocumentoIxCeField { get; set; }

        /// <summary>
        /// Possible values:  0: OnlySend  1: P7mComposition 
        /// </summary>
        /// <value>Possible values:  0: OnlySend  1: P7mComposition </value>
        [DataMember(Name="sendingMode", EmitDefaultValue=false)]
        public int? SendingMode { get; set; }

        /// <summary>
        /// Has custome credentials
        /// </summary>
        /// <value>Has custome credentials</value>
        [DataMember(Name="hasCustomCredentials", EmitDefaultValue=false)]
        public bool? HasCustomCredentials { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IxFeSendingSettingsDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BusinessUnitCode: ").Append(BusinessUnitCode).Append("\n");
            sb.Append("  Search: ").Append(Search).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  AutoFind: ").Append(AutoFind).Append("\n");
            sb.Append("  AutoFindMinutes: ").Append(AutoFindMinutes).Append("\n");
            sb.Append("  IxVatField: ").Append(IxVatField).Append("\n");
            sb.Append("  IxSdiField: ").Append(IxSdiField).Append("\n");
            sb.Append("  IdVersamentoIxCeField: ").Append(IdVersamentoIxCeField).Append("\n");
            sb.Append("  IdDocumentoIxCeField: ").Append(IdDocumentoIxCeField).Append("\n");
            sb.Append("  SendingMode: ").Append(SendingMode).Append("\n");
            sb.Append("  HasCustomCredentials: ").Append(HasCustomCredentials).Append("\n");
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
            return this.Equals(input as IxFeSendingSettingsDTO);
        }

        /// <summary>
        /// Returns true if IxFeSendingSettingsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of IxFeSendingSettingsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IxFeSendingSettingsDTO input)
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
                    this.BusinessUnitCode == input.BusinessUnitCode ||
                    (this.BusinessUnitCode != null &&
                    this.BusinessUnitCode.Equals(input.BusinessUnitCode))
                ) && 
                (
                    this.Search == input.Search ||
                    (this.Search != null &&
                    this.Search.Equals(input.Search))
                ) && 
                (
                    this.DocumentType == input.DocumentType ||
                    (this.DocumentType != null &&
                    this.DocumentType.Equals(input.DocumentType))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.AutoFind == input.AutoFind ||
                    (this.AutoFind != null &&
                    this.AutoFind.Equals(input.AutoFind))
                ) && 
                (
                    this.AutoFindMinutes == input.AutoFindMinutes ||
                    (this.AutoFindMinutes != null &&
                    this.AutoFindMinutes.Equals(input.AutoFindMinutes))
                ) && 
                (
                    this.IxVatField == input.IxVatField ||
                    (this.IxVatField != null &&
                    this.IxVatField.Equals(input.IxVatField))
                ) && 
                (
                    this.IxSdiField == input.IxSdiField ||
                    (this.IxSdiField != null &&
                    this.IxSdiField.Equals(input.IxSdiField))
                ) && 
                (
                    this.IdVersamentoIxCeField == input.IdVersamentoIxCeField ||
                    (this.IdVersamentoIxCeField != null &&
                    this.IdVersamentoIxCeField.Equals(input.IdVersamentoIxCeField))
                ) && 
                (
                    this.IdDocumentoIxCeField == input.IdDocumentoIxCeField ||
                    (this.IdDocumentoIxCeField != null &&
                    this.IdDocumentoIxCeField.Equals(input.IdDocumentoIxCeField))
                ) && 
                (
                    this.SendingMode == input.SendingMode ||
                    (this.SendingMode != null &&
                    this.SendingMode.Equals(input.SendingMode))
                ) && 
                (
                    this.HasCustomCredentials == input.HasCustomCredentials ||
                    (this.HasCustomCredentials != null &&
                    this.HasCustomCredentials.Equals(input.HasCustomCredentials))
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
                if (this.BusinessUnitCode != null)
                    hashCode = hashCode * 59 + this.BusinessUnitCode.GetHashCode();
                if (this.Search != null)
                    hashCode = hashCode * 59 + this.Search.GetHashCode();
                if (this.DocumentType != null)
                    hashCode = hashCode * 59 + this.DocumentType.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.AutoFind != null)
                    hashCode = hashCode * 59 + this.AutoFind.GetHashCode();
                if (this.AutoFindMinutes != null)
                    hashCode = hashCode * 59 + this.AutoFindMinutes.GetHashCode();
                if (this.IxVatField != null)
                    hashCode = hashCode * 59 + this.IxVatField.GetHashCode();
                if (this.IxSdiField != null)
                    hashCode = hashCode * 59 + this.IxSdiField.GetHashCode();
                if (this.IdVersamentoIxCeField != null)
                    hashCode = hashCode * 59 + this.IdVersamentoIxCeField.GetHashCode();
                if (this.IdDocumentoIxCeField != null)
                    hashCode = hashCode * 59 + this.IdDocumentoIxCeField.GetHashCode();
                if (this.SendingMode != null)
                    hashCode = hashCode * 59 + this.SendingMode.GetHashCode();
                if (this.HasCustomCredentials != null)
                    hashCode = hashCode * 59 + this.HasCustomCredentials.GetHashCode();
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
