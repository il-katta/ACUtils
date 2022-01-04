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
    /// Class of Multivalue additional field
    /// </summary>
    [DataContract]
        public partial class AdditionalFieldMultivalueDTO : FieldBaseDTO,  IEquatable<AdditionalFieldMultivalueDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalFieldMultivalueDTO" /> class.
        /// </summary>
        /// <param name="displayValue">Values to display.</param>
        /// <param name="value">Value.</param>
        /// <param name="limitToList">Possible values ​​limited to the list.</param>
        /// <param name="additionalFieldType">Possible values:  0: Textbox  1: Databox  2: Numeric  3: Combobox  4: TableBox  5: Checkbox  6: MultiValue  7: ClasseBox  8: Group  9: RubricaBox  10: TextArea .</param>
        /// <param name="groupId">Group Identifier.</param>
        /// <param name="binderFieldId">Binder Field Identifier.</param>
        /// <param name="taskWorkVariableId">Variable Identifier in taskword context.</param>
        /// <param name="validationType">Possible values:  0: None  1: Regex  2: Formula .</param>
        /// <param name="validationString">Validation string (regex or formula).</param>
        public AdditionalFieldMultivalueDTO(List<string> displayValue = default(List<string>), List<string> value = default(List<string>), bool? limitToList = default(bool?), int? additionalFieldType = default(int?), int? groupId = default(int?), int? binderFieldId = default(int?), int? taskWorkVariableId = default(int?), int? validationType = default(int?), string validationString = default(string), string name = default(string), string externalId = default(string), string description = default(string), int? order = default(int?), string dataSource = default(string), bool? required = default(bool?), string formula = default(string), string className = default(string), bool? locked = default(bool?), string comboGruppiId = default(string), List<DependencyFieldItem> dependencyFields = default(List<DependencyFieldItem>), List<AssocitationFieldItem> associations = default(List<AssocitationFieldItem>), bool? isAdditional = default(bool?), bool? visible = default(bool?), string predefinedProfileFormula = default(string), string visibilityCondition = default(string), int? addressBookDefaultFilter = default(int?), List<int?> enabledAddressBook = default(List<int?>), int? columns = default(int?)) : base(name, externalId, description, order, dataSource, required, formula, className, locked, comboGruppiId, dependencyFields, associations, isAdditional, visible, predefinedProfileFormula, visibilityCondition, addressBookDefaultFilter, enabledAddressBook, columns)
        {
            this.DisplayValue = displayValue;
            this.Value = value;
            this.LimitToList = limitToList;
            this.AdditionalFieldType = additionalFieldType;
            this.GroupId = groupId;
            this.BinderFieldId = binderFieldId;
            this.TaskWorkVariableId = taskWorkVariableId;
            this.ValidationType = validationType;
            this.ValidationString = validationString;
        }
        
        /// <summary>
        /// Values to display
        /// </summary>
        /// <value>Values to display</value>
        [DataMember(Name="displayValue", EmitDefaultValue=false)]
        public List<string> DisplayValue { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        /// <value>Value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public List<string> Value { get; set; }

        /// <summary>
        /// Possible values ​​limited to the list
        /// </summary>
        /// <value>Possible values ​​limited to the list</value>
        [DataMember(Name="limitToList", EmitDefaultValue=false)]
        public bool? LimitToList { get; set; }

        /// <summary>
        /// Possible values:  0: Textbox  1: Databox  2: Numeric  3: Combobox  4: TableBox  5: Checkbox  6: MultiValue  7: ClasseBox  8: Group  9: RubricaBox  10: TextArea 
        /// </summary>
        /// <value>Possible values:  0: Textbox  1: Databox  2: Numeric  3: Combobox  4: TableBox  5: Checkbox  6: MultiValue  7: ClasseBox  8: Group  9: RubricaBox  10: TextArea </value>
        [DataMember(Name="additionalFieldType", EmitDefaultValue=false)]
        public int? AdditionalFieldType { get; set; }

        /// <summary>
        /// Group Identifier
        /// </summary>
        /// <value>Group Identifier</value>
        [DataMember(Name="groupId", EmitDefaultValue=false)]
        public int? GroupId { get; set; }

        /// <summary>
        /// Binder Field Identifier
        /// </summary>
        /// <value>Binder Field Identifier</value>
        [DataMember(Name="binderFieldId", EmitDefaultValue=false)]
        public int? BinderFieldId { get; set; }

        /// <summary>
        /// Variable Identifier in taskword context
        /// </summary>
        /// <value>Variable Identifier in taskword context</value>
        [DataMember(Name="taskWorkVariableId", EmitDefaultValue=false)]
        public int? TaskWorkVariableId { get; set; }

        /// <summary>
        /// Possible values:  0: None  1: Regex  2: Formula 
        /// </summary>
        /// <value>Possible values:  0: None  1: Regex  2: Formula </value>
        [DataMember(Name="validationType", EmitDefaultValue=false)]
        public int? ValidationType { get; set; }

        /// <summary>
        /// Validation string (regex or formula)
        /// </summary>
        /// <value>Validation string (regex or formula)</value>
        [DataMember(Name="validationString", EmitDefaultValue=false)]
        public string ValidationString { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalFieldMultivalueDTO {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  DisplayValue: ").Append(DisplayValue).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  LimitToList: ").Append(LimitToList).Append("\n");
            sb.Append("  AdditionalFieldType: ").Append(AdditionalFieldType).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  BinderFieldId: ").Append(BinderFieldId).Append("\n");
            sb.Append("  TaskWorkVariableId: ").Append(TaskWorkVariableId).Append("\n");
            sb.Append("  ValidationType: ").Append(ValidationType).Append("\n");
            sb.Append("  ValidationString: ").Append(ValidationString).Append("\n");
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
            return this.Equals(input as AdditionalFieldMultivalueDTO);
        }

        /// <summary>
        /// Returns true if AdditionalFieldMultivalueDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalFieldMultivalueDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalFieldMultivalueDTO input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.DisplayValue == input.DisplayValue ||
                    this.DisplayValue != null &&
                    input.DisplayValue != null &&
                    this.DisplayValue.SequenceEqual(input.DisplayValue)
                ) && base.Equals(input) && 
                (
                    this.Value == input.Value ||
                    this.Value != null &&
                    input.Value != null &&
                    this.Value.SequenceEqual(input.Value)
                ) && base.Equals(input) && 
                (
                    this.LimitToList == input.LimitToList ||
                    (this.LimitToList != null &&
                    this.LimitToList.Equals(input.LimitToList))
                ) && base.Equals(input) && 
                (
                    this.AdditionalFieldType == input.AdditionalFieldType ||
                    (this.AdditionalFieldType != null &&
                    this.AdditionalFieldType.Equals(input.AdditionalFieldType))
                ) && base.Equals(input) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && base.Equals(input) && 
                (
                    this.BinderFieldId == input.BinderFieldId ||
                    (this.BinderFieldId != null &&
                    this.BinderFieldId.Equals(input.BinderFieldId))
                ) && base.Equals(input) && 
                (
                    this.TaskWorkVariableId == input.TaskWorkVariableId ||
                    (this.TaskWorkVariableId != null &&
                    this.TaskWorkVariableId.Equals(input.TaskWorkVariableId))
                ) && base.Equals(input) && 
                (
                    this.ValidationType == input.ValidationType ||
                    (this.ValidationType != null &&
                    this.ValidationType.Equals(input.ValidationType))
                ) && base.Equals(input) && 
                (
                    this.ValidationString == input.ValidationString ||
                    (this.ValidationString != null &&
                    this.ValidationString.Equals(input.ValidationString))
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
                if (this.LimitToList != null)
                    hashCode = hashCode * 59 + this.LimitToList.GetHashCode();
                if (this.AdditionalFieldType != null)
                    hashCode = hashCode * 59 + this.AdditionalFieldType.GetHashCode();
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.BinderFieldId != null)
                    hashCode = hashCode * 59 + this.BinderFieldId.GetHashCode();
                if (this.TaskWorkVariableId != null)
                    hashCode = hashCode * 59 + this.TaskWorkVariableId.GetHashCode();
                if (this.ValidationType != null)
                    hashCode = hashCode * 59 + this.ValidationType.GetHashCode();
                if (this.ValidationString != null)
                    hashCode = hashCode * 59 + this.ValidationString.GetHashCode();
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
