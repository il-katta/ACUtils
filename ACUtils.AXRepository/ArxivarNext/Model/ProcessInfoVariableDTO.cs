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
    /// Class of process variables information
    /// </summary>
    [DataContract]
    public partial class ProcessInfoVariableDTO :  IEquatable<ProcessInfoVariableDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessInfoVariableDTO" /> class.
        /// </summary>
        /// <param name="processVariables">List of process variables.</param>
        /// <param name="processVariablesFields">Fields.</param>
        public ProcessInfoVariableDTO(List<ProcessVariableDTO> processVariables = default(List<ProcessVariableDTO>), ProcessVariablesFieldsDTO processVariablesFields = default(ProcessVariablesFieldsDTO))
        {
            this.ProcessVariables = processVariables;
            this.ProcessVariablesFields = processVariablesFields;
        }
        
        /// <summary>
        /// List of process variables
        /// </summary>
        /// <value>List of process variables</value>
        [DataMember(Name="processVariables", EmitDefaultValue=false)]
        public List<ProcessVariableDTO> ProcessVariables { get; set; }

        /// <summary>
        /// Fields
        /// </summary>
        /// <value>Fields</value>
        [DataMember(Name="processVariablesFields", EmitDefaultValue=false)]
        public ProcessVariablesFieldsDTO ProcessVariablesFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessInfoVariableDTO {\n");
            sb.Append("  ProcessVariables: ").Append(ProcessVariables).Append("\n");
            sb.Append("  ProcessVariablesFields: ").Append(ProcessVariablesFields).Append("\n");
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
            return this.Equals(input as ProcessInfoVariableDTO);
        }

        /// <summary>
        /// Returns true if ProcessInfoVariableDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessInfoVariableDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessInfoVariableDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProcessVariables == input.ProcessVariables ||
                    this.ProcessVariables != null &&
                    this.ProcessVariables.SequenceEqual(input.ProcessVariables)
                ) && 
                (
                    this.ProcessVariablesFields == input.ProcessVariablesFields ||
                    (this.ProcessVariablesFields != null &&
                    this.ProcessVariablesFields.Equals(input.ProcessVariablesFields))
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
                if (this.ProcessVariables != null)
                    hashCode = hashCode * 59 + this.ProcessVariables.GetHashCode();
                if (this.ProcessVariablesFields != null)
                    hashCode = hashCode * 59 + this.ProcessVariablesFields.GetHashCode();
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
