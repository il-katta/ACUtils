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
    /// Class of document type: users masks
    /// </summary>
    [DataContract]
    public partial class UsersMasksDTO :  IEquatable<UsersMasksDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersMasksDTO" /> class.
        /// </summary>
        /// <param name="documentType">Document type.</param>
        /// <param name="defaultMask">Default document Type Mask.</param>
        /// <param name="usersMasks">Users masks.</param>
        public UsersMasksDTO(DocumentTypeSimpleDTO documentType = default(DocumentTypeSimpleDTO), MaskSimpleDTO defaultMask = default(MaskSimpleDTO), List<UserMaskDTO> usersMasks = default(List<UserMaskDTO>))
        {
            this.DocumentType = documentType;
            this.DefaultMask = defaultMask;
            this.UsersMasks = usersMasks;
        }
        
        /// <summary>
        /// Document type
        /// </summary>
        /// <value>Document type</value>
        [DataMember(Name="documentType", EmitDefaultValue=false)]
        public DocumentTypeSimpleDTO DocumentType { get; set; }

        /// <summary>
        /// Default document Type Mask
        /// </summary>
        /// <value>Default document Type Mask</value>
        [DataMember(Name="defaultMask", EmitDefaultValue=false)]
        public MaskSimpleDTO DefaultMask { get; set; }

        /// <summary>
        /// Users masks
        /// </summary>
        /// <value>Users masks</value>
        [DataMember(Name="usersMasks", EmitDefaultValue=false)]
        public List<UserMaskDTO> UsersMasks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsersMasksDTO {\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  DefaultMask: ").Append(DefaultMask).Append("\n");
            sb.Append("  UsersMasks: ").Append(UsersMasks).Append("\n");
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
            return this.Equals(input as UsersMasksDTO);
        }

        /// <summary>
        /// Returns true if UsersMasksDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of UsersMasksDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsersMasksDTO input)
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
                    this.DefaultMask == input.DefaultMask ||
                    (this.DefaultMask != null &&
                    this.DefaultMask.Equals(input.DefaultMask))
                ) && 
                (
                    this.UsersMasks == input.UsersMasks ||
                    this.UsersMasks != null &&
                    this.UsersMasks.SequenceEqual(input.UsersMasks)
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
                if (this.DefaultMask != null)
                    hashCode = hashCode * 59 + this.DefaultMask.GetHashCode();
                if (this.UsersMasks != null)
                    hashCode = hashCode * 59 + this.UsersMasks.GetHashCode();
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