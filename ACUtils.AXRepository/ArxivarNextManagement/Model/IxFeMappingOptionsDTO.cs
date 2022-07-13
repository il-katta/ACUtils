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
    /// Class for IX-FE Mapping options
    /// </summary>
    [DataContract]
    public partial class IxFeMappingOptionsDTO :  IEquatable<IxFeMappingOptionsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IxFeMappingOptionsDTO" /> class.
        /// </summary>
        /// <param name="documentType">Parent document type.</param>
        /// <param name="copySecurityFromParent">Copy security settings from parent class.</param>
        /// <param name="defaultState">Default state for created predefined profiles.</param>
        /// <param name="notificationSettings">Notification settings.</param>
        public IxFeMappingOptionsDTO(DocumentTypeSimpleDTO documentType = default(DocumentTypeSimpleDTO), bool? copySecurityFromParent = default(bool?), StateSimpleDTO defaultState = default(StateSimpleDTO), List<IxFeNotificationSettingsBaseDTO> notificationSettings = default(List<IxFeNotificationSettingsBaseDTO>))
        {
            this.DocumentType = documentType;
            this.CopySecurityFromParent = copySecurityFromParent;
            this.DefaultState = defaultState;
            this.NotificationSettings = notificationSettings;
        }
        
        /// <summary>
        /// Parent document type
        /// </summary>
        /// <value>Parent document type</value>
        [DataMember(Name="documentType", EmitDefaultValue=false)]
        public DocumentTypeSimpleDTO DocumentType { get; set; }

        /// <summary>
        /// Copy security settings from parent class
        /// </summary>
        /// <value>Copy security settings from parent class</value>
        [DataMember(Name="copySecurityFromParent", EmitDefaultValue=false)]
        public bool? CopySecurityFromParent { get; set; }

        /// <summary>
        /// Default state for created predefined profiles
        /// </summary>
        /// <value>Default state for created predefined profiles</value>
        [DataMember(Name="defaultState", EmitDefaultValue=false)]
        public StateSimpleDTO DefaultState { get; set; }

        /// <summary>
        /// Notification settings
        /// </summary>
        /// <value>Notification settings</value>
        [DataMember(Name="notificationSettings", EmitDefaultValue=false)]
        public List<IxFeNotificationSettingsBaseDTO> NotificationSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IxFeMappingOptionsDTO {\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  CopySecurityFromParent: ").Append(CopySecurityFromParent).Append("\n");
            sb.Append("  DefaultState: ").Append(DefaultState).Append("\n");
            sb.Append("  NotificationSettings: ").Append(NotificationSettings).Append("\n");
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
            return this.Equals(input as IxFeMappingOptionsDTO);
        }

        /// <summary>
        /// Returns true if IxFeMappingOptionsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of IxFeMappingOptionsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IxFeMappingOptionsDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocumentType == input.DocumentType ||
                    (this.DocumentType != null &&
                    this.DocumentType.Equals(input.DocumentType))
                ) && 
                (
                    this.CopySecurityFromParent == input.CopySecurityFromParent ||
                    (this.CopySecurityFromParent != null &&
                    this.CopySecurityFromParent.Equals(input.CopySecurityFromParent))
                ) && 
                (
                    this.DefaultState == input.DefaultState ||
                    (this.DefaultState != null &&
                    this.DefaultState.Equals(input.DefaultState))
                ) && 
                (
                    this.NotificationSettings == input.NotificationSettings ||
                    this.NotificationSettings != null &&
                    this.NotificationSettings.SequenceEqual(input.NotificationSettings)
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
                if (this.DocumentType != null)
                    hashCode = hashCode * 59 + this.DocumentType.GetHashCode();
                if (this.CopySecurityFromParent != null)
                    hashCode = hashCode * 59 + this.CopySecurityFromParent.GetHashCode();
                if (this.DefaultState != null)
                    hashCode = hashCode * 59 + this.DefaultState.GetHashCode();
                if (this.NotificationSettings != null)
                    hashCode = hashCode * 59 + this.NotificationSettings.GetHashCode();
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