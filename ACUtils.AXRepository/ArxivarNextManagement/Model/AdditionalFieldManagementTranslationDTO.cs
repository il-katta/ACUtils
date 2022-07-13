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
    /// Class of field translation
    /// </summary>
    [DataContract]
    public partial class AdditionalFieldManagementTranslationDTO :  IEquatable<AdditionalFieldManagementTranslationDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalFieldManagementTranslationDTO" /> class.
        /// </summary>
        /// <param name="type">Possible values:  0: Description  1: ErrorValidation .</param>
        /// <param name="langCode">Language code.</param>
        /// <param name="value">Translation.</param>
        public AdditionalFieldManagementTranslationDTO(int? type = default(int?), string langCode = default(string), string value = default(string))
        {
            this.Type = type;
            this.LangCode = langCode;
            this.Value = value;
        }
        
        /// <summary>
        /// Possible values:  0: Description  1: ErrorValidation 
        /// </summary>
        /// <value>Possible values:  0: Description  1: ErrorValidation </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int? Type { get; set; }

        /// <summary>
        /// Language code
        /// </summary>
        /// <value>Language code</value>
        [DataMember(Name="langCode", EmitDefaultValue=false)]
        public string LangCode { get; set; }

        /// <summary>
        /// Translation
        /// </summary>
        /// <value>Translation</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalFieldManagementTranslationDTO {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  LangCode: ").Append(LangCode).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as AdditionalFieldManagementTranslationDTO);
        }

        /// <summary>
        /// Returns true if AdditionalFieldManagementTranslationDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalFieldManagementTranslationDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalFieldManagementTranslationDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.LangCode == input.LangCode ||
                    (this.LangCode != null &&
                    this.LangCode.Equals(input.LangCode))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.LangCode != null)
                    hashCode = hashCode * 59 + this.LangCode.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
