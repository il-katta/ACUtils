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
    /// Email defaults information
    /// </summary>
    [DataContract]
    public partial class MailDefaultsInfoDTO :  IEquatable<MailDefaultsInfoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailDefaultsInfoDTO" /> class.
        /// </summary>
        /// <param name="senderEmailAddress">Sender email address.</param>
        /// <param name="senderDescription">Sender description.</param>
        /// <param name="subject">Default subject.</param>
        /// <param name="userPrivacyForAttachmentsEnabled">Whether the users privacy settings are enabled for the mail&#39;s attachments.</param>
        /// <param name="xUidlIgnored">Whether the X-Uidl are ignored on message&#39;s hash compute.</param>
        /// <param name="timezoneIgnored">Whether the timezone is ignored on message&#39;s hash compute.</param>
        /// <param name="hashIsComputedWithEmailAddress">Whether the message&#39;s hash is computed using the email address.</param>
        public MailDefaultsInfoDTO(string senderEmailAddress = default(string), string senderDescription = default(string), string subject = default(string), bool? userPrivacyForAttachmentsEnabled = default(bool?), bool? xUidlIgnored = default(bool?), bool? timezoneIgnored = default(bool?), bool? hashIsComputedWithEmailAddress = default(bool?))
        {
            this.SenderEmailAddress = senderEmailAddress;
            this.SenderDescription = senderDescription;
            this.Subject = subject;
            this.UserPrivacyForAttachmentsEnabled = userPrivacyForAttachmentsEnabled;
            this.XUidlIgnored = xUidlIgnored;
            this.TimezoneIgnored = timezoneIgnored;
            this.HashIsComputedWithEmailAddress = hashIsComputedWithEmailAddress;
        }
        
        /// <summary>
        /// Sender email address
        /// </summary>
        /// <value>Sender email address</value>
        [DataMember(Name="senderEmailAddress", EmitDefaultValue=false)]
        public string SenderEmailAddress { get; set; }

        /// <summary>
        /// Sender description
        /// </summary>
        /// <value>Sender description</value>
        [DataMember(Name="senderDescription", EmitDefaultValue=false)]
        public string SenderDescription { get; set; }

        /// <summary>
        /// Default subject
        /// </summary>
        /// <value>Default subject</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Whether the users privacy settings are enabled for the mail&#39;s attachments
        /// </summary>
        /// <value>Whether the users privacy settings are enabled for the mail&#39;s attachments</value>
        [DataMember(Name="userPrivacyForAttachmentsEnabled", EmitDefaultValue=false)]
        public bool? UserPrivacyForAttachmentsEnabled { get; set; }

        /// <summary>
        /// Whether the X-Uidl are ignored on message&#39;s hash compute
        /// </summary>
        /// <value>Whether the X-Uidl are ignored on message&#39;s hash compute</value>
        [DataMember(Name="xUidlIgnored", EmitDefaultValue=false)]
        public bool? XUidlIgnored { get; set; }

        /// <summary>
        /// Whether the timezone is ignored on message&#39;s hash compute
        /// </summary>
        /// <value>Whether the timezone is ignored on message&#39;s hash compute</value>
        [DataMember(Name="timezoneIgnored", EmitDefaultValue=false)]
        public bool? TimezoneIgnored { get; set; }

        /// <summary>
        /// Whether the message&#39;s hash is computed using the email address
        /// </summary>
        /// <value>Whether the message&#39;s hash is computed using the email address</value>
        [DataMember(Name="hashIsComputedWithEmailAddress", EmitDefaultValue=false)]
        public bool? HashIsComputedWithEmailAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MailDefaultsInfoDTO {\n");
            sb.Append("  SenderEmailAddress: ").Append(SenderEmailAddress).Append("\n");
            sb.Append("  SenderDescription: ").Append(SenderDescription).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  UserPrivacyForAttachmentsEnabled: ").Append(UserPrivacyForAttachmentsEnabled).Append("\n");
            sb.Append("  XUidlIgnored: ").Append(XUidlIgnored).Append("\n");
            sb.Append("  TimezoneIgnored: ").Append(TimezoneIgnored).Append("\n");
            sb.Append("  HashIsComputedWithEmailAddress: ").Append(HashIsComputedWithEmailAddress).Append("\n");
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
            return this.Equals(input as MailDefaultsInfoDTO);
        }

        /// <summary>
        /// Returns true if MailDefaultsInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MailDefaultsInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MailDefaultsInfoDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SenderEmailAddress == input.SenderEmailAddress ||
                    (this.SenderEmailAddress != null &&
                    this.SenderEmailAddress.Equals(input.SenderEmailAddress))
                ) && 
                (
                    this.SenderDescription == input.SenderDescription ||
                    (this.SenderDescription != null &&
                    this.SenderDescription.Equals(input.SenderDescription))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.UserPrivacyForAttachmentsEnabled == input.UserPrivacyForAttachmentsEnabled ||
                    (this.UserPrivacyForAttachmentsEnabled != null &&
                    this.UserPrivacyForAttachmentsEnabled.Equals(input.UserPrivacyForAttachmentsEnabled))
                ) && 
                (
                    this.XUidlIgnored == input.XUidlIgnored ||
                    (this.XUidlIgnored != null &&
                    this.XUidlIgnored.Equals(input.XUidlIgnored))
                ) && 
                (
                    this.TimezoneIgnored == input.TimezoneIgnored ||
                    (this.TimezoneIgnored != null &&
                    this.TimezoneIgnored.Equals(input.TimezoneIgnored))
                ) && 
                (
                    this.HashIsComputedWithEmailAddress == input.HashIsComputedWithEmailAddress ||
                    (this.HashIsComputedWithEmailAddress != null &&
                    this.HashIsComputedWithEmailAddress.Equals(input.HashIsComputedWithEmailAddress))
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
                if (this.SenderEmailAddress != null)
                    hashCode = hashCode * 59 + this.SenderEmailAddress.GetHashCode();
                if (this.SenderDescription != null)
                    hashCode = hashCode * 59 + this.SenderDescription.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.UserPrivacyForAttachmentsEnabled != null)
                    hashCode = hashCode * 59 + this.UserPrivacyForAttachmentsEnabled.GetHashCode();
                if (this.XUidlIgnored != null)
                    hashCode = hashCode * 59 + this.XUidlIgnored.GetHashCode();
                if (this.TimezoneIgnored != null)
                    hashCode = hashCode * 59 + this.TimezoneIgnored.GetHashCode();
                if (this.HashIsComputedWithEmailAddress != null)
                    hashCode = hashCode * 59 + this.HashIsComputedWithEmailAddress.GetHashCode();
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
