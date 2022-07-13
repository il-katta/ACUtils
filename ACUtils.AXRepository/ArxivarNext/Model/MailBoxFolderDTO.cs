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
    /// Class for mail box folder information
    /// </summary>
    [DataContract]
    public partial class MailBoxFolderDTO :  IEquatable<MailBoxFolderDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailBoxFolderDTO" /> class.
        /// </summary>
        /// <param name="name">Folder name.</param>
        /// <param name="fullName">Folder path.</param>
        /// <param name="subFolders">Subfolders.</param>
        public MailBoxFolderDTO(string name = default(string), string fullName = default(string), List<MailBoxFolderDTO> subFolders = default(List<MailBoxFolderDTO>))
        {
            this.Name = name;
            this.FullName = fullName;
            this.SubFolders = subFolders;
        }
        
        /// <summary>
        /// Folder name
        /// </summary>
        /// <value>Folder name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Folder path
        /// </summary>
        /// <value>Folder path</value>
        [DataMember(Name="fullName", EmitDefaultValue=false)]
        public string FullName { get; set; }

        /// <summary>
        /// Subfolders
        /// </summary>
        /// <value>Subfolders</value>
        [DataMember(Name="subFolders", EmitDefaultValue=false)]
        public List<MailBoxFolderDTO> SubFolders { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MailBoxFolderDTO {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  SubFolders: ").Append(SubFolders).Append("\n");
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
            return this.Equals(input as MailBoxFolderDTO);
        }

        /// <summary>
        /// Returns true if MailBoxFolderDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MailBoxFolderDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MailBoxFolderDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.SubFolders == input.SubFolders ||
                    this.SubFolders != null &&
                    this.SubFolders.SequenceEqual(input.SubFolders)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.FullName != null)
                    hashCode = hashCode * 59 + this.FullName.GetHashCode();
                if (this.SubFolders != null)
                    hashCode = hashCode * 59 + this.SubFolders.GetHashCode();
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
