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
    /// Class for security options
    /// </summary>
    [DataContract]
    public partial class SecurityDTO :  IEquatable<SecurityDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="userId">User identifier.</param>
        /// <param name="businessUnitCode">Business Unit Identifier.</param>
        /// <param name="documentTypeId">Document Type identifier.</param>
        /// <param name="editProfile">Edit profile option.</param>
        /// <param name="viewProfile">View profile option.</param>
        /// <param name="viewDocument">View document option.</param>
        /// <param name="previewDocument">Document preview option.</param>
        /// <param name="archiveDocument">Archive option.</param>
        /// <param name="editDocument">Edit document option.</param>
        /// <param name="deleteProfile">Delete profile option.</param>
        /// <param name="sign">Sign option.</param>
        /// <param name="hideRevisions">Hide revisions option.</param>
        /// <param name="share">Allow create sharing.</param>
        /// <param name="shareModifyExpiration">Allow change expiration.</param>
        /// <param name="shareModifyExpirationType">Allow change expiration type: after certain days or at first read or after certain number of downloads.</param>
        /// <param name="shareModifyExpirationMaxTime">Allow change max number of read for a document.</param>
        /// <param name="shareModifyMailSubject">Allow change mail subject.</param>
        /// <param name="shareModifyMailBody">Allow change mail body.</param>
        /// <param name="shareModifyWfStart">Allow change workflow that starts at link read.</param>
        /// <param name="shareModifyWfExpiration">Allow change workflow that starts at link expiration.</param>
        /// <param name="shareModifyWfExpirationRead">Allow change workflow that starts at link expiration if it isn&#39;t never read.</param>
        /// <param name="shareModifyLogin">Allow to set a login information to access sharing.</param>
        /// <param name="shareModifySpecificVersion">Allow to set file version to show.</param>
        public SecurityDTO(int? id = default(int?), int? userId = default(int?), string businessUnitCode = default(string), int? documentTypeId = default(int?), bool? editProfile = default(bool?), bool? viewProfile = default(bool?), bool? viewDocument = default(bool?), bool? previewDocument = default(bool?), bool? archiveDocument = default(bool?), bool? editDocument = default(bool?), bool? deleteProfile = default(bool?), bool? sign = default(bool?), bool? hideRevisions = default(bool?), bool? share = default(bool?), bool? shareModifyExpiration = default(bool?), bool? shareModifyExpirationType = default(bool?), bool? shareModifyExpirationMaxTime = default(bool?), bool? shareModifyMailSubject = default(bool?), bool? shareModifyMailBody = default(bool?), bool? shareModifyWfStart = default(bool?), bool? shareModifyWfExpiration = default(bool?), bool? shareModifyWfExpirationRead = default(bool?), bool? shareModifyLogin = default(bool?), bool? shareModifySpecificVersion = default(bool?))
        {
            this.Id = id;
            this.UserId = userId;
            this.BusinessUnitCode = businessUnitCode;
            this.DocumentTypeId = documentTypeId;
            this.EditProfile = editProfile;
            this.ViewProfile = viewProfile;
            this.ViewDocument = viewDocument;
            this.PreviewDocument = previewDocument;
            this.ArchiveDocument = archiveDocument;
            this.EditDocument = editDocument;
            this.DeleteProfile = deleteProfile;
            this.Sign = sign;
            this.HideRevisions = hideRevisions;
            this.Share = share;
            this.ShareModifyExpiration = shareModifyExpiration;
            this.ShareModifyExpirationType = shareModifyExpirationType;
            this.ShareModifyExpirationMaxTime = shareModifyExpirationMaxTime;
            this.ShareModifyMailSubject = shareModifyMailSubject;
            this.ShareModifyMailBody = shareModifyMailBody;
            this.ShareModifyWfStart = shareModifyWfStart;
            this.ShareModifyWfExpiration = shareModifyWfExpiration;
            this.ShareModifyWfExpirationRead = shareModifyWfExpirationRead;
            this.ShareModifyLogin = shareModifyLogin;
            this.ShareModifySpecificVersion = shareModifySpecificVersion;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// User identifier
        /// </summary>
        /// <value>User identifier</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Business Unit Identifier
        /// </summary>
        /// <value>Business Unit Identifier</value>
        [DataMember(Name="businessUnitCode", EmitDefaultValue=false)]
        public string BusinessUnitCode { get; set; }

        /// <summary>
        /// Document Type identifier
        /// </summary>
        /// <value>Document Type identifier</value>
        [DataMember(Name="documentTypeId", EmitDefaultValue=false)]
        public int? DocumentTypeId { get; set; }

        /// <summary>
        /// Edit profile option
        /// </summary>
        /// <value>Edit profile option</value>
        [DataMember(Name="editProfile", EmitDefaultValue=false)]
        public bool? EditProfile { get; set; }

        /// <summary>
        /// View profile option
        /// </summary>
        /// <value>View profile option</value>
        [DataMember(Name="viewProfile", EmitDefaultValue=false)]
        public bool? ViewProfile { get; set; }

        /// <summary>
        /// View document option
        /// </summary>
        /// <value>View document option</value>
        [DataMember(Name="viewDocument", EmitDefaultValue=false)]
        public bool? ViewDocument { get; set; }

        /// <summary>
        /// Document preview option
        /// </summary>
        /// <value>Document preview option</value>
        [DataMember(Name="previewDocument", EmitDefaultValue=false)]
        public bool? PreviewDocument { get; set; }

        /// <summary>
        /// Archive option
        /// </summary>
        /// <value>Archive option</value>
        [DataMember(Name="archiveDocument", EmitDefaultValue=false)]
        public bool? ArchiveDocument { get; set; }

        /// <summary>
        /// Edit document option
        /// </summary>
        /// <value>Edit document option</value>
        [DataMember(Name="editDocument", EmitDefaultValue=false)]
        public bool? EditDocument { get; set; }

        /// <summary>
        /// Delete profile option
        /// </summary>
        /// <value>Delete profile option</value>
        [DataMember(Name="deleteProfile", EmitDefaultValue=false)]
        public bool? DeleteProfile { get; set; }

        /// <summary>
        /// Sign option
        /// </summary>
        /// <value>Sign option</value>
        [DataMember(Name="sign", EmitDefaultValue=false)]
        public bool? Sign { get; set; }

        /// <summary>
        /// Hide revisions option
        /// </summary>
        /// <value>Hide revisions option</value>
        [DataMember(Name="hideRevisions", EmitDefaultValue=false)]
        public bool? HideRevisions { get; set; }

        /// <summary>
        /// Allow create sharing
        /// </summary>
        /// <value>Allow create sharing</value>
        [DataMember(Name="share", EmitDefaultValue=false)]
        public bool? Share { get; set; }

        /// <summary>
        /// Allow change expiration
        /// </summary>
        /// <value>Allow change expiration</value>
        [DataMember(Name="shareModifyExpiration", EmitDefaultValue=false)]
        public bool? ShareModifyExpiration { get; set; }

        /// <summary>
        /// Allow change expiration type: after certain days or at first read or after certain number of downloads
        /// </summary>
        /// <value>Allow change expiration type: after certain days or at first read or after certain number of downloads</value>
        [DataMember(Name="shareModifyExpirationType", EmitDefaultValue=false)]
        public bool? ShareModifyExpirationType { get; set; }

        /// <summary>
        /// Allow change max number of read for a document
        /// </summary>
        /// <value>Allow change max number of read for a document</value>
        [DataMember(Name="shareModifyExpirationMaxTime", EmitDefaultValue=false)]
        public bool? ShareModifyExpirationMaxTime { get; set; }

        /// <summary>
        /// Allow change mail subject
        /// </summary>
        /// <value>Allow change mail subject</value>
        [DataMember(Name="shareModifyMailSubject", EmitDefaultValue=false)]
        public bool? ShareModifyMailSubject { get; set; }

        /// <summary>
        /// Allow change mail body
        /// </summary>
        /// <value>Allow change mail body</value>
        [DataMember(Name="shareModifyMailBody", EmitDefaultValue=false)]
        public bool? ShareModifyMailBody { get; set; }

        /// <summary>
        /// Allow change workflow that starts at link read
        /// </summary>
        /// <value>Allow change workflow that starts at link read</value>
        [DataMember(Name="shareModifyWfStart", EmitDefaultValue=false)]
        public bool? ShareModifyWfStart { get; set; }

        /// <summary>
        /// Allow change workflow that starts at link expiration
        /// </summary>
        /// <value>Allow change workflow that starts at link expiration</value>
        [DataMember(Name="shareModifyWfExpiration", EmitDefaultValue=false)]
        public bool? ShareModifyWfExpiration { get; set; }

        /// <summary>
        /// Allow change workflow that starts at link expiration if it isn&#39;t never read
        /// </summary>
        /// <value>Allow change workflow that starts at link expiration if it isn&#39;t never read</value>
        [DataMember(Name="shareModifyWfExpirationRead", EmitDefaultValue=false)]
        public bool? ShareModifyWfExpirationRead { get; set; }

        /// <summary>
        /// Allow to set a login information to access sharing
        /// </summary>
        /// <value>Allow to set a login information to access sharing</value>
        [DataMember(Name="shareModifyLogin", EmitDefaultValue=false)]
        public bool? ShareModifyLogin { get; set; }

        /// <summary>
        /// Allow to set file version to show
        /// </summary>
        /// <value>Allow to set file version to show</value>
        [DataMember(Name="shareModifySpecificVersion", EmitDefaultValue=false)]
        public bool? ShareModifySpecificVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  BusinessUnitCode: ").Append(BusinessUnitCode).Append("\n");
            sb.Append("  DocumentTypeId: ").Append(DocumentTypeId).Append("\n");
            sb.Append("  EditProfile: ").Append(EditProfile).Append("\n");
            sb.Append("  ViewProfile: ").Append(ViewProfile).Append("\n");
            sb.Append("  ViewDocument: ").Append(ViewDocument).Append("\n");
            sb.Append("  PreviewDocument: ").Append(PreviewDocument).Append("\n");
            sb.Append("  ArchiveDocument: ").Append(ArchiveDocument).Append("\n");
            sb.Append("  EditDocument: ").Append(EditDocument).Append("\n");
            sb.Append("  DeleteProfile: ").Append(DeleteProfile).Append("\n");
            sb.Append("  Sign: ").Append(Sign).Append("\n");
            sb.Append("  HideRevisions: ").Append(HideRevisions).Append("\n");
            sb.Append("  Share: ").Append(Share).Append("\n");
            sb.Append("  ShareModifyExpiration: ").Append(ShareModifyExpiration).Append("\n");
            sb.Append("  ShareModifyExpirationType: ").Append(ShareModifyExpirationType).Append("\n");
            sb.Append("  ShareModifyExpirationMaxTime: ").Append(ShareModifyExpirationMaxTime).Append("\n");
            sb.Append("  ShareModifyMailSubject: ").Append(ShareModifyMailSubject).Append("\n");
            sb.Append("  ShareModifyMailBody: ").Append(ShareModifyMailBody).Append("\n");
            sb.Append("  ShareModifyWfStart: ").Append(ShareModifyWfStart).Append("\n");
            sb.Append("  ShareModifyWfExpiration: ").Append(ShareModifyWfExpiration).Append("\n");
            sb.Append("  ShareModifyWfExpirationRead: ").Append(ShareModifyWfExpirationRead).Append("\n");
            sb.Append("  ShareModifyLogin: ").Append(ShareModifyLogin).Append("\n");
            sb.Append("  ShareModifySpecificVersion: ").Append(ShareModifySpecificVersion).Append("\n");
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
            return this.Equals(input as SecurityDTO);
        }

        /// <summary>
        /// Returns true if SecurityDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SecurityDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityDTO input)
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
                    this.BusinessUnitCode == input.BusinessUnitCode ||
                    (this.BusinessUnitCode != null &&
                    this.BusinessUnitCode.Equals(input.BusinessUnitCode))
                ) && 
                (
                    this.DocumentTypeId == input.DocumentTypeId ||
                    (this.DocumentTypeId != null &&
                    this.DocumentTypeId.Equals(input.DocumentTypeId))
                ) && 
                (
                    this.EditProfile == input.EditProfile ||
                    (this.EditProfile != null &&
                    this.EditProfile.Equals(input.EditProfile))
                ) && 
                (
                    this.ViewProfile == input.ViewProfile ||
                    (this.ViewProfile != null &&
                    this.ViewProfile.Equals(input.ViewProfile))
                ) && 
                (
                    this.ViewDocument == input.ViewDocument ||
                    (this.ViewDocument != null &&
                    this.ViewDocument.Equals(input.ViewDocument))
                ) && 
                (
                    this.PreviewDocument == input.PreviewDocument ||
                    (this.PreviewDocument != null &&
                    this.PreviewDocument.Equals(input.PreviewDocument))
                ) && 
                (
                    this.ArchiveDocument == input.ArchiveDocument ||
                    (this.ArchiveDocument != null &&
                    this.ArchiveDocument.Equals(input.ArchiveDocument))
                ) && 
                (
                    this.EditDocument == input.EditDocument ||
                    (this.EditDocument != null &&
                    this.EditDocument.Equals(input.EditDocument))
                ) && 
                (
                    this.DeleteProfile == input.DeleteProfile ||
                    (this.DeleteProfile != null &&
                    this.DeleteProfile.Equals(input.DeleteProfile))
                ) && 
                (
                    this.Sign == input.Sign ||
                    (this.Sign != null &&
                    this.Sign.Equals(input.Sign))
                ) && 
                (
                    this.HideRevisions == input.HideRevisions ||
                    (this.HideRevisions != null &&
                    this.HideRevisions.Equals(input.HideRevisions))
                ) && 
                (
                    this.Share == input.Share ||
                    (this.Share != null &&
                    this.Share.Equals(input.Share))
                ) && 
                (
                    this.ShareModifyExpiration == input.ShareModifyExpiration ||
                    (this.ShareModifyExpiration != null &&
                    this.ShareModifyExpiration.Equals(input.ShareModifyExpiration))
                ) && 
                (
                    this.ShareModifyExpirationType == input.ShareModifyExpirationType ||
                    (this.ShareModifyExpirationType != null &&
                    this.ShareModifyExpirationType.Equals(input.ShareModifyExpirationType))
                ) && 
                (
                    this.ShareModifyExpirationMaxTime == input.ShareModifyExpirationMaxTime ||
                    (this.ShareModifyExpirationMaxTime != null &&
                    this.ShareModifyExpirationMaxTime.Equals(input.ShareModifyExpirationMaxTime))
                ) && 
                (
                    this.ShareModifyMailSubject == input.ShareModifyMailSubject ||
                    (this.ShareModifyMailSubject != null &&
                    this.ShareModifyMailSubject.Equals(input.ShareModifyMailSubject))
                ) && 
                (
                    this.ShareModifyMailBody == input.ShareModifyMailBody ||
                    (this.ShareModifyMailBody != null &&
                    this.ShareModifyMailBody.Equals(input.ShareModifyMailBody))
                ) && 
                (
                    this.ShareModifyWfStart == input.ShareModifyWfStart ||
                    (this.ShareModifyWfStart != null &&
                    this.ShareModifyWfStart.Equals(input.ShareModifyWfStart))
                ) && 
                (
                    this.ShareModifyWfExpiration == input.ShareModifyWfExpiration ||
                    (this.ShareModifyWfExpiration != null &&
                    this.ShareModifyWfExpiration.Equals(input.ShareModifyWfExpiration))
                ) && 
                (
                    this.ShareModifyWfExpirationRead == input.ShareModifyWfExpirationRead ||
                    (this.ShareModifyWfExpirationRead != null &&
                    this.ShareModifyWfExpirationRead.Equals(input.ShareModifyWfExpirationRead))
                ) && 
                (
                    this.ShareModifyLogin == input.ShareModifyLogin ||
                    (this.ShareModifyLogin != null &&
                    this.ShareModifyLogin.Equals(input.ShareModifyLogin))
                ) && 
                (
                    this.ShareModifySpecificVersion == input.ShareModifySpecificVersion ||
                    (this.ShareModifySpecificVersion != null &&
                    this.ShareModifySpecificVersion.Equals(input.ShareModifySpecificVersion))
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
                if (this.BusinessUnitCode != null)
                    hashCode = hashCode * 59 + this.BusinessUnitCode.GetHashCode();
                if (this.DocumentTypeId != null)
                    hashCode = hashCode * 59 + this.DocumentTypeId.GetHashCode();
                if (this.EditProfile != null)
                    hashCode = hashCode * 59 + this.EditProfile.GetHashCode();
                if (this.ViewProfile != null)
                    hashCode = hashCode * 59 + this.ViewProfile.GetHashCode();
                if (this.ViewDocument != null)
                    hashCode = hashCode * 59 + this.ViewDocument.GetHashCode();
                if (this.PreviewDocument != null)
                    hashCode = hashCode * 59 + this.PreviewDocument.GetHashCode();
                if (this.ArchiveDocument != null)
                    hashCode = hashCode * 59 + this.ArchiveDocument.GetHashCode();
                if (this.EditDocument != null)
                    hashCode = hashCode * 59 + this.EditDocument.GetHashCode();
                if (this.DeleteProfile != null)
                    hashCode = hashCode * 59 + this.DeleteProfile.GetHashCode();
                if (this.Sign != null)
                    hashCode = hashCode * 59 + this.Sign.GetHashCode();
                if (this.HideRevisions != null)
                    hashCode = hashCode * 59 + this.HideRevisions.GetHashCode();
                if (this.Share != null)
                    hashCode = hashCode * 59 + this.Share.GetHashCode();
                if (this.ShareModifyExpiration != null)
                    hashCode = hashCode * 59 + this.ShareModifyExpiration.GetHashCode();
                if (this.ShareModifyExpirationType != null)
                    hashCode = hashCode * 59 + this.ShareModifyExpirationType.GetHashCode();
                if (this.ShareModifyExpirationMaxTime != null)
                    hashCode = hashCode * 59 + this.ShareModifyExpirationMaxTime.GetHashCode();
                if (this.ShareModifyMailSubject != null)
                    hashCode = hashCode * 59 + this.ShareModifyMailSubject.GetHashCode();
                if (this.ShareModifyMailBody != null)
                    hashCode = hashCode * 59 + this.ShareModifyMailBody.GetHashCode();
                if (this.ShareModifyWfStart != null)
                    hashCode = hashCode * 59 + this.ShareModifyWfStart.GetHashCode();
                if (this.ShareModifyWfExpiration != null)
                    hashCode = hashCode * 59 + this.ShareModifyWfExpiration.GetHashCode();
                if (this.ShareModifyWfExpirationRead != null)
                    hashCode = hashCode * 59 + this.ShareModifyWfExpirationRead.GetHashCode();
                if (this.ShareModifyLogin != null)
                    hashCode = hashCode * 59 + this.ShareModifyLogin.GetHashCode();
                if (this.ShareModifySpecificVersion != null)
                    hashCode = hashCode * 59 + this.ShareModifySpecificVersion.GetHashCode();
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
