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
    /// Class of professional role
    /// </summary>
    [DataContract]
        public partial class ProfessionalRoleInfoDTO :  IEquatable<ProfessionalRoleInfoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfessionalRoleInfoDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="userId">User Identifier.</param>
        /// <param name="userCompleteName">User Description.</param>
        /// <param name="professionalRoleId">Professional Role Identifier.</param>
        /// <param name="professionalRoleCompleteName">Professional Role Description.</param>
        public ProfessionalRoleInfoDTO(int? id = default(int?), int? userId = default(int?), string userCompleteName = default(string), int? professionalRoleId = default(int?), string professionalRoleCompleteName = default(string))
        {
            this.Id = id;
            this.UserId = userId;
            this.UserCompleteName = userCompleteName;
            this.ProfessionalRoleId = professionalRoleId;
            this.ProfessionalRoleCompleteName = professionalRoleCompleteName;
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
        /// User Description
        /// </summary>
        /// <value>User Description</value>
        [DataMember(Name="userCompleteName", EmitDefaultValue=false)]
        public string UserCompleteName { get; set; }

        /// <summary>
        /// Professional Role Identifier
        /// </summary>
        /// <value>Professional Role Identifier</value>
        [DataMember(Name="professionalRoleId", EmitDefaultValue=false)]
        public int? ProfessionalRoleId { get; set; }

        /// <summary>
        /// Professional Role Description
        /// </summary>
        /// <value>Professional Role Description</value>
        [DataMember(Name="professionalRoleCompleteName", EmitDefaultValue=false)]
        public string ProfessionalRoleCompleteName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProfessionalRoleInfoDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserCompleteName: ").Append(UserCompleteName).Append("\n");
            sb.Append("  ProfessionalRoleId: ").Append(ProfessionalRoleId).Append("\n");
            sb.Append("  ProfessionalRoleCompleteName: ").Append(ProfessionalRoleCompleteName).Append("\n");
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
            return this.Equals(input as ProfessionalRoleInfoDTO);
        }

        /// <summary>
        /// Returns true if ProfessionalRoleInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ProfessionalRoleInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfessionalRoleInfoDTO input)
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
                    this.ProfessionalRoleId == input.ProfessionalRoleId ||
                    (this.ProfessionalRoleId != null &&
                    this.ProfessionalRoleId.Equals(input.ProfessionalRoleId))
                ) && 
                (
                    this.ProfessionalRoleCompleteName == input.ProfessionalRoleCompleteName ||
                    (this.ProfessionalRoleCompleteName != null &&
                    this.ProfessionalRoleCompleteName.Equals(input.ProfessionalRoleCompleteName))
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
                if (this.ProfessionalRoleId != null)
                    hashCode = hashCode * 59 + this.ProfessionalRoleId.GetHashCode();
                if (this.ProfessionalRoleCompleteName != null)
                    hashCode = hashCode * 59 + this.ProfessionalRoleCompleteName.GetHashCode();
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
