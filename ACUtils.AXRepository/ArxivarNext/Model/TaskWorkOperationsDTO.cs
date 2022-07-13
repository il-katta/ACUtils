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
    /// TaskWorkOperationsDTO
    /// </summary>
    [DataContract]
    public partial class TaskWorkOperationsDTO :  IEquatable<TaskWorkOperationsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskWorkOperationsDTO" /> class.
        /// </summary>
        /// <param name="taskWorkCommandsOperations">TaskWork commands.</param>
        /// <param name="taskWorkVariablesOperation">Process variables to set.</param>
        /// <param name="taskWorkDocumentOperations">Document operations.</param>
        /// <param name="taskWorkProfessionalRoleOperations">Professional roles.</param>
        /// <param name="taskWorkOperatingInstructions">Operating Instruction.</param>
        /// <param name="taskWorkDynamicJobOperation">Dynamic jobs.</param>
        /// <param name="taskWorkSignOperations">Sign operations.</param>
        /// <param name="canReAssignTask">Reassign task opertiona.</param>
        public TaskWorkOperationsDTO(List<TaskWorkCommandDTO> taskWorkCommandsOperations = default(List<TaskWorkCommandDTO>), TaskWorkVariableOperationDTO taskWorkVariablesOperation = default(TaskWorkVariableOperationDTO), List<TaskWorkDocumentOperationDTO> taskWorkDocumentOperations = default(List<TaskWorkDocumentOperationDTO>), ProfessionalRoleOperationsDTO taskWorkProfessionalRoleOperations = default(ProfessionalRoleOperationsDTO), List<string> taskWorkOperatingInstructions = default(List<string>), TaskWorkDynamicJobOperationsDTO taskWorkDynamicJobOperation = default(TaskWorkDynamicJobOperationsDTO), List<TaskWorkSignOperationDTO> taskWorkSignOperations = default(List<TaskWorkSignOperationDTO>), bool? canReAssignTask = default(bool?))
        {
            this.TaskWorkCommandsOperations = taskWorkCommandsOperations;
            this.TaskWorkVariablesOperation = taskWorkVariablesOperation;
            this.TaskWorkDocumentOperations = taskWorkDocumentOperations;
            this.TaskWorkProfessionalRoleOperations = taskWorkProfessionalRoleOperations;
            this.TaskWorkOperatingInstructions = taskWorkOperatingInstructions;
            this.TaskWorkDynamicJobOperation = taskWorkDynamicJobOperation;
            this.TaskWorkSignOperations = taskWorkSignOperations;
            this.CanReAssignTask = canReAssignTask;
        }
        
        /// <summary>
        /// TaskWork commands
        /// </summary>
        /// <value>TaskWork commands</value>
        [DataMember(Name="taskWorkCommandsOperations", EmitDefaultValue=false)]
        public List<TaskWorkCommandDTO> TaskWorkCommandsOperations { get; set; }

        /// <summary>
        /// Process variables to set
        /// </summary>
        /// <value>Process variables to set</value>
        [DataMember(Name="taskWorkVariablesOperation", EmitDefaultValue=false)]
        public TaskWorkVariableOperationDTO TaskWorkVariablesOperation { get; set; }

        /// <summary>
        /// Document operations
        /// </summary>
        /// <value>Document operations</value>
        [DataMember(Name="taskWorkDocumentOperations", EmitDefaultValue=false)]
        public List<TaskWorkDocumentOperationDTO> TaskWorkDocumentOperations { get; set; }

        /// <summary>
        /// Professional roles
        /// </summary>
        /// <value>Professional roles</value>
        [DataMember(Name="taskWorkProfessionalRoleOperations", EmitDefaultValue=false)]
        public ProfessionalRoleOperationsDTO TaskWorkProfessionalRoleOperations { get; set; }

        /// <summary>
        /// Operating Instruction
        /// </summary>
        /// <value>Operating Instruction</value>
        [DataMember(Name="taskWorkOperatingInstructions", EmitDefaultValue=false)]
        public List<string> TaskWorkOperatingInstructions { get; set; }

        /// <summary>
        /// Dynamic jobs
        /// </summary>
        /// <value>Dynamic jobs</value>
        [DataMember(Name="taskWorkDynamicJobOperation", EmitDefaultValue=false)]
        public TaskWorkDynamicJobOperationsDTO TaskWorkDynamicJobOperation { get; set; }

        /// <summary>
        /// Sign operations
        /// </summary>
        /// <value>Sign operations</value>
        [DataMember(Name="taskWorkSignOperations", EmitDefaultValue=false)]
        public List<TaskWorkSignOperationDTO> TaskWorkSignOperations { get; set; }

        /// <summary>
        /// Reassign task opertiona
        /// </summary>
        /// <value>Reassign task opertiona</value>
        [DataMember(Name="canReAssignTask", EmitDefaultValue=false)]
        public bool? CanReAssignTask { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskWorkOperationsDTO {\n");
            sb.Append("  TaskWorkCommandsOperations: ").Append(TaskWorkCommandsOperations).Append("\n");
            sb.Append("  TaskWorkVariablesOperation: ").Append(TaskWorkVariablesOperation).Append("\n");
            sb.Append("  TaskWorkDocumentOperations: ").Append(TaskWorkDocumentOperations).Append("\n");
            sb.Append("  TaskWorkProfessionalRoleOperations: ").Append(TaskWorkProfessionalRoleOperations).Append("\n");
            sb.Append("  TaskWorkOperatingInstructions: ").Append(TaskWorkOperatingInstructions).Append("\n");
            sb.Append("  TaskWorkDynamicJobOperation: ").Append(TaskWorkDynamicJobOperation).Append("\n");
            sb.Append("  TaskWorkSignOperations: ").Append(TaskWorkSignOperations).Append("\n");
            sb.Append("  CanReAssignTask: ").Append(CanReAssignTask).Append("\n");
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
            return this.Equals(input as TaskWorkOperationsDTO);
        }

        /// <summary>
        /// Returns true if TaskWorkOperationsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskWorkOperationsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskWorkOperationsDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskWorkCommandsOperations == input.TaskWorkCommandsOperations ||
                    this.TaskWorkCommandsOperations != null &&
                    this.TaskWorkCommandsOperations.SequenceEqual(input.TaskWorkCommandsOperations)
                ) && 
                (
                    this.TaskWorkVariablesOperation == input.TaskWorkVariablesOperation ||
                    (this.TaskWorkVariablesOperation != null &&
                    this.TaskWorkVariablesOperation.Equals(input.TaskWorkVariablesOperation))
                ) && 
                (
                    this.TaskWorkDocumentOperations == input.TaskWorkDocumentOperations ||
                    this.TaskWorkDocumentOperations != null &&
                    this.TaskWorkDocumentOperations.SequenceEqual(input.TaskWorkDocumentOperations)
                ) && 
                (
                    this.TaskWorkProfessionalRoleOperations == input.TaskWorkProfessionalRoleOperations ||
                    (this.TaskWorkProfessionalRoleOperations != null &&
                    this.TaskWorkProfessionalRoleOperations.Equals(input.TaskWorkProfessionalRoleOperations))
                ) && 
                (
                    this.TaskWorkOperatingInstructions == input.TaskWorkOperatingInstructions ||
                    this.TaskWorkOperatingInstructions != null &&
                    this.TaskWorkOperatingInstructions.SequenceEqual(input.TaskWorkOperatingInstructions)
                ) && 
                (
                    this.TaskWorkDynamicJobOperation == input.TaskWorkDynamicJobOperation ||
                    (this.TaskWorkDynamicJobOperation != null &&
                    this.TaskWorkDynamicJobOperation.Equals(input.TaskWorkDynamicJobOperation))
                ) && 
                (
                    this.TaskWorkSignOperations == input.TaskWorkSignOperations ||
                    this.TaskWorkSignOperations != null &&
                    this.TaskWorkSignOperations.SequenceEqual(input.TaskWorkSignOperations)
                ) && 
                (
                    this.CanReAssignTask == input.CanReAssignTask ||
                    (this.CanReAssignTask != null &&
                    this.CanReAssignTask.Equals(input.CanReAssignTask))
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
                if (this.TaskWorkCommandsOperations != null)
                    hashCode = hashCode * 59 + this.TaskWorkCommandsOperations.GetHashCode();
                if (this.TaskWorkVariablesOperation != null)
                    hashCode = hashCode * 59 + this.TaskWorkVariablesOperation.GetHashCode();
                if (this.TaskWorkDocumentOperations != null)
                    hashCode = hashCode * 59 + this.TaskWorkDocumentOperations.GetHashCode();
                if (this.TaskWorkProfessionalRoleOperations != null)
                    hashCode = hashCode * 59 + this.TaskWorkProfessionalRoleOperations.GetHashCode();
                if (this.TaskWorkOperatingInstructions != null)
                    hashCode = hashCode * 59 + this.TaskWorkOperatingInstructions.GetHashCode();
                if (this.TaskWorkDynamicJobOperation != null)
                    hashCode = hashCode * 59 + this.TaskWorkDynamicJobOperation.GetHashCode();
                if (this.TaskWorkSignOperations != null)
                    hashCode = hashCode * 59 + this.TaskWorkSignOperations.GetHashCode();
                if (this.CanReAssignTask != null)
                    hashCode = hashCode * 59 + this.CanReAssignTask.GetHashCode();
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
