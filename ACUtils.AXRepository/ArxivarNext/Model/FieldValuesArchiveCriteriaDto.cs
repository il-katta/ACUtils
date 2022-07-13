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
    /// Class of criteria fields for values in profiling
    /// </summary>
    [DataContract]
    public partial class FieldValuesArchiveCriteriaDto :  IEquatable<FieldValuesArchiveCriteriaDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldValuesArchiveCriteriaDto" /> class.
        /// </summary>
        /// <param name="searchFilterDto">Filter for profiling.</param>
        /// <param name="fieldName">Field Name.</param>
        /// <param name="filterValue">Filter Value.</param>
        /// <param name="filterId">Filter Identifier.</param>
        /// <param name="filters">Filter Fields.</param>
        public FieldValuesArchiveCriteriaDto(ProfileDTO searchFilterDto = default(ProfileDTO), string fieldName = default(string), string filterValue = default(string), string filterId = default(string), List<FieldBaseForSearchDTO> filters = default(List<FieldBaseForSearchDTO>))
        {
            this.SearchFilterDto = searchFilterDto;
            this.FieldName = fieldName;
            this.FilterValue = filterValue;
            this.FilterId = filterId;
            this.Filters = filters;
        }
        
        /// <summary>
        /// Filter for profiling
        /// </summary>
        /// <value>Filter for profiling</value>
        [DataMember(Name="searchFilterDto", EmitDefaultValue=false)]
        public ProfileDTO SearchFilterDto { get; set; }

        /// <summary>
        /// Field Name
        /// </summary>
        /// <value>Field Name</value>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// Filter Value
        /// </summary>
        /// <value>Filter Value</value>
        [DataMember(Name="filterValue", EmitDefaultValue=false)]
        public string FilterValue { get; set; }

        /// <summary>
        /// Filter Identifier
        /// </summary>
        /// <value>Filter Identifier</value>
        [DataMember(Name="filterId", EmitDefaultValue=false)]
        public string FilterId { get; set; }

        /// <summary>
        /// Filter Fields
        /// </summary>
        /// <value>Filter Fields</value>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<FieldBaseForSearchDTO> Filters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldValuesArchiveCriteriaDto {\n");
            sb.Append("  SearchFilterDto: ").Append(SearchFilterDto).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  FilterValue: ").Append(FilterValue).Append("\n");
            sb.Append("  FilterId: ").Append(FilterId).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
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
            return this.Equals(input as FieldValuesArchiveCriteriaDto);
        }

        /// <summary>
        /// Returns true if FieldValuesArchiveCriteriaDto instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldValuesArchiveCriteriaDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldValuesArchiveCriteriaDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SearchFilterDto == input.SearchFilterDto ||
                    (this.SearchFilterDto != null &&
                    this.SearchFilterDto.Equals(input.SearchFilterDto))
                ) && 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.FilterValue == input.FilterValue ||
                    (this.FilterValue != null &&
                    this.FilterValue.Equals(input.FilterValue))
                ) && 
                (
                    this.FilterId == input.FilterId ||
                    (this.FilterId != null &&
                    this.FilterId.Equals(input.FilterId))
                ) && 
                (
                    this.Filters == input.Filters ||
                    this.Filters != null &&
                    this.Filters.SequenceEqual(input.Filters)
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
                if (this.SearchFilterDto != null)
                    hashCode = hashCode * 59 + this.SearchFilterDto.GetHashCode();
                if (this.FieldName != null)
                    hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.FilterValue != null)
                    hashCode = hashCode * 59 + this.FilterValue.GetHashCode();
                if (this.FilterId != null)
                    hashCode = hashCode * 59 + this.FilterId.GetHashCode();
                if (this.Filters != null)
                    hashCode = hashCode * 59 + this.Filters.GetHashCode();
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
