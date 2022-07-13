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
    /// Class of field for select in search
    /// </summary>
    [DataContract]
    public partial class FieldBaseForSelectDTO :  IEquatable<FieldBaseForSelectDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldBaseForSelectDTO" /> class.
        /// </summary>
        /// <param name="toCalculate">Calculate.</param>
        /// <param name="index">Order.</param>
        /// <param name="selected">Selected.</param>
        /// <param name="fieldType">Possible values:  0: Standard  1: Group  2: Additional .</param>
        /// <param name="orderBy">Order on the results of the search.</param>
        /// <param name="externalId">External Identifier.</param>
        /// <param name="label">Label.</param>
        /// <param name="name">Name.</param>
        /// <param name="userSelectionEnabled">Enabled the selection.</param>
        /// <param name="userSelectionGroup">Possible values:  0: Icon  1: Standard  2: Additional .</param>
        public FieldBaseForSelectDTO(bool? toCalculate = default(bool?), int? index = default(int?), bool? selected = default(bool?), int? fieldType = default(int?), OrderBy orderBy = default(OrderBy), string externalId = default(string), string label = default(string), string name = default(string), bool? userSelectionEnabled = default(bool?), int? userSelectionGroup = default(int?))
        {
            this.ToCalculate = toCalculate;
            this.Index = index;
            this.Selected = selected;
            this.FieldType = fieldType;
            this.OrderBy = orderBy;
            this.ExternalId = externalId;
            this.Label = label;
            this.Name = name;
            this.UserSelectionEnabled = userSelectionEnabled;
            this.UserSelectionGroup = userSelectionGroup;
        }
        
        /// <summary>
        /// Calculate
        /// </summary>
        /// <value>Calculate</value>
        [DataMember(Name="toCalculate", EmitDefaultValue=false)]
        public bool? ToCalculate { get; set; }

        /// <summary>
        /// Order
        /// </summary>
        /// <value>Order</value>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public int? Index { get; set; }

        /// <summary>
        /// Selected
        /// </summary>
        /// <value>Selected</value>
        [DataMember(Name="selected", EmitDefaultValue=false)]
        public bool? Selected { get; set; }

        /// <summary>
        /// Possible values:  0: Standard  1: Group  2: Additional 
        /// </summary>
        /// <value>Possible values:  0: Standard  1: Group  2: Additional </value>
        [DataMember(Name="fieldType", EmitDefaultValue=false)]
        public int? FieldType { get; set; }

        /// <summary>
        /// Order on the results of the search
        /// </summary>
        /// <value>Order on the results of the search</value>
        [DataMember(Name="orderBy", EmitDefaultValue=false)]
        public OrderBy OrderBy { get; set; }

        /// <summary>
        /// External Identifier
        /// </summary>
        /// <value>External Identifier</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Label
        /// </summary>
        /// <value>Label</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Enabled the selection
        /// </summary>
        /// <value>Enabled the selection</value>
        [DataMember(Name="userSelectionEnabled", EmitDefaultValue=false)]
        public bool? UserSelectionEnabled { get; set; }

        /// <summary>
        /// Possible values:  0: Icon  1: Standard  2: Additional 
        /// </summary>
        /// <value>Possible values:  0: Icon  1: Standard  2: Additional </value>
        [DataMember(Name="userSelectionGroup", EmitDefaultValue=false)]
        public int? UserSelectionGroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldBaseForSelectDTO {\n");
            sb.Append("  ToCalculate: ").Append(ToCalculate).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Selected: ").Append(Selected).Append("\n");
            sb.Append("  FieldType: ").Append(FieldType).Append("\n");
            sb.Append("  OrderBy: ").Append(OrderBy).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UserSelectionEnabled: ").Append(UserSelectionEnabled).Append("\n");
            sb.Append("  UserSelectionGroup: ").Append(UserSelectionGroup).Append("\n");
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
            return this.Equals(input as FieldBaseForSelectDTO);
        }

        /// <summary>
        /// Returns true if FieldBaseForSelectDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldBaseForSelectDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldBaseForSelectDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ToCalculate == input.ToCalculate ||
                    (this.ToCalculate != null &&
                    this.ToCalculate.Equals(input.ToCalculate))
                ) && 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                ) && 
                (
                    this.Selected == input.Selected ||
                    (this.Selected != null &&
                    this.Selected.Equals(input.Selected))
                ) && 
                (
                    this.FieldType == input.FieldType ||
                    (this.FieldType != null &&
                    this.FieldType.Equals(input.FieldType))
                ) && 
                (
                    this.OrderBy == input.OrderBy ||
                    (this.OrderBy != null &&
                    this.OrderBy.Equals(input.OrderBy))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.UserSelectionEnabled == input.UserSelectionEnabled ||
                    (this.UserSelectionEnabled != null &&
                    this.UserSelectionEnabled.Equals(input.UserSelectionEnabled))
                ) && 
                (
                    this.UserSelectionGroup == input.UserSelectionGroup ||
                    (this.UserSelectionGroup != null &&
                    this.UserSelectionGroup.Equals(input.UserSelectionGroup))
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
                if (this.ToCalculate != null)
                    hashCode = hashCode * 59 + this.ToCalculate.GetHashCode();
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.Selected != null)
                    hashCode = hashCode * 59 + this.Selected.GetHashCode();
                if (this.FieldType != null)
                    hashCode = hashCode * 59 + this.FieldType.GetHashCode();
                if (this.OrderBy != null)
                    hashCode = hashCode * 59 + this.OrderBy.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.UserSelectionEnabled != null)
                    hashCode = hashCode * 59 + this.UserSelectionEnabled.GetHashCode();
                if (this.UserSelectionGroup != null)
                    hashCode = hashCode * 59 + this.UserSelectionGroup.GetHashCode();
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
