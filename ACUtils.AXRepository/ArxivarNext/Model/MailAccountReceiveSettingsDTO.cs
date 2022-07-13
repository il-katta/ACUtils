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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = ACUtils.AXRepository.ArxivarNext.Client.SwaggerDateConverter;

namespace ACUtils.AXRepository.ArxivarNext.Model
{
    /// <summary>
    /// Abstract class for receiving mail
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "className")]
    [JsonSubtypes.KnownSubType(typeof(MailAccountReceiveSettingsImapDTO), "MailAccountReceiveSettingsImapDTO")]
    [JsonSubtypes.KnownSubType(typeof(MailAccountReceiveSettingsPop3DTO), "MailAccountReceiveSettingsPop3DTO")]
    public partial class MailAccountReceiveSettingsDTO :  IEquatable<MailAccountReceiveSettingsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailAccountReceiveSettingsDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MailAccountReceiveSettingsDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MailAccountReceiveSettingsDTO" /> class.
        /// </summary>
        /// <param name="className">Name of class (required).</param>
        /// <param name="authenticationMode">Possible values:  0: Basic  1: Microsoft  2: Google .</param>
        /// <param name="tenantId">The tenant ID.</param>
        /// <param name="clientId">The client ID.</param>
        /// <param name="clientSecret">The client Secret.</param>
        /// <param name="isClientSecretSet">Gets or sets whether the client secret is set.</param>
        /// <param name="isAuthorizationResponseSet">Gets or sets whether the authorization response is set.</param>
        /// <param name="authorizationResponse">The authorization response.</param>
        public MailAccountReceiveSettingsDTO(string className = default(string), int? authenticationMode = default(int?), string tenantId = default(string), string clientId = default(string), string clientSecret = default(string), bool? isClientSecretSet = default(bool?), bool? isAuthorizationResponseSet = default(bool?), string authorizationResponse = default(string))
        {
            // to ensure "className" is required (not null)
            if (className == null)
            {
                throw new InvalidDataException("className is a required property for MailAccountReceiveSettingsDTO and cannot be null");
            }
            else
            {
                this.ClassName = className;
            }
            this.AuthenticationMode = authenticationMode;
            this.TenantId = tenantId;
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.IsClientSecretSet = isClientSecretSet;
            this.IsAuthorizationResponseSet = isAuthorizationResponseSet;
            this.AuthorizationResponse = authorizationResponse;
        }
        
        /// <summary>
        /// Name of class
        /// </summary>
        /// <value>Name of class</value>
        [DataMember(Name="className", EmitDefaultValue=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// Possible values:  0: Basic  1: Microsoft  2: Google 
        /// </summary>
        /// <value>Possible values:  0: Basic  1: Microsoft  2: Google </value>
        [DataMember(Name="authenticationMode", EmitDefaultValue=false)]
        public int? AuthenticationMode { get; set; }

        /// <summary>
        /// The tenant ID
        /// </summary>
        /// <value>The tenant ID</value>
        [DataMember(Name="tenantId", EmitDefaultValue=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// The client ID
        /// </summary>
        /// <value>The client ID</value>
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// The client Secret
        /// </summary>
        /// <value>The client Secret</value>
        [DataMember(Name="clientSecret", EmitDefaultValue=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Gets or sets whether the client secret is set
        /// </summary>
        /// <value>Gets or sets whether the client secret is set</value>
        [DataMember(Name="isClientSecretSet", EmitDefaultValue=false)]
        public bool? IsClientSecretSet { get; set; }

        /// <summary>
        /// Gets or sets whether the authorization response is set
        /// </summary>
        /// <value>Gets or sets whether the authorization response is set</value>
        [DataMember(Name="isAuthorizationResponseSet", EmitDefaultValue=false)]
        public bool? IsAuthorizationResponseSet { get; set; }

        /// <summary>
        /// The authorization response
        /// </summary>
        /// <value>The authorization response</value>
        [DataMember(Name="authorizationResponse", EmitDefaultValue=false)]
        public string AuthorizationResponse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MailAccountReceiveSettingsDTO {\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
            sb.Append("  AuthenticationMode: ").Append(AuthenticationMode).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  IsClientSecretSet: ").Append(IsClientSecretSet).Append("\n");
            sb.Append("  IsAuthorizationResponseSet: ").Append(IsAuthorizationResponseSet).Append("\n");
            sb.Append("  AuthorizationResponse: ").Append(AuthorizationResponse).Append("\n");
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
            return this.Equals(input as MailAccountReceiveSettingsDTO);
        }

        /// <summary>
        /// Returns true if MailAccountReceiveSettingsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MailAccountReceiveSettingsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MailAccountReceiveSettingsDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClassName == input.ClassName ||
                    (this.ClassName != null &&
                    this.ClassName.Equals(input.ClassName))
                ) && 
                (
                    this.AuthenticationMode == input.AuthenticationMode ||
                    (this.AuthenticationMode != null &&
                    this.AuthenticationMode.Equals(input.AuthenticationMode))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.ClientSecret == input.ClientSecret ||
                    (this.ClientSecret != null &&
                    this.ClientSecret.Equals(input.ClientSecret))
                ) && 
                (
                    this.IsClientSecretSet == input.IsClientSecretSet ||
                    (this.IsClientSecretSet != null &&
                    this.IsClientSecretSet.Equals(input.IsClientSecretSet))
                ) && 
                (
                    this.IsAuthorizationResponseSet == input.IsAuthorizationResponseSet ||
                    (this.IsAuthorizationResponseSet != null &&
                    this.IsAuthorizationResponseSet.Equals(input.IsAuthorizationResponseSet))
                ) && 
                (
                    this.AuthorizationResponse == input.AuthorizationResponse ||
                    (this.AuthorizationResponse != null &&
                    this.AuthorizationResponse.Equals(input.AuthorizationResponse))
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
                if (this.ClassName != null)
                    hashCode = hashCode * 59 + this.ClassName.GetHashCode();
                if (this.AuthenticationMode != null)
                    hashCode = hashCode * 59 + this.AuthenticationMode.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.ClientSecret != null)
                    hashCode = hashCode * 59 + this.ClientSecret.GetHashCode();
                if (this.IsClientSecretSet != null)
                    hashCode = hashCode * 59 + this.IsClientSecretSet.GetHashCode();
                if (this.IsAuthorizationResponseSet != null)
                    hashCode = hashCode * 59 + this.IsAuthorizationResponseSet.GetHashCode();
                if (this.AuthorizationResponse != null)
                    hashCode = hashCode * 59 + this.AuthorizationResponse.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
