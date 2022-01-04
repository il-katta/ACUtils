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
    /// Class of workflow item
    /// </summary>
    [DataContract]
        public partial class WorkflowDTO :  IEquatable<WorkflowDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowDTO" /> class.
        /// </summary>
        /// <param name="id">Identiifer.</param>
        /// <param name="detail">Detail.</param>
        /// <param name="name">Name.</param>
        /// <param name="description">Description.</param>
        /// <param name="state">Possible values:  0: Deleted  1: Online  2: InEdit  3: Approving .</param>
        /// <param name="organizationChart">Organization chart Identifier.</param>
        /// <param name="businessUnit">Business unit Code.</param>
        /// <param name="color">Color code.</param>
        /// <param name="revision">Revision Number.</param>
        /// <param name="workflowParentId">Parent Identifier.</param>
        /// <param name="approvalDate">Date of Approval.</param>
        /// <param name="creationDate">Creation Date.</param>
        /// <param name="editDate">Last Edit Date.</param>
        /// <param name="reason">Reason for the Revision.</param>
        public WorkflowDTO(int? id = default(int?), string detail = default(string), string name = default(string), string description = default(string), int? state = default(int?), int? organizationChart = default(int?), string businessUnit = default(string), int? color = default(int?), int? revision = default(int?), int? workflowParentId = default(int?), DateTime? approvalDate = default(DateTime?), DateTime? creationDate = default(DateTime?), DateTime? editDate = default(DateTime?), string reason = default(string))
        {
            this.Id = id;
            this.Detail = detail;
            this.Name = name;
            this.Description = description;
            this.State = state;
            this.OrganizationChart = organizationChart;
            this.BusinessUnit = businessUnit;
            this.Color = color;
            this.Revision = revision;
            this.WorkflowParentId = workflowParentId;
            this.ApprovalDate = approvalDate;
            this.CreationDate = creationDate;
            this.EditDate = editDate;
            this.Reason = reason;
        }
        
        /// <summary>
        /// Identiifer
        /// </summary>
        /// <value>Identiifer</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Detail
        /// </summary>
        /// <value>Detail</value>
        [DataMember(Name="detail", EmitDefaultValue=false)]
        public string Detail { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Possible values:  0: Deleted  1: Online  2: InEdit  3: Approving 
        /// </summary>
        /// <value>Possible values:  0: Deleted  1: Online  2: InEdit  3: Approving </value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public int? State { get; set; }

        /// <summary>
        /// Organization chart Identifier
        /// </summary>
        /// <value>Organization chart Identifier</value>
        [DataMember(Name="organizationChart", EmitDefaultValue=false)]
        public int? OrganizationChart { get; set; }

        /// <summary>
        /// Business unit Code
        /// </summary>
        /// <value>Business unit Code</value>
        [DataMember(Name="businessUnit", EmitDefaultValue=false)]
        public string BusinessUnit { get; set; }

        /// <summary>
        /// Color code
        /// </summary>
        /// <value>Color code</value>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public int? Color { get; set; }

        /// <summary>
        /// Revision Number
        /// </summary>
        /// <value>Revision Number</value>
        [DataMember(Name="revision", EmitDefaultValue=false)]
        public int? Revision { get; set; }

        /// <summary>
        /// Parent Identifier
        /// </summary>
        /// <value>Parent Identifier</value>
        [DataMember(Name="workflowParentId", EmitDefaultValue=false)]
        public int? WorkflowParentId { get; set; }

        /// <summary>
        /// Date of Approval
        /// </summary>
        /// <value>Date of Approval</value>
        [DataMember(Name="approvalDate", EmitDefaultValue=false)]
        public DateTime? ApprovalDate { get; set; }

        /// <summary>
        /// Creation Date
        /// </summary>
        /// <value>Creation Date</value>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Last Edit Date
        /// </summary>
        /// <value>Last Edit Date</value>
        [DataMember(Name="editDate", EmitDefaultValue=false)]
        public DateTime? EditDate { get; set; }

        /// <summary>
        /// Reason for the Revision
        /// </summary>
        /// <value>Reason for the Revision</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  OrganizationChart: ").Append(OrganizationChart).Append("\n");
            sb.Append("  BusinessUnit: ").Append(BusinessUnit).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  WorkflowParentId: ").Append(WorkflowParentId).Append("\n");
            sb.Append("  ApprovalDate: ").Append(ApprovalDate).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  EditDate: ").Append(EditDate).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
            return this.Equals(input as WorkflowDTO);
        }

        /// <summary>
        /// Returns true if WorkflowDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkflowDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkflowDTO input)
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
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.OrganizationChart == input.OrganizationChart ||
                    (this.OrganizationChart != null &&
                    this.OrganizationChart.Equals(input.OrganizationChart))
                ) && 
                (
                    this.BusinessUnit == input.BusinessUnit ||
                    (this.BusinessUnit != null &&
                    this.BusinessUnit.Equals(input.BusinessUnit))
                ) && 
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
                ) && 
                (
                    this.Revision == input.Revision ||
                    (this.Revision != null &&
                    this.Revision.Equals(input.Revision))
                ) && 
                (
                    this.WorkflowParentId == input.WorkflowParentId ||
                    (this.WorkflowParentId != null &&
                    this.WorkflowParentId.Equals(input.WorkflowParentId))
                ) && 
                (
                    this.ApprovalDate == input.ApprovalDate ||
                    (this.ApprovalDate != null &&
                    this.ApprovalDate.Equals(input.ApprovalDate))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.EditDate == input.EditDate ||
                    (this.EditDate != null &&
                    this.EditDate.Equals(input.EditDate))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
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
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.OrganizationChart != null)
                    hashCode = hashCode * 59 + this.OrganizationChart.GetHashCode();
                if (this.BusinessUnit != null)
                    hashCode = hashCode * 59 + this.BusinessUnit.GetHashCode();
                if (this.Color != null)
                    hashCode = hashCode * 59 + this.Color.GetHashCode();
                if (this.Revision != null)
                    hashCode = hashCode * 59 + this.Revision.GetHashCode();
                if (this.WorkflowParentId != null)
                    hashCode = hashCode * 59 + this.WorkflowParentId.GetHashCode();
                if (this.ApprovalDate != null)
                    hashCode = hashCode * 59 + this.ApprovalDate.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.EditDate != null)
                    hashCode = hashCode * 59 + this.EditDate.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
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
