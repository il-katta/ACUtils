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
    /// ScanResultDto
    /// </summary>
    [DataContract]
        public partial class ScanResultDto :  IEquatable<ScanResultDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScanResultDto" /> class.
        /// </summary>
        /// <param name="bufferIds">bufferIds.</param>
        /// <param name="fileNames">fileNames.</param>
        public ScanResultDto(List<string> bufferIds = default(List<string>), List<string> fileNames = default(List<string>))
        {
            this.BufferIds = bufferIds;
            this.FileNames = fileNames;
        }
        
        /// <summary>
        /// Gets or Sets BufferIds
        /// </summary>
        [DataMember(Name="bufferIds", EmitDefaultValue=false)]
        public List<string> BufferIds { get; set; }

        /// <summary>
        /// Gets or Sets FileNames
        /// </summary>
        [DataMember(Name="fileNames", EmitDefaultValue=false)]
        public List<string> FileNames { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScanResultDto {\n");
            sb.Append("  BufferIds: ").Append(BufferIds).Append("\n");
            sb.Append("  FileNames: ").Append(FileNames).Append("\n");
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
            return this.Equals(input as ScanResultDto);
        }

        /// <summary>
        /// Returns true if ScanResultDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ScanResultDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScanResultDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BufferIds == input.BufferIds ||
                    this.BufferIds != null &&
                    input.BufferIds != null &&
                    this.BufferIds.SequenceEqual(input.BufferIds)
                ) && 
                (
                    this.FileNames == input.FileNames ||
                    this.FileNames != null &&
                    input.FileNames != null &&
                    this.FileNames.SequenceEqual(input.FileNames)
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
                if (this.BufferIds != null)
                    hashCode = hashCode * 59 + this.BufferIds.GetHashCode();
                if (this.FileNames != null)
                    hashCode = hashCode * 59 + this.FileNames.GetHashCode();
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
