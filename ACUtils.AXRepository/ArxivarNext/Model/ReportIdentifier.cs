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
    /// ReportIdentifier
    /// </summary>
    [DataContract]
        public partial class ReportIdentifier :  IEquatable<ReportIdentifier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportIdentifier" /> class.
        /// </summary>
        /// <param name="identifier">The Id or ExternalId of the report.</param>
        /// <param name="identifierType">Possible values:  1: Id  2: ExternalId .</param>
        public ReportIdentifier(string identifier = default(string), int? identifierType = default(int?))
        {
            this.Identifier = identifier;
            this.IdentifierType = identifierType;
        }
        
        /// <summary>
        /// The Id or ExternalId of the report
        /// </summary>
        /// <value>The Id or ExternalId of the report</value>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// Possible values:  1: Id  2: ExternalId 
        /// </summary>
        /// <value>Possible values:  1: Id  2: ExternalId </value>
        [DataMember(Name="identifierType", EmitDefaultValue=false)]
        public int? IdentifierType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportIdentifier {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  IdentifierType: ").Append(IdentifierType).Append("\n");
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
            return this.Equals(input as ReportIdentifier);
        }

        /// <summary>
        /// Returns true if ReportIdentifier instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportIdentifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportIdentifier input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.IdentifierType == input.IdentifierType ||
                    (this.IdentifierType != null &&
                    this.IdentifierType.Equals(input.IdentifierType))
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
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.IdentifierType != null)
                    hashCode = hashCode * 59 + this.IdentifierType.GetHashCode();
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
