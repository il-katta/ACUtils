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
    /// QueueAggregationStatusInfoDto
    /// </summary>
    [DataContract]
        public partial class QueueAggregationStatusInfoDto :  IEquatable<QueueAggregationStatusInfoDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueAggregationStatusInfoDto" /> class.
        /// </summary>
        /// <param name="workingProgress">workingProgress.</param>
        /// <param name="queueStatus">Possible values:  0: CompletedOk  1: CompletedPartialOk  2: CompletedKo  3: Deleted  4: Processing  5: Enqueued  6: Waiting  7: Failed .</param>
        /// <param name="isCompleted">isCompleted.</param>
        /// <param name="queueId">Queue Identifier.</param>
        /// <param name="queueName">Queue Name.</param>
        /// <param name="queueType">Queue Type.</param>
        /// <param name="createdAt">Creation Date.</param>
        /// <param name="expireAt">Expiration Date.</param>
        /// <param name="workItemCount">Items.</param>
        /// <param name="stateCount">stateCount.</param>
        public QueueAggregationStatusInfoDto(int? workingProgress = default(int?), int? queueStatus = default(int?), bool? isCompleted = default(bool?), string queueId = default(string), string queueName = default(string), string queueType = default(string), DateTime? createdAt = default(DateTime?), DateTime? expireAt = default(DateTime?), int? workItemCount = default(int?), QueueStateAggregationInfoDto stateCount = default(QueueStateAggregationInfoDto))
        {
            this.WorkingProgress = workingProgress;
            this.QueueStatus = queueStatus;
            this.IsCompleted = isCompleted;
            this.QueueId = queueId;
            this.QueueName = queueName;
            this.QueueType = queueType;
            this.CreatedAt = createdAt;
            this.ExpireAt = expireAt;
            this.WorkItemCount = workItemCount;
            this.StateCount = stateCount;
        }
        
        /// <summary>
        /// Gets or Sets WorkingProgress
        /// </summary>
        [DataMember(Name="workingProgress", EmitDefaultValue=false)]
        public int? WorkingProgress { get; set; }

        /// <summary>
        /// Possible values:  0: CompletedOk  1: CompletedPartialOk  2: CompletedKo  3: Deleted  4: Processing  5: Enqueued  6: Waiting  7: Failed 
        /// </summary>
        /// <value>Possible values:  0: CompletedOk  1: CompletedPartialOk  2: CompletedKo  3: Deleted  4: Processing  5: Enqueued  6: Waiting  7: Failed </value>
        [DataMember(Name="queueStatus", EmitDefaultValue=false)]
        public int? QueueStatus { get; set; }

        /// <summary>
        /// Gets or Sets IsCompleted
        /// </summary>
        [DataMember(Name="isCompleted", EmitDefaultValue=false)]
        public bool? IsCompleted { get; set; }

        /// <summary>
        /// Queue Identifier
        /// </summary>
        /// <value>Queue Identifier</value>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }

        /// <summary>
        /// Queue Name
        /// </summary>
        /// <value>Queue Name</value>
        [DataMember(Name="queueName", EmitDefaultValue=false)]
        public string QueueName { get; set; }

        /// <summary>
        /// Queue Type
        /// </summary>
        /// <value>Queue Type</value>
        [DataMember(Name="queueType", EmitDefaultValue=false)]
        public string QueueType { get; set; }

        /// <summary>
        /// Creation Date
        /// </summary>
        /// <value>Creation Date</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Expiration Date
        /// </summary>
        /// <value>Expiration Date</value>
        [DataMember(Name="expireAt", EmitDefaultValue=false)]
        public DateTime? ExpireAt { get; set; }

        /// <summary>
        /// Items
        /// </summary>
        /// <value>Items</value>
        [DataMember(Name="workItemCount", EmitDefaultValue=false)]
        public int? WorkItemCount { get; set; }

        /// <summary>
        /// Gets or Sets StateCount
        /// </summary>
        [DataMember(Name="stateCount", EmitDefaultValue=false)]
        public QueueStateAggregationInfoDto StateCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueAggregationStatusInfoDto {\n");
            sb.Append("  WorkingProgress: ").Append(WorkingProgress).Append("\n");
            sb.Append("  QueueStatus: ").Append(QueueStatus).Append("\n");
            sb.Append("  IsCompleted: ").Append(IsCompleted).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  QueueName: ").Append(QueueName).Append("\n");
            sb.Append("  QueueType: ").Append(QueueType).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ExpireAt: ").Append(ExpireAt).Append("\n");
            sb.Append("  WorkItemCount: ").Append(WorkItemCount).Append("\n");
            sb.Append("  StateCount: ").Append(StateCount).Append("\n");
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
            return this.Equals(input as QueueAggregationStatusInfoDto);
        }

        /// <summary>
        /// Returns true if QueueAggregationStatusInfoDto instances are equal
        /// </summary>
        /// <param name="input">Instance of QueueAggregationStatusInfoDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueAggregationStatusInfoDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WorkingProgress == input.WorkingProgress ||
                    (this.WorkingProgress != null &&
                    this.WorkingProgress.Equals(input.WorkingProgress))
                ) && 
                (
                    this.QueueStatus == input.QueueStatus ||
                    (this.QueueStatus != null &&
                    this.QueueStatus.Equals(input.QueueStatus))
                ) && 
                (
                    this.IsCompleted == input.IsCompleted ||
                    (this.IsCompleted != null &&
                    this.IsCompleted.Equals(input.IsCompleted))
                ) && 
                (
                    this.QueueId == input.QueueId ||
                    (this.QueueId != null &&
                    this.QueueId.Equals(input.QueueId))
                ) && 
                (
                    this.QueueName == input.QueueName ||
                    (this.QueueName != null &&
                    this.QueueName.Equals(input.QueueName))
                ) && 
                (
                    this.QueueType == input.QueueType ||
                    (this.QueueType != null &&
                    this.QueueType.Equals(input.QueueType))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.ExpireAt == input.ExpireAt ||
                    (this.ExpireAt != null &&
                    this.ExpireAt.Equals(input.ExpireAt))
                ) && 
                (
                    this.WorkItemCount == input.WorkItemCount ||
                    (this.WorkItemCount != null &&
                    this.WorkItemCount.Equals(input.WorkItemCount))
                ) && 
                (
                    this.StateCount == input.StateCount ||
                    (this.StateCount != null &&
                    this.StateCount.Equals(input.StateCount))
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
                if (this.WorkingProgress != null)
                    hashCode = hashCode * 59 + this.WorkingProgress.GetHashCode();
                if (this.QueueStatus != null)
                    hashCode = hashCode * 59 + this.QueueStatus.GetHashCode();
                if (this.IsCompleted != null)
                    hashCode = hashCode * 59 + this.IsCompleted.GetHashCode();
                if (this.QueueId != null)
                    hashCode = hashCode * 59 + this.QueueId.GetHashCode();
                if (this.QueueName != null)
                    hashCode = hashCode * 59 + this.QueueName.GetHashCode();
                if (this.QueueType != null)
                    hashCode = hashCode * 59 + this.QueueType.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ExpireAt != null)
                    hashCode = hashCode * 59 + this.ExpireAt.GetHashCode();
                if (this.WorkItemCount != null)
                    hashCode = hashCode * 59 + this.WorkItemCount.GetHashCode();
                if (this.StateCount != null)
                    hashCode = hashCode * 59 + this.StateCount.GetHashCode();
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
