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
    /// Class of information user who can use the folder for ARXDrive
    /// </summary>
    [DataContract]
        public partial class ArxDriveFolderModeUserInfo :  IEquatable<ArxDriveFolderModeUserInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArxDriveFolderModeUserInfo" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="userId">User Identifier.</param>
        /// <param name="userCompleteName">User Name.</param>
        /// <param name="category">Possible values:  0: U  1: S  2: M  3: F  4: G  5: I  6: D .</param>
        public ArxDriveFolderModeUserInfo(int? id = default(int?), int? userId = default(int?), string userCompleteName = default(string), int? category = default(int?))
        {
            this.Id = id;
            this.UserId = userId;
            this.UserCompleteName = userCompleteName;
            this.Category = category;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// User Identifier
        /// </summary>
        /// <value>User Identifier</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// User Name
        /// </summary>
        /// <value>User Name</value>
        [DataMember(Name="userCompleteName", EmitDefaultValue=false)]
        public string UserCompleteName { get; set; }

        /// <summary>
        /// Possible values:  0: U  1: S  2: M  3: F  4: G  5: I  6: D 
        /// </summary>
        /// <value>Possible values:  0: U  1: S  2: M  3: F  4: G  5: I  6: D </value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public int? Category { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArxDriveFolderModeUserInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserCompleteName: ").Append(UserCompleteName).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
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
            return this.Equals(input as ArxDriveFolderModeUserInfo);
        }

        /// <summary>
        /// Returns true if ArxDriveFolderModeUserInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ArxDriveFolderModeUserInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArxDriveFolderModeUserInfo input)
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
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.UserCompleteName == input.UserCompleteName ||
                    (this.UserCompleteName != null &&
                    this.UserCompleteName.Equals(input.UserCompleteName))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserCompleteName != null)
                    hashCode = hashCode * 59 + this.UserCompleteName.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
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
