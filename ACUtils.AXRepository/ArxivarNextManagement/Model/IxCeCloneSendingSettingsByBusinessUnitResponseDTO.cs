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
    /// Class for business unit settings clone result in IX-CE
    /// </summary>
    [DataContract]
    public partial class IxCeCloneSendingSettingsByBusinessUnitResponseDTO :  IEquatable<IxCeCloneSendingSettingsByBusinessUnitResponseDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IxCeCloneSendingSettingsByBusinessUnitResponseDTO" /> class.
        /// </summary>
        /// <param name="cloneRequestId">Identifier of clone process in progress.</param>
        public IxCeCloneSendingSettingsByBusinessUnitResponseDTO(string cloneRequestId = default(string))
        {
            this.CloneRequestId = cloneRequestId;
        }
        
        /// <summary>
        /// Identifier of clone process in progress
        /// </summary>
        /// <value>Identifier of clone process in progress</value>
        [DataMember(Name="cloneRequestId", EmitDefaultValue=false)]
        public string CloneRequestId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IxCeCloneSendingSettingsByBusinessUnitResponseDTO {\n");
            sb.Append("  CloneRequestId: ").Append(CloneRequestId).Append("\n");
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
            return this.Equals(input as IxCeCloneSendingSettingsByBusinessUnitResponseDTO);
        }

        /// <summary>
        /// Returns true if IxCeCloneSendingSettingsByBusinessUnitResponseDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of IxCeCloneSendingSettingsByBusinessUnitResponseDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IxCeCloneSendingSettingsByBusinessUnitResponseDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CloneRequestId == input.CloneRequestId ||
                    (this.CloneRequestId != null &&
                    this.CloneRequestId.Equals(input.CloneRequestId))
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
                if (this.CloneRequestId != null)
                    hashCode = hashCode * 59 + this.CloneRequestId.GetHashCode();
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
