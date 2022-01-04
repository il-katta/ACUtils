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
    /// WorkflowSavedEventStatusDTO
    /// </summary>
    [DataContract]
        public partial class WorkflowSavedEventStatusDTO :  IEquatable<WorkflowSavedEventStatusDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowSavedEventStatusDTO" /> class.
        /// </summary>
        /// <param name="edit">edit.</param>
        /// <param name="reason">reason.</param>
        public WorkflowSavedEventStatusDTO(bool? edit = default(bool?), string reason = default(string))
        {
            this.Edit = edit;
            this.Reason = reason;
        }
        
        /// <summary>
        /// Gets or Sets Edit
        /// </summary>
        [DataMember(Name="edit", EmitDefaultValue=false)]
        public bool? Edit { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowSavedEventStatusDTO {\n");
            sb.Append("  Edit: ").Append(Edit).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
            return this.Equals(input as WorkflowSavedEventStatusDTO);
        }

        /// <summary>
        /// Returns true if WorkflowSavedEventStatusDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkflowSavedEventStatusDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkflowSavedEventStatusDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Edit == input.Edit ||
                    (this.Edit != null &&
                    this.Edit.Equals(input.Edit))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
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
                if (this.Edit != null)
                    hashCode = hashCode * 59 + this.Edit.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
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
