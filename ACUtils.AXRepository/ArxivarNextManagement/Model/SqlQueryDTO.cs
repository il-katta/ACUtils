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
    /// Enum for Sql Query options
    /// </summary>
    [DataContract]
    public partial class SqlQueryDTO :  IEquatable<SqlQueryDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlQueryDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="sqlConnectionId">Sql connection identifier.</param>
        /// <param name="context">Possible values:  0: Generic  1: Workflow  2: Process .</param>
        /// <param name="type">Possible values:  0: WithResult  1: NoResult .</param>
        /// <param name="name">Description.</param>
        /// <param name="query">Sql text query.</param>
        /// <param name="orderBy">Sql order by fields.</param>
        /// <param name="formula">Sql Where formula.</param>
        /// <param name="referenceId">Reference identifier.</param>
        /// <param name="externalId">External identifier.</param>
        /// <param name="enableCache">Enable query result cache.</param>
        /// <param name="cacheDuration">Cache duration.</param>
        /// <param name="conditions">List of query conditions.</param>
        public SqlQueryDTO(string id = default(string), string sqlConnectionId = default(string), int? context = default(int?), int? type = default(int?), string name = default(string), string query = default(string), string orderBy = default(string), string formula = default(string), string referenceId = default(string), string externalId = default(string), bool? enableCache = default(bool?), int? cacheDuration = default(int?), List<SqlConditionBaseDTO> conditions = default(List<SqlConditionBaseDTO>))
        {
            this.Id = id;
            this.SqlConnectionId = sqlConnectionId;
            this.Context = context;
            this.Type = type;
            this.Name = name;
            this.Query = query;
            this.OrderBy = orderBy;
            this.Formula = formula;
            this.ReferenceId = referenceId;
            this.ExternalId = externalId;
            this.EnableCache = enableCache;
            this.CacheDuration = cacheDuration;
            this.Conditions = conditions;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Sql connection identifier
        /// </summary>
        /// <value>Sql connection identifier</value>
        [DataMember(Name="sqlConnectionId", EmitDefaultValue=false)]
        public string SqlConnectionId { get; set; }

        /// <summary>
        /// Possible values:  0: Generic  1: Workflow  2: Process 
        /// </summary>
        /// <value>Possible values:  0: Generic  1: Workflow  2: Process </value>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public int? Context { get; set; }

        /// <summary>
        /// Possible values:  0: WithResult  1: NoResult 
        /// </summary>
        /// <value>Possible values:  0: WithResult  1: NoResult </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int? Type { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Sql text query
        /// </summary>
        /// <value>Sql text query</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }

        /// <summary>
        /// Sql order by fields
        /// </summary>
        /// <value>Sql order by fields</value>
        [DataMember(Name="orderBy", EmitDefaultValue=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// Sql Where formula
        /// </summary>
        /// <value>Sql Where formula</value>
        [DataMember(Name="formula", EmitDefaultValue=false)]
        public string Formula { get; set; }

        /// <summary>
        /// Reference identifier
        /// </summary>
        /// <value>Reference identifier</value>
        [DataMember(Name="referenceId", EmitDefaultValue=false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// External identifier
        /// </summary>
        /// <value>External identifier</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Enable query result cache
        /// </summary>
        /// <value>Enable query result cache</value>
        [DataMember(Name="enableCache", EmitDefaultValue=false)]
        public bool? EnableCache { get; set; }

        /// <summary>
        /// Cache duration
        /// </summary>
        /// <value>Cache duration</value>
        [DataMember(Name="cacheDuration", EmitDefaultValue=false)]
        public int? CacheDuration { get; set; }

        /// <summary>
        /// List of query conditions
        /// </summary>
        /// <value>List of query conditions</value>
        [DataMember(Name="conditions", EmitDefaultValue=false)]
        public List<SqlConditionBaseDTO> Conditions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SqlQueryDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SqlConnectionId: ").Append(SqlConnectionId).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  OrderBy: ").Append(OrderBy).Append("\n");
            sb.Append("  Formula: ").Append(Formula).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  EnableCache: ").Append(EnableCache).Append("\n");
            sb.Append("  CacheDuration: ").Append(CacheDuration).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
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
            return this.Equals(input as SqlQueryDTO);
        }

        /// <summary>
        /// Returns true if SqlQueryDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SqlQueryDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SqlQueryDTO input)
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
                    this.SqlConnectionId == input.SqlConnectionId ||
                    (this.SqlConnectionId != null &&
                    this.SqlConnectionId.Equals(input.SqlConnectionId))
                ) && 
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
                ) && 
                (
                    this.OrderBy == input.OrderBy ||
                    (this.OrderBy != null &&
                    this.OrderBy.Equals(input.OrderBy))
                ) && 
                (
                    this.Formula == input.Formula ||
                    (this.Formula != null &&
                    this.Formula.Equals(input.Formula))
                ) && 
                (
                    this.ReferenceId == input.ReferenceId ||
                    (this.ReferenceId != null &&
                    this.ReferenceId.Equals(input.ReferenceId))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.EnableCache == input.EnableCache ||
                    (this.EnableCache != null &&
                    this.EnableCache.Equals(input.EnableCache))
                ) && 
                (
                    this.CacheDuration == input.CacheDuration ||
                    (this.CacheDuration != null &&
                    this.CacheDuration.Equals(input.CacheDuration))
                ) && 
                (
                    this.Conditions == input.Conditions ||
                    this.Conditions != null &&
                    this.Conditions.SequenceEqual(input.Conditions)
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
                if (this.SqlConnectionId != null)
                    hashCode = hashCode * 59 + this.SqlConnectionId.GetHashCode();
                if (this.Context != null)
                    hashCode = hashCode * 59 + this.Context.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.OrderBy != null)
                    hashCode = hashCode * 59 + this.OrderBy.GetHashCode();
                if (this.Formula != null)
                    hashCode = hashCode * 59 + this.Formula.GetHashCode();
                if (this.ReferenceId != null)
                    hashCode = hashCode * 59 + this.ReferenceId.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.EnableCache != null)
                    hashCode = hashCode * 59 + this.EnableCache.GetHashCode();
                if (this.CacheDuration != null)
                    hashCode = hashCode * 59 + this.CacheDuration.GetHashCode();
                if (this.Conditions != null)
                    hashCode = hashCode * 59 + this.Conditions.GetHashCode();
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
