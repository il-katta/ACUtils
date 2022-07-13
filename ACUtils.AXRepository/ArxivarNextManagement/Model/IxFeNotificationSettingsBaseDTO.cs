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
    /// Class of IX-FE notification settings
    /// </summary>
    [DataContract]
    public partial class IxFeNotificationSettingsBaseDTO :  IEquatable<IxFeNotificationSettingsBaseDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IxFeNotificationSettingsBaseDTO" /> class.
        /// </summary>
        /// <param name="context">Possible values:  0: Internal  1: Sending  2: Receiving .</param>
        /// <param name="type">Notification type.</param>
        /// <param name="state">State.</param>
        public IxFeNotificationSettingsBaseDTO(int? context = default(int?), IxFeNotificationDTO type = default(IxFeNotificationDTO), StateSimpleDTO state = default(StateSimpleDTO))
        {
            this.Context = context;
            this.Type = type;
            this.State = state;
        }
        
        /// <summary>
        /// Possible values:  0: Internal  1: Sending  2: Receiving 
        /// </summary>
        /// <value>Possible values:  0: Internal  1: Sending  2: Receiving </value>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public int? Context { get; set; }

        /// <summary>
        /// Notification type
        /// </summary>
        /// <value>Notification type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public IxFeNotificationDTO Type { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateSimpleDTO State { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IxFeNotificationSettingsBaseDTO {\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as IxFeNotificationSettingsBaseDTO);
        }

        /// <summary>
        /// Returns true if IxFeNotificationSettingsBaseDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of IxFeNotificationSettingsBaseDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IxFeNotificationSettingsBaseDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.Context != null)
                    hashCode = hashCode * 59 + this.Context.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
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