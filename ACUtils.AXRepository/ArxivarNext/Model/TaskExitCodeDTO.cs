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
    /// Dto for task exit code definition
    /// </summary>
    [DataContract]
    public partial class TaskExitCodeDTO :  IEquatable<TaskExitCodeDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskExitCodeDTO" /> class.
        /// </summary>
        /// <param name="id">Id of the exit code.</param>
        /// <param name="value">The value of the exit code.</param>
        /// <param name="icon">Icon idex of the exit code.</param>
        /// <param name="translatedDescription">Translated description in the user language.</param>
        /// <param name="taskIds">Ids of taskwork eligible for this exitcode.</param>
        /// <param name="isDefault">Is default exit code.</param>
        public TaskExitCodeDTO(int? id = default(int?), string value = default(string), int? icon = default(int?), string translatedDescription = default(string), List<int?> taskIds = default(List<int?>), bool? isDefault = default(bool?))
        {
            this.Id = id;
            this.Value = value;
            this.Icon = icon;
            this.TranslatedDescription = translatedDescription;
            this.TaskIds = taskIds;
            this.IsDefault = isDefault;
        }
        
        /// <summary>
        /// Id of the exit code
        /// </summary>
        /// <value>Id of the exit code</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The value of the exit code
        /// </summary>
        /// <value>The value of the exit code</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Icon idex of the exit code
        /// </summary>
        /// <value>Icon idex of the exit code</value>
        [DataMember(Name="icon", EmitDefaultValue=false)]
        public int? Icon { get; set; }

        /// <summary>
        /// Translated description in the user language
        /// </summary>
        /// <value>Translated description in the user language</value>
        [DataMember(Name="translatedDescription", EmitDefaultValue=false)]
        public string TranslatedDescription { get; set; }

        /// <summary>
        /// Ids of taskwork eligible for this exitcode
        /// </summary>
        /// <value>Ids of taskwork eligible for this exitcode</value>
        [DataMember(Name="taskIds", EmitDefaultValue=false)]
        public List<int?> TaskIds { get; set; }

        /// <summary>
        /// Is default exit code
        /// </summary>
        /// <value>Is default exit code</value>
        [DataMember(Name="isDefault", EmitDefaultValue=false)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskExitCodeDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  TranslatedDescription: ").Append(TranslatedDescription).Append("\n");
            sb.Append("  TaskIds: ").Append(TaskIds).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
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
            return this.Equals(input as TaskExitCodeDTO);
        }

        /// <summary>
        /// Returns true if TaskExitCodeDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskExitCodeDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskExitCodeDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
                ) && 
                (
                    this.TranslatedDescription == input.TranslatedDescription ||
                    (this.TranslatedDescription != null &&
                    this.TranslatedDescription.Equals(input.TranslatedDescription))
                ) && 
                (
                    this.TaskIds == input.TaskIds ||
                    this.TaskIds != null &&
                    this.TaskIds.SequenceEqual(input.TaskIds)
                ) && 
                (
                    this.IsDefault == input.IsDefault ||
                    (this.IsDefault != null &&
                    this.IsDefault.Equals(input.IsDefault))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Icon != null)
                    hashCode = hashCode * 59 + this.Icon.GetHashCode();
                if (this.TranslatedDescription != null)
                    hashCode = hashCode * 59 + this.TranslatedDescription.GetHashCode();
                if (this.TaskIds != null)
                    hashCode = hashCode * 59 + this.TaskIds.GetHashCode();
                if (this.IsDefault != null)
                    hashCode = hashCode * 59 + this.IsDefault.GetHashCode();
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
