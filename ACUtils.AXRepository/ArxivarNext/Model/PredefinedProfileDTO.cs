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
    /// Class of predefined profile data
    /// </summary>
    [DataContract]
    public partial class PredefinedProfileDTO :  IEquatable<PredefinedProfileDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PredefinedProfileDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="name">Name.</param>
        /// <param name="postProfilationActions">List of post profilation actions.</param>
        /// <param name="userCompleteName">Full name of the user who created the predefined profile.</param>
        /// <param name="creationDate">Creation date.</param>
        /// <param name="documentType">Document type identifier.</param>
        /// <param name="aoo">Business code.</param>
        /// <param name="user">User identifier.</param>
        /// <param name="collaborationTemplateId">Collaboration Identifier.</param>
        /// <param name="fields">List of fields.</param>
        public PredefinedProfileDTO(int? id = default(int?), string name = default(string), List<PostProfilationActionDTO> postProfilationActions = default(List<PostProfilationActionDTO>), string userCompleteName = default(string), DateTime? creationDate = default(DateTime?), int? documentType = default(int?), string aoo = default(string), int? user = default(int?), string collaborationTemplateId = default(string), List<FieldBaseDTO> fields = default(List<FieldBaseDTO>))
        {
            this.Id = id;
            this.Name = name;
            this.PostProfilationActions = postProfilationActions;
            this.UserCompleteName = userCompleteName;
            this.CreationDate = creationDate;
            this.DocumentType = documentType;
            this.Aoo = aoo;
            this.User = user;
            this.CollaborationTemplateId = collaborationTemplateId;
            this.Fields = fields;
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
        /// List of post profilation actions
        /// </summary>
        /// <value>List of post profilation actions</value>
        [DataMember(Name="postProfilationActions", EmitDefaultValue=false)]
        public List<PostProfilationActionDTO> PostProfilationActions { get; set; }

        /// <summary>
        /// Full name of the user who created the predefined profile
        /// </summary>
        /// <value>Full name of the user who created the predefined profile</value>
        [DataMember(Name="userCompleteName", EmitDefaultValue=false)]
        public string UserCompleteName { get; set; }

        /// <summary>
        /// Creation date
        /// </summary>
        /// <value>Creation date</value>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Document type identifier
        /// </summary>
        /// <value>Document type identifier</value>
        [DataMember(Name="documentType", EmitDefaultValue=false)]
        public int? DocumentType { get; set; }

        /// <summary>
        /// Business code
        /// </summary>
        /// <value>Business code</value>
        [DataMember(Name="aoo", EmitDefaultValue=false)]
        public string Aoo { get; set; }

        /// <summary>
        /// User identifier
        /// </summary>
        /// <value>User identifier</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public int? User { get; set; }

        /// <summary>
        /// Collaboration Identifier
        /// </summary>
        /// <value>Collaboration Identifier</value>
        [DataMember(Name="collaborationTemplateId", EmitDefaultValue=false)]
        public string CollaborationTemplateId { get; set; }

        /// <summary>
        /// List of fields
        /// </summary>
        /// <value>List of fields</value>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<FieldBaseDTO> Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PredefinedProfileDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PostProfilationActions: ").Append(PostProfilationActions).Append("\n");
            sb.Append("  UserCompleteName: ").Append(UserCompleteName).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  Aoo: ").Append(Aoo).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  CollaborationTemplateId: ").Append(CollaborationTemplateId).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
            return this.Equals(input as PredefinedProfileDTO);
        }

        /// <summary>
        /// Returns true if PredefinedProfileDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of PredefinedProfileDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PredefinedProfileDTO input)
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
                    this.PostProfilationActions == input.PostProfilationActions ||
                    this.PostProfilationActions != null &&
                    this.PostProfilationActions.SequenceEqual(input.PostProfilationActions)
                ) && 
                (
                    this.UserCompleteName == input.UserCompleteName ||
                    (this.UserCompleteName != null &&
                    this.UserCompleteName.Equals(input.UserCompleteName))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.DocumentType == input.DocumentType ||
                    (this.DocumentType != null &&
                    this.DocumentType.Equals(input.DocumentType))
                ) && 
                (
                    this.Aoo == input.Aoo ||
                    (this.Aoo != null &&
                    this.Aoo.Equals(input.Aoo))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.CollaborationTemplateId == input.CollaborationTemplateId ||
                    (this.CollaborationTemplateId != null &&
                    this.CollaborationTemplateId.Equals(input.CollaborationTemplateId))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
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
                if (this.PostProfilationActions != null)
                    hashCode = hashCode * 59 + this.PostProfilationActions.GetHashCode();
                if (this.UserCompleteName != null)
                    hashCode = hashCode * 59 + this.UserCompleteName.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.DocumentType != null)
                    hashCode = hashCode * 59 + this.DocumentType.GetHashCode();
                if (this.Aoo != null)
                    hashCode = hashCode * 59 + this.Aoo.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.CollaborationTemplateId != null)
                    hashCode = hashCode * 59 + this.CollaborationTemplateId.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
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