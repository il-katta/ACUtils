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
    /// Class for documents log access level
    /// </summary>
    [DataContract]
    public partial class LogLevelDTO :  IEquatable<LogLevelDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogLevelDTO" /> class.
        /// </summary>
        /// <param name="admin">Admin.</param>
        /// <param name="profiler">Profiler.</param>
        /// <param name="user">User.</param>
        public LogLevelDTO(bool? admin = default(bool?), bool? profiler = default(bool?), bool? user = default(bool?))
        {
            this.Admin = admin;
            this.Profiler = profiler;
            this.User = user;
        }
        
        /// <summary>
        /// Admin
        /// </summary>
        /// <value>Admin</value>
        [DataMember(Name="admin", EmitDefaultValue=false)]
        public bool? Admin { get; set; }

        /// <summary>
        /// Profiler
        /// </summary>
        /// <value>Profiler</value>
        [DataMember(Name="profiler", EmitDefaultValue=false)]
        public bool? Profiler { get; set; }

        /// <summary>
        /// User
        /// </summary>
        /// <value>User</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public bool? User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogLevelDTO {\n");
            sb.Append("  Admin: ").Append(Admin).Append("\n");
            sb.Append("  Profiler: ").Append(Profiler).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(input as LogLevelDTO);
        }

        /// <summary>
        /// Returns true if LogLevelDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of LogLevelDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogLevelDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Admin == input.Admin ||
                    (this.Admin != null &&
                    this.Admin.Equals(input.Admin))
                ) && 
                (
                    this.Profiler == input.Profiler ||
                    (this.Profiler != null &&
                    this.Profiler.Equals(input.Profiler))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                if (this.Admin != null)
                    hashCode = hashCode * 59 + this.Admin.GetHashCode();
                if (this.Profiler != null)
                    hashCode = hashCode * 59 + this.Profiler.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
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