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
    /// Cladd of request for update binder combo custom fields values
    /// </summary>
    [DataContract]
    public partial class BinderComboValuesUpdateRequest :  IEquatable<BinderComboValuesUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BinderComboValuesUpdateRequest" /> class.
        /// </summary>
        /// <param name="values">Array of values to update.</param>
        /// <param name="binderComboCustomFieldId">Identifier of the binder custom combo field.</param>
        public BinderComboValuesUpdateRequest(List<string> values = default(List<string>), int? binderComboCustomFieldId = default(int?))
        {
            this.Values = values;
            this.BinderComboCustomFieldId = binderComboCustomFieldId;
        }
        
        /// <summary>
        /// Array of values to update
        /// </summary>
        /// <value>Array of values to update</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }

        /// <summary>
        /// Identifier of the binder custom combo field
        /// </summary>
        /// <value>Identifier of the binder custom combo field</value>
        [DataMember(Name="binderComboCustomFieldId", EmitDefaultValue=false)]
        public int? BinderComboCustomFieldId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BinderComboValuesUpdateRequest {\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  BinderComboCustomFieldId: ").Append(BinderComboCustomFieldId).Append("\n");
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
            return this.Equals(input as BinderComboValuesUpdateRequest);
        }

        /// <summary>
        /// Returns true if BinderComboValuesUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BinderComboValuesUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BinderComboValuesUpdateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(input.Values)
                ) && 
                (
                    this.BinderComboCustomFieldId == input.BinderComboCustomFieldId ||
                    (this.BinderComboCustomFieldId != null &&
                    this.BinderComboCustomFieldId.Equals(input.BinderComboCustomFieldId))
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
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                if (this.BinderComboCustomFieldId != null)
                    hashCode = hashCode * 59 + this.BinderComboCustomFieldId.GetHashCode();
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
