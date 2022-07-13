/* 
 * WebAPI - Area Management
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: management
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
using SwaggerDateConverter = ACUtils.AXRepository.ArxivarNextManagement.Client.SwaggerDateConverter;

namespace ACUtils.AXRepository.ArxivarNextManagement.Model
{
    /// <summary>
    /// Class of ArxCe time control
    /// </summary>
    [DataContract]
    public partial class ArxCeTimeControlDTO :  IEquatable<ArxCeTimeControlDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArxCeTimeControlDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="startDate">Start date.</param>
        /// <param name="endDate">End date.</param>
        /// <param name="controlField">Control field.</param>
        public ArxCeTimeControlDTO(string id = default(string), string startDate = default(string), string endDate = default(string), string controlField = default(string))
        {
            this.Id = id;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.ControlField = controlField;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Start date
        /// </summary>
        /// <value>Start date</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// End date
        /// </summary>
        /// <value>End date</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// Control field
        /// </summary>
        /// <value>Control field</value>
        [DataMember(Name="controlField", EmitDefaultValue=false)]
        public string ControlField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArxCeTimeControlDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ControlField: ").Append(ControlField).Append("\n");
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
            return this.Equals(input as ArxCeTimeControlDTO);
        }

        /// <summary>
        /// Returns true if ArxCeTimeControlDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ArxCeTimeControlDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArxCeTimeControlDTO input)
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
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.ControlField == input.ControlField ||
                    (this.ControlField != null &&
                    this.ControlField.Equals(input.ControlField))
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
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.ControlField != null)
                    hashCode = hashCode * 59 + this.ControlField.GetHashCode();
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
