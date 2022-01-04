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
    /// RelationNodeDTO
    /// </summary>
    [DataContract]
        public partial class RelationNodeDTO :  IEquatable<RelationNodeDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelationNodeDTO" /> class.
        /// </summary>
        /// <param name="docNumber">Docnumber of profile.</param>
        /// <param name="documentType">Document type system id.</param>
        /// <param name="description">Description of this node.</param>
        /// <param name="isGroup">Id group.</param>
        /// <param name="accessDenied">Access denied for the user.</param>
        /// <param name="childs">Child nodes.</param>
        public RelationNodeDTO(int? docNumber = default(int?), int? documentType = default(int?), string description = default(string), bool? isGroup = default(bool?), bool? accessDenied = default(bool?), List<RelationNodeDTO> childs = default(List<RelationNodeDTO>))
        {
            this.DocNumber = docNumber;
            this.DocumentType = documentType;
            this.Description = description;
            this.IsGroup = isGroup;
            this.AccessDenied = accessDenied;
            this.Childs = childs;
        }
        
        /// <summary>
        /// Docnumber of profile
        /// </summary>
        /// <value>Docnumber of profile</value>
        [DataMember(Name="docNumber", EmitDefaultValue=false)]
        public int? DocNumber { get; set; }

        /// <summary>
        /// Document type system id
        /// </summary>
        /// <value>Document type system id</value>
        [DataMember(Name="documentType", EmitDefaultValue=false)]
        public int? DocumentType { get; set; }

        /// <summary>
        /// Description of this node
        /// </summary>
        /// <value>Description of this node</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Id group
        /// </summary>
        /// <value>Id group</value>
        [DataMember(Name="isGroup", EmitDefaultValue=false)]
        public bool? IsGroup { get; set; }

        /// <summary>
        /// Access denied for the user
        /// </summary>
        /// <value>Access denied for the user</value>
        [DataMember(Name="accessDenied", EmitDefaultValue=false)]
        public bool? AccessDenied { get; set; }

        /// <summary>
        /// Child nodes
        /// </summary>
        /// <value>Child nodes</value>
        [DataMember(Name="childs", EmitDefaultValue=false)]
        public List<RelationNodeDTO> Childs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelationNodeDTO {\n");
            sb.Append("  DocNumber: ").Append(DocNumber).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsGroup: ").Append(IsGroup).Append("\n");
            sb.Append("  AccessDenied: ").Append(AccessDenied).Append("\n");
            sb.Append("  Childs: ").Append(Childs).Append("\n");
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
            return this.Equals(input as RelationNodeDTO);
        }

        /// <summary>
        /// Returns true if RelationNodeDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of RelationNodeDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelationNodeDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocNumber == input.DocNumber ||
                    (this.DocNumber != null &&
                    this.DocNumber.Equals(input.DocNumber))
                ) && 
                (
                    this.DocumentType == input.DocumentType ||
                    (this.DocumentType != null &&
                    this.DocumentType.Equals(input.DocumentType))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IsGroup == input.IsGroup ||
                    (this.IsGroup != null &&
                    this.IsGroup.Equals(input.IsGroup))
                ) && 
                (
                    this.AccessDenied == input.AccessDenied ||
                    (this.AccessDenied != null &&
                    this.AccessDenied.Equals(input.AccessDenied))
                ) && 
                (
                    this.Childs == input.Childs ||
                    this.Childs != null &&
                    input.Childs != null &&
                    this.Childs.SequenceEqual(input.Childs)
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
                if (this.DocNumber != null)
                    hashCode = hashCode * 59 + this.DocNumber.GetHashCode();
                if (this.DocumentType != null)
                    hashCode = hashCode * 59 + this.DocumentType.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsGroup != null)
                    hashCode = hashCode * 59 + this.IsGroup.GetHashCode();
                if (this.AccessDenied != null)
                    hashCode = hashCode * 59 + this.AccessDenied.GetHashCode();
                if (this.Childs != null)
                    hashCode = hashCode * 59 + this.Childs.GetHashCode();
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
