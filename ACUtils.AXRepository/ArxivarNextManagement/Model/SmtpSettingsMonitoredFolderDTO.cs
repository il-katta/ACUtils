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
    /// Monitored folder information
    /// </summary>
    [DataContract]
    public partial class SmtpSettingsMonitoredFolderDTO :  IEquatable<SmtpSettingsMonitoredFolderDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmtpSettingsMonitoredFolderDTO" /> class.
        /// </summary>
        /// <param name="id">The folder id.</param>
        /// <param name="isEnabled">Whether the folder is enabled.</param>
        /// <param name="path">The folder&#39;s full path.</param>
        /// <param name="user">The user associated.</param>
        /// <param name="statusMode">Possible values:  0: IncomingOnly  1: OutgoingOnly  2: Standard .</param>
        public SmtpSettingsMonitoredFolderDTO(int? id = default(int?), bool? isEnabled = default(bool?), string path = default(string), UserSimpleDTO user = default(UserSimpleDTO), int? statusMode = default(int?))
        {
            this.Id = id;
            this.IsEnabled = isEnabled;
            this.Path = path;
            this.User = user;
            this.StatusMode = statusMode;
        }
        
        /// <summary>
        /// The folder id
        /// </summary>
        /// <value>The folder id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Whether the folder is enabled
        /// </summary>
        /// <value>Whether the folder is enabled</value>
        [DataMember(Name="isEnabled", EmitDefaultValue=false)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// The folder&#39;s full path
        /// </summary>
        /// <value>The folder&#39;s full path</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// The user associated
        /// </summary>
        /// <value>The user associated</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserSimpleDTO User { get; set; }

        /// <summary>
        /// Possible values:  0: IncomingOnly  1: OutgoingOnly  2: Standard 
        /// </summary>
        /// <value>Possible values:  0: IncomingOnly  1: OutgoingOnly  2: Standard </value>
        [DataMember(Name="statusMode", EmitDefaultValue=false)]
        public int? StatusMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmtpSettingsMonitoredFolderDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  StatusMode: ").Append(StatusMode).Append("\n");
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
            return this.Equals(input as SmtpSettingsMonitoredFolderDTO);
        }

        /// <summary>
        /// Returns true if SmtpSettingsMonitoredFolderDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SmtpSettingsMonitoredFolderDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmtpSettingsMonitoredFolderDTO input)
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
                    this.IsEnabled == input.IsEnabled ||
                    (this.IsEnabled != null &&
                    this.IsEnabled.Equals(input.IsEnabled))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.StatusMode == input.StatusMode ||
                    (this.StatusMode != null &&
                    this.StatusMode.Equals(input.StatusMode))
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
                if (this.IsEnabled != null)
                    hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.StatusMode != null)
                    hashCode = hashCode * 59 + this.StatusMode.GetHashCode();
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
