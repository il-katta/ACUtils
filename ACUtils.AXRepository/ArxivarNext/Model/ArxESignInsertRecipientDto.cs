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
    /// ARXeSigN recipient
    /// </summary>
    [DataContract]
    public partial class ArxESignInsertRecipientDto :  IEquatable<ArxESignInsertRecipientDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArxESignInsertRecipientDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ArxESignInsertRecipientDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ArxESignInsertRecipientDto" /> class.
        /// </summary>
        /// <param name="applyTimestamp">Indicates if apply timestamp.</param>
        /// <param name="confirmRead">Read confirmation.</param>
        /// <param name="attachmentOperations">attachmentOperations.</param>
        /// <param name="moduleFieldOperations">moduleFieldOperations.</param>
        /// <param name="signOperations">signOperations.</param>
        /// <param name="mobilePhone">Mobile Phone.</param>
        /// <param name="email">Email (required).</param>
        /// <param name="firstName">First name (required).</param>
        /// <param name="lastName">Last name (required).</param>
        /// <param name="order">Sign flow order (required).</param>
        /// <param name="recipientKind">Possible values:  0: Signer  1: InCopy  (required).</param>
        /// <param name="recipientAuthType">Possible values:  0: None  1: Sms .</param>
        /// <param name="language">Language.</param>
        public ArxESignInsertRecipientDto(bool? applyTimestamp = default(bool?), bool? confirmRead = default(bool?), List<ArxESignAttachmentOperationDto> attachmentOperations = default(List<ArxESignAttachmentOperationDto>), List<ArxESignModuleFieldOperationDto> moduleFieldOperations = default(List<ArxESignModuleFieldOperationDto>), List<ArxESignSignOperationDto> signOperations = default(List<ArxESignSignOperationDto>), string mobilePhone = default(string), string email = default(string), string firstName = default(string), string lastName = default(string), int? order = default(int?), int? recipientKind = default(int?), int? recipientAuthType = default(int?), string language = default(string))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for ArxESignInsertRecipientDto and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new InvalidDataException("firstName is a required property for ArxESignInsertRecipientDto and cannot be null");
            }
            else
            {
                this.FirstName = firstName;
            }
            // to ensure "lastName" is required (not null)
            if (lastName == null)
            {
                throw new InvalidDataException("lastName is a required property for ArxESignInsertRecipientDto and cannot be null");
            }
            else
            {
                this.LastName = lastName;
            }
            // to ensure "order" is required (not null)
            if (order == null)
            {
                throw new InvalidDataException("order is a required property for ArxESignInsertRecipientDto and cannot be null");
            }
            else
            {
                this.Order = order;
            }
            // to ensure "recipientKind" is required (not null)
            if (recipientKind == null)
            {
                throw new InvalidDataException("recipientKind is a required property for ArxESignInsertRecipientDto and cannot be null");
            }
            else
            {
                this.RecipientKind = recipientKind;
            }
            this.ApplyTimestamp = applyTimestamp;
            this.ConfirmRead = confirmRead;
            this.AttachmentOperations = attachmentOperations;
            this.ModuleFieldOperations = moduleFieldOperations;
            this.SignOperations = signOperations;
            this.MobilePhone = mobilePhone;
            this.RecipientAuthType = recipientAuthType;
            this.Language = language;
        }
        
        /// <summary>
        /// Indicates if apply timestamp
        /// </summary>
        /// <value>Indicates if apply timestamp</value>
        [DataMember(Name="applyTimestamp", EmitDefaultValue=false)]
        public bool? ApplyTimestamp { get; set; }

        /// <summary>
        /// Read confirmation
        /// </summary>
        /// <value>Read confirmation</value>
        [DataMember(Name="confirmRead", EmitDefaultValue=false)]
        public bool? ConfirmRead { get; set; }

        /// <summary>
        /// Gets or Sets AttachmentOperations
        /// </summary>
        [DataMember(Name="attachmentOperations", EmitDefaultValue=false)]
        public List<ArxESignAttachmentOperationDto> AttachmentOperations { get; set; }

        /// <summary>
        /// Gets or Sets ModuleFieldOperations
        /// </summary>
        [DataMember(Name="moduleFieldOperations", EmitDefaultValue=false)]
        public List<ArxESignModuleFieldOperationDto> ModuleFieldOperations { get; set; }

        /// <summary>
        /// Gets or Sets SignOperations
        /// </summary>
        [DataMember(Name="signOperations", EmitDefaultValue=false)]
        public List<ArxESignSignOperationDto> SignOperations { get; set; }

        /// <summary>
        /// Mobile Phone
        /// </summary>
        /// <value>Mobile Phone</value>
        [DataMember(Name="mobilePhone", EmitDefaultValue=false)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        /// <value>Email</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// First name
        /// </summary>
        /// <value>First name</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        /// <value>Last name</value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Sign flow order
        /// </summary>
        /// <value>Sign flow order</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int? Order { get; set; }

        /// <summary>
        /// Possible values:  0: Signer  1: InCopy 
        /// </summary>
        /// <value>Possible values:  0: Signer  1: InCopy </value>
        [DataMember(Name="recipientKind", EmitDefaultValue=false)]
        public int? RecipientKind { get; set; }

        /// <summary>
        /// Possible values:  0: None  1: Sms 
        /// </summary>
        /// <value>Possible values:  0: None  1: Sms </value>
        [DataMember(Name="recipientAuthType", EmitDefaultValue=false)]
        public int? RecipientAuthType { get; set; }

        /// <summary>
        /// Language
        /// </summary>
        /// <value>Language</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArxESignInsertRecipientDto {\n");
            sb.Append("  ApplyTimestamp: ").Append(ApplyTimestamp).Append("\n");
            sb.Append("  ConfirmRead: ").Append(ConfirmRead).Append("\n");
            sb.Append("  AttachmentOperations: ").Append(AttachmentOperations).Append("\n");
            sb.Append("  ModuleFieldOperations: ").Append(ModuleFieldOperations).Append("\n");
            sb.Append("  SignOperations: ").Append(SignOperations).Append("\n");
            sb.Append("  MobilePhone: ").Append(MobilePhone).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  RecipientKind: ").Append(RecipientKind).Append("\n");
            sb.Append("  RecipientAuthType: ").Append(RecipientAuthType).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
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
            return this.Equals(input as ArxESignInsertRecipientDto);
        }

        /// <summary>
        /// Returns true if ArxESignInsertRecipientDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ArxESignInsertRecipientDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArxESignInsertRecipientDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplyTimestamp == input.ApplyTimestamp ||
                    (this.ApplyTimestamp != null &&
                    this.ApplyTimestamp.Equals(input.ApplyTimestamp))
                ) && 
                (
                    this.ConfirmRead == input.ConfirmRead ||
                    (this.ConfirmRead != null &&
                    this.ConfirmRead.Equals(input.ConfirmRead))
                ) && 
                (
                    this.AttachmentOperations == input.AttachmentOperations ||
                    this.AttachmentOperations != null &&
                    this.AttachmentOperations.SequenceEqual(input.AttachmentOperations)
                ) && 
                (
                    this.ModuleFieldOperations == input.ModuleFieldOperations ||
                    this.ModuleFieldOperations != null &&
                    this.ModuleFieldOperations.SequenceEqual(input.ModuleFieldOperations)
                ) && 
                (
                    this.SignOperations == input.SignOperations ||
                    this.SignOperations != null &&
                    this.SignOperations.SequenceEqual(input.SignOperations)
                ) && 
                (
                    this.MobilePhone == input.MobilePhone ||
                    (this.MobilePhone != null &&
                    this.MobilePhone.Equals(input.MobilePhone))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.RecipientKind == input.RecipientKind ||
                    (this.RecipientKind != null &&
                    this.RecipientKind.Equals(input.RecipientKind))
                ) && 
                (
                    this.RecipientAuthType == input.RecipientAuthType ||
                    (this.RecipientAuthType != null &&
                    this.RecipientAuthType.Equals(input.RecipientAuthType))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
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
                if (this.ApplyTimestamp != null)
                    hashCode = hashCode * 59 + this.ApplyTimestamp.GetHashCode();
                if (this.ConfirmRead != null)
                    hashCode = hashCode * 59 + this.ConfirmRead.GetHashCode();
                if (this.AttachmentOperations != null)
                    hashCode = hashCode * 59 + this.AttachmentOperations.GetHashCode();
                if (this.ModuleFieldOperations != null)
                    hashCode = hashCode * 59 + this.ModuleFieldOperations.GetHashCode();
                if (this.SignOperations != null)
                    hashCode = hashCode * 59 + this.SignOperations.GetHashCode();
                if (this.MobilePhone != null)
                    hashCode = hashCode * 59 + this.MobilePhone.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.RecipientKind != null)
                    hashCode = hashCode * 59 + this.RecipientKind.GetHashCode();
                if (this.RecipientAuthType != null)
                    hashCode = hashCode * 59 + this.RecipientAuthType.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
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
