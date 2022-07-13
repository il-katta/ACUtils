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
    /// Close document for external app request
    /// </summary>
    [DataContract]
    public partial class UpdateDocumentRequestDTO :  IEquatable<UpdateDocumentRequestDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDocumentRequestDTO" /> class.
        /// </summary>
        /// <param name="idDocument">idDocument.</param>
        /// <param name="cacheFileId">cacheFileId.</param>
        /// <param name="updateOption">Possible values:  0: None  1: ForceRevision  2: ForceOverWrite .</param>
        public UpdateDocumentRequestDTO(string idDocument = default(string), string cacheFileId = default(string), int? updateOption = default(int?))
        {
            this.IdDocument = idDocument;
            this.CacheFileId = cacheFileId;
            this.UpdateOption = updateOption;
        }
        
        /// <summary>
        /// Gets or Sets IdDocument
        /// </summary>
        [DataMember(Name="idDocument", EmitDefaultValue=false)]
        public string IdDocument { get; set; }

        /// <summary>
        /// Gets or Sets CacheFileId
        /// </summary>
        [DataMember(Name="cacheFileId", EmitDefaultValue=false)]
        public string CacheFileId { get; set; }

        /// <summary>
        /// Possible values:  0: None  1: ForceRevision  2: ForceOverWrite 
        /// </summary>
        /// <value>Possible values:  0: None  1: ForceRevision  2: ForceOverWrite </value>
        [DataMember(Name="updateOption", EmitDefaultValue=false)]
        public int? UpdateOption { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDocumentRequestDTO {\n");
            sb.Append("  IdDocument: ").Append(IdDocument).Append("\n");
            sb.Append("  CacheFileId: ").Append(CacheFileId).Append("\n");
            sb.Append("  UpdateOption: ").Append(UpdateOption).Append("\n");
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
            return this.Equals(input as UpdateDocumentRequestDTO);
        }

        /// <summary>
        /// Returns true if UpdateDocumentRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateDocumentRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateDocumentRequestDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdDocument == input.IdDocument ||
                    (this.IdDocument != null &&
                    this.IdDocument.Equals(input.IdDocument))
                ) && 
                (
                    this.CacheFileId == input.CacheFileId ||
                    (this.CacheFileId != null &&
                    this.CacheFileId.Equals(input.CacheFileId))
                ) && 
                (
                    this.UpdateOption == input.UpdateOption ||
                    (this.UpdateOption != null &&
                    this.UpdateOption.Equals(input.UpdateOption))
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
                if (this.IdDocument != null)
                    hashCode = hashCode * 59 + this.IdDocument.GetHashCode();
                if (this.CacheFileId != null)
                    hashCode = hashCode * 59 + this.CacheFileId.GetHashCode();
                if (this.UpdateOption != null)
                    hashCode = hashCode * 59 + this.UpdateOption.GetHashCode();
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
