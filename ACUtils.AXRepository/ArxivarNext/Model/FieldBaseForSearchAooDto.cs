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
    /// FieldBaseForSearchAooDto
    /// </summary>
    [DataContract]
        public partial class FieldBaseForSearchAooDto : FieldBaseForSearchDTO,  IEquatable<FieldBaseForSearchAooDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldBaseForSearchAooDto" /> class.
        /// </summary>
        /// <param name="_operator">Possible values:  0: Non_Impostato  1: Uguale  2: Diverso  3: Inizia  4: Contiene  5: Termina  6: Nullo  7: Non_Nullo  8: Vuoto  9: Non_Vuoto  10: Nullo_o_Vuoto  11: Non_Nullo_e_Non_Vuoto  12: Like .</param>
        /// <param name="valore1">valore1.</param>
        /// <param name="valore2">valore2.</param>
        public FieldBaseForSearchAooDto(int? _operator = default(int?), AooSearchFilterDto valore1 = default(AooSearchFilterDto), AooSearchFilterDto valore2 = default(AooSearchFilterDto), int? groupId = default(int?), int? fieldType = default(int?), int? additionalFieldType = default(int?), int? defaultOperator = default(int?), string tableName = default(string), int? binderFieldId = default(int?), string multiple = default(string), string name = default(string), string externalId = default(string), string description = default(string), int? order = default(int?), string dataSource = default(string), bool? required = default(bool?), string formula = default(string), string className = default(string), bool? locked = default(bool?), string comboGruppiId = default(string), List<DependencyFieldItem> dependencyFields = default(List<DependencyFieldItem>), Dictionary<string, string> associations = default(Dictionary<string, string>), bool? isAdditional = default(bool?), bool? visible = default(bool?), string predefinedProfileFormula = default(string)) : base(groupId, fieldType, additionalFieldType, defaultOperator, tableName, binderFieldId, multiple, name, externalId, description, order, dataSource, required, formula, className, locked, comboGruppiId, dependencyFields, associations, isAdditional, visible, predefinedProfileFormula)
        {
            this._Operator = _operator;
            this.Valore1 = valore1;
            this.Valore2 = valore2;
        }
        
        /// <summary>
        /// Possible values:  0: Non_Impostato  1: Uguale  2: Diverso  3: Inizia  4: Contiene  5: Termina  6: Nullo  7: Non_Nullo  8: Vuoto  9: Non_Vuoto  10: Nullo_o_Vuoto  11: Non_Nullo_e_Non_Vuoto  12: Like 
        /// </summary>
        /// <value>Possible values:  0: Non_Impostato  1: Uguale  2: Diverso  3: Inizia  4: Contiene  5: Termina  6: Nullo  7: Non_Nullo  8: Vuoto  9: Non_Vuoto  10: Nullo_o_Vuoto  11: Non_Nullo_e_Non_Vuoto  12: Like </value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public int? _Operator { get; set; }

        /// <summary>
        /// Gets or Sets Valore1
        /// </summary>
        [DataMember(Name="valore1", EmitDefaultValue=false)]
        public AooSearchFilterDto Valore1 { get; set; }

        /// <summary>
        /// Gets or Sets Valore2
        /// </summary>
        [DataMember(Name="valore2", EmitDefaultValue=false)]
        public AooSearchFilterDto Valore2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldBaseForSearchAooDto {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
            sb.Append("  Valore1: ").Append(Valore1).Append("\n");
            sb.Append("  Valore2: ").Append(Valore2).Append("\n");
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
            return this.Equals(input as FieldBaseForSearchAooDto);
        }

        /// <summary>
        /// Returns true if FieldBaseForSearchAooDto instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldBaseForSearchAooDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldBaseForSearchAooDto input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this._Operator == input._Operator ||
                    (this._Operator != null &&
                    this._Operator.Equals(input._Operator))
                ) && base.Equals(input) && 
                (
                    this.Valore1 == input.Valore1 ||
                    (this.Valore1 != null &&
                    this.Valore1.Equals(input.Valore1))
                ) && base.Equals(input) && 
                (
                    this.Valore2 == input.Valore2 ||
                    (this.Valore2 != null &&
                    this.Valore2.Equals(input.Valore2))
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
                if (this._Operator != null)
                    hashCode = hashCode * 59 + this._Operator.GetHashCode();
                if (this.Valore1 != null)
                    hashCode = hashCode * 59 + this.Valore1.GetHashCode();
                if (this.Valore2 != null)
                    hashCode = hashCode * 59 + this.Valore2.GetHashCode();
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
