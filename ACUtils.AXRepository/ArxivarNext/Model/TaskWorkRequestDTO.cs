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
    /// TaskWorkRequestDTO
    /// </summary>
    [DataContract]
    public partial class TaskWorkRequestDTO :  IEquatable<TaskWorkRequestDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskWorkRequestDTO" /> class.
        /// </summary>
        /// <param name="select">select.</param>
        /// <param name="workFlowIds">workFlowIds.</param>
        /// <param name="taskWorkIds">taskWorkIds.</param>
        public TaskWorkRequestDTO(SelectDTO select = default(SelectDTO), List<int?> workFlowIds = default(List<int?>), List<int?> taskWorkIds = default(List<int?>))
        {
            this.Select = select;
            this.WorkFlowIds = workFlowIds;
            this.TaskWorkIds = taskWorkIds;
        }
        
        /// <summary>
        /// Gets or Sets Select
        /// </summary>
        [DataMember(Name="select", EmitDefaultValue=false)]
        public SelectDTO Select { get; set; }

        /// <summary>
        /// Gets or Sets WorkFlowIds
        /// </summary>
        [DataMember(Name="workFlowIds", EmitDefaultValue=false)]
        public List<int?> WorkFlowIds { get; set; }

        /// <summary>
        /// Gets or Sets TaskWorkIds
        /// </summary>
        [DataMember(Name="taskWorkIds", EmitDefaultValue=false)]
        public List<int?> TaskWorkIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskWorkRequestDTO {\n");
            sb.Append("  Select: ").Append(Select).Append("\n");
            sb.Append("  WorkFlowIds: ").Append(WorkFlowIds).Append("\n");
            sb.Append("  TaskWorkIds: ").Append(TaskWorkIds).Append("\n");
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
            return this.Equals(input as TaskWorkRequestDTO);
        }

        /// <summary>
        /// Returns true if TaskWorkRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskWorkRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskWorkRequestDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Select == input.Select ||
                    (this.Select != null &&
                    this.Select.Equals(input.Select))
                ) && 
                (
                    this.WorkFlowIds == input.WorkFlowIds ||
                    this.WorkFlowIds != null &&
                    this.WorkFlowIds.SequenceEqual(input.WorkFlowIds)
                ) && 
                (
                    this.TaskWorkIds == input.TaskWorkIds ||
                    this.TaskWorkIds != null &&
                    this.TaskWorkIds.SequenceEqual(input.TaskWorkIds)
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
                if (this.Select != null)
                    hashCode = hashCode * 59 + this.Select.GetHashCode();
                if (this.WorkFlowIds != null)
                    hashCode = hashCode * 59 + this.WorkFlowIds.GetHashCode();
                if (this.TaskWorkIds != null)
                    hashCode = hashCode * 59 + this.TaskWorkIds.GetHashCode();
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