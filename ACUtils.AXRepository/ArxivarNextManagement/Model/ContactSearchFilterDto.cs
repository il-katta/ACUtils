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
    /// Class of filter for contact search
    /// </summary>
    [DataContract]
    public partial class ContactSearchFilterDto :  IEquatable<ContactSearchFilterDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactSearchFilterDto" /> class.
        /// </summary>
        /// <param name="modality">Possible values:  0: Text  1: Id  2: Advanced .</param>
        /// <param name="values">Values.</param>
        /// <param name="profileData">Filter of Profile data.</param>
        public ContactSearchFilterDto(int? modality = default(int?), List<string> values = default(List<string>), JoinDmDatiProfilo profileData = default(JoinDmDatiProfilo))
        {
            this.Modality = modality;
            this.Values = values;
            this.ProfileData = profileData;
        }
        
        /// <summary>
        /// Possible values:  0: Text  1: Id  2: Advanced 
        /// </summary>
        /// <value>Possible values:  0: Text  1: Id  2: Advanced </value>
        [DataMember(Name="modality", EmitDefaultValue=false)]
        public int? Modality { get; set; }

        /// <summary>
        /// Values
        /// </summary>
        /// <value>Values</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }

        /// <summary>
        /// Filter of Profile data
        /// </summary>
        /// <value>Filter of Profile data</value>
        [DataMember(Name="profileData", EmitDefaultValue=false)]
        public JoinDmDatiProfilo ProfileData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactSearchFilterDto {\n");
            sb.Append("  Modality: ").Append(Modality).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  ProfileData: ").Append(ProfileData).Append("\n");
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
            return this.Equals(input as ContactSearchFilterDto);
        }

        /// <summary>
        /// Returns true if ContactSearchFilterDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactSearchFilterDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactSearchFilterDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Modality == input.Modality ||
                    (this.Modality != null &&
                    this.Modality.Equals(input.Modality))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(input.Values)
                ) && 
                (
                    this.ProfileData == input.ProfileData ||
                    (this.ProfileData != null &&
                    this.ProfileData.Equals(input.ProfileData))
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
                if (this.Modality != null)
                    hashCode = hashCode * 59 + this.Modality.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                if (this.ProfileData != null)
                    hashCode = hashCode * 59 + this.ProfileData.GetHashCode();
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
