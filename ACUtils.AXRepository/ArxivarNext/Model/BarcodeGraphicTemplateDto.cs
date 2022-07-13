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
    /// Class of Barcode Graphic Template
    /// </summary>
    [DataContract]
    public partial class BarcodeGraphicTemplateDto :  IEquatable<BarcodeGraphicTemplateDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BarcodeGraphicTemplateDto" /> class.
        /// </summary>
        /// <param name="graphicTemplateB64">Origin Blob.</param>
        /// <param name="templateDattableB64">Origin Datatable.</param>
        public BarcodeGraphicTemplateDto(string graphicTemplateB64 = default(string), string templateDattableB64 = default(string))
        {
            this.GraphicTemplateB64 = graphicTemplateB64;
            this.TemplateDattableB64 = templateDattableB64;
        }
        
        /// <summary>
        /// Origin Blob
        /// </summary>
        /// <value>Origin Blob</value>
        [DataMember(Name="graphicTemplateB64", EmitDefaultValue=false)]
        public string GraphicTemplateB64 { get; set; }

        /// <summary>
        /// Origin Datatable
        /// </summary>
        /// <value>Origin Datatable</value>
        [DataMember(Name="templateDattableB64", EmitDefaultValue=false)]
        public string TemplateDattableB64 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BarcodeGraphicTemplateDto {\n");
            sb.Append("  GraphicTemplateB64: ").Append(GraphicTemplateB64).Append("\n");
            sb.Append("  TemplateDattableB64: ").Append(TemplateDattableB64).Append("\n");
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
            return this.Equals(input as BarcodeGraphicTemplateDto);
        }

        /// <summary>
        /// Returns true if BarcodeGraphicTemplateDto instances are equal
        /// </summary>
        /// <param name="input">Instance of BarcodeGraphicTemplateDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BarcodeGraphicTemplateDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GraphicTemplateB64 == input.GraphicTemplateB64 ||
                    (this.GraphicTemplateB64 != null &&
                    this.GraphicTemplateB64.Equals(input.GraphicTemplateB64))
                ) && 
                (
                    this.TemplateDattableB64 == input.TemplateDattableB64 ||
                    (this.TemplateDattableB64 != null &&
                    this.TemplateDattableB64.Equals(input.TemplateDattableB64))
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
                if (this.GraphicTemplateB64 != null)
                    hashCode = hashCode * 59 + this.GraphicTemplateB64.GetHashCode();
                if (this.TemplateDattableB64 != null)
                    hashCode = hashCode * 59 + this.TemplateDattableB64.GetHashCode();
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
