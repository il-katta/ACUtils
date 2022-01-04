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
    /// Class of Select data
    /// </summary>
    [DataContract]
        public partial class SelectDTO :  IEquatable<SelectDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectDTO" /> class.
        /// </summary>
        /// <param name="fields">Fields.</param>
        /// <param name="maxItems">Maximum Number of items.</param>
        public SelectDTO(List<FieldBaseForSelectDTO> fields = default(List<FieldBaseForSelectDTO>), int? maxItems = default(int?))
        {
            this.Fields = fields;
            this.MaxItems = maxItems;
        }
        
        /// <summary>
        /// Fields
        /// </summary>
        /// <value>Fields</value>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<FieldBaseForSelectDTO> Fields { get; set; }

        /// <summary>
        /// Maximum Number of items
        /// </summary>
        /// <value>Maximum Number of items</value>
        [DataMember(Name="maxItems", EmitDefaultValue=false)]
        public int? MaxItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SelectDTO {\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  MaxItems: ").Append(MaxItems).Append("\n");
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
            return this.Equals(input as SelectDTO);
        }

        /// <summary>
        /// Returns true if SelectDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SelectDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelectDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.MaxItems == input.MaxItems ||
                    (this.MaxItems != null &&
                    this.MaxItems.Equals(input.MaxItems))
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
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.MaxItems != null)
                    hashCode = hashCode * 59 + this.MaxItems.GetHashCode();
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
