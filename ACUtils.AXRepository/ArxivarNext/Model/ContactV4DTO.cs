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
    /// Class of the Contact item: V4 introduces FeaEnabled, FeaExpireDate
    /// </summary>
    [DataContract]
        public partial class ContactV4DTO :  IEquatable<ContactV4DTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactV4DTO" /> class.
        /// </summary>
        /// <param name="feaEnabled">Firma Elettronica Avanzata is enabled.</param>
        /// <param name="feaExpireDate">Firma Elettronica Avanzata expiration date.</param>
        /// <param name="firstName">Firstname.</param>
        /// <param name="lastName">Lastname.</param>
        /// <param name="pec">Posta Elettronica Certificata.</param>
        /// <param name="addressBookId">Identifier of Address Book.</param>
        /// <param name="contactName">Name.</param>
        /// <param name="job">Job.</param>
        /// <param name="phone">Phone Number.</param>
        /// <param name="fax">Fax Number.</param>
        /// <param name="cellPhone">Mobile Phone Number.</param>
        /// <param name="house">Address.</param>
        /// <param name="department">Department.</param>
        /// <param name="office">Office.</param>
        /// <param name="email">Email.</param>
        /// <param name="id">Identifier.</param>
        public ContactV4DTO(bool? feaEnabled = default(bool?), DateTime? feaExpireDate = default(DateTime?), string firstName = default(string), string lastName = default(string), string pec = default(string), int? addressBookId = default(int?), string contactName = default(string), string job = default(string), string phone = default(string), string fax = default(string), string cellPhone = default(string), string house = default(string), string department = default(string), string office = default(string), string email = default(string), int? id = default(int?))
        {
            this.FeaEnabled = feaEnabled;
            this.FeaExpireDate = feaExpireDate;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Pec = pec;
            this.AddressBookId = addressBookId;
            this.ContactName = contactName;
            this.Job = job;
            this.Phone = phone;
            this.Fax = fax;
            this.CellPhone = cellPhone;
            this.House = house;
            this.Department = department;
            this.Office = office;
            this.Email = email;
            this.Id = id;
        }
        
        /// <summary>
        /// Firma Elettronica Avanzata is enabled
        /// </summary>
        /// <value>Firma Elettronica Avanzata is enabled</value>
        [DataMember(Name="feaEnabled", EmitDefaultValue=false)]
        public bool? FeaEnabled { get; set; }

        /// <summary>
        /// Firma Elettronica Avanzata expiration date
        /// </summary>
        /// <value>Firma Elettronica Avanzata expiration date</value>
        [DataMember(Name="feaExpireDate", EmitDefaultValue=false)]
        public DateTime? FeaExpireDate { get; set; }

        /// <summary>
        /// Firstname
        /// </summary>
        /// <value>Firstname</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Lastname
        /// </summary>
        /// <value>Lastname</value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Posta Elettronica Certificata
        /// </summary>
        /// <value>Posta Elettronica Certificata</value>
        [DataMember(Name="pec", EmitDefaultValue=false)]
        public string Pec { get; set; }

        /// <summary>
        /// Identifier of Address Book
        /// </summary>
        /// <value>Identifier of Address Book</value>
        [DataMember(Name="addressBookId", EmitDefaultValue=false)]
        public int? AddressBookId { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="contactName", EmitDefaultValue=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// Job
        /// </summary>
        /// <value>Job</value>
        [DataMember(Name="job", EmitDefaultValue=false)]
        public string Job { get; set; }

        /// <summary>
        /// Phone Number
        /// </summary>
        /// <value>Phone Number</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Fax Number
        /// </summary>
        /// <value>Fax Number</value>
        [DataMember(Name="fax", EmitDefaultValue=false)]
        public string Fax { get; set; }

        /// <summary>
        /// Mobile Phone Number
        /// </summary>
        /// <value>Mobile Phone Number</value>
        [DataMember(Name="cellPhone", EmitDefaultValue=false)]
        public string CellPhone { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        /// <value>Address</value>
        [DataMember(Name="house", EmitDefaultValue=false)]
        public string House { get; set; }

        /// <summary>
        /// Department
        /// </summary>
        /// <value>Department</value>
        [DataMember(Name="department", EmitDefaultValue=false)]
        public string Department { get; set; }

        /// <summary>
        /// Office
        /// </summary>
        /// <value>Office</value>
        [DataMember(Name="office", EmitDefaultValue=false)]
        public string Office { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        /// <value>Email</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactV4DTO {\n");
            sb.Append("  FeaEnabled: ").Append(FeaEnabled).Append("\n");
            sb.Append("  FeaExpireDate: ").Append(FeaExpireDate).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Pec: ").Append(Pec).Append("\n");
            sb.Append("  AddressBookId: ").Append(AddressBookId).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  Job: ").Append(Job).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  CellPhone: ").Append(CellPhone).Append("\n");
            sb.Append("  House: ").Append(House).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  Office: ").Append(Office).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as ContactV4DTO);
        }

        /// <summary>
        /// Returns true if ContactV4DTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactV4DTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactV4DTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FeaEnabled == input.FeaEnabled ||
                    (this.FeaEnabled != null &&
                    this.FeaEnabled.Equals(input.FeaEnabled))
                ) && 
                (
                    this.FeaExpireDate == input.FeaExpireDate ||
                    (this.FeaExpireDate != null &&
                    this.FeaExpireDate.Equals(input.FeaExpireDate))
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
                    this.Pec == input.Pec ||
                    (this.Pec != null &&
                    this.Pec.Equals(input.Pec))
                ) && 
                (
                    this.AddressBookId == input.AddressBookId ||
                    (this.AddressBookId != null &&
                    this.AddressBookId.Equals(input.AddressBookId))
                ) && 
                (
                    this.ContactName == input.ContactName ||
                    (this.ContactName != null &&
                    this.ContactName.Equals(input.ContactName))
                ) && 
                (
                    this.Job == input.Job ||
                    (this.Job != null &&
                    this.Job.Equals(input.Job))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Fax == input.Fax ||
                    (this.Fax != null &&
                    this.Fax.Equals(input.Fax))
                ) && 
                (
                    this.CellPhone == input.CellPhone ||
                    (this.CellPhone != null &&
                    this.CellPhone.Equals(input.CellPhone))
                ) && 
                (
                    this.House == input.House ||
                    (this.House != null &&
                    this.House.Equals(input.House))
                ) && 
                (
                    this.Department == input.Department ||
                    (this.Department != null &&
                    this.Department.Equals(input.Department))
                ) && 
                (
                    this.Office == input.Office ||
                    (this.Office != null &&
                    this.Office.Equals(input.Office))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.FeaEnabled != null)
                    hashCode = hashCode * 59 + this.FeaEnabled.GetHashCode();
                if (this.FeaExpireDate != null)
                    hashCode = hashCode * 59 + this.FeaExpireDate.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Pec != null)
                    hashCode = hashCode * 59 + this.Pec.GetHashCode();
                if (this.AddressBookId != null)
                    hashCode = hashCode * 59 + this.AddressBookId.GetHashCode();
                if (this.ContactName != null)
                    hashCode = hashCode * 59 + this.ContactName.GetHashCode();
                if (this.Job != null)
                    hashCode = hashCode * 59 + this.Job.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Fax != null)
                    hashCode = hashCode * 59 + this.Fax.GetHashCode();
                if (this.CellPhone != null)
                    hashCode = hashCode * 59 + this.CellPhone.GetHashCode();
                if (this.House != null)
                    hashCode = hashCode * 59 + this.House.GetHashCode();
                if (this.Department != null)
                    hashCode = hashCode * 59 + this.Department.GetHashCode();
                if (this.Office != null)
                    hashCode = hashCode * 59 + this.Office.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
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
