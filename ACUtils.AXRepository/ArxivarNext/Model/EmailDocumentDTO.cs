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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = ACUtils.AXRepository.ArxivarNext.Client.SwaggerDateConverter;

namespace ACUtils.AXRepository.ArxivarNext.Model
{
    /// <summary>
    /// EmailDocumentDTO
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "className")]
    [JsonSubtypes.KnownSubType(typeof(NewAttachDocumentoDTO), "NewAttachDocumentoDTO")]
    [JsonSubtypes.KnownSubType(typeof(SavedAttachDocumentoDTO), "SavedAttachDocumentoDTO")]
    [JsonSubtypes.KnownSubType(typeof(NewAttachArxDocumentoDTO), "NewAttachArxDocumentoDTO")]
    public partial class EmailDocumentDTO :  IEquatable<EmailDocumentDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailDocumentDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmailDocumentDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailDocumentDTO" /> class.
        /// </summary>
        /// <param name="className">Class Name (required).</param>
        public EmailDocumentDTO(string className = default(string))
        {
            // to ensure "className" is required (not null)
            if (className == null)
            {
                throw new InvalidDataException("className is a required property for EmailDocumentDTO and cannot be null");
            }
            else
            {
                this.ClassName = className;
            }
        }
        
        /// <summary>
        /// Class Name
        /// </summary>
        /// <value>Class Name</value>
        [DataMember(Name="className", EmitDefaultValue=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailDocumentDTO {\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
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
            return this.Equals(input as EmailDocumentDTO);
        }

        /// <summary>
        /// Returns true if EmailDocumentDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailDocumentDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailDocumentDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClassName == input.ClassName ||
                    (this.ClassName != null &&
                    this.ClassName.Equals(input.ClassName))
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
                if (this.ClassName != null)
                    hashCode = hashCode * 59 + this.ClassName.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
