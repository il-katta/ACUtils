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
    /// Class of layout
    /// </summary>
    [DataContract]
    public partial class LayoutDTO :  IEquatable<LayoutDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="type">Possible values:  1: DesktopMenu  2: CommandsPanel .</param>
        /// <param name="name">Name.</param>
        /// <param name="author">Author user.</param>
        /// <param name="authorCompleteName">Author name.</param>
        /// <param name="creationDate">Creation Date.</param>
        /// <param name="priority">Priority.</param>
        /// <param name="details">Details.</param>
        /// <param name="usingType">Possible values:  2: Computer  4: Tablet  8: Smartphone .</param>
        /// <param name="users">Users.</param>
        /// <param name="isSystem">System Layout.</param>
        public LayoutDTO(int? id = default(int?), int? type = default(int?), string name = default(string), int? author = default(int?), string authorCompleteName = default(string), DateTime? creationDate = default(DateTime?), int? priority = default(int?), List<LayoutDetailDTO> details = default(List<LayoutDetailDTO>), int? usingType = default(int?), List<LayoutUsersDto> users = default(List<LayoutUsersDto>), bool? isSystem = default(bool?))
        {
            this.Id = id;
            this.Type = type;
            this.Name = name;
            this.Author = author;
            this.AuthorCompleteName = authorCompleteName;
            this.CreationDate = creationDate;
            this.Priority = priority;
            this.Details = details;
            this.UsingType = usingType;
            this.Users = users;
            this.IsSystem = isSystem;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Possible values:  1: DesktopMenu  2: CommandsPanel 
        /// </summary>
        /// <value>Possible values:  1: DesktopMenu  2: CommandsPanel </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int? Type { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Author user
        /// </summary>
        /// <value>Author user</value>
        [DataMember(Name="author", EmitDefaultValue=false)]
        public int? Author { get; set; }

        /// <summary>
        /// Author name
        /// </summary>
        /// <value>Author name</value>
        [DataMember(Name="authorCompleteName", EmitDefaultValue=false)]
        public string AuthorCompleteName { get; set; }

        /// <summary>
        /// Creation Date
        /// </summary>
        /// <value>Creation Date</value>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Priority
        /// </summary>
        /// <value>Priority</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// Details
        /// </summary>
        /// <value>Details</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public List<LayoutDetailDTO> Details { get; set; }

        /// <summary>
        /// Possible values:  2: Computer  4: Tablet  8: Smartphone 
        /// </summary>
        /// <value>Possible values:  2: Computer  4: Tablet  8: Smartphone </value>
        [DataMember(Name="usingType", EmitDefaultValue=false)]
        public int? UsingType { get; set; }

        /// <summary>
        /// Users
        /// </summary>
        /// <value>Users</value>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<LayoutUsersDto> Users { get; set; }

        /// <summary>
        /// System Layout
        /// </summary>
        /// <value>System Layout</value>
        [DataMember(Name="isSystem", EmitDefaultValue=false)]
        public bool? IsSystem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LayoutDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  AuthorCompleteName: ").Append(AuthorCompleteName).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  UsingType: ").Append(UsingType).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
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
            return this.Equals(input as LayoutDTO);
        }

        /// <summary>
        /// Returns true if LayoutDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of LayoutDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LayoutDTO input)
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
                ) && 
                (
                    this.AuthorCompleteName == input.AuthorCompleteName ||
                    (this.AuthorCompleteName != null &&
                    this.AuthorCompleteName.Equals(input.AuthorCompleteName))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && 
                (
                    this.UsingType == input.UsingType ||
                    (this.UsingType != null &&
                    this.UsingType.Equals(input.UsingType))
                ) && 
                (
                    this.Users == input.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(input.Users)
                ) && 
                (
                    this.IsSystem == input.IsSystem ||
                    (this.IsSystem != null &&
                    this.IsSystem.Equals(input.IsSystem))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Author != null)
                    hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.AuthorCompleteName != null)
                    hashCode = hashCode * 59 + this.AuthorCompleteName.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.UsingType != null)
                    hashCode = hashCode * 59 + this.UsingType.GetHashCode();
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
                if (this.IsSystem != null)
                    hashCode = hashCode * 59 + this.IsSystem.GetHashCode();
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
