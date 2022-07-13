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
    /// Sign Flow configuration
    /// </summary>
    [DataContract]
    public partial class ArxESignConfigurationDto :  IEquatable<ArxESignConfigurationDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArxESignConfigurationDto" /> class.
        /// </summary>
        /// <param name="apiBaseUrlCustom">Base url custom. Overrides ApiBaseUrlLicense.</param>
        /// <param name="isSetApiTokenCustom">Access token custom. Overrides ApiBaseUrlLicense -&amp;gt; is set.</param>
        /// <param name="apiTokenCustom">Access token custom. Overrides ApiBaseUrlLicense.</param>
        /// <param name="isSetApiBaseUrlLicense">Base url from license permission -&amp;gt; is set.</param>
        /// <param name="isSetApiTokenLicense">Access token from license permission -&amp;gt; is set.</param>
        /// <param name="creationDate">Creation date.</param>
        /// <param name="lastUpdate">Last update.</param>
        public ArxESignConfigurationDto(string apiBaseUrlCustom = default(string), bool? isSetApiTokenCustom = default(bool?), string apiTokenCustom = default(string), bool? isSetApiBaseUrlLicense = default(bool?), bool? isSetApiTokenLicense = default(bool?), DateTime? creationDate = default(DateTime?), DateTime? lastUpdate = default(DateTime?))
        {
            this.ApiBaseUrlCustom = apiBaseUrlCustom;
            this.IsSetApiTokenCustom = isSetApiTokenCustom;
            this.ApiTokenCustom = apiTokenCustom;
            this.IsSetApiBaseUrlLicense = isSetApiBaseUrlLicense;
            this.IsSetApiTokenLicense = isSetApiTokenLicense;
            this.CreationDate = creationDate;
            this.LastUpdate = lastUpdate;
        }
        
        /// <summary>
        /// Base url custom. Overrides ApiBaseUrlLicense
        /// </summary>
        /// <value>Base url custom. Overrides ApiBaseUrlLicense</value>
        [DataMember(Name="apiBaseUrlCustom", EmitDefaultValue=false)]
        public string ApiBaseUrlCustom { get; set; }

        /// <summary>
        /// Access token custom. Overrides ApiBaseUrlLicense -&amp;gt; is set
        /// </summary>
        /// <value>Access token custom. Overrides ApiBaseUrlLicense -&amp;gt; is set</value>
        [DataMember(Name="isSetApiTokenCustom", EmitDefaultValue=false)]
        public bool? IsSetApiTokenCustom { get; set; }

        /// <summary>
        /// Access token custom. Overrides ApiBaseUrlLicense
        /// </summary>
        /// <value>Access token custom. Overrides ApiBaseUrlLicense</value>
        [DataMember(Name="apiTokenCustom", EmitDefaultValue=false)]
        public string ApiTokenCustom { get; set; }

        /// <summary>
        /// Base url from license permission -&amp;gt; is set
        /// </summary>
        /// <value>Base url from license permission -&amp;gt; is set</value>
        [DataMember(Name="isSetApiBaseUrlLicense", EmitDefaultValue=false)]
        public bool? IsSetApiBaseUrlLicense { get; set; }

        /// <summary>
        /// Access token from license permission -&amp;gt; is set
        /// </summary>
        /// <value>Access token from license permission -&amp;gt; is set</value>
        [DataMember(Name="isSetApiTokenLicense", EmitDefaultValue=false)]
        public bool? IsSetApiTokenLicense { get; set; }

        /// <summary>
        /// Creation date
        /// </summary>
        /// <value>Creation date</value>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Last update
        /// </summary>
        /// <value>Last update</value>
        [DataMember(Name="lastUpdate", EmitDefaultValue=false)]
        public DateTime? LastUpdate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArxESignConfigurationDto {\n");
            sb.Append("  ApiBaseUrlCustom: ").Append(ApiBaseUrlCustom).Append("\n");
            sb.Append("  IsSetApiTokenCustom: ").Append(IsSetApiTokenCustom).Append("\n");
            sb.Append("  ApiTokenCustom: ").Append(ApiTokenCustom).Append("\n");
            sb.Append("  IsSetApiBaseUrlLicense: ").Append(IsSetApiBaseUrlLicense).Append("\n");
            sb.Append("  IsSetApiTokenLicense: ").Append(IsSetApiTokenLicense).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
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
            return this.Equals(input as ArxESignConfigurationDto);
        }

        /// <summary>
        /// Returns true if ArxESignConfigurationDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ArxESignConfigurationDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArxESignConfigurationDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiBaseUrlCustom == input.ApiBaseUrlCustom ||
                    (this.ApiBaseUrlCustom != null &&
                    this.ApiBaseUrlCustom.Equals(input.ApiBaseUrlCustom))
                ) && 
                (
                    this.IsSetApiTokenCustom == input.IsSetApiTokenCustom ||
                    (this.IsSetApiTokenCustom != null &&
                    this.IsSetApiTokenCustom.Equals(input.IsSetApiTokenCustom))
                ) && 
                (
                    this.ApiTokenCustom == input.ApiTokenCustom ||
                    (this.ApiTokenCustom != null &&
                    this.ApiTokenCustom.Equals(input.ApiTokenCustom))
                ) && 
                (
                    this.IsSetApiBaseUrlLicense == input.IsSetApiBaseUrlLicense ||
                    (this.IsSetApiBaseUrlLicense != null &&
                    this.IsSetApiBaseUrlLicense.Equals(input.IsSetApiBaseUrlLicense))
                ) && 
                (
                    this.IsSetApiTokenLicense == input.IsSetApiTokenLicense ||
                    (this.IsSetApiTokenLicense != null &&
                    this.IsSetApiTokenLicense.Equals(input.IsSetApiTokenLicense))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.LastUpdate == input.LastUpdate ||
                    (this.LastUpdate != null &&
                    this.LastUpdate.Equals(input.LastUpdate))
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
                if (this.ApiBaseUrlCustom != null)
                    hashCode = hashCode * 59 + this.ApiBaseUrlCustom.GetHashCode();
                if (this.IsSetApiTokenCustom != null)
                    hashCode = hashCode * 59 + this.IsSetApiTokenCustom.GetHashCode();
                if (this.ApiTokenCustom != null)
                    hashCode = hashCode * 59 + this.ApiTokenCustom.GetHashCode();
                if (this.IsSetApiBaseUrlLicense != null)
                    hashCode = hashCode * 59 + this.IsSetApiBaseUrlLicense.GetHashCode();
                if (this.IsSetApiTokenLicense != null)
                    hashCode = hashCode * 59 + this.IsSetApiTokenLicense.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.LastUpdate != null)
                    hashCode = hashCode * 59 + this.LastUpdate.GetHashCode();
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