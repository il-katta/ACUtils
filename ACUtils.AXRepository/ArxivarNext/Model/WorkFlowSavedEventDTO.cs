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
    /// WorkFlowSavedEventDTO
    /// </summary>
    [DataContract]
    public partial class WorkFlowSavedEventDTO :  IEquatable<WorkFlowSavedEventDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkFlowSavedEventDTO" /> class.
        /// </summary>
        /// <param name="eventId">eventId.</param>
        /// <param name="isActive">isActive.</param>
        /// <param name="eventPriority">eventPriority.</param>
        /// <param name="workflowVersion">Possible values:  0: V1  1: V2 .</param>
        /// <param name="workflowName">workflowName.</param>
        /// <param name="workflowId">workflowId.</param>
        /// <param name="diagramRevision">diagramRevision.</param>
        /// <param name="diagramId">diagramId.</param>
        /// <param name="configuration">configuration.</param>
        public WorkFlowSavedEventDTO(string eventId = default(string), bool? isActive = default(bool?), int? eventPriority = default(int?), int? workflowVersion = default(int?), string workflowName = default(string), int? workflowId = default(int?), int? diagramRevision = default(int?), string diagramId = default(string), WorkflowEventAbstractConfiguration configuration = default(WorkflowEventAbstractConfiguration))
        {
            this.EventId = eventId;
            this.IsActive = isActive;
            this.EventPriority = eventPriority;
            this.WorkflowVersion = workflowVersion;
            this.WorkflowName = workflowName;
            this.WorkflowId = workflowId;
            this.DiagramRevision = diagramRevision;
            this.DiagramId = diagramId;
            this.Configuration = configuration;
        }
        
        /// <summary>
        /// Gets or Sets EventId
        /// </summary>
        [DataMember(Name="eventId", EmitDefaultValue=false)]
        public string EventId { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or Sets EventPriority
        /// </summary>
        [DataMember(Name="eventPriority", EmitDefaultValue=false)]
        public int? EventPriority { get; set; }

        /// <summary>
        /// Possible values:  0: V1  1: V2 
        /// </summary>
        /// <value>Possible values:  0: V1  1: V2 </value>
        [DataMember(Name="workflowVersion", EmitDefaultValue=false)]
        public int? WorkflowVersion { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowName
        /// </summary>
        [DataMember(Name="workflowName", EmitDefaultValue=false)]
        public string WorkflowName { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowId
        /// </summary>
        [DataMember(Name="workflowId", EmitDefaultValue=false)]
        public int? WorkflowId { get; set; }

        /// <summary>
        /// Gets or Sets DiagramRevision
        /// </summary>
        [DataMember(Name="diagramRevision", EmitDefaultValue=false)]
        public int? DiagramRevision { get; set; }

        /// <summary>
        /// Gets or Sets DiagramId
        /// </summary>
        [DataMember(Name="diagramId", EmitDefaultValue=false)]
        public string DiagramId { get; set; }

        /// <summary>
        /// Gets or Sets Configuration
        /// </summary>
        [DataMember(Name="configuration", EmitDefaultValue=false)]
        public WorkflowEventAbstractConfiguration Configuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkFlowSavedEventDTO {\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  EventPriority: ").Append(EventPriority).Append("\n");
            sb.Append("  WorkflowVersion: ").Append(WorkflowVersion).Append("\n");
            sb.Append("  WorkflowName: ").Append(WorkflowName).Append("\n");
            sb.Append("  WorkflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("  DiagramRevision: ").Append(DiagramRevision).Append("\n");
            sb.Append("  DiagramId: ").Append(DiagramId).Append("\n");
            sb.Append("  Configuration: ").Append(Configuration).Append("\n");
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
            return this.Equals(input as WorkFlowSavedEventDTO);
        }

        /// <summary>
        /// Returns true if WorkFlowSavedEventDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkFlowSavedEventDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkFlowSavedEventDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EventId == input.EventId ||
                    (this.EventId != null &&
                    this.EventId.Equals(input.EventId))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.EventPriority == input.EventPriority ||
                    (this.EventPriority != null &&
                    this.EventPriority.Equals(input.EventPriority))
                ) && 
                (
                    this.WorkflowVersion == input.WorkflowVersion ||
                    (this.WorkflowVersion != null &&
                    this.WorkflowVersion.Equals(input.WorkflowVersion))
                ) && 
                (
                    this.WorkflowName == input.WorkflowName ||
                    (this.WorkflowName != null &&
                    this.WorkflowName.Equals(input.WorkflowName))
                ) && 
                (
                    this.WorkflowId == input.WorkflowId ||
                    (this.WorkflowId != null &&
                    this.WorkflowId.Equals(input.WorkflowId))
                ) && 
                (
                    this.DiagramRevision == input.DiagramRevision ||
                    (this.DiagramRevision != null &&
                    this.DiagramRevision.Equals(input.DiagramRevision))
                ) && 
                (
                    this.DiagramId == input.DiagramId ||
                    (this.DiagramId != null &&
                    this.DiagramId.Equals(input.DiagramId))
                ) && 
                (
                    this.Configuration == input.Configuration ||
                    (this.Configuration != null &&
                    this.Configuration.Equals(input.Configuration))
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
                if (this.EventId != null)
                    hashCode = hashCode * 59 + this.EventId.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.EventPriority != null)
                    hashCode = hashCode * 59 + this.EventPriority.GetHashCode();
                if (this.WorkflowVersion != null)
                    hashCode = hashCode * 59 + this.WorkflowVersion.GetHashCode();
                if (this.WorkflowName != null)
                    hashCode = hashCode * 59 + this.WorkflowName.GetHashCode();
                if (this.WorkflowId != null)
                    hashCode = hashCode * 59 + this.WorkflowId.GetHashCode();
                if (this.DiagramRevision != null)
                    hashCode = hashCode * 59 + this.DiagramRevision.GetHashCode();
                if (this.DiagramId != null)
                    hashCode = hashCode * 59 + this.DiagramId.GetHashCode();
                if (this.Configuration != null)
                    hashCode = hashCode * 59 + this.Configuration.GetHashCode();
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
