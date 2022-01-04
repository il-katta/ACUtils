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
    /// Class of document type
    /// </summary>
    [DataContract]
        public partial class DocumentTypeBaseDTO :  IEquatable<DocumentTypeBaseDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentTypeBaseDTO" /> class.
        /// </summary>
        /// <param name="id">Unique identifier.</param>
        /// <param name="idParent">Identifier of the parent document type.</param>
        /// <param name="key">Complete key.</param>
        /// <param name="description">Description.</param>
        /// <param name="documentType">Identifier of the first level.</param>
        /// <param name="type2">Identifier of the second level.</param>
        /// <param name="type3">Identifier of the third level.</param>
        /// <param name="docState">Default value of the document status.</param>
        /// <param name="inOut">Default value of the document inout.</param>
        /// <param name="isLeaf">Defines if the document type no has underlying levels.</param>
        /// <param name="requireFile">Required file.</param>
        /// <param name="pa">Required Public Administration (PA).</param>
        /// <param name="paDefaultValue">Default value of the PA protocol check,.</param>
        public DocumentTypeBaseDTO(int? id = default(int?), int? idParent = default(int?), string key = default(string), string description = default(string), int? documentType = default(int?), int? type2 = default(int?), int? type3 = default(int?), string docState = default(string), int? inOut = default(int?), bool? isLeaf = default(bool?), int? requireFile = default(int?), int? pa = default(int?), bool? paDefaultValue = default(bool?))
        {
            this.Id = id;
            this.IdParent = idParent;
            this.Key = key;
            this.Description = description;
            this.DocumentType = documentType;
            this.Type2 = type2;
            this.Type3 = type3;
            this.DocState = docState;
            this.InOut = inOut;
            this.IsLeaf = isLeaf;
            this.RequireFile = requireFile;
            this.Pa = pa;
            this.PaDefaultValue = paDefaultValue;
        }
        
        /// <summary>
        /// Unique identifier
        /// </summary>
        /// <value>Unique identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Identifier of the parent document type
        /// </summary>
        /// <value>Identifier of the parent document type</value>
        [DataMember(Name="idParent", EmitDefaultValue=false)]
        public int? IdParent { get; set; }

        /// <summary>
        /// Complete key
        /// </summary>
        /// <value>Complete key</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Identifier of the first level
        /// </summary>
        /// <value>Identifier of the first level</value>
        [DataMember(Name="documentType", EmitDefaultValue=false)]
        public int? DocumentType { get; set; }

        /// <summary>
        /// Identifier of the second level
        /// </summary>
        /// <value>Identifier of the second level</value>
        [DataMember(Name="type2", EmitDefaultValue=false)]
        public int? Type2 { get; set; }

        /// <summary>
        /// Identifier of the third level
        /// </summary>
        /// <value>Identifier of the third level</value>
        [DataMember(Name="type3", EmitDefaultValue=false)]
        public int? Type3 { get; set; }

        /// <summary>
        /// Default value of the document status
        /// </summary>
        /// <value>Default value of the document status</value>
        [DataMember(Name="docState", EmitDefaultValue=false)]
        public string DocState { get; set; }

        /// <summary>
        /// Default value of the document inout
        /// </summary>
        /// <value>Default value of the document inout</value>
        [DataMember(Name="inOut", EmitDefaultValue=false)]
        public int? InOut { get; set; }

        /// <summary>
        /// Defines if the document type no has underlying levels
        /// </summary>
        /// <value>Defines if the document type no has underlying levels</value>
        [DataMember(Name="isLeaf", EmitDefaultValue=false)]
        public bool? IsLeaf { get; set; }

        /// <summary>
        /// Required file
        /// </summary>
        /// <value>Required file</value>
        [DataMember(Name="requireFile", EmitDefaultValue=false)]
        public int? RequireFile { get; set; }

        /// <summary>
        /// Required Public Administration (PA)
        /// </summary>
        /// <value>Required Public Administration (PA)</value>
        [DataMember(Name="pa", EmitDefaultValue=false)]
        public int? Pa { get; set; }

        /// <summary>
        /// Default value of the PA protocol check,
        /// </summary>
        /// <value>Default value of the PA protocol check,</value>
        [DataMember(Name="paDefaultValue", EmitDefaultValue=false)]
        public bool? PaDefaultValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentTypeBaseDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdParent: ").Append(IdParent).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  Type2: ").Append(Type2).Append("\n");
            sb.Append("  Type3: ").Append(Type3).Append("\n");
            sb.Append("  DocState: ").Append(DocState).Append("\n");
            sb.Append("  InOut: ").Append(InOut).Append("\n");
            sb.Append("  IsLeaf: ").Append(IsLeaf).Append("\n");
            sb.Append("  RequireFile: ").Append(RequireFile).Append("\n");
            sb.Append("  Pa: ").Append(Pa).Append("\n");
            sb.Append("  PaDefaultValue: ").Append(PaDefaultValue).Append("\n");
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
            return this.Equals(input as DocumentTypeBaseDTO);
        }

        /// <summary>
        /// Returns true if DocumentTypeBaseDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentTypeBaseDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentTypeBaseDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IdParent == input.IdParent ||
                    (this.IdParent != null &&
                    this.IdParent.Equals(input.IdParent))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DocumentType == input.DocumentType ||
                    (this.DocumentType != null &&
                    this.DocumentType.Equals(input.DocumentType))
                ) && 
                (
                    this.Type2 == input.Type2 ||
                    (this.Type2 != null &&
                    this.Type2.Equals(input.Type2))
                ) && 
                (
                    this.Type3 == input.Type3 ||
                    (this.Type3 != null &&
                    this.Type3.Equals(input.Type3))
                ) && 
                (
                    this.DocState == input.DocState ||
                    (this.DocState != null &&
                    this.DocState.Equals(input.DocState))
                ) && 
                (
                    this.InOut == input.InOut ||
                    (this.InOut != null &&
                    this.InOut.Equals(input.InOut))
                ) && 
                (
                    this.IsLeaf == input.IsLeaf ||
                    (this.IsLeaf != null &&
                    this.IsLeaf.Equals(input.IsLeaf))
                ) && 
                (
                    this.RequireFile == input.RequireFile ||
                    (this.RequireFile != null &&
                    this.RequireFile.Equals(input.RequireFile))
                ) && 
                (
                    this.Pa == input.Pa ||
                    (this.Pa != null &&
                    this.Pa.Equals(input.Pa))
                ) && 
                (
                    this.PaDefaultValue == input.PaDefaultValue ||
                    (this.PaDefaultValue != null &&
                    this.PaDefaultValue.Equals(input.PaDefaultValue))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IdParent != null)
                    hashCode = hashCode * 59 + this.IdParent.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DocumentType != null)
                    hashCode = hashCode * 59 + this.DocumentType.GetHashCode();
                if (this.Type2 != null)
                    hashCode = hashCode * 59 + this.Type2.GetHashCode();
                if (this.Type3 != null)
                    hashCode = hashCode * 59 + this.Type3.GetHashCode();
                if (this.DocState != null)
                    hashCode = hashCode * 59 + this.DocState.GetHashCode();
                if (this.InOut != null)
                    hashCode = hashCode * 59 + this.InOut.GetHashCode();
                if (this.IsLeaf != null)
                    hashCode = hashCode * 59 + this.IsLeaf.GetHashCode();
                if (this.RequireFile != null)
                    hashCode = hashCode * 59 + this.RequireFile.GetHashCode();
                if (this.Pa != null)
                    hashCode = hashCode * 59 + this.Pa.GetHashCode();
                if (this.PaDefaultValue != null)
                    hashCode = hashCode * 59 + this.PaDefaultValue.GetHashCode();
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
