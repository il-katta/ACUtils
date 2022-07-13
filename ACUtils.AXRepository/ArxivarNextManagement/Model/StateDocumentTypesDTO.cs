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
    /// Class of document types of related to a document state
    /// </summary>
    [DataContract]
    public partial class StateDocumentTypesDTO :  IEquatable<StateDocumentTypesDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StateDocumentTypesDTO" /> class.
        /// </summary>
        /// <param name="state">State.</param>
        /// <param name="documentTypes">Document Type.</param>
        public StateDocumentTypesDTO(StateSimpleDTO state = default(StateSimpleDTO), List<DocumentTypeSimpleDTO> documentTypes = default(List<DocumentTypeSimpleDTO>))
        {
            this.State = state;
            this.DocumentTypes = documentTypes;
        }
        
        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateSimpleDTO State { get; set; }

        /// <summary>
        /// Document Type
        /// </summary>
        /// <value>Document Type</value>
        [DataMember(Name="documentTypes", EmitDefaultValue=false)]
        public List<DocumentTypeSimpleDTO> DocumentTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StateDocumentTypesDTO {\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  DocumentTypes: ").Append(DocumentTypes).Append("\n");
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
            return this.Equals(input as StateDocumentTypesDTO);
        }

        /// <summary>
        /// Returns true if StateDocumentTypesDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of StateDocumentTypesDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StateDocumentTypesDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.DocumentTypes == input.DocumentTypes ||
                    this.DocumentTypes != null &&
                    this.DocumentTypes.SequenceEqual(input.DocumentTypes)
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
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.DocumentTypes != null)
                    hashCode = hashCode * 59 + this.DocumentTypes.GetHashCode();
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