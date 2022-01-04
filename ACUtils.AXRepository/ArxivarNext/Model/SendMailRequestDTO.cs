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
    /// SendMailRequestDTO
    /// </summary>
    [DataContract]
        public partial class SendMailRequestDTO :  IEquatable<SendMailRequestDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendMailRequestDTO" /> class.
        /// </summary>
        /// <param name="idAccount">The account used to send the email.</param>
        /// <param name="returnReceipt">Set to true if you want the email to request a return-receipt when received by the recipient.  The default value is false.</param>
        /// <param name="id">The message draft id, null or 0 if is a new message.</param>
        /// <param name="isBodyHtml">Gets or sets a value indicating whether the mail message body is in HTML.  The default value is false.</param>
        /// <param name="body">Gets or sets the message body.</param>
        /// <param name="subject">The email subject.</param>
        /// <param name="priority">Possible values:  0: Normal  2: High .</param>
        /// <param name="from">from.</param>
        /// <param name="destinations">List email destination.</param>
        /// <param name="documents">The email document list.</param>
        public SendMailRequestDTO(int? idAccount = default(int?), bool? returnReceipt = default(bool?), int? id = default(int?), bool? isBodyHtml = default(bool?), string body = default(string), string subject = default(string), int? priority = default(int?), EmailFromAddressDTO from = default(EmailFromAddressDTO), List<EmailDestinationAddressDTO> destinations = default(List<EmailDestinationAddressDTO>), List<EmailDocumentDTO> documents = default(List<EmailDocumentDTO>))
        {
            this.IdAccount = idAccount;
            this.ReturnReceipt = returnReceipt;
            this.Id = id;
            this.IsBodyHtml = isBodyHtml;
            this.Body = body;
            this.Subject = subject;
            this.Priority = priority;
            this.From = from;
            this.Destinations = destinations;
            this.Documents = documents;
        }
        
        /// <summary>
        /// The account used to send the email
        /// </summary>
        /// <value>The account used to send the email</value>
        [DataMember(Name="idAccount", EmitDefaultValue=false)]
        public int? IdAccount { get; set; }

        /// <summary>
        /// Set to true if you want the email to request a return-receipt when received by the recipient.  The default value is false
        /// </summary>
        /// <value>Set to true if you want the email to request a return-receipt when received by the recipient.  The default value is false</value>
        [DataMember(Name="returnReceipt", EmitDefaultValue=false)]
        public bool? ReturnReceipt { get; set; }

        /// <summary>
        /// The message draft id, null or 0 if is a new message
        /// </summary>
        /// <value>The message draft id, null or 0 if is a new message</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the mail message body is in HTML.  The default value is false
        /// </summary>
        /// <value>Gets or sets a value indicating whether the mail message body is in HTML.  The default value is false</value>
        [DataMember(Name="isBodyHtml", EmitDefaultValue=false)]
        public bool? IsBodyHtml { get; set; }

        /// <summary>
        /// Gets or sets the message body
        /// </summary>
        /// <value>Gets or sets the message body</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// The email subject
        /// </summary>
        /// <value>The email subject</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Possible values:  0: Normal  2: High 
        /// </summary>
        /// <value>Possible values:  0: Normal  2: High </value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public EmailFromAddressDTO From { get; set; }

        /// <summary>
        /// List email destination
        /// </summary>
        /// <value>List email destination</value>
        [DataMember(Name="destinations", EmitDefaultValue=false)]
        public List<EmailDestinationAddressDTO> Destinations { get; set; }

        /// <summary>
        /// The email document list
        /// </summary>
        /// <value>The email document list</value>
        [DataMember(Name="documents", EmitDefaultValue=false)]
        public List<EmailDocumentDTO> Documents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendMailRequestDTO {\n");
            sb.Append("  IdAccount: ").Append(IdAccount).Append("\n");
            sb.Append("  ReturnReceipt: ").Append(ReturnReceipt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsBodyHtml: ").Append(IsBodyHtml).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Destinations: ").Append(Destinations).Append("\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
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
            return this.Equals(input as SendMailRequestDTO);
        }

        /// <summary>
        /// Returns true if SendMailRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SendMailRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendMailRequestDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdAccount == input.IdAccount ||
                    (this.IdAccount != null &&
                    this.IdAccount.Equals(input.IdAccount))
                ) && 
                (
                    this.ReturnReceipt == input.ReturnReceipt ||
                    (this.ReturnReceipt != null &&
                    this.ReturnReceipt.Equals(input.ReturnReceipt))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsBodyHtml == input.IsBodyHtml ||
                    (this.IsBodyHtml != null &&
                    this.IsBodyHtml.Equals(input.IsBodyHtml))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Destinations == input.Destinations ||
                    this.Destinations != null &&
                    input.Destinations != null &&
                    this.Destinations.SequenceEqual(input.Destinations)
                ) && 
                (
                    this.Documents == input.Documents ||
                    this.Documents != null &&
                    input.Documents != null &&
                    this.Documents.SequenceEqual(input.Documents)
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
                if (this.IdAccount != null)
                    hashCode = hashCode * 59 + this.IdAccount.GetHashCode();
                if (this.ReturnReceipt != null)
                    hashCode = hashCode * 59 + this.ReturnReceipt.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsBodyHtml != null)
                    hashCode = hashCode * 59 + this.IsBodyHtml.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.Destinations != null)
                    hashCode = hashCode * 59 + this.Destinations.GetHashCode();
                if (this.Documents != null)
                    hashCode = hashCode * 59 + this.Documents.GetHashCode();
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
