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
    /// Int key value
    /// </summary>
    [DataContract]
    public partial class DoubleKeyValueDTO :  IEquatable<DoubleKeyValueDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleKeyValueDTO" /> class.
        /// </summary>
        /// <param name="className">ClassName.</param>
        /// <param name="key">Key.</param>
        /// <param name="value">Value.</param>
        public DoubleKeyValueDTO(string className = default(string), string key = default(string), double? value = default(double?))
        {
            this.ClassName = className;
            this.Key = key;
            this.Value = value;
        }
        
        /// <summary>
        /// ClassName
        /// </summary>
        /// <value>ClassName</value>
        [DataMember(Name="className", EmitDefaultValue=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// Key
        /// </summary>
        /// <value>Key</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        /// <value>Value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double? Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DoubleKeyValueDTO {\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as DoubleKeyValueDTO);
        }

        /// <summary>
        /// Returns true if DoubleKeyValueDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of DoubleKeyValueDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DoubleKeyValueDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClassName == input.ClassName ||
                    (this.ClassName != null &&
                    this.ClassName.Equals(input.ClassName))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.ClassName != null)
                    hashCode = hashCode * 59 + this.ClassName.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
