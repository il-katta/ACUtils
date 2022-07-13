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
    /// Class of Business Unit clone options
    /// </summary>
    [DataContract]
    public partial class BusinessUnitCloneOptionsDTO :  IEquatable<BusinessUnitCloneOptionsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessUnitCloneOptionsDTO" /> class.
        /// </summary>
        /// <param name="originalAooCode">Business Unit code to clone.</param>
        /// <param name="newCode">Code.</param>
        /// <param name="newName">Name.</param>
        public BusinessUnitCloneOptionsDTO(string originalAooCode = default(string), string newCode = default(string), string newName = default(string))
        {
            this.OriginalAooCode = originalAooCode;
            this.NewCode = newCode;
            this.NewName = newName;
        }
        
        /// <summary>
        /// Business Unit code to clone
        /// </summary>
        /// <value>Business Unit code to clone</value>
        [DataMember(Name="originalAooCode", EmitDefaultValue=false)]
        public string OriginalAooCode { get; set; }

        /// <summary>
        /// Code
        /// </summary>
        /// <value>Code</value>
        [DataMember(Name="newCode", EmitDefaultValue=false)]
        public string NewCode { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="newName", EmitDefaultValue=false)]
        public string NewName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessUnitCloneOptionsDTO {\n");
            sb.Append("  OriginalAooCode: ").Append(OriginalAooCode).Append("\n");
            sb.Append("  NewCode: ").Append(NewCode).Append("\n");
            sb.Append("  NewName: ").Append(NewName).Append("\n");
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
            return this.Equals(input as BusinessUnitCloneOptionsDTO);
        }

        /// <summary>
        /// Returns true if BusinessUnitCloneOptionsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessUnitCloneOptionsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessUnitCloneOptionsDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OriginalAooCode == input.OriginalAooCode ||
                    (this.OriginalAooCode != null &&
                    this.OriginalAooCode.Equals(input.OriginalAooCode))
                ) && 
                (
                    this.NewCode == input.NewCode ||
                    (this.NewCode != null &&
                    this.NewCode.Equals(input.NewCode))
                ) && 
                (
                    this.NewName == input.NewName ||
                    (this.NewName != null &&
                    this.NewName.Equals(input.NewName))
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
                if (this.OriginalAooCode != null)
                    hashCode = hashCode * 59 + this.OriginalAooCode.GetHashCode();
                if (this.NewCode != null)
                    hashCode = hashCode * 59 + this.NewCode.GetHashCode();
                if (this.NewName != null)
                    hashCode = hashCode * 59 + this.NewName.GetHashCode();
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