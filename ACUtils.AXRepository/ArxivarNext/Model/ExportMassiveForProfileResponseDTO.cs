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
    /// ExportMassiveForProfileResponseDTO
    /// </summary>
    [DataContract]
        public partial class ExportMassiveForProfileResponseDTO :  IEquatable<ExportMassiveForProfileResponseDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportMassiveForProfileResponseDTO" /> class.
        /// </summary>
        /// <param name="exportRequestId">Identifier of export in progress.</param>
        public ExportMassiveForProfileResponseDTO(string exportRequestId = default(string))
        {
            this.ExportRequestId = exportRequestId;
        }
        
        /// <summary>
        /// Identifier of export in progress
        /// </summary>
        /// <value>Identifier of export in progress</value>
        [DataMember(Name="exportRequestId", EmitDefaultValue=false)]
        public string ExportRequestId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportMassiveForProfileResponseDTO {\n");
            sb.Append("  ExportRequestId: ").Append(ExportRequestId).Append("\n");
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
            return this.Equals(input as ExportMassiveForProfileResponseDTO);
        }

        /// <summary>
        /// Returns true if ExportMassiveForProfileResponseDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ExportMassiveForProfileResponseDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExportMassiveForProfileResponseDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExportRequestId == input.ExportRequestId ||
                    (this.ExportRequestId != null &&
                    this.ExportRequestId.Equals(input.ExportRequestId))
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
                if (this.ExportRequestId != null)
                    hashCode = hashCode * 59 + this.ExportRequestId.GetHashCode();
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
