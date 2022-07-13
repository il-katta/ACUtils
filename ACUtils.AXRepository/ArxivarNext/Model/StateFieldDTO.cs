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
    /// State of document
    /// </summary>
    [DataContract]
    public partial class StateFieldDTO : FieldBaseDTO,  IEquatable<StateFieldDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StateFieldDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StateFieldDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StateFieldDTO" /> class.
        /// </summary>
        /// <param name="displayValue">State description.</param>
        /// <param name="value">State value.</param>
        public StateFieldDTO(string displayValue = default(string), string value = default(string), string name = default(string), string externalId = default(string), string description = default(string), int? order = default(int?), string dataSource = default(string), bool? required = default(bool?), string formula = default(string), string className = "StateFieldDTO", bool? locked = default(bool?), string comboGruppiId = default(string), List<DependencyFieldItem> dependencyFields = default(List<DependencyFieldItem>), List<AssocitationFieldItem> associations = default(List<AssocitationFieldItem>), bool? isAdditional = default(bool?), bool? visible = default(bool?), string predefinedProfileFormula = default(string), string visibilityCondition = default(string), string mandatoryCondition = default(string), int? addressBookDefaultFilter = default(int?), List<int?> enabledAddressBook = default(List<int?>), int? columns = default(int?)) : base(name, externalId, description, order, dataSource, required, formula, className, locked, comboGruppiId, dependencyFields, associations, isAdditional, visible, predefinedProfileFormula, visibilityCondition, mandatoryCondition, addressBookDefaultFilter, enabledAddressBook, columns)
        {
            this.DisplayValue = displayValue;
            this.Value = value;
        }
        
        /// <summary>
        /// State description
        /// </summary>
        /// <value>State description</value>
        [DataMember(Name="displayValue", EmitDefaultValue=false)]
        public string DisplayValue { get; set; }

        /// <summary>
        /// State value
        /// </summary>
        /// <value>State value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StateFieldDTO {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  DisplayValue: ").Append(DisplayValue).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as StateFieldDTO);
        }

        /// <summary>
        /// Returns true if StateFieldDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of StateFieldDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StateFieldDTO input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.DisplayValue == input.DisplayValue ||
                    (this.DisplayValue != null &&
                    this.DisplayValue.Equals(input.DisplayValue))
                ) && base.Equals(input) && 
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
                int hashCode = base.GetHashCode();
                if (this.DisplayValue != null)
                    hashCode = hashCode * 59 + this.DisplayValue.GetHashCode();
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
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
