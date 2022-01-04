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
    /// Class mail enqueud for send
    /// </summary>
    [DataContract]
        public partial class MailOutDTO :  IEquatable<MailOutDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailOutDTO" /> class.
        /// </summary>
        /// <param name="id">Unique Id of mail out.</param>
        /// <param name="senderId">Unique id for sender (Arxivar user).</param>
        /// <param name="messageId">Message Unique Id.</param>
        /// <param name="state">Possible values:  0: To_send  1: Sent  2: Not_Sent .</param>
        /// <param name="retryCount">Retry count for send.</param>
        /// <param name="smtpId">Smtp rule Id.</param>
        public MailOutDTO(int? id = default(int?), int? senderId = default(int?), int? messageId = default(int?), int? state = default(int?), int? retryCount = default(int?), int? smtpId = default(int?))
        {
            this.Id = id;
            this.SenderId = senderId;
            this.MessageId = messageId;
            this.State = state;
            this.RetryCount = retryCount;
            this.SmtpId = smtpId;
        }
        
        /// <summary>
        /// Unique Id of mail out
        /// </summary>
        /// <value>Unique Id of mail out</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Unique id for sender (Arxivar user)
        /// </summary>
        /// <value>Unique id for sender (Arxivar user)</value>
        [DataMember(Name="senderId", EmitDefaultValue=false)]
        public int? SenderId { get; set; }

        /// <summary>
        /// Message Unique Id
        /// </summary>
        /// <value>Message Unique Id</value>
        [DataMember(Name="messageId", EmitDefaultValue=false)]
        public int? MessageId { get; set; }

        /// <summary>
        /// Possible values:  0: To_send  1: Sent  2: Not_Sent 
        /// </summary>
        /// <value>Possible values:  0: To_send  1: Sent  2: Not_Sent </value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public int? State { get; set; }

        /// <summary>
        /// Retry count for send
        /// </summary>
        /// <value>Retry count for send</value>
        [DataMember(Name="retryCount", EmitDefaultValue=false)]
        public int? RetryCount { get; set; }

        /// <summary>
        /// Smtp rule Id
        /// </summary>
        /// <value>Smtp rule Id</value>
        [DataMember(Name="smtpId", EmitDefaultValue=false)]
        public int? SmtpId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MailOutDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SenderId: ").Append(SenderId).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  RetryCount: ").Append(RetryCount).Append("\n");
            sb.Append("  SmtpId: ").Append(SmtpId).Append("\n");
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
            return this.Equals(input as MailOutDTO);
        }

        /// <summary>
        /// Returns true if MailOutDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MailOutDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MailOutDTO input)
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
                    this.SenderId == input.SenderId ||
                    (this.SenderId != null &&
                    this.SenderId.Equals(input.SenderId))
                ) && 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.RetryCount == input.RetryCount ||
                    (this.RetryCount != null &&
                    this.RetryCount.Equals(input.RetryCount))
                ) && 
                (
                    this.SmtpId == input.SmtpId ||
                    (this.SmtpId != null &&
                    this.SmtpId.Equals(input.SmtpId))
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
                if (this.SenderId != null)
                    hashCode = hashCode * 59 + this.SenderId.GetHashCode();
                if (this.MessageId != null)
                    hashCode = hashCode * 59 + this.MessageId.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.RetryCount != null)
                    hashCode = hashCode * 59 + this.RetryCount.GetHashCode();
                if (this.SmtpId != null)
                    hashCode = hashCode * 59 + this.SmtpId.GetHashCode();
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
