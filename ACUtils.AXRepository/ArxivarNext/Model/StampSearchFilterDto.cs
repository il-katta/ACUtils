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
    /// StampSearchFilterDto
    /// </summary>
    [DataContract]
    public partial class StampSearchFilterDto :  IEquatable<StampSearchFilterDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StampSearchFilterDto" /> class.
        /// </summary>
        /// <param name="stampInstanceApplied">stampInstanceApplied.</param>
        /// <param name="stampDefinitionId">stampDefinitionId.</param>
        public StampSearchFilterDto(int? stampInstanceApplied = default(int?), string stampDefinitionId = default(string))
        {
            this.StampInstanceApplied = stampInstanceApplied;
            this.StampDefinitionId = stampDefinitionId;
        }
        
        /// <summary>
        /// Gets or Sets StampInstanceApplied
        /// </summary>
        [DataMember(Name="stampInstanceApplied", EmitDefaultValue=false)]
        public int? StampInstanceApplied { get; set; }

        /// <summary>
        /// Gets or Sets StampDefinitionId
        /// </summary>
        [DataMember(Name="stampDefinitionId", EmitDefaultValue=false)]
        public string StampDefinitionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StampSearchFilterDto {\n");
            sb.Append("  StampInstanceApplied: ").Append(StampInstanceApplied).Append("\n");
            sb.Append("  StampDefinitionId: ").Append(StampDefinitionId).Append("\n");
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
            return this.Equals(input as StampSearchFilterDto);
        }

        /// <summary>
        /// Returns true if StampSearchFilterDto instances are equal
        /// </summary>
        /// <param name="input">Instance of StampSearchFilterDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StampSearchFilterDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StampInstanceApplied == input.StampInstanceApplied ||
                    (this.StampInstanceApplied != null &&
                    this.StampInstanceApplied.Equals(input.StampInstanceApplied))
                ) && 
                (
                    this.StampDefinitionId == input.StampDefinitionId ||
                    (this.StampDefinitionId != null &&
                    this.StampDefinitionId.Equals(input.StampDefinitionId))
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
                if (this.StampInstanceApplied != null)
                    hashCode = hashCode * 59 + this.StampInstanceApplied.GetHashCode();
                if (this.StampDefinitionId != null)
                    hashCode = hashCode * 59 + this.StampDefinitionId.GetHashCode();
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
