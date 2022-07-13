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
    /// Class for mail settings
    /// </summary>
    [DataContract]
    public partial class MailAccountSettingsDTO :  IEquatable<MailAccountSettingsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailAccountSettingsDTO" /> class.
        /// </summary>
        /// <param name="general">Mail general settings.</param>
        /// <param name="_in">Mail IN settings.</param>
        /// <param name="_out">Mail OUT settings.</param>
        public MailAccountSettingsDTO(MailAccountSettingsGeneralDTO general = default(MailAccountSettingsGeneralDTO), MailAccountSettingsInDTO _in = default(MailAccountSettingsInDTO), MailAccountSettingsOutDTO _out = default(MailAccountSettingsOutDTO))
        {
            this.General = general;
            this.In = _in;
            this.Out = _out;
        }
        
        /// <summary>
        /// Mail general settings
        /// </summary>
        /// <value>Mail general settings</value>
        [DataMember(Name="general", EmitDefaultValue=false)]
        public MailAccountSettingsGeneralDTO General { get; set; }

        /// <summary>
        /// Mail IN settings
        /// </summary>
        /// <value>Mail IN settings</value>
        [DataMember(Name="in", EmitDefaultValue=false)]
        public MailAccountSettingsInDTO In { get; set; }

        /// <summary>
        /// Mail OUT settings
        /// </summary>
        /// <value>Mail OUT settings</value>
        [DataMember(Name="out", EmitDefaultValue=false)]
        public MailAccountSettingsOutDTO Out { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MailAccountSettingsDTO {\n");
            sb.Append("  General: ").Append(General).Append("\n");
            sb.Append("  In: ").Append(In).Append("\n");
            sb.Append("  Out: ").Append(Out).Append("\n");
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
            return this.Equals(input as MailAccountSettingsDTO);
        }

        /// <summary>
        /// Returns true if MailAccountSettingsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MailAccountSettingsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MailAccountSettingsDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.General == input.General ||
                    (this.General != null &&
                    this.General.Equals(input.General))
                ) && 
                (
                    this.In == input.In ||
                    (this.In != null &&
                    this.In.Equals(input.In))
                ) && 
                (
                    this.Out == input.Out ||
                    (this.Out != null &&
                    this.Out.Equals(input.Out))
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
                if (this.General != null)
                    hashCode = hashCode * 59 + this.General.GetHashCode();
                if (this.In != null)
                    hashCode = hashCode * 59 + this.In.GetHashCode();
                if (this.Out != null)
                    hashCode = hashCode * 59 + this.Out.GetHashCode();
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
