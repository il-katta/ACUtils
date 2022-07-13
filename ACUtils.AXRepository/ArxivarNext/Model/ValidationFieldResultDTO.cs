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
    /// ValidationFieldResultDTO
    /// </summary>
    [DataContract]
    public partial class ValidationFieldResultDTO :  IEquatable<ValidationFieldResultDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationFieldResultDTO" /> class.
        /// </summary>
        /// <param name="isValid">isValid.</param>
        /// <param name="validationErrorMessage">validationErrorMessage.</param>
        public ValidationFieldResultDTO(bool? isValid = default(bool?), string validationErrorMessage = default(string))
        {
            this.IsValid = isValid;
            this.ValidationErrorMessage = validationErrorMessage;
        }
        
        /// <summary>
        /// Gets or Sets IsValid
        /// </summary>
        [DataMember(Name="isValid", EmitDefaultValue=false)]
        public bool? IsValid { get; set; }

        /// <summary>
        /// Gets or Sets ValidationErrorMessage
        /// </summary>
        [DataMember(Name="validationErrorMessage", EmitDefaultValue=false)]
        public string ValidationErrorMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidationFieldResultDTO {\n");
            sb.Append("  IsValid: ").Append(IsValid).Append("\n");
            sb.Append("  ValidationErrorMessage: ").Append(ValidationErrorMessage).Append("\n");
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
            return this.Equals(input as ValidationFieldResultDTO);
        }

        /// <summary>
        /// Returns true if ValidationFieldResultDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ValidationFieldResultDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidationFieldResultDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsValid == input.IsValid ||
                    (this.IsValid != null &&
                    this.IsValid.Equals(input.IsValid))
                ) && 
                (
                    this.ValidationErrorMessage == input.ValidationErrorMessage ||
                    (this.ValidationErrorMessage != null &&
                    this.ValidationErrorMessage.Equals(input.ValidationErrorMessage))
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
                if (this.IsValid != null)
                    hashCode = hashCode * 59 + this.IsValid.GetHashCode();
                if (this.ValidationErrorMessage != null)
                    hashCode = hashCode * 59 + this.ValidationErrorMessage.GetHashCode();
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
