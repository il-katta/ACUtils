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
    /// Defines the information needed to build the authorization redirect url to the external provider (Google, Microsoft, ...)
    /// </summary>
    [DataContract]
    public partial class ExternalAuthRedirectUrlRequestDTO :  IEquatable<ExternalAuthRedirectUrlRequestDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalAuthRedirectUrlRequestDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExternalAuthRedirectUrlRequestDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalAuthRedirectUrlRequestDTO" /> class.
        /// </summary>
        /// <param name="mailSettings">The {Abletech.Arxivar.Server.Dtos.Mail.MailServerSettingsDTO} information (required).</param>
        /// <param name="flowType">Possible values:  0: Send  1: Receive .</param>
        /// <param name="portalBaseUrl">The portal base url (required).</param>
        public ExternalAuthRedirectUrlRequestDTO(MailServerSettingsDTO mailSettings = default(MailServerSettingsDTO), int? flowType = default(int?), string portalBaseUrl = default(string))
        {
            // to ensure "mailSettings" is required (not null)
            if (mailSettings == null)
            {
                throw new InvalidDataException("mailSettings is a required property for ExternalAuthRedirectUrlRequestDTO and cannot be null");
            }
            else
            {
                this.MailSettings = mailSettings;
            }
            // to ensure "portalBaseUrl" is required (not null)
            if (portalBaseUrl == null)
            {
                throw new InvalidDataException("portalBaseUrl is a required property for ExternalAuthRedirectUrlRequestDTO and cannot be null");
            }
            else
            {
                this.PortalBaseUrl = portalBaseUrl;
            }
            this.FlowType = flowType;
        }
        
        /// <summary>
        /// The {Abletech.Arxivar.Server.Dtos.Mail.MailServerSettingsDTO} information
        /// </summary>
        /// <value>The {Abletech.Arxivar.Server.Dtos.Mail.MailServerSettingsDTO} information</value>
        [DataMember(Name="mailSettings", EmitDefaultValue=false)]
        public MailServerSettingsDTO MailSettings { get; set; }

        /// <summary>
        /// Possible values:  0: Send  1: Receive 
        /// </summary>
        /// <value>Possible values:  0: Send  1: Receive </value>
        [DataMember(Name="flowType", EmitDefaultValue=false)]
        public int? FlowType { get; set; }

        /// <summary>
        /// The portal base url
        /// </summary>
        /// <value>The portal base url</value>
        [DataMember(Name="portalBaseUrl", EmitDefaultValue=false)]
        public string PortalBaseUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalAuthRedirectUrlRequestDTO {\n");
            sb.Append("  MailSettings: ").Append(MailSettings).Append("\n");
            sb.Append("  FlowType: ").Append(FlowType).Append("\n");
            sb.Append("  PortalBaseUrl: ").Append(PortalBaseUrl).Append("\n");
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
            return this.Equals(input as ExternalAuthRedirectUrlRequestDTO);
        }

        /// <summary>
        /// Returns true if ExternalAuthRedirectUrlRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ExternalAuthRedirectUrlRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalAuthRedirectUrlRequestDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MailSettings == input.MailSettings ||
                    (this.MailSettings != null &&
                    this.MailSettings.Equals(input.MailSettings))
                ) && 
                (
                    this.FlowType == input.FlowType ||
                    (this.FlowType != null &&
                    this.FlowType.Equals(input.FlowType))
                ) && 
                (
                    this.PortalBaseUrl == input.PortalBaseUrl ||
                    (this.PortalBaseUrl != null &&
                    this.PortalBaseUrl.Equals(input.PortalBaseUrl))
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
                if (this.MailSettings != null)
                    hashCode = hashCode * 59 + this.MailSettings.GetHashCode();
                if (this.FlowType != null)
                    hashCode = hashCode * 59 + this.FlowType.GetHashCode();
                if (this.PortalBaseUrl != null)
                    hashCode = hashCode * 59 + this.PortalBaseUrl.GetHashCode();
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
