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
    /// Process Variable information
    /// </summary>
    [DataContract]
    public partial class ProcessVariableDTO :  IEquatable<ProcessVariableDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessVariableDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="name">Name.</param>
        /// <param name="description">Description.</param>
        /// <param name="processId">Process Identifier.</param>
        /// <param name="label">Label.</param>
        /// <param name="value">Value.</param>
        /// <param name="parentId">Parent Matrix Variable Identifier.</param>
        /// <param name="labelTranslatedId">Translated Label Identifier.</param>
        /// <param name="descriptionTranslatedId">Trasnlated description Identifier.</param>
        /// <param name="textFormat">Format for visualization.</param>
        /// <param name="maxRowNumber">Maximun number of row of text.</param>
        /// <param name="isLimitToList">Is limit to list.</param>
        /// <param name="processVariableFormat">Possible values:  1: Text  2: Number  3: DateTime  4: Boolean  5: Combo  6: Matrix  7: TextArea  8: TableBox .</param>
        /// <param name="validationString">The validation string of the variable.</param>
        /// <param name="validationType">Possible values:  0: None  1: Regex  2: Formula .</param>
        public ProcessVariableDTO(int? id = default(int?), string name = default(string), string description = default(string), int? processId = default(int?), string label = default(string), string value = default(string), int? parentId = default(int?), int? labelTranslatedId = default(int?), int? descriptionTranslatedId = default(int?), int? textFormat = default(int?), int? maxRowNumber = default(int?), bool? isLimitToList = default(bool?), int? processVariableFormat = default(int?), string validationString = default(string), int? validationType = default(int?))
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.ProcessId = processId;
            this.Label = label;
            this.Value = value;
            this.ParentId = parentId;
            this.LabelTranslatedId = labelTranslatedId;
            this.DescriptionTranslatedId = descriptionTranslatedId;
            this.TextFormat = textFormat;
            this.MaxRowNumber = maxRowNumber;
            this.IsLimitToList = isLimitToList;
            this.ProcessVariableFormat = processVariableFormat;
            this.ValidationString = validationString;
            this.ValidationType = validationType;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Process Identifier
        /// </summary>
        /// <value>Process Identifier</value>
        [DataMember(Name="processId", EmitDefaultValue=false)]
        public int? ProcessId { get; set; }

        /// <summary>
        /// Label
        /// </summary>
        /// <value>Label</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        /// <value>Value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Parent Matrix Variable Identifier
        /// </summary>
        /// <value>Parent Matrix Variable Identifier</value>
        [DataMember(Name="parentId", EmitDefaultValue=false)]
        public int? ParentId { get; set; }

        /// <summary>
        /// Translated Label Identifier
        /// </summary>
        /// <value>Translated Label Identifier</value>
        [DataMember(Name="labelTranslatedId", EmitDefaultValue=false)]
        public int? LabelTranslatedId { get; set; }

        /// <summary>
        /// Trasnlated description Identifier
        /// </summary>
        /// <value>Trasnlated description Identifier</value>
        [DataMember(Name="descriptionTranslatedId", EmitDefaultValue=false)]
        public int? DescriptionTranslatedId { get; set; }

        /// <summary>
        /// Format for visualization
        /// </summary>
        /// <value>Format for visualization</value>
        [DataMember(Name="textFormat", EmitDefaultValue=false)]
        public int? TextFormat { get; set; }

        /// <summary>
        /// Maximun number of row of text
        /// </summary>
        /// <value>Maximun number of row of text</value>
        [DataMember(Name="maxRowNumber", EmitDefaultValue=false)]
        public int? MaxRowNumber { get; set; }

        /// <summary>
        /// Is limit to list
        /// </summary>
        /// <value>Is limit to list</value>
        [DataMember(Name="isLimitToList", EmitDefaultValue=false)]
        public bool? IsLimitToList { get; set; }

        /// <summary>
        /// Possible values:  1: Text  2: Number  3: DateTime  4: Boolean  5: Combo  6: Matrix  7: TextArea  8: TableBox 
        /// </summary>
        /// <value>Possible values:  1: Text  2: Number  3: DateTime  4: Boolean  5: Combo  6: Matrix  7: TextArea  8: TableBox </value>
        [DataMember(Name="processVariableFormat", EmitDefaultValue=false)]
        public int? ProcessVariableFormat { get; set; }

        /// <summary>
        /// The validation string of the variable
        /// </summary>
        /// <value>The validation string of the variable</value>
        [DataMember(Name="validationString", EmitDefaultValue=false)]
        public string ValidationString { get; set; }

        /// <summary>
        /// Possible values:  0: None  1: Regex  2: Formula 
        /// </summary>
        /// <value>Possible values:  0: None  1: Regex  2: Formula </value>
        [DataMember(Name="validationType", EmitDefaultValue=false)]
        public int? ValidationType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessVariableDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ProcessId: ").Append(ProcessId).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  LabelTranslatedId: ").Append(LabelTranslatedId).Append("\n");
            sb.Append("  DescriptionTranslatedId: ").Append(DescriptionTranslatedId).Append("\n");
            sb.Append("  TextFormat: ").Append(TextFormat).Append("\n");
            sb.Append("  MaxRowNumber: ").Append(MaxRowNumber).Append("\n");
            sb.Append("  IsLimitToList: ").Append(IsLimitToList).Append("\n");
            sb.Append("  ProcessVariableFormat: ").Append(ProcessVariableFormat).Append("\n");
            sb.Append("  ValidationString: ").Append(ValidationString).Append("\n");
            sb.Append("  ValidationType: ").Append(ValidationType).Append("\n");
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
            return this.Equals(input as ProcessVariableDTO);
        }

        /// <summary>
        /// Returns true if ProcessVariableDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessVariableDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessVariableDTO input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ProcessId == input.ProcessId ||
                    (this.ProcessId != null &&
                    this.ProcessId.Equals(input.ProcessId))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.LabelTranslatedId == input.LabelTranslatedId ||
                    (this.LabelTranslatedId != null &&
                    this.LabelTranslatedId.Equals(input.LabelTranslatedId))
                ) && 
                (
                    this.DescriptionTranslatedId == input.DescriptionTranslatedId ||
                    (this.DescriptionTranslatedId != null &&
                    this.DescriptionTranslatedId.Equals(input.DescriptionTranslatedId))
                ) && 
                (
                    this.TextFormat == input.TextFormat ||
                    (this.TextFormat != null &&
                    this.TextFormat.Equals(input.TextFormat))
                ) && 
                (
                    this.MaxRowNumber == input.MaxRowNumber ||
                    (this.MaxRowNumber != null &&
                    this.MaxRowNumber.Equals(input.MaxRowNumber))
                ) && 
                (
                    this.IsLimitToList == input.IsLimitToList ||
                    (this.IsLimitToList != null &&
                    this.IsLimitToList.Equals(input.IsLimitToList))
                ) && 
                (
                    this.ProcessVariableFormat == input.ProcessVariableFormat ||
                    (this.ProcessVariableFormat != null &&
                    this.ProcessVariableFormat.Equals(input.ProcessVariableFormat))
                ) && 
                (
                    this.ValidationString == input.ValidationString ||
                    (this.ValidationString != null &&
                    this.ValidationString.Equals(input.ValidationString))
                ) && 
                (
                    this.ValidationType == input.ValidationType ||
                    (this.ValidationType != null &&
                    this.ValidationType.Equals(input.ValidationType))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ProcessId != null)
                    hashCode = hashCode * 59 + this.ProcessId.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.ParentId != null)
                    hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.LabelTranslatedId != null)
                    hashCode = hashCode * 59 + this.LabelTranslatedId.GetHashCode();
                if (this.DescriptionTranslatedId != null)
                    hashCode = hashCode * 59 + this.DescriptionTranslatedId.GetHashCode();
                if (this.TextFormat != null)
                    hashCode = hashCode * 59 + this.TextFormat.GetHashCode();
                if (this.MaxRowNumber != null)
                    hashCode = hashCode * 59 + this.MaxRowNumber.GetHashCode();
                if (this.IsLimitToList != null)
                    hashCode = hashCode * 59 + this.IsLimitToList.GetHashCode();
                if (this.ProcessVariableFormat != null)
                    hashCode = hashCode * 59 + this.ProcessVariableFormat.GetHashCode();
                if (this.ValidationString != null)
                    hashCode = hashCode * 59 + this.ValidationString.GetHashCode();
                if (this.ValidationType != null)
                    hashCode = hashCode * 59 + this.ValidationType.GetHashCode();
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
