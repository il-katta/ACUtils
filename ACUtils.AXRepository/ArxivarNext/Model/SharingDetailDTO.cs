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
    /// Detail of a sharing
    /// </summary>
    [DataContract]
        public partial class SharingDetailDTO :  IEquatable<SharingDetailDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharingDetailDTO" /> class.
        /// </summary>
        /// <param name="sharingDetailId">Unique id of the detail.</param>
        /// <param name="sharingId">Id of the sharing.</param>
        /// <param name="docnumber">Docnumber fot the detail.</param>
        /// <param name="revision">Revision for the detail.</param>
        public SharingDetailDTO(string sharingDetailId = default(string), string sharingId = default(string), int? docnumber = default(int?), int? revision = default(int?))
        {
            this.SharingDetailId = sharingDetailId;
            this.SharingId = sharingId;
            this.Docnumber = docnumber;
            this.Revision = revision;
        }
        
        /// <summary>
        /// Unique id of the detail
        /// </summary>
        /// <value>Unique id of the detail</value>
        [DataMember(Name="sharingDetailId", EmitDefaultValue=false)]
        public string SharingDetailId { get; set; }

        /// <summary>
        /// Id of the sharing
        /// </summary>
        /// <value>Id of the sharing</value>
        [DataMember(Name="sharingId", EmitDefaultValue=false)]
        public string SharingId { get; set; }

        /// <summary>
        /// Docnumber fot the detail
        /// </summary>
        /// <value>Docnumber fot the detail</value>
        [DataMember(Name="docnumber", EmitDefaultValue=false)]
        public int? Docnumber { get; set; }

        /// <summary>
        /// Revision for the detail
        /// </summary>
        /// <value>Revision for the detail</value>
        [DataMember(Name="revision", EmitDefaultValue=false)]
        public int? Revision { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SharingDetailDTO {\n");
            sb.Append("  SharingDetailId: ").Append(SharingDetailId).Append("\n");
            sb.Append("  SharingId: ").Append(SharingId).Append("\n");
            sb.Append("  Docnumber: ").Append(Docnumber).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
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
            return this.Equals(input as SharingDetailDTO);
        }

        /// <summary>
        /// Returns true if SharingDetailDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SharingDetailDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharingDetailDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SharingDetailId == input.SharingDetailId ||
                    (this.SharingDetailId != null &&
                    this.SharingDetailId.Equals(input.SharingDetailId))
                ) && 
                (
                    this.SharingId == input.SharingId ||
                    (this.SharingId != null &&
                    this.SharingId.Equals(input.SharingId))
                ) && 
                (
                    this.Docnumber == input.Docnumber ||
                    (this.Docnumber != null &&
                    this.Docnumber.Equals(input.Docnumber))
                ) && 
                (
                    this.Revision == input.Revision ||
                    (this.Revision != null &&
                    this.Revision.Equals(input.Revision))
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
                if (this.SharingDetailId != null)
                    hashCode = hashCode * 59 + this.SharingDetailId.GetHashCode();
                if (this.SharingId != null)
                    hashCode = hashCode * 59 + this.SharingId.GetHashCode();
                if (this.Docnumber != null)
                    hashCode = hashCode * 59 + this.Docnumber.GetHashCode();
                if (this.Revision != null)
                    hashCode = hashCode * 59 + this.Revision.GetHashCode();
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
