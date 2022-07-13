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
    /// EditProcessDocRequestDTO
    /// </summary>
    [DataContract]
    public partial class EditProcessDocRequestDTO :  IEquatable<EditProcessDocRequestDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditProcessDocRequestDTO" /> class.
        /// </summary>
        /// <param name="accessToken">accessToken.</param>
        /// <param name="processDocId">processDocId.</param>
        /// <param name="taskWorkId">taskWorkId.</param>
        /// <param name="externalAppType">Possible values:  0: Office365 .</param>
        public EditProcessDocRequestDTO(string accessToken = default(string), int? processDocId = default(int?), int? taskWorkId = default(int?), int? externalAppType = default(int?))
        {
            this.AccessToken = accessToken;
            this.ProcessDocId = processDocId;
            this.TaskWorkId = taskWorkId;
            this.ExternalAppType = externalAppType;
        }
        
        /// <summary>
        /// Gets or Sets AccessToken
        /// </summary>
        [DataMember(Name="accessToken", EmitDefaultValue=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or Sets ProcessDocId
        /// </summary>
        [DataMember(Name="processDocId", EmitDefaultValue=false)]
        public int? ProcessDocId { get; set; }

        /// <summary>
        /// Gets or Sets TaskWorkId
        /// </summary>
        [DataMember(Name="taskWorkId", EmitDefaultValue=false)]
        public int? TaskWorkId { get; set; }

        /// <summary>
        /// Possible values:  0: Office365 
        /// </summary>
        /// <value>Possible values:  0: Office365 </value>
        [DataMember(Name="externalAppType", EmitDefaultValue=false)]
        public int? ExternalAppType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EditProcessDocRequestDTO {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  ProcessDocId: ").Append(ProcessDocId).Append("\n");
            sb.Append("  TaskWorkId: ").Append(TaskWorkId).Append("\n");
            sb.Append("  ExternalAppType: ").Append(ExternalAppType).Append("\n");
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
            return this.Equals(input as EditProcessDocRequestDTO);
        }

        /// <summary>
        /// Returns true if EditProcessDocRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EditProcessDocRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EditProcessDocRequestDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessToken == input.AccessToken ||
                    (this.AccessToken != null &&
                    this.AccessToken.Equals(input.AccessToken))
                ) && 
                (
                    this.ProcessDocId == input.ProcessDocId ||
                    (this.ProcessDocId != null &&
                    this.ProcessDocId.Equals(input.ProcessDocId))
                ) && 
                (
                    this.TaskWorkId == input.TaskWorkId ||
                    (this.TaskWorkId != null &&
                    this.TaskWorkId.Equals(input.TaskWorkId))
                ) && 
                (
                    this.ExternalAppType == input.ExternalAppType ||
                    (this.ExternalAppType != null &&
                    this.ExternalAppType.Equals(input.ExternalAppType))
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
                if (this.AccessToken != null)
                    hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
                if (this.ProcessDocId != null)
                    hashCode = hashCode * 59 + this.ProcessDocId.GetHashCode();
                if (this.TaskWorkId != null)
                    hashCode = hashCode * 59 + this.TaskWorkId.GetHashCode();
                if (this.ExternalAppType != null)
                    hashCode = hashCode * 59 + this.ExternalAppType.GetHashCode();
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
