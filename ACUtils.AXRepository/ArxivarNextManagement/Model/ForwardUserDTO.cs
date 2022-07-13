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
    /// Class of users with forward origin option
    /// </summary>
    [DataContract]
    public partial class ForwardUserDTO :  IEquatable<ForwardUserDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForwardUserDTO" /> class.
        /// </summary>
        /// <param name="user">User.</param>
        /// <param name="origin">Possible values:  0: E  1: U  2: I  3: EU  4: EI  5: UI  6: EUI .</param>
        public ForwardUserDTO(UserSimpleDTO user = default(UserSimpleDTO), int? origin = default(int?))
        {
            this.User = user;
            this.Origin = origin;
        }
        
        /// <summary>
        /// User
        /// </summary>
        /// <value>User</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserSimpleDTO User { get; set; }

        /// <summary>
        /// Possible values:  0: E  1: U  2: I  3: EU  4: EI  5: UI  6: EUI 
        /// </summary>
        /// <value>Possible values:  0: E  1: U  2: I  3: EU  4: EI  5: UI  6: EUI </value>
        [DataMember(Name="origin", EmitDefaultValue=false)]
        public int? Origin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForwardUserDTO {\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
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
            return this.Equals(input as ForwardUserDTO);
        }

        /// <summary>
        /// Returns true if ForwardUserDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ForwardUserDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForwardUserDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
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
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Origin != null)
                    hashCode = hashCode * 59 + this.Origin.GetHashCode();
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