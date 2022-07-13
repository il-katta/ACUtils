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
    /// IxCeDocumentDetailDTO
    /// </summary>
    [DataContract]
    public partial class IxCeDocumentDetailDTO :  IEquatable<IxCeDocumentDetailDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IxCeDocumentDetailDTO" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="ixCeServiceId">ixCeServiceId.</param>
        /// <param name="status">Possible values:  0: Error  1: Inserted  2: ConnectorTakeCharge  3: ConnectorError  4: TakeChargeError  5: IxceTakeCharge  6: ToValidate  7: Validated  8: InError  9: Discarded  10: Preserved .</param>
        /// <param name="message">message.</param>
        /// <param name="creationDate">creationDate.</param>
        public IxCeDocumentDetailDTO(int? id = default(int?), int? ixCeServiceId = default(int?), int? status = default(int?), string message = default(string), DateTime? creationDate = default(DateTime?))
        {
            this.Id = id;
            this.IxCeServiceId = ixCeServiceId;
            this.Status = status;
            this.Message = message;
            this.CreationDate = creationDate;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets IxCeServiceId
        /// </summary>
        [DataMember(Name="ixCeServiceId", EmitDefaultValue=false)]
        public int? IxCeServiceId { get; set; }

        /// <summary>
        /// Possible values:  0: Error  1: Inserted  2: ConnectorTakeCharge  3: ConnectorError  4: TakeChargeError  5: IxceTakeCharge  6: ToValidate  7: Validated  8: InError  9: Discarded  10: Preserved 
        /// </summary>
        /// <value>Possible values:  0: Error  1: Inserted  2: ConnectorTakeCharge  3: ConnectorError  4: TakeChargeError  5: IxceTakeCharge  6: ToValidate  7: Validated  8: InError  9: Discarded  10: Preserved </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets CreationDate
        /// </summary>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IxCeDocumentDetailDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IxCeServiceId: ").Append(IxCeServiceId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
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
            return this.Equals(input as IxCeDocumentDetailDTO);
        }

        /// <summary>
        /// Returns true if IxCeDocumentDetailDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of IxCeDocumentDetailDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IxCeDocumentDetailDTO input)
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
                    this.IxCeServiceId == input.IxCeServiceId ||
                    (this.IxCeServiceId != null &&
                    this.IxCeServiceId.Equals(input.IxCeServiceId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
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
                if (this.IxCeServiceId != null)
                    hashCode = hashCode * 59 + this.IxCeServiceId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
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