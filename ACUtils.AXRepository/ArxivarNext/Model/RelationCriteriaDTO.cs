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
    /// RelationCriteriaDTO
    /// </summary>
    [DataContract]
    public partial class RelationCriteriaDTO :  IEquatable<RelationCriteriaDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelationCriteriaDTO" /> class.
        /// </summary>
        /// <param name="docNumber">Document Identifier.</param>
        /// <param name="relationExploringMethod">Possible values:  0: Class  1: Fathers  2: childs .</param>
        /// <param name="select">Columns to show for the documents contained.</param>
        public RelationCriteriaDTO(int? docNumber = default(int?), int? relationExploringMethod = default(int?), SelectDTO select = default(SelectDTO))
        {
            this.DocNumber = docNumber;
            this.RelationExploringMethod = relationExploringMethod;
            this.Select = select;
        }
        
        /// <summary>
        /// Document Identifier
        /// </summary>
        /// <value>Document Identifier</value>
        [DataMember(Name="docNumber", EmitDefaultValue=false)]
        public int? DocNumber { get; set; }

        /// <summary>
        /// Possible values:  0: Class  1: Fathers  2: childs 
        /// </summary>
        /// <value>Possible values:  0: Class  1: Fathers  2: childs </value>
        [DataMember(Name="relationExploringMethod", EmitDefaultValue=false)]
        public int? RelationExploringMethod { get; set; }

        /// <summary>
        /// Columns to show for the documents contained
        /// </summary>
        /// <value>Columns to show for the documents contained</value>
        [DataMember(Name="select", EmitDefaultValue=false)]
        public SelectDTO Select { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelationCriteriaDTO {\n");
            sb.Append("  DocNumber: ").Append(DocNumber).Append("\n");
            sb.Append("  RelationExploringMethod: ").Append(RelationExploringMethod).Append("\n");
            sb.Append("  Select: ").Append(Select).Append("\n");
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
            return this.Equals(input as RelationCriteriaDTO);
        }

        /// <summary>
        /// Returns true if RelationCriteriaDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of RelationCriteriaDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelationCriteriaDTO input)
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
                    this.RelationExploringMethod == input.RelationExploringMethod ||
                    (this.RelationExploringMethod != null &&
                    this.RelationExploringMethod.Equals(input.RelationExploringMethod))
                ) && 
                (
                    this.Select == input.Select ||
                    (this.Select != null &&
                    this.Select.Equals(input.Select))
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
                if (this.RelationExploringMethod != null)
                    hashCode = hashCode * 59 + this.RelationExploringMethod.GetHashCode();
                if (this.Select != null)
                    hashCode = hashCode * 59 + this.Select.GetHashCode();
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
