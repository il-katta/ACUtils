/* 
 * WebAPI
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: data
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
using SwaggerDateConverter = ACUtils.AXRepository.ArxivarNext.Client.SwaggerDateConverter;

namespace ACUtils.AXRepository.ArxivarNext.Model
{
    /// <summary>
    /// ARXeSigN operation
    /// </summary>
    [DataContract]
    public partial class ArxESignSignOperationDto :  IEquatable<ArxESignSignOperationDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArxESignSignOperationDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ArxESignSignOperationDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ArxESignSignOperationDto" /> class.
        /// </summary>
        /// <param name="signType">Possible values:  0: Click  1: Draw  2: Type  (required).</param>
        /// <param name="displayIp">Display IP in signature.</param>
        /// <param name="displayName">Display Name in signature.</param>
        /// <param name="displaySignatureDate">Display Signature date in signature.</param>
        /// <param name="displayEmail">Display email in signature.</param>
        /// <param name="name">Name (required).</param>
        /// <param name="required">Indicates if the operation is required.</param>
        /// <param name="documentId">Document identifier (required).</param>
        public ArxESignSignOperationDto(int? signType = default(int?), bool? displayIp = default(bool?), bool? displayName = default(bool?), bool? displaySignatureDate = default(bool?), bool? displayEmail = default(bool?), string name = default(string), bool? required = default(bool?), string documentId = default(string))
        {
            // to ensure "signType" is required (not null)
            if (signType == null)
            {
                throw new InvalidDataException("signType is a required property for ArxESignSignOperationDto and cannot be null");
            }
            else
            {
                this.SignType = signType;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ArxESignSignOperationDto and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "documentId" is required (not null)
            if (documentId == null)
            {
                throw new InvalidDataException("documentId is a required property for ArxESignSignOperationDto and cannot be null");
            }
            else
            {
                this.DocumentId = documentId;
            }
            this.DisplayIp = displayIp;
            this.DisplayName = displayName;
            this.DisplaySignatureDate = displaySignatureDate;
            this.DisplayEmail = displayEmail;
            this.Required = required;
        }
        
        /// <summary>
        /// Possible values:  0: Click  1: Draw  2: Type 
        /// </summary>
        /// <value>Possible values:  0: Click  1: Draw  2: Type </value>
        [DataMember(Name="signType", EmitDefaultValue=false)]
        public int? SignType { get; set; }

        /// <summary>
        /// Display IP in signature
        /// </summary>
        /// <value>Display IP in signature</value>
        [DataMember(Name="displayIp", EmitDefaultValue=false)]
        public bool? DisplayIp { get; set; }

        /// <summary>
        /// Display Name in signature
        /// </summary>
        /// <value>Display Name in signature</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public bool? DisplayName { get; set; }

        /// <summary>
        /// Display Signature date in signature
        /// </summary>
        /// <value>Display Signature date in signature</value>
        [DataMember(Name="displaySignatureDate", EmitDefaultValue=false)]
        public bool? DisplaySignatureDate { get; set; }

        /// <summary>
        /// Display email in signature
        /// </summary>
        /// <value>Display email in signature</value>
        [DataMember(Name="displayEmail", EmitDefaultValue=false)]
        public bool? DisplayEmail { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Indicates if the operation is required
        /// </summary>
        /// <value>Indicates if the operation is required</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; set; }

        /// <summary>
        /// Document identifier
        /// </summary>
        /// <value>Document identifier</value>
        [DataMember(Name="documentId", EmitDefaultValue=false)]
        public string DocumentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArxESignSignOperationDto {\n");
            sb.Append("  SignType: ").Append(SignType).Append("\n");
            sb.Append("  DisplayIp: ").Append(DisplayIp).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  DisplaySignatureDate: ").Append(DisplaySignatureDate).Append("\n");
            sb.Append("  DisplayEmail: ").Append(DisplayEmail).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
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
            return this.Equals(input as ArxESignSignOperationDto);
        }

        /// <summary>
        /// Returns true if ArxESignSignOperationDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ArxESignSignOperationDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArxESignSignOperationDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SignType == input.SignType ||
                    (this.SignType != null &&
                    this.SignType.Equals(input.SignType))
                ) && 
                (
                    this.DisplayIp == input.DisplayIp ||
                    (this.DisplayIp != null &&
                    this.DisplayIp.Equals(input.DisplayIp))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.DisplaySignatureDate == input.DisplaySignatureDate ||
                    (this.DisplaySignatureDate != null &&
                    this.DisplaySignatureDate.Equals(input.DisplaySignatureDate))
                ) && 
                (
                    this.DisplayEmail == input.DisplayEmail ||
                    (this.DisplayEmail != null &&
                    this.DisplayEmail.Equals(input.DisplayEmail))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Required == input.Required ||
                    (this.Required != null &&
                    this.Required.Equals(input.Required))
                ) && 
                (
                    this.DocumentId == input.DocumentId ||
                    (this.DocumentId != null &&
                    this.DocumentId.Equals(input.DocumentId))
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
                if (this.SignType != null)
                    hashCode = hashCode * 59 + this.SignType.GetHashCode();
                if (this.DisplayIp != null)
                    hashCode = hashCode * 59 + this.DisplayIp.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.DisplaySignatureDate != null)
                    hashCode = hashCode * 59 + this.DisplaySignatureDate.GetHashCode();
                if (this.DisplayEmail != null)
                    hashCode = hashCode * 59 + this.DisplayEmail.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.DocumentId != null)
                    hashCode = hashCode * 59 + this.DocumentId.GetHashCode();
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