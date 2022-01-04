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
    /// Class of association item
    /// </summary>
    [DataContract]
        public partial class AssociationDTO :  IEquatable<AssociationDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociationDTO" /> class.
        /// </summary>
        /// <param name="id">Unique Identifier.</param>
        /// <param name="docNumber">Identifier of the principal profile.</param>
        /// <param name="user">Identifier of author.</param>
        /// <param name="date">Creation Date.</param>
        /// <param name="description">Name.</param>
        /// <param name="userNameComplete">Full Name of the author.</param>
        public AssociationDTO(int? id = default(int?), int? docNumber = default(int?), int? user = default(int?), DateTime? date = default(DateTime?), string description = default(string), string userNameComplete = default(string))
        {
            this.Id = id;
            this.DocNumber = docNumber;
            this.User = user;
            this.Date = date;
            this.Description = description;
            this.UserNameComplete = userNameComplete;
        }
        
        /// <summary>
        /// Unique Identifier
        /// </summary>
        /// <value>Unique Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Identifier of the principal profile
        /// </summary>
        /// <value>Identifier of the principal profile</value>
        [DataMember(Name="docNumber", EmitDefaultValue=false)]
        public int? DocNumber { get; set; }

        /// <summary>
        /// Identifier of author
        /// </summary>
        /// <value>Identifier of author</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public int? User { get; set; }

        /// <summary>
        /// Creation Date
        /// </summary>
        /// <value>Creation Date</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Full Name of the author
        /// </summary>
        /// <value>Full Name of the author</value>
        [DataMember(Name="userNameComplete", EmitDefaultValue=false)]
        public string UserNameComplete { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociationDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DocNumber: ").Append(DocNumber).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  UserNameComplete: ").Append(UserNameComplete).Append("\n");
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
            return this.Equals(input as AssociationDTO);
        }

        /// <summary>
        /// Returns true if AssociationDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AssociationDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssociationDTO input)
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
                    this.DocNumber == input.DocNumber ||
                    (this.DocNumber != null &&
                    this.DocNumber.Equals(input.DocNumber))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.UserNameComplete == input.UserNameComplete ||
                    (this.UserNameComplete != null &&
                    this.UserNameComplete.Equals(input.UserNameComplete))
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
                if (this.DocNumber != null)
                    hashCode = hashCode * 59 + this.DocNumber.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.UserNameComplete != null)
                    hashCode = hashCode * 59 + this.UserNameComplete.GetHashCode();
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
