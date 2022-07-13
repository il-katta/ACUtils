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
    /// IxCeDocumentDTO
    /// </summary>
    [DataContract]
    public partial class IxCeDocumentDTO :  IEquatable<IxCeDocumentDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IxCeDocumentDTO" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="attachmentId">attachmentId.</param>
        /// <param name="noteId">noteId.</param>
        /// <param name="fatherId">fatherId.</param>
        /// <param name="ixceId">ixceId.</param>
        /// <param name="vatNumber">vatNumber.</param>
        /// <param name="documentTypeSystemId">documentTypeSystemId.</param>
        /// <param name="documentTypeDescription">documentTypeDescription.</param>
        /// <param name="docnumber">docnumber.</param>
        /// <param name="revision">revision.</param>
        /// <param name="creationDate">creationDate.</param>
        /// <param name="status">Possible values:  0: Error  1: Inserted  2: ConnectorTakeCharge  3: ConnectorError  4: TakeChargeError  5: IxceTakeCharge  6: ToValidate  7: Validated  8: InError  9: Discarded  10: Preserved .</param>
        /// <param name="insertionHash">insertionHash.</param>
        /// <param name="receiveHash">receiveHash.</param>
        /// <param name="accumulationPackageId">accumulationPackageId.</param>
        /// <param name="accumulationPackageDescription">accumulationPackageDescription.</param>
        /// <param name="modified">modified.</param>
        /// <param name="lastUpdate">lastUpdate.</param>
        /// <param name="description">description.</param>
        /// <param name="userId">userId.</param>
        /// <param name="userDescription">userDescription.</param>
        /// <param name="serviceType">Possible values:  0: IX  1: IXCE  2: IXCE_V2  3: IX_V2 .</param>
        /// <param name="ixDocumentId">ixDocumentId.</param>
        /// <param name="ixceIndex">ixceIndex.</param>
        public IxCeDocumentDTO(int? id = default(int?), int? attachmentId = default(int?), int? noteId = default(int?), int? fatherId = default(int?), string ixceId = default(string), string vatNumber = default(string), int? documentTypeSystemId = default(int?), string documentTypeDescription = default(string), int? docnumber = default(int?), int? revision = default(int?), DateTime? creationDate = default(DateTime?), int? status = default(int?), string insertionHash = default(string), string receiveHash = default(string), int? accumulationPackageId = default(int?), string accumulationPackageDescription = default(string), bool? modified = default(bool?), DateTime? lastUpdate = default(DateTime?), string description = default(string), int? userId = default(int?), string userDescription = default(string), int? serviceType = default(int?), int? ixDocumentId = default(int?), int? ixceIndex = default(int?))
        {
            this.Id = id;
            this.AttachmentId = attachmentId;
            this.NoteId = noteId;
            this.FatherId = fatherId;
            this.IxceId = ixceId;
            this.VatNumber = vatNumber;
            this.DocumentTypeSystemId = documentTypeSystemId;
            this.DocumentTypeDescription = documentTypeDescription;
            this.Docnumber = docnumber;
            this.Revision = revision;
            this.CreationDate = creationDate;
            this.Status = status;
            this.InsertionHash = insertionHash;
            this.ReceiveHash = receiveHash;
            this.AccumulationPackageId = accumulationPackageId;
            this.AccumulationPackageDescription = accumulationPackageDescription;
            this.Modified = modified;
            this.LastUpdate = lastUpdate;
            this.Description = description;
            this.UserId = userId;
            this.UserDescription = userDescription;
            this.ServiceType = serviceType;
            this.IxDocumentId = ixDocumentId;
            this.IxceIndex = ixceIndex;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets AttachmentId
        /// </summary>
        [DataMember(Name="attachmentId", EmitDefaultValue=false)]
        public int? AttachmentId { get; set; }

        /// <summary>
        /// Gets or Sets NoteId
        /// </summary>
        [DataMember(Name="noteId", EmitDefaultValue=false)]
        public int? NoteId { get; set; }

        /// <summary>
        /// Gets or Sets FatherId
        /// </summary>
        [DataMember(Name="fatherId", EmitDefaultValue=false)]
        public int? FatherId { get; set; }

        /// <summary>
        /// Gets or Sets IxceId
        /// </summary>
        [DataMember(Name="ixceId", EmitDefaultValue=false)]
        public string IxceId { get; set; }

        /// <summary>
        /// Gets or Sets VatNumber
        /// </summary>
        [DataMember(Name="vatNumber", EmitDefaultValue=false)]
        public string VatNumber { get; set; }

        /// <summary>
        /// Gets or Sets DocumentTypeSystemId
        /// </summary>
        [DataMember(Name="documentTypeSystemId", EmitDefaultValue=false)]
        public int? DocumentTypeSystemId { get; set; }

        /// <summary>
        /// Gets or Sets DocumentTypeDescription
        /// </summary>
        [DataMember(Name="documentTypeDescription", EmitDefaultValue=false)]
        public string DocumentTypeDescription { get; set; }

        /// <summary>
        /// Gets or Sets Docnumber
        /// </summary>
        [DataMember(Name="docnumber", EmitDefaultValue=false)]
        public int? Docnumber { get; set; }

        /// <summary>
        /// Gets or Sets Revision
        /// </summary>
        [DataMember(Name="revision", EmitDefaultValue=false)]
        public int? Revision { get; set; }

        /// <summary>
        /// Gets or Sets CreationDate
        /// </summary>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Possible values:  0: Error  1: Inserted  2: ConnectorTakeCharge  3: ConnectorError  4: TakeChargeError  5: IxceTakeCharge  6: ToValidate  7: Validated  8: InError  9: Discarded  10: Preserved 
        /// </summary>
        /// <value>Possible values:  0: Error  1: Inserted  2: ConnectorTakeCharge  3: ConnectorError  4: TakeChargeError  5: IxceTakeCharge  6: ToValidate  7: Validated  8: InError  9: Discarded  10: Preserved </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }

        /// <summary>
        /// Gets or Sets InsertionHash
        /// </summary>
        [DataMember(Name="insertionHash", EmitDefaultValue=false)]
        public string InsertionHash { get; set; }

        /// <summary>
        /// Gets or Sets ReceiveHash
        /// </summary>
        [DataMember(Name="receiveHash", EmitDefaultValue=false)]
        public string ReceiveHash { get; set; }

        /// <summary>
        /// Gets or Sets AccumulationPackageId
        /// </summary>
        [DataMember(Name="accumulationPackageId", EmitDefaultValue=false)]
        public int? AccumulationPackageId { get; set; }

        /// <summary>
        /// Gets or Sets AccumulationPackageDescription
        /// </summary>
        [DataMember(Name="accumulationPackageDescription", EmitDefaultValue=false)]
        public string AccumulationPackageDescription { get; set; }

        /// <summary>
        /// Gets or Sets Modified
        /// </summary>
        [DataMember(Name="modified", EmitDefaultValue=false)]
        public bool? Modified { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdate
        /// </summary>
        [DataMember(Name="lastUpdate", EmitDefaultValue=false)]
        public DateTime? LastUpdate { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or Sets UserDescription
        /// </summary>
        [DataMember(Name="userDescription", EmitDefaultValue=false)]
        public string UserDescription { get; set; }

        /// <summary>
        /// Possible values:  0: IX  1: IXCE  2: IXCE_V2  3: IX_V2 
        /// </summary>
        /// <value>Possible values:  0: IX  1: IXCE  2: IXCE_V2  3: IX_V2 </value>
        [DataMember(Name="serviceType", EmitDefaultValue=false)]
        public int? ServiceType { get; set; }

        /// <summary>
        /// Gets or Sets IxDocumentId
        /// </summary>
        [DataMember(Name="ixDocumentId", EmitDefaultValue=false)]
        public int? IxDocumentId { get; set; }

        /// <summary>
        /// Gets or Sets IxceIndex
        /// </summary>
        [DataMember(Name="ixceIndex", EmitDefaultValue=false)]
        public int? IxceIndex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IxCeDocumentDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AttachmentId: ").Append(AttachmentId).Append("\n");
            sb.Append("  NoteId: ").Append(NoteId).Append("\n");
            sb.Append("  FatherId: ").Append(FatherId).Append("\n");
            sb.Append("  IxceId: ").Append(IxceId).Append("\n");
            sb.Append("  VatNumber: ").Append(VatNumber).Append("\n");
            sb.Append("  DocumentTypeSystemId: ").Append(DocumentTypeSystemId).Append("\n");
            sb.Append("  DocumentTypeDescription: ").Append(DocumentTypeDescription).Append("\n");
            sb.Append("  Docnumber: ").Append(Docnumber).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  InsertionHash: ").Append(InsertionHash).Append("\n");
            sb.Append("  ReceiveHash: ").Append(ReceiveHash).Append("\n");
            sb.Append("  AccumulationPackageId: ").Append(AccumulationPackageId).Append("\n");
            sb.Append("  AccumulationPackageDescription: ").Append(AccumulationPackageDescription).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserDescription: ").Append(UserDescription).Append("\n");
            sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
            sb.Append("  IxDocumentId: ").Append(IxDocumentId).Append("\n");
            sb.Append("  IxceIndex: ").Append(IxceIndex).Append("\n");
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
            return this.Equals(input as IxCeDocumentDTO);
        }

        /// <summary>
        /// Returns true if IxCeDocumentDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of IxCeDocumentDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IxCeDocumentDTO input)
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
                    this.AttachmentId == input.AttachmentId ||
                    (this.AttachmentId != null &&
                    this.AttachmentId.Equals(input.AttachmentId))
                ) && 
                (
                    this.NoteId == input.NoteId ||
                    (this.NoteId != null &&
                    this.NoteId.Equals(input.NoteId))
                ) && 
                (
                    this.FatherId == input.FatherId ||
                    (this.FatherId != null &&
                    this.FatherId.Equals(input.FatherId))
                ) && 
                (
                    this.IxceId == input.IxceId ||
                    (this.IxceId != null &&
                    this.IxceId.Equals(input.IxceId))
                ) && 
                (
                    this.VatNumber == input.VatNumber ||
                    (this.VatNumber != null &&
                    this.VatNumber.Equals(input.VatNumber))
                ) && 
                (
                    this.DocumentTypeSystemId == input.DocumentTypeSystemId ||
                    (this.DocumentTypeSystemId != null &&
                    this.DocumentTypeSystemId.Equals(input.DocumentTypeSystemId))
                ) && 
                (
                    this.DocumentTypeDescription == input.DocumentTypeDescription ||
                    (this.DocumentTypeDescription != null &&
                    this.DocumentTypeDescription.Equals(input.DocumentTypeDescription))
                ) && 
                (
                    this.Docnumber == input.Docnumber ||
                    (this.Docnumber != null &&
                    this.Docnumber.Equals(input.Docnumber))
                ) && 
                (
                    this.Revision == input.Revision ||
                    (this.Revision != null &&
                    this.Revision.Equals(input.Revision))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.InsertionHash == input.InsertionHash ||
                    (this.InsertionHash != null &&
                    this.InsertionHash.Equals(input.InsertionHash))
                ) && 
                (
                    this.ReceiveHash == input.ReceiveHash ||
                    (this.ReceiveHash != null &&
                    this.ReceiveHash.Equals(input.ReceiveHash))
                ) && 
                (
                    this.AccumulationPackageId == input.AccumulationPackageId ||
                    (this.AccumulationPackageId != null &&
                    this.AccumulationPackageId.Equals(input.AccumulationPackageId))
                ) && 
                (
                    this.AccumulationPackageDescription == input.AccumulationPackageDescription ||
                    (this.AccumulationPackageDescription != null &&
                    this.AccumulationPackageDescription.Equals(input.AccumulationPackageDescription))
                ) && 
                (
                    this.Modified == input.Modified ||
                    (this.Modified != null &&
                    this.Modified.Equals(input.Modified))
                ) && 
                (
                    this.LastUpdate == input.LastUpdate ||
                    (this.LastUpdate != null &&
                    this.LastUpdate.Equals(input.LastUpdate))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.UserDescription == input.UserDescription ||
                    (this.UserDescription != null &&
                    this.UserDescription.Equals(input.UserDescription))
                ) && 
                (
                    this.ServiceType == input.ServiceType ||
                    (this.ServiceType != null &&
                    this.ServiceType.Equals(input.ServiceType))
                ) && 
                (
                    this.IxDocumentId == input.IxDocumentId ||
                    (this.IxDocumentId != null &&
                    this.IxDocumentId.Equals(input.IxDocumentId))
                ) && 
                (
                    this.IxceIndex == input.IxceIndex ||
                    (this.IxceIndex != null &&
                    this.IxceIndex.Equals(input.IxceIndex))
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
                if (this.AttachmentId != null)
                    hashCode = hashCode * 59 + this.AttachmentId.GetHashCode();
                if (this.NoteId != null)
                    hashCode = hashCode * 59 + this.NoteId.GetHashCode();
                if (this.FatherId != null)
                    hashCode = hashCode * 59 + this.FatherId.GetHashCode();
                if (this.IxceId != null)
                    hashCode = hashCode * 59 + this.IxceId.GetHashCode();
                if (this.VatNumber != null)
                    hashCode = hashCode * 59 + this.VatNumber.GetHashCode();
                if (this.DocumentTypeSystemId != null)
                    hashCode = hashCode * 59 + this.DocumentTypeSystemId.GetHashCode();
                if (this.DocumentTypeDescription != null)
                    hashCode = hashCode * 59 + this.DocumentTypeDescription.GetHashCode();
                if (this.Docnumber != null)
                    hashCode = hashCode * 59 + this.Docnumber.GetHashCode();
                if (this.Revision != null)
                    hashCode = hashCode * 59 + this.Revision.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.InsertionHash != null)
                    hashCode = hashCode * 59 + this.InsertionHash.GetHashCode();
                if (this.ReceiveHash != null)
                    hashCode = hashCode * 59 + this.ReceiveHash.GetHashCode();
                if (this.AccumulationPackageId != null)
                    hashCode = hashCode * 59 + this.AccumulationPackageId.GetHashCode();
                if (this.AccumulationPackageDescription != null)
                    hashCode = hashCode * 59 + this.AccumulationPackageDescription.GetHashCode();
                if (this.Modified != null)
                    hashCode = hashCode * 59 + this.Modified.GetHashCode();
                if (this.LastUpdate != null)
                    hashCode = hashCode * 59 + this.LastUpdate.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserDescription != null)
                    hashCode = hashCode * 59 + this.UserDescription.GetHashCode();
                if (this.ServiceType != null)
                    hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.IxDocumentId != null)
                    hashCode = hashCode * 59 + this.IxDocumentId.GetHashCode();
                if (this.IxceIndex != null)
                    hashCode = hashCode * 59 + this.IxceIndex.GetHashCode();
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
