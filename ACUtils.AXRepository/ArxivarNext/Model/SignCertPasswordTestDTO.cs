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
    /// SignCertPasswordTestDTO
    /// </summary>
    [DataContract]
    public partial class SignCertPasswordTestDTO :  IEquatable<SignCertPasswordTestDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignCertPasswordTestDTO" /> class.
        /// </summary>
        /// <param name="password">password.</param>
        /// <param name="otp">otp.</param>
        /// <param name="certRelatedId">For Remote Telecom Provider.</param>
        public SignCertPasswordTestDTO(string password = default(string), string otp = default(string), string certRelatedId = default(string))
        {
            this.Password = password;
            this.Otp = otp;
            this.CertRelatedId = certRelatedId;
        }
        
        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets Otp
        /// </summary>
        [DataMember(Name="otp", EmitDefaultValue=false)]
        public string Otp { get; set; }

        /// <summary>
        /// For Remote Telecom Provider
        /// </summary>
        /// <value>For Remote Telecom Provider</value>
        [DataMember(Name="certRelatedId", EmitDefaultValue=false)]
        public string CertRelatedId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignCertPasswordTestDTO {\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Otp: ").Append(Otp).Append("\n");
            sb.Append("  CertRelatedId: ").Append(CertRelatedId).Append("\n");
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
            return this.Equals(input as SignCertPasswordTestDTO);
        }

        /// <summary>
        /// Returns true if SignCertPasswordTestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SignCertPasswordTestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignCertPasswordTestDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Otp == input.Otp ||
                    (this.Otp != null &&
                    this.Otp.Equals(input.Otp))
                ) && 
                (
                    this.CertRelatedId == input.CertRelatedId ||
                    (this.CertRelatedId != null &&
                    this.CertRelatedId.Equals(input.CertRelatedId))
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
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Otp != null)
                    hashCode = hashCode * 59 + this.Otp.GetHashCode();
                if (this.CertRelatedId != null)
                    hashCode = hashCode * 59 + this.CertRelatedId.GetHashCode();
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
