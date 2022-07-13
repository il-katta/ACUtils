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
    /// DelegationDTO
    /// </summary>
    [DataContract]
    public partial class DelegationDTO :  IEquatable<DelegationDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DelegationDTO" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="organizationChartDelegatingUser">organizationChartDelegatingUser.</param>
        /// <param name="organizationChartDelegatedUser">organizationChartDelegatedUser.</param>
        /// <param name="delegatingUser">delegatingUser.</param>
        /// <param name="delegatedUser">delegatedUser.</param>
        /// <param name="mails">mails.</param>
        /// <param name="tasks">tasks.</param>
        /// <param name="from">from.</param>
        /// <param name="to">to.</param>
        /// <param name="note">note.</param>
        /// <param name="isActive">isActive.</param>
        /// <param name="delegationMode">Possible values:  0: Static  1: Dynamic .</param>
        /// <param name="ignoreDelegationPeriod">ignoreDelegationPeriod.</param>
        public DelegationDTO(int? id = default(int?), int? organizationChartDelegatingUser = default(int?), int? organizationChartDelegatedUser = default(int?), DelegationUserDTO delegatingUser = default(DelegationUserDTO), DelegationUserDTO delegatedUser = default(DelegationUserDTO), bool? mails = default(bool?), bool? tasks = default(bool?), DateTime? from = default(DateTime?), DateTime? to = default(DateTime?), string note = default(string), bool? isActive = default(bool?), int? delegationMode = default(int?), bool? ignoreDelegationPeriod = default(bool?))
        {
            this.Id = id;
            this.OrganizationChartDelegatingUser = organizationChartDelegatingUser;
            this.OrganizationChartDelegatedUser = organizationChartDelegatedUser;
            this.DelegatingUser = delegatingUser;
            this.DelegatedUser = delegatedUser;
            this.Mails = mails;
            this.Tasks = tasks;
            this.From = from;
            this.To = to;
            this.Note = note;
            this.IsActive = isActive;
            this.DelegationMode = delegationMode;
            this.IgnoreDelegationPeriod = ignoreDelegationPeriod;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationChartDelegatingUser
        /// </summary>
        [DataMember(Name="organizationChartDelegatingUser", EmitDefaultValue=false)]
        public int? OrganizationChartDelegatingUser { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationChartDelegatedUser
        /// </summary>
        [DataMember(Name="organizationChartDelegatedUser", EmitDefaultValue=false)]
        public int? OrganizationChartDelegatedUser { get; set; }

        /// <summary>
        /// Gets or Sets DelegatingUser
        /// </summary>
        [DataMember(Name="delegatingUser", EmitDefaultValue=false)]
        public DelegationUserDTO DelegatingUser { get; set; }

        /// <summary>
        /// Gets or Sets DelegatedUser
        /// </summary>
        [DataMember(Name="delegatedUser", EmitDefaultValue=false)]
        public DelegationUserDTO DelegatedUser { get; set; }

        /// <summary>
        /// Gets or Sets Mails
        /// </summary>
        [DataMember(Name="mails", EmitDefaultValue=false)]
        public bool? Mails { get; set; }

        /// <summary>
        /// Gets or Sets Tasks
        /// </summary>
        [DataMember(Name="tasks", EmitDefaultValue=false)]
        public bool? Tasks { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public DateTime? From { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public DateTime? To { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Possible values:  0: Static  1: Dynamic 
        /// </summary>
        /// <value>Possible values:  0: Static  1: Dynamic </value>
        [DataMember(Name="delegationMode", EmitDefaultValue=false)]
        public int? DelegationMode { get; set; }

        /// <summary>
        /// Gets or Sets IgnoreDelegationPeriod
        /// </summary>
        [DataMember(Name="ignoreDelegationPeriod", EmitDefaultValue=false)]
        public bool? IgnoreDelegationPeriod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DelegationDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrganizationChartDelegatingUser: ").Append(OrganizationChartDelegatingUser).Append("\n");
            sb.Append("  OrganizationChartDelegatedUser: ").Append(OrganizationChartDelegatedUser).Append("\n");
            sb.Append("  DelegatingUser: ").Append(DelegatingUser).Append("\n");
            sb.Append("  DelegatedUser: ").Append(DelegatedUser).Append("\n");
            sb.Append("  Mails: ").Append(Mails).Append("\n");
            sb.Append("  Tasks: ").Append(Tasks).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  DelegationMode: ").Append(DelegationMode).Append("\n");
            sb.Append("  IgnoreDelegationPeriod: ").Append(IgnoreDelegationPeriod).Append("\n");
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
            return this.Equals(input as DelegationDTO);
        }

        /// <summary>
        /// Returns true if DelegationDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of DelegationDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DelegationDTO input)
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
                    this.OrganizationChartDelegatingUser == input.OrganizationChartDelegatingUser ||
                    (this.OrganizationChartDelegatingUser != null &&
                    this.OrganizationChartDelegatingUser.Equals(input.OrganizationChartDelegatingUser))
                ) && 
                (
                    this.OrganizationChartDelegatedUser == input.OrganizationChartDelegatedUser ||
                    (this.OrganizationChartDelegatedUser != null &&
                    this.OrganizationChartDelegatedUser.Equals(input.OrganizationChartDelegatedUser))
                ) && 
                (
                    this.DelegatingUser == input.DelegatingUser ||
                    (this.DelegatingUser != null &&
                    this.DelegatingUser.Equals(input.DelegatingUser))
                ) && 
                (
                    this.DelegatedUser == input.DelegatedUser ||
                    (this.DelegatedUser != null &&
                    this.DelegatedUser.Equals(input.DelegatedUser))
                ) && 
                (
                    this.Mails == input.Mails ||
                    (this.Mails != null &&
                    this.Mails.Equals(input.Mails))
                ) && 
                (
                    this.Tasks == input.Tasks ||
                    (this.Tasks != null &&
                    this.Tasks.Equals(input.Tasks))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.DelegationMode == input.DelegationMode ||
                    (this.DelegationMode != null &&
                    this.DelegationMode.Equals(input.DelegationMode))
                ) && 
                (
                    this.IgnoreDelegationPeriod == input.IgnoreDelegationPeriod ||
                    (this.IgnoreDelegationPeriod != null &&
                    this.IgnoreDelegationPeriod.Equals(input.IgnoreDelegationPeriod))
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
                if (this.OrganizationChartDelegatingUser != null)
                    hashCode = hashCode * 59 + this.OrganizationChartDelegatingUser.GetHashCode();
                if (this.OrganizationChartDelegatedUser != null)
                    hashCode = hashCode * 59 + this.OrganizationChartDelegatedUser.GetHashCode();
                if (this.DelegatingUser != null)
                    hashCode = hashCode * 59 + this.DelegatingUser.GetHashCode();
                if (this.DelegatedUser != null)
                    hashCode = hashCode * 59 + this.DelegatedUser.GetHashCode();
                if (this.Mails != null)
                    hashCode = hashCode * 59 + this.Mails.GetHashCode();
                if (this.Tasks != null)
                    hashCode = hashCode * 59 + this.Tasks.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.DelegationMode != null)
                    hashCode = hashCode * 59 + this.DelegationMode.GetHashCode();
                if (this.IgnoreDelegationPeriod != null)
                    hashCode = hashCode * 59 + this.IgnoreDelegationPeriod.GetHashCode();
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
