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
    /// FieldValuesDTO
    /// </summary>
    [DataContract]
    public partial class FieldValuesDTO :  IEquatable<FieldValuesDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldValuesDTO" /> class.
        /// </summary>
        /// <param name="keyField">KeyField.</param>
        /// <param name="selectField">SelectField.</param>
        /// <param name="associations">Associations.</param>
        /// <param name="fieldName">FieldName.</param>
        /// <param name="dataSource">DataSource.</param>
        public FieldValuesDTO(string keyField = default(string), string selectField = default(string), Dictionary<string, string> associations = default(Dictionary<string, string>), string fieldName = default(string), List<RowSearchResult> dataSource = default(List<RowSearchResult>))
        {
            this.KeyField = keyField;
            this.SelectField = selectField;
            this.Associations = associations;
            this.FieldName = fieldName;
            this.DataSource = dataSource;
        }
        
        /// <summary>
        /// KeyField
        /// </summary>
        /// <value>KeyField</value>
        [DataMember(Name="keyField", EmitDefaultValue=false)]
        public string KeyField { get; set; }

        /// <summary>
        /// SelectField
        /// </summary>
        /// <value>SelectField</value>
        [DataMember(Name="selectField", EmitDefaultValue=false)]
        public string SelectField { get; set; }

        /// <summary>
        /// Associations
        /// </summary>
        /// <value>Associations</value>
        [DataMember(Name="associations", EmitDefaultValue=false)]
        public Dictionary<string, string> Associations { get; set; }

        /// <summary>
        /// FieldName
        /// </summary>
        /// <value>FieldName</value>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// DataSource
        /// </summary>
        /// <value>DataSource</value>
        [DataMember(Name="dataSource", EmitDefaultValue=false)]
        public List<RowSearchResult> DataSource { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldValuesDTO {\n");
            sb.Append("  KeyField: ").Append(KeyField).Append("\n");
            sb.Append("  SelectField: ").Append(SelectField).Append("\n");
            sb.Append("  Associations: ").Append(Associations).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  DataSource: ").Append(DataSource).Append("\n");
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
            return this.Equals(input as FieldValuesDTO);
        }

        /// <summary>
        /// Returns true if FieldValuesDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldValuesDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldValuesDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeyField == input.KeyField ||
                    (this.KeyField != null &&
                    this.KeyField.Equals(input.KeyField))
                ) && 
                (
                    this.SelectField == input.SelectField ||
                    (this.SelectField != null &&
                    this.SelectField.Equals(input.SelectField))
                ) && 
                (
                    this.Associations == input.Associations ||
                    this.Associations != null &&
                    this.Associations.SequenceEqual(input.Associations)
                ) && 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.DataSource == input.DataSource ||
                    this.DataSource != null &&
                    this.DataSource.SequenceEqual(input.DataSource)
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
                if (this.KeyField != null)
                    hashCode = hashCode * 59 + this.KeyField.GetHashCode();
                if (this.SelectField != null)
                    hashCode = hashCode * 59 + this.SelectField.GetHashCode();
                if (this.Associations != null)
                    hashCode = hashCode * 59 + this.Associations.GetHashCode();
                if (this.FieldName != null)
                    hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.DataSource != null)
                    hashCode = hashCode * 59 + this.DataSource.GetHashCode();
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
