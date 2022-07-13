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
    /// Class of remote signature field
    /// </summary>
    [DataContract]
    public partial class RemoteSignTaskWorkElementRequestDTO :  IEquatable<RemoteSignTaskWorkElementRequestDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteSignTaskWorkElementRequestDTO" /> class.
        /// </summary>
        /// <param name="taskWorkId">TaskWork id.</param>
        /// <param name="pdfEmbeddedMode">Enabled Pdf Embedded Signature.</param>
        /// <param name="signPdfProperties">Settings of pdf signature.</param>
        public RemoteSignTaskWorkElementRequestDTO(int? taskWorkId = default(int?), bool? pdfEmbeddedMode = default(bool?), SignPdfPropertiesDTO signPdfProperties = default(SignPdfPropertiesDTO))
        {
            this.TaskWorkId = taskWorkId;
            this.PdfEmbeddedMode = pdfEmbeddedMode;
            this.SignPdfProperties = signPdfProperties;
        }
        
        /// <summary>
        /// TaskWork id
        /// </summary>
        /// <value>TaskWork id</value>
        [DataMember(Name="taskWorkId", EmitDefaultValue=false)]
        public int? TaskWorkId { get; set; }

        /// <summary>
        /// Enabled Pdf Embedded Signature
        /// </summary>
        /// <value>Enabled Pdf Embedded Signature</value>
        [DataMember(Name="pdfEmbeddedMode", EmitDefaultValue=false)]
        public bool? PdfEmbeddedMode { get; set; }

        /// <summary>
        /// Settings of pdf signature
        /// </summary>
        /// <value>Settings of pdf signature</value>
        [DataMember(Name="signPdfProperties", EmitDefaultValue=false)]
        public SignPdfPropertiesDTO SignPdfProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoteSignTaskWorkElementRequestDTO {\n");
            sb.Append("  TaskWorkId: ").Append(TaskWorkId).Append("\n");
            sb.Append("  PdfEmbeddedMode: ").Append(PdfEmbeddedMode).Append("\n");
            sb.Append("  SignPdfProperties: ").Append(SignPdfProperties).Append("\n");
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
            return this.Equals(input as RemoteSignTaskWorkElementRequestDTO);
        }

        /// <summary>
        /// Returns true if RemoteSignTaskWorkElementRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoteSignTaskWorkElementRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoteSignTaskWorkElementRequestDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskWorkId == input.TaskWorkId ||
                    (this.TaskWorkId != null &&
                    this.TaskWorkId.Equals(input.TaskWorkId))
                ) && 
                (
                    this.PdfEmbeddedMode == input.PdfEmbeddedMode ||
                    (this.PdfEmbeddedMode != null &&
                    this.PdfEmbeddedMode.Equals(input.PdfEmbeddedMode))
                ) && 
                (
                    this.SignPdfProperties == input.SignPdfProperties ||
                    (this.SignPdfProperties != null &&
                    this.SignPdfProperties.Equals(input.SignPdfProperties))
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
                if (this.TaskWorkId != null)
                    hashCode = hashCode * 59 + this.TaskWorkId.GetHashCode();
                if (this.PdfEmbeddedMode != null)
                    hashCode = hashCode * 59 + this.PdfEmbeddedMode.GetHashCode();
                if (this.SignPdfProperties != null)
                    hashCode = hashCode * 59 + this.SignPdfProperties.GetHashCode();
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
