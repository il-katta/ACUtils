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
    /// Class of user option for search
    /// </summary>
    [DataContract]
        public partial class UserSearchOptionDTO :  IEquatable<UserSearchOptionDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSearchOptionDTO" /> class.
        /// </summary>
        /// <param name="maxSearchItems">Maximum Number of Items for search.</param>
        /// <param name="maxViewItems">Maximum Number of Items for view.</param>
        /// <param name="extendAInCc">Extend the search to the knowledge copy.</param>
        /// <param name="authorityData">Visibility of Authority Data.</param>
        public UserSearchOptionDTO(int? maxSearchItems = default(int?), int? maxViewItems = default(int?), bool? extendAInCc = default(bool?), bool? authorityData = default(bool?))
        {
            this.MaxSearchItems = maxSearchItems;
            this.MaxViewItems = maxViewItems;
            this.ExtendAInCc = extendAInCc;
            this.AuthorityData = authorityData;
        }
        
        /// <summary>
        /// Maximum Number of Items for search
        /// </summary>
        /// <value>Maximum Number of Items for search</value>
        [DataMember(Name="maxSearchItems", EmitDefaultValue=false)]
        public int? MaxSearchItems { get; set; }

        /// <summary>
        /// Maximum Number of Items for view
        /// </summary>
        /// <value>Maximum Number of Items for view</value>
        [DataMember(Name="maxViewItems", EmitDefaultValue=false)]
        public int? MaxViewItems { get; set; }

        /// <summary>
        /// Extend the search to the knowledge copy
        /// </summary>
        /// <value>Extend the search to the knowledge copy</value>
        [DataMember(Name="extendAInCc", EmitDefaultValue=false)]
        public bool? ExtendAInCc { get; set; }

        /// <summary>
        /// Visibility of Authority Data
        /// </summary>
        /// <value>Visibility of Authority Data</value>
        [DataMember(Name="authorityData", EmitDefaultValue=false)]
        public bool? AuthorityData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserSearchOptionDTO {\n");
            sb.Append("  MaxSearchItems: ").Append(MaxSearchItems).Append("\n");
            sb.Append("  MaxViewItems: ").Append(MaxViewItems).Append("\n");
            sb.Append("  ExtendAInCc: ").Append(ExtendAInCc).Append("\n");
            sb.Append("  AuthorityData: ").Append(AuthorityData).Append("\n");
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
            return this.Equals(input as UserSearchOptionDTO);
        }

        /// <summary>
        /// Returns true if UserSearchOptionDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of UserSearchOptionDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSearchOptionDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxSearchItems == input.MaxSearchItems ||
                    (this.MaxSearchItems != null &&
                    this.MaxSearchItems.Equals(input.MaxSearchItems))
                ) && 
                (
                    this.MaxViewItems == input.MaxViewItems ||
                    (this.MaxViewItems != null &&
                    this.MaxViewItems.Equals(input.MaxViewItems))
                ) && 
                (
                    this.ExtendAInCc == input.ExtendAInCc ||
                    (this.ExtendAInCc != null &&
                    this.ExtendAInCc.Equals(input.ExtendAInCc))
                ) && 
                (
                    this.AuthorityData == input.AuthorityData ||
                    (this.AuthorityData != null &&
                    this.AuthorityData.Equals(input.AuthorityData))
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
                if (this.MaxSearchItems != null)
                    hashCode = hashCode * 59 + this.MaxSearchItems.GetHashCode();
                if (this.MaxViewItems != null)
                    hashCode = hashCode * 59 + this.MaxViewItems.GetHashCode();
                if (this.ExtendAInCc != null)
                    hashCode = hashCode * 59 + this.ExtendAInCc.GetHashCode();
                if (this.AuthorityData != null)
                    hashCode = hashCode * 59 + this.AuthorityData.GetHashCode();
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
