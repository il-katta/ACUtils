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
    /// PnDeviceDTO
    /// </summary>
    [DataContract]
    public partial class PnDeviceDTO :  IEquatable<PnDeviceDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PnDeviceDTO" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="userId">userId.</param>
        /// <param name="deviceKind">Possible values:  0: Ios  1: Android  2: WindowsPhone .</param>
        /// <param name="token">token.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="appKind">Possible values:  0: ArxMobile  1: ArxMobileTasks  2: ArxMobileNext .</param>
        public PnDeviceDTO(int? id = default(int?), int? userId = default(int?), int? deviceKind = default(int?), string token = default(string), bool? enabled = default(bool?), int? appKind = default(int?))
        {
            this.Id = id;
            this.UserId = userId;
            this.DeviceKind = deviceKind;
            this.Token = token;
            this.Enabled = enabled;
            this.AppKind = appKind;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Possible values:  0: Ios  1: Android  2: WindowsPhone 
        /// </summary>
        /// <value>Possible values:  0: Ios  1: Android  2: WindowsPhone </value>
        [DataMember(Name="deviceKind", EmitDefaultValue=false)]
        public int? DeviceKind { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Possible values:  0: ArxMobile  1: ArxMobileTasks  2: ArxMobileNext 
        /// </summary>
        /// <value>Possible values:  0: ArxMobile  1: ArxMobileTasks  2: ArxMobileNext </value>
        [DataMember(Name="appKind", EmitDefaultValue=false)]
        public int? AppKind { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PnDeviceDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  DeviceKind: ").Append(DeviceKind).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  AppKind: ").Append(AppKind).Append("\n");
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
            return this.Equals(input as PnDeviceDTO);
        }

        /// <summary>
        /// Returns true if PnDeviceDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of PnDeviceDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PnDeviceDTO input)
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
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.DeviceKind == input.DeviceKind ||
                    (this.DeviceKind != null &&
                    this.DeviceKind.Equals(input.DeviceKind))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.AppKind == input.AppKind ||
                    (this.AppKind != null &&
                    this.AppKind.Equals(input.AppKind))
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.DeviceKind != null)
                    hashCode = hashCode * 59 + this.DeviceKind.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.AppKind != null)
                    hashCode = hashCode * 59 + this.AppKind.GetHashCode();
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
