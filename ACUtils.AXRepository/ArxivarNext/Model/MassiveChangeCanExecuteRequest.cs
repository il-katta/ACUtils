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
    /// Dto for check massive change operation for the user
    /// </summary>
    [DataContract]
    public partial class MassiveChangeCanExecuteRequest :  IEquatable<MassiveChangeCanExecuteRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MassiveChangeCanExecuteRequest" /> class.
        /// </summary>
        /// <param name="docnumbers">Docnumbers to massive change.</param>
        public MassiveChangeCanExecuteRequest(List<int?> docnumbers = default(List<int?>))
        {
            this.Docnumbers = docnumbers;
        }
        
        /// <summary>
        /// Docnumbers to massive change
        /// </summary>
        /// <value>Docnumbers to massive change</value>
        [DataMember(Name="docnumbers", EmitDefaultValue=false)]
        public List<int?> Docnumbers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MassiveChangeCanExecuteRequest {\n");
            sb.Append("  Docnumbers: ").Append(Docnumbers).Append("\n");
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
            return this.Equals(input as MassiveChangeCanExecuteRequest);
        }

        /// <summary>
        /// Returns true if MassiveChangeCanExecuteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MassiveChangeCanExecuteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MassiveChangeCanExecuteRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Docnumbers == input.Docnumbers ||
                    this.Docnumbers != null &&
                    this.Docnumbers.SequenceEqual(input.Docnumbers)
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
                if (this.Docnumbers != null)
                    hashCode = hashCode * 59 + this.Docnumbers.GetHashCode();
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
