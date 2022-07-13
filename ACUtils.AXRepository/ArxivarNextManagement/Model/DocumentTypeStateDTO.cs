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
    /// Class of document type: states
    /// </summary>
    [DataContract]
    public partial class DocumentTypeStateDTO :  IEquatable<DocumentTypeStateDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentTypeStateDTO" /> class.
        /// </summary>
        /// <param name="documentType">Document type.</param>
        /// <param name="stateId">State value.</param>
        /// <param name="state">State basic information for visualization.</param>
        public DocumentTypeStateDTO(DocumentTypeSimpleDTO documentType = default(DocumentTypeSimpleDTO), string stateId = default(string), StateSimpleDTO state = default(StateSimpleDTO))
        {
            this.DocumentType = documentType;
            this.StateId = stateId;
            this.State = state;
        }
        
        /// <summary>
        /// Document type
        /// </summary>
        /// <value>Document type</value>
        [DataMember(Name="documentType", EmitDefaultValue=false)]
        public DocumentTypeSimpleDTO DocumentType { get; set; }

        /// <summary>
        /// State value
        /// </summary>
        /// <value>State value</value>
        [DataMember(Name="stateId", EmitDefaultValue=false)]
        public string StateId { get; set; }

        /// <summary>
        /// State basic information for visualization
        /// </summary>
        /// <value>State basic information for visualization</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateSimpleDTO State { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentTypeStateDTO {\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  StateId: ").Append(StateId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as DocumentTypeStateDTO);
        }

        /// <summary>
        /// Returns true if DocumentTypeStateDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentTypeStateDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentTypeStateDTO input)
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
                    this.StateId == input.StateId ||
                    (this.StateId != null &&
                    this.StateId.Equals(input.StateId))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.StateId != null)
                    hashCode = hashCode * 59 + this.StateId.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
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
