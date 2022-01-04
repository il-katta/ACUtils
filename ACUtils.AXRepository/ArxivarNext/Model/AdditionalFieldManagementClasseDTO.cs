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
    /// Class for additional field of type ClasseBox
    /// </summary>
    [DataContract]
        public partial class AdditionalFieldManagementClasseDTO :  IEquatable<AdditionalFieldManagementClasseDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalFieldManagementClasseDTO" /> class.
        /// </summary>
        /// <param name="deleteRule">Possible values:  0: Cascade  1: Owned .</param>
        /// <param name="linkedDocumentType">linkedDocumentType.</param>
        /// <param name="maskForInsert">maskForInsert.</param>
        /// <param name="maskForView">maskForView.</param>
        /// <param name="showExpanded">Show expanded.</param>
        /// <param name="singleElement">Single element.</param>
        public AdditionalFieldManagementClasseDTO(int? deleteRule = default(int?), DocumentTypeSimpleDTO linkedDocumentType = default(DocumentTypeSimpleDTO), MaskSimpleDTO maskForInsert = default(MaskSimpleDTO), MaskSimpleDTO maskForView = default(MaskSimpleDTO), bool? showExpanded = default(bool?), bool? singleElement = default(bool?))
        {
            this.DeleteRule = deleteRule;
            this.LinkedDocumentType = linkedDocumentType;
            this.MaskForInsert = maskForInsert;
            this.MaskForView = maskForView;
            this.ShowExpanded = showExpanded;
            this.SingleElement = singleElement;
        }
        
        /// <summary>
        /// Possible values:  0: Cascade  1: Owned 
        /// </summary>
        /// <value>Possible values:  0: Cascade  1: Owned </value>
        [DataMember(Name="deleteRule", EmitDefaultValue=false)]
        public int? DeleteRule { get; set; }

        /// <summary>
        /// Gets or Sets LinkedDocumentType
        /// </summary>
        [DataMember(Name="linkedDocumentType", EmitDefaultValue=false)]
        public DocumentTypeSimpleDTO LinkedDocumentType { get; set; }

        /// <summary>
        /// Gets or Sets MaskForInsert
        /// </summary>
        [DataMember(Name="maskForInsert", EmitDefaultValue=false)]
        public MaskSimpleDTO MaskForInsert { get; set; }

        /// <summary>
        /// Gets or Sets MaskForView
        /// </summary>
        [DataMember(Name="maskForView", EmitDefaultValue=false)]
        public MaskSimpleDTO MaskForView { get; set; }

        /// <summary>
        /// Show expanded
        /// </summary>
        /// <value>Show expanded</value>
        [DataMember(Name="showExpanded", EmitDefaultValue=false)]
        public bool? ShowExpanded { get; set; }

        /// <summary>
        /// Single element
        /// </summary>
        /// <value>Single element</value>
        [DataMember(Name="singleElement", EmitDefaultValue=false)]
        public bool? SingleElement { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalFieldManagementClasseDTO {\n");
            sb.Append("  DeleteRule: ").Append(DeleteRule).Append("\n");
            sb.Append("  LinkedDocumentType: ").Append(LinkedDocumentType).Append("\n");
            sb.Append("  MaskForInsert: ").Append(MaskForInsert).Append("\n");
            sb.Append("  MaskForView: ").Append(MaskForView).Append("\n");
            sb.Append("  ShowExpanded: ").Append(ShowExpanded).Append("\n");
            sb.Append("  SingleElement: ").Append(SingleElement).Append("\n");
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
            return this.Equals(input as AdditionalFieldManagementClasseDTO);
        }

        /// <summary>
        /// Returns true if AdditionalFieldManagementClasseDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalFieldManagementClasseDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalFieldManagementClasseDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeleteRule == input.DeleteRule ||
                    (this.DeleteRule != null &&
                    this.DeleteRule.Equals(input.DeleteRule))
                ) && 
                (
                    this.LinkedDocumentType == input.LinkedDocumentType ||
                    (this.LinkedDocumentType != null &&
                    this.LinkedDocumentType.Equals(input.LinkedDocumentType))
                ) && 
                (
                    this.MaskForInsert == input.MaskForInsert ||
                    (this.MaskForInsert != null &&
                    this.MaskForInsert.Equals(input.MaskForInsert))
                ) && 
                (
                    this.MaskForView == input.MaskForView ||
                    (this.MaskForView != null &&
                    this.MaskForView.Equals(input.MaskForView))
                ) && 
                (
                    this.ShowExpanded == input.ShowExpanded ||
                    (this.ShowExpanded != null &&
                    this.ShowExpanded.Equals(input.ShowExpanded))
                ) && 
                (
                    this.SingleElement == input.SingleElement ||
                    (this.SingleElement != null &&
                    this.SingleElement.Equals(input.SingleElement))
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
                if (this.DeleteRule != null)
                    hashCode = hashCode * 59 + this.DeleteRule.GetHashCode();
                if (this.LinkedDocumentType != null)
                    hashCode = hashCode * 59 + this.LinkedDocumentType.GetHashCode();
                if (this.MaskForInsert != null)
                    hashCode = hashCode * 59 + this.MaskForInsert.GetHashCode();
                if (this.MaskForView != null)
                    hashCode = hashCode * 59 + this.MaskForView.GetHashCode();
                if (this.ShowExpanded != null)
                    hashCode = hashCode * 59 + this.ShowExpanded.GetHashCode();
                if (this.SingleElement != null)
                    hashCode = hashCode * 59 + this.SingleElement.GetHashCode();
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
