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
    /// ShareObjectOptionsDTO
    /// </summary>
    [DataContract]
    public partial class ShareObjectOptionsDTO :  IEquatable<ShareObjectOptionsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShareObjectOptionsDTO" /> class.
        /// </summary>
        /// <param name="options">List of share options.</param>
        /// <param name="objectType">Object type.</param>
        /// <param name="objectId">Object unique identifier.</param>
        public ShareObjectOptionsDTO(List<ShareOptionOptionDTO> options = default(List<ShareOptionOptionDTO>), int? objectType = default(int?), string objectId = default(string))
        {
            this.Options = options;
            this.ObjectType = objectType;
            this.ObjectId = objectId;
        }
        
        /// <summary>
        /// List of share options
        /// </summary>
        /// <value>List of share options</value>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public List<ShareOptionOptionDTO> Options { get; set; }

        /// <summary>
        /// Object type
        /// </summary>
        /// <value>Object type</value>
        [DataMember(Name="objectType", EmitDefaultValue=false)]
        public int? ObjectType { get; set; }

        /// <summary>
        /// Object unique identifier
        /// </summary>
        /// <value>Object unique identifier</value>
        [DataMember(Name="objectId", EmitDefaultValue=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShareObjectOptionsDTO {\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
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
            return this.Equals(input as ShareObjectOptionsDTO);
        }

        /// <summary>
        /// Returns true if ShareObjectOptionsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ShareObjectOptionsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShareObjectOptionsDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    this.Options.SequenceEqual(input.Options)
                ) && 
                (
                    this.ObjectType == input.ObjectType ||
                    (this.ObjectType != null &&
                    this.ObjectType.Equals(input.ObjectType))
                ) && 
                (
                    this.ObjectId == input.ObjectId ||
                    (this.ObjectId != null &&
                    this.ObjectId.Equals(input.ObjectId))
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
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.ObjectType != null)
                    hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.ObjectId != null)
                    hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
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
