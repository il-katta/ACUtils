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
    /// Class of authentication refresh token request
    /// </summary>
    [DataContract]
        public partial class AuthenticationRefreshTokenRequestDTO :  IEquatable<AuthenticationRefreshTokenRequestDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationRefreshTokenRequestDTO" /> class.
        /// </summary>
        /// <param name="clientId">Client Identifier (required).</param>
        /// <param name="clientSecret">Client Secret (required).</param>
        /// <param name="refreshToken">Refresh Token (required).</param>
        public AuthenticationRefreshTokenRequestDTO(string clientId = default(string), string clientSecret = default(string), string refreshToken = default(string))
        {
            // to ensure "clientId" is required (not null)
            if (clientId == null)
            {
                throw new InvalidDataException("clientId is a required property for AuthenticationRefreshTokenRequestDTO and cannot be null");
            }
            else
            {
                this.ClientId = clientId;
            }
            // to ensure "clientSecret" is required (not null)
            if (clientSecret == null)
            {
                throw new InvalidDataException("clientSecret is a required property for AuthenticationRefreshTokenRequestDTO and cannot be null");
            }
            else
            {
                this.ClientSecret = clientSecret;
            }
            // to ensure "refreshToken" is required (not null)
            if (refreshToken == null)
            {
                throw new InvalidDataException("refreshToken is a required property for AuthenticationRefreshTokenRequestDTO and cannot be null");
            }
            else
            {
                this.RefreshToken = refreshToken;
            }
        }
        
        /// <summary>
        /// Client Identifier
        /// </summary>
        /// <value>Client Identifier</value>
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Client Secret
        /// </summary>
        /// <value>Client Secret</value>
        [DataMember(Name="clientSecret", EmitDefaultValue=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Refresh Token
        /// </summary>
        /// <value>Refresh Token</value>
        [DataMember(Name="refreshToken", EmitDefaultValue=false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthenticationRefreshTokenRequestDTO {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
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
            return this.Equals(input as AuthenticationRefreshTokenRequestDTO);
        }

        /// <summary>
        /// Returns true if AuthenticationRefreshTokenRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthenticationRefreshTokenRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticationRefreshTokenRequestDTO input)
        {
            if (input == null)
                return false;

            return 
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
                    this.RefreshToken == input.RefreshToken ||
                    (this.RefreshToken != null &&
                    this.RefreshToken.Equals(input.RefreshToken))
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
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.ClientSecret != null)
                    hashCode = hashCode * 59 + this.ClientSecret.GetHashCode();
                if (this.RefreshToken != null)
                    hashCode = hashCode * 59 + this.RefreshToken.GetHashCode();
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
