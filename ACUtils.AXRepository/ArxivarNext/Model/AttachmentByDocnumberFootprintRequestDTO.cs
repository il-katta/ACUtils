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
    /// Class for get attachment by docnumber and footprint
    /// </summary>
    [DataContract]
    public partial class AttachmentByDocnumberFootprintRequestDTO :  IEquatable<AttachmentByDocnumberFootprintRequestDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentByDocnumberFootprintRequestDTO" /> class.
        /// </summary>
        /// <param name="docnumber">Document Identifier.</param>
        /// <param name="footprint">Hash of the file.</param>
        public AttachmentByDocnumberFootprintRequestDTO(int? docnumber = default(int?), string footprint = default(string))
        {
            this.Docnumber = docnumber;
            this.Footprint = footprint;
        }
        
        /// <summary>
        /// Document Identifier
        /// </summary>
        /// <value>Document Identifier</value>
        [DataMember(Name="docnumber", EmitDefaultValue=false)]
        public int? Docnumber { get; set; }

        /// <summary>
        /// Hash of the file
        /// </summary>
        /// <value>Hash of the file</value>
        [DataMember(Name="footprint", EmitDefaultValue=false)]
        public string Footprint { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachmentByDocnumberFootprintRequestDTO {\n");
            sb.Append("  Docnumber: ").Append(Docnumber).Append("\n");
            sb.Append("  Footprint: ").Append(Footprint).Append("\n");
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
            return this.Equals(input as AttachmentByDocnumberFootprintRequestDTO);
        }

        /// <summary>
        /// Returns true if AttachmentByDocnumberFootprintRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AttachmentByDocnumberFootprintRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttachmentByDocnumberFootprintRequestDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Docnumber == input.Docnumber ||
                    (this.Docnumber != null &&
                    this.Docnumber.Equals(input.Docnumber))
                ) && 
                (
                    this.Footprint == input.Footprint ||
                    (this.Footprint != null &&
                    this.Footprint.Equals(input.Footprint))
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
                if (this.Docnumber != null)
                    hashCode = hashCode * 59 + this.Docnumber.GetHashCode();
                if (this.Footprint != null)
                    hashCode = hashCode * 59 + this.Footprint.GetHashCode();
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
