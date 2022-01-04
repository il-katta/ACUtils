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
    /// Class of workflow information
    /// </summary>
    [DataContract]
        public partial class WorkflowInfoDTO :  IEquatable<WorkflowInfoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowInfoDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="name">Name.</param>
        /// <param name="description">Description.</param>
        /// <param name="state">Possible values:  1: In_Corso  2: Terminato .</param>
        /// <param name="hasNote">Has Notes.</param>
        /// <param name="hasAttachement">Has Attachments.</param>
        /// <param name="startDate">Start Date.</param>
        /// <param name="endDate">End Date.</param>
        /// <param name="expireDate">Expiration Date.</param>
        /// <param name="userCompleteName">User Desciption.</param>
        public WorkflowInfoDTO(int? id = default(int?), string name = default(string), string description = default(string), int? state = default(int?), bool? hasNote = default(bool?), bool? hasAttachement = default(bool?), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), DateTime? expireDate = default(DateTime?), string userCompleteName = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.State = state;
            this.HasNote = hasNote;
            this.HasAttachement = hasAttachement;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.ExpireDate = expireDate;
            this.UserCompleteName = userCompleteName;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Possible values:  1: In_Corso  2: Terminato 
        /// </summary>
        /// <value>Possible values:  1: In_Corso  2: Terminato </value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public int? State { get; set; }

        /// <summary>
        /// Has Notes
        /// </summary>
        /// <value>Has Notes</value>
        [DataMember(Name="hasNote", EmitDefaultValue=false)]
        public bool? HasNote { get; set; }

        /// <summary>
        /// Has Attachments
        /// </summary>
        /// <value>Has Attachments</value>
        [DataMember(Name="hasAttachement", EmitDefaultValue=false)]
        public bool? HasAttachement { get; set; }

        /// <summary>
        /// Start Date
        /// </summary>
        /// <value>Start Date</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// End Date
        /// </summary>
        /// <value>End Date</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Expiration Date
        /// </summary>
        /// <value>Expiration Date</value>
        [DataMember(Name="expireDate", EmitDefaultValue=false)]
        public DateTime? ExpireDate { get; set; }

        /// <summary>
        /// User Desciption
        /// </summary>
        /// <value>User Desciption</value>
        [DataMember(Name="userCompleteName", EmitDefaultValue=false)]
        public string UserCompleteName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowInfoDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  HasNote: ").Append(HasNote).Append("\n");
            sb.Append("  HasAttachement: ").Append(HasAttachement).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ExpireDate: ").Append(ExpireDate).Append("\n");
            sb.Append("  UserCompleteName: ").Append(UserCompleteName).Append("\n");
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
            return this.Equals(input as WorkflowInfoDTO);
        }

        /// <summary>
        /// Returns true if WorkflowInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkflowInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkflowInfoDTO input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.HasNote == input.HasNote ||
                    (this.HasNote != null &&
                    this.HasNote.Equals(input.HasNote))
                ) && 
                (
                    this.HasAttachement == input.HasAttachement ||
                    (this.HasAttachement != null &&
                    this.HasAttachement.Equals(input.HasAttachement))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.ExpireDate == input.ExpireDate ||
                    (this.ExpireDate != null &&
                    this.ExpireDate.Equals(input.ExpireDate))
                ) && 
                (
                    this.UserCompleteName == input.UserCompleteName ||
                    (this.UserCompleteName != null &&
                    this.UserCompleteName.Equals(input.UserCompleteName))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.HasNote != null)
                    hashCode = hashCode * 59 + this.HasNote.GetHashCode();
                if (this.HasAttachement != null)
                    hashCode = hashCode * 59 + this.HasAttachement.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.ExpireDate != null)
                    hashCode = hashCode * 59 + this.ExpireDate.GetHashCode();
                if (this.UserCompleteName != null)
                    hashCode = hashCode * 59 + this.UserCompleteName.GetHashCode();
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
