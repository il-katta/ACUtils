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
    /// BusinessUnitSetupParamsDTO
    /// </summary>
    [DataContract]
    public partial class BusinessUnitSetupParamsDTO :  IEquatable<BusinessUnitSetupParamsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessUnitSetupParamsDTO" /> class.
        /// </summary>
        /// <param name="codAmm">CodAmm.</param>
        /// <param name="idPa">IdPa.</param>
        public BusinessUnitSetupParamsDTO(string codAmm = default(string), string idPa = default(string))
        {
            this.CodAmm = codAmm;
            this.IdPa = idPa;
        }
        
        /// <summary>
        /// CodAmm
        /// </summary>
        /// <value>CodAmm</value>
        [DataMember(Name="codAmm", EmitDefaultValue=false)]
        public string CodAmm { get; set; }

        /// <summary>
        /// IdPa
        /// </summary>
        /// <value>IdPa</value>
        [DataMember(Name="idPa", EmitDefaultValue=false)]
        public string IdPa { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessUnitSetupParamsDTO {\n");
            sb.Append("  CodAmm: ").Append(CodAmm).Append("\n");
            sb.Append("  IdPa: ").Append(IdPa).Append("\n");
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
            return this.Equals(input as BusinessUnitSetupParamsDTO);
        }

        /// <summary>
        /// Returns true if BusinessUnitSetupParamsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessUnitSetupParamsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessUnitSetupParamsDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CodAmm == input.CodAmm ||
                    (this.CodAmm != null &&
                    this.CodAmm.Equals(input.CodAmm))
                ) && 
                (
                    this.IdPa == input.IdPa ||
                    (this.IdPa != null &&
                    this.IdPa.Equals(input.IdPa))
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
                if (this.CodAmm != null)
                    hashCode = hashCode * 59 + this.CodAmm.GetHashCode();
                if (this.IdPa != null)
                    hashCode = hashCode * 59 + this.IdPa.GetHashCode();
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