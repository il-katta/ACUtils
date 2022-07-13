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
    /// Class of mask to archive documents
    /// </summary>
    [DataContract]
    public partial class MaskDTO :  IEquatable<MaskDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaskDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="maskName">Name.</param>
        /// <param name="maskDescription">Description.</param>
        /// <param name="predefinedProfileId">Predefined Profile Identifier.</param>
        /// <param name="user">Author Identifier.</param>
        /// <param name="externalId">External Identifier.</param>
        /// <param name="isRoot">Root.</param>
        /// <param name="type">Possible values:  0: Nothing  1: Barcode  2: Archiviazione .</param>
        /// <param name="paMode">Possible values:  0: None  1: OnlyNever  2: OnlyOptionally  3: NeverOrOptionally  4: OnlyAlways  5: AlwaysOrNever  6: AlwaysOrOptionally  7: All .</param>
        /// <param name="showAdditional">Show Additional.</param>
        /// <param name="kind">Possible values:  0: UserMask  1: SystemMask .</param>
        /// <param name="showGroups">Show Groups.</param>
        /// <param name="userCompleteName">Author Complete Name.</param>
        /// <param name="whitelistFileExtensions">Whitelist Extension.</param>
        /// <param name="blacklistFileExtensions">Blacklist Extension.</param>
        /// <param name="minFileSize">File size minimum value.</param>
        /// <param name="maxFileSize">File size maximum value.</param>
        /// <param name="predefinedProfile">Predefined Profile associated with the mask.</param>
        /// <param name="maskDetails">Details.</param>
        /// <param name="maskClassOptions">Options on document type.</param>
        /// <param name="useAdvancedTool">This option indicates if the mask use new features for ARXivar Next Portal.</param>
        public MaskDTO(string id = default(string), string maskName = default(string), string maskDescription = default(string), int? predefinedProfileId = default(int?), int? user = default(int?), string externalId = default(string), bool? isRoot = default(bool?), int? type = default(int?), int? paMode = default(int?), bool? showAdditional = default(bool?), int? kind = default(int?), bool? showGroups = default(bool?), string userCompleteName = default(string), List<string> whitelistFileExtensions = default(List<string>), List<string> blacklistFileExtensions = default(List<string>), long? minFileSize = default(long?), long? maxFileSize = default(long?), PredefinedProfileDTO predefinedProfile = default(PredefinedProfileDTO), List<MaskDetailDTO> maskDetails = default(List<MaskDetailDTO>), List<MaskClassOptionsDTO> maskClassOptions = default(List<MaskClassOptionsDTO>), bool? useAdvancedTool = default(bool?))
        {
            this.Id = id;
            this.MaskName = maskName;
            this.MaskDescription = maskDescription;
            this.PredefinedProfileId = predefinedProfileId;
            this.User = user;
            this.ExternalId = externalId;
            this.IsRoot = isRoot;
            this.Type = type;
            this.PaMode = paMode;
            this.ShowAdditional = showAdditional;
            this.Kind = kind;
            this.ShowGroups = showGroups;
            this.UserCompleteName = userCompleteName;
            this.WhitelistFileExtensions = whitelistFileExtensions;
            this.BlacklistFileExtensions = blacklistFileExtensions;
            this.MinFileSize = minFileSize;
            this.MaxFileSize = maxFileSize;
            this.PredefinedProfile = predefinedProfile;
            this.MaskDetails = maskDetails;
            this.MaskClassOptions = maskClassOptions;
            this.UseAdvancedTool = useAdvancedTool;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="maskName", EmitDefaultValue=false)]
        public string MaskName { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="maskDescription", EmitDefaultValue=false)]
        public string MaskDescription { get; set; }

        /// <summary>
        /// Predefined Profile Identifier
        /// </summary>
        /// <value>Predefined Profile Identifier</value>
        [DataMember(Name="predefinedProfileId", EmitDefaultValue=false)]
        public int? PredefinedProfileId { get; set; }

        /// <summary>
        /// Author Identifier
        /// </summary>
        /// <value>Author Identifier</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public int? User { get; set; }

        /// <summary>
        /// External Identifier
        /// </summary>
        /// <value>External Identifier</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Root
        /// </summary>
        /// <value>Root</value>
        [DataMember(Name="isRoot", EmitDefaultValue=false)]
        public bool? IsRoot { get; set; }

        /// <summary>
        /// Possible values:  0: Nothing  1: Barcode  2: Archiviazione 
        /// </summary>
        /// <value>Possible values:  0: Nothing  1: Barcode  2: Archiviazione </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int? Type { get; set; }

        /// <summary>
        /// Possible values:  0: None  1: OnlyNever  2: OnlyOptionally  3: NeverOrOptionally  4: OnlyAlways  5: AlwaysOrNever  6: AlwaysOrOptionally  7: All 
        /// </summary>
        /// <value>Possible values:  0: None  1: OnlyNever  2: OnlyOptionally  3: NeverOrOptionally  4: OnlyAlways  5: AlwaysOrNever  6: AlwaysOrOptionally  7: All </value>
        [DataMember(Name="paMode", EmitDefaultValue=false)]
        public int? PaMode { get; set; }

        /// <summary>
        /// Show Additional
        /// </summary>
        /// <value>Show Additional</value>
        [DataMember(Name="showAdditional", EmitDefaultValue=false)]
        public bool? ShowAdditional { get; set; }

        /// <summary>
        /// Possible values:  0: UserMask  1: SystemMask 
        /// </summary>
        /// <value>Possible values:  0: UserMask  1: SystemMask </value>
        [DataMember(Name="kind", EmitDefaultValue=false)]
        public int? Kind { get; set; }

        /// <summary>
        /// Show Groups
        /// </summary>
        /// <value>Show Groups</value>
        [DataMember(Name="showGroups", EmitDefaultValue=false)]
        public bool? ShowGroups { get; set; }

        /// <summary>
        /// Author Complete Name
        /// </summary>
        /// <value>Author Complete Name</value>
        [DataMember(Name="userCompleteName", EmitDefaultValue=false)]
        public string UserCompleteName { get; set; }

        /// <summary>
        /// Whitelist Extension
        /// </summary>
        /// <value>Whitelist Extension</value>
        [DataMember(Name="whitelistFileExtensions", EmitDefaultValue=false)]
        public List<string> WhitelistFileExtensions { get; set; }

        /// <summary>
        /// Blacklist Extension
        /// </summary>
        /// <value>Blacklist Extension</value>
        [DataMember(Name="blacklistFileExtensions", EmitDefaultValue=false)]
        public List<string> BlacklistFileExtensions { get; set; }

        /// <summary>
        /// File size minimum value
        /// </summary>
        /// <value>File size minimum value</value>
        [DataMember(Name="minFileSize", EmitDefaultValue=false)]
        public long? MinFileSize { get; set; }

        /// <summary>
        /// File size maximum value
        /// </summary>
        /// <value>File size maximum value</value>
        [DataMember(Name="maxFileSize", EmitDefaultValue=false)]
        public long? MaxFileSize { get; set; }

        /// <summary>
        /// Predefined Profile associated with the mask
        /// </summary>
        /// <value>Predefined Profile associated with the mask</value>
        [DataMember(Name="predefinedProfile", EmitDefaultValue=false)]
        public PredefinedProfileDTO PredefinedProfile { get; set; }

        /// <summary>
        /// Details
        /// </summary>
        /// <value>Details</value>
        [DataMember(Name="maskDetails", EmitDefaultValue=false)]
        public List<MaskDetailDTO> MaskDetails { get; set; }

        /// <summary>
        /// Options on document type
        /// </summary>
        /// <value>Options on document type</value>
        [DataMember(Name="maskClassOptions", EmitDefaultValue=false)]
        public List<MaskClassOptionsDTO> MaskClassOptions { get; set; }

        /// <summary>
        /// This option indicates if the mask use new features for ARXivar Next Portal
        /// </summary>
        /// <value>This option indicates if the mask use new features for ARXivar Next Portal</value>
        [DataMember(Name="useAdvancedTool", EmitDefaultValue=false)]
        public bool? UseAdvancedTool { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MaskDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MaskName: ").Append(MaskName).Append("\n");
            sb.Append("  MaskDescription: ").Append(MaskDescription).Append("\n");
            sb.Append("  PredefinedProfileId: ").Append(PredefinedProfileId).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  IsRoot: ").Append(IsRoot).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  PaMode: ").Append(PaMode).Append("\n");
            sb.Append("  ShowAdditional: ").Append(ShowAdditional).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  ShowGroups: ").Append(ShowGroups).Append("\n");
            sb.Append("  UserCompleteName: ").Append(UserCompleteName).Append("\n");
            sb.Append("  WhitelistFileExtensions: ").Append(WhitelistFileExtensions).Append("\n");
            sb.Append("  BlacklistFileExtensions: ").Append(BlacklistFileExtensions).Append("\n");
            sb.Append("  MinFileSize: ").Append(MinFileSize).Append("\n");
            sb.Append("  MaxFileSize: ").Append(MaxFileSize).Append("\n");
            sb.Append("  PredefinedProfile: ").Append(PredefinedProfile).Append("\n");
            sb.Append("  MaskDetails: ").Append(MaskDetails).Append("\n");
            sb.Append("  MaskClassOptions: ").Append(MaskClassOptions).Append("\n");
            sb.Append("  UseAdvancedTool: ").Append(UseAdvancedTool).Append("\n");
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
            return this.Equals(input as MaskDTO);
        }

        /// <summary>
        /// Returns true if MaskDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MaskDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MaskDTO input)
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
                    this.MaskName == input.MaskName ||
                    (this.MaskName != null &&
                    this.MaskName.Equals(input.MaskName))
                ) && 
                (
                    this.MaskDescription == input.MaskDescription ||
                    (this.MaskDescription != null &&
                    this.MaskDescription.Equals(input.MaskDescription))
                ) && 
                (
                    this.PredefinedProfileId == input.PredefinedProfileId ||
                    (this.PredefinedProfileId != null &&
                    this.PredefinedProfileId.Equals(input.PredefinedProfileId))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.IsRoot == input.IsRoot ||
                    (this.IsRoot != null &&
                    this.IsRoot.Equals(input.IsRoot))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.PaMode == input.PaMode ||
                    (this.PaMode != null &&
                    this.PaMode.Equals(input.PaMode))
                ) && 
                (
                    this.ShowAdditional == input.ShowAdditional ||
                    (this.ShowAdditional != null &&
                    this.ShowAdditional.Equals(input.ShowAdditional))
                ) && 
                (
                    this.Kind == input.Kind ||
                    (this.Kind != null &&
                    this.Kind.Equals(input.Kind))
                ) && 
                (
                    this.ShowGroups == input.ShowGroups ||
                    (this.ShowGroups != null &&
                    this.ShowGroups.Equals(input.ShowGroups))
                ) && 
                (
                    this.UserCompleteName == input.UserCompleteName ||
                    (this.UserCompleteName != null &&
                    this.UserCompleteName.Equals(input.UserCompleteName))
                ) && 
                (
                    this.WhitelistFileExtensions == input.WhitelistFileExtensions ||
                    this.WhitelistFileExtensions != null &&
                    this.WhitelistFileExtensions.SequenceEqual(input.WhitelistFileExtensions)
                ) && 
                (
                    this.BlacklistFileExtensions == input.BlacklistFileExtensions ||
                    this.BlacklistFileExtensions != null &&
                    this.BlacklistFileExtensions.SequenceEqual(input.BlacklistFileExtensions)
                ) && 
                (
                    this.MinFileSize == input.MinFileSize ||
                    (this.MinFileSize != null &&
                    this.MinFileSize.Equals(input.MinFileSize))
                ) && 
                (
                    this.MaxFileSize == input.MaxFileSize ||
                    (this.MaxFileSize != null &&
                    this.MaxFileSize.Equals(input.MaxFileSize))
                ) && 
                (
                    this.PredefinedProfile == input.PredefinedProfile ||
                    (this.PredefinedProfile != null &&
                    this.PredefinedProfile.Equals(input.PredefinedProfile))
                ) && 
                (
                    this.MaskDetails == input.MaskDetails ||
                    this.MaskDetails != null &&
                    this.MaskDetails.SequenceEqual(input.MaskDetails)
                ) && 
                (
                    this.MaskClassOptions == input.MaskClassOptions ||
                    this.MaskClassOptions != null &&
                    this.MaskClassOptions.SequenceEqual(input.MaskClassOptions)
                ) && 
                (
                    this.UseAdvancedTool == input.UseAdvancedTool ||
                    (this.UseAdvancedTool != null &&
                    this.UseAdvancedTool.Equals(input.UseAdvancedTool))
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
                if (this.MaskName != null)
                    hashCode = hashCode * 59 + this.MaskName.GetHashCode();
                if (this.MaskDescription != null)
                    hashCode = hashCode * 59 + this.MaskDescription.GetHashCode();
                if (this.PredefinedProfileId != null)
                    hashCode = hashCode * 59 + this.PredefinedProfileId.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.IsRoot != null)
                    hashCode = hashCode * 59 + this.IsRoot.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.PaMode != null)
                    hashCode = hashCode * 59 + this.PaMode.GetHashCode();
                if (this.ShowAdditional != null)
                    hashCode = hashCode * 59 + this.ShowAdditional.GetHashCode();
                if (this.Kind != null)
                    hashCode = hashCode * 59 + this.Kind.GetHashCode();
                if (this.ShowGroups != null)
                    hashCode = hashCode * 59 + this.ShowGroups.GetHashCode();
                if (this.UserCompleteName != null)
                    hashCode = hashCode * 59 + this.UserCompleteName.GetHashCode();
                if (this.WhitelistFileExtensions != null)
                    hashCode = hashCode * 59 + this.WhitelistFileExtensions.GetHashCode();
                if (this.BlacklistFileExtensions != null)
                    hashCode = hashCode * 59 + this.BlacklistFileExtensions.GetHashCode();
                if (this.MinFileSize != null)
                    hashCode = hashCode * 59 + this.MinFileSize.GetHashCode();
                if (this.MaxFileSize != null)
                    hashCode = hashCode * 59 + this.MaxFileSize.GetHashCode();
                if (this.PredefinedProfile != null)
                    hashCode = hashCode * 59 + this.PredefinedProfile.GetHashCode();
                if (this.MaskDetails != null)
                    hashCode = hashCode * 59 + this.MaskDetails.GetHashCode();
                if (this.MaskClassOptions != null)
                    hashCode = hashCode * 59 + this.MaskClassOptions.GetHashCode();
                if (this.UseAdvancedTool != null)
                    hashCode = hashCode * 59 + this.UseAdvancedTool.GetHashCode();
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
