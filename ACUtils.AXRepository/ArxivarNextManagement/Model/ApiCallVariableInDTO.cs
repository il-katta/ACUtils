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
    /// Class of API call variable
    /// </summary>
    [DataContract]
    public partial class ApiCallVariableInDTO :  IEquatable<ApiCallVariableInDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiCallVariableInDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="type">Possible values:  0: System  1: SystemAuth  2: Api  3: Custom  4: Profile  5: Variable .</param>
        /// <param name="name">Name.</param>
        /// <param name="defaultValue">Default value.</param>
        /// <param name="isEncrypted">Boolean represents if variable is encrypted.</param>
        /// <param name="apiCallId">Login API call identifier.</param>
        /// <param name="apiCallVariableOutId">Login API call variable out identifier.</param>
        public ApiCallVariableInDTO(int? id = default(int?), int? type = default(int?), string name = default(string), string defaultValue = default(string), bool? isEncrypted = default(bool?), int? apiCallId = default(int?), int? apiCallVariableOutId = default(int?))
        {
            this.Id = id;
            this.Type = type;
            this.Name = name;
            this.DefaultValue = defaultValue;
            this.IsEncrypted = isEncrypted;
            this.ApiCallId = apiCallId;
            this.ApiCallVariableOutId = apiCallVariableOutId;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Possible values:  0: System  1: SystemAuth  2: Api  3: Custom  4: Profile  5: Variable 
        /// </summary>
        /// <value>Possible values:  0: System  1: SystemAuth  2: Api  3: Custom  4: Profile  5: Variable </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int? Type { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Default value
        /// </summary>
        /// <value>Default value</value>
        [DataMember(Name="defaultValue", EmitDefaultValue=false)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Boolean represents if variable is encrypted
        /// </summary>
        /// <value>Boolean represents if variable is encrypted</value>
        [DataMember(Name="isEncrypted", EmitDefaultValue=false)]
        public bool? IsEncrypted { get; set; }

        /// <summary>
        /// Login API call identifier
        /// </summary>
        /// <value>Login API call identifier</value>
        [DataMember(Name="apiCallId", EmitDefaultValue=false)]
        public int? ApiCallId { get; set; }

        /// <summary>
        /// Login API call variable out identifier
        /// </summary>
        /// <value>Login API call variable out identifier</value>
        [DataMember(Name="apiCallVariableOutId", EmitDefaultValue=false)]
        public int? ApiCallVariableOutId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiCallVariableInDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  IsEncrypted: ").Append(IsEncrypted).Append("\n");
            sb.Append("  ApiCallId: ").Append(ApiCallId).Append("\n");
            sb.Append("  ApiCallVariableOutId: ").Append(ApiCallVariableOutId).Append("\n");
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
            return this.Equals(input as ApiCallVariableInDTO);
        }

        /// <summary>
        /// Returns true if ApiCallVariableInDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiCallVariableInDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiCallVariableInDTO input)
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
                    this.DefaultValue == input.DefaultValue ||
                    (this.DefaultValue != null &&
                    this.DefaultValue.Equals(input.DefaultValue))
                ) && 
                (
                    this.IsEncrypted == input.IsEncrypted ||
                    (this.IsEncrypted != null &&
                    this.IsEncrypted.Equals(input.IsEncrypted))
                ) && 
                (
                    this.ApiCallId == input.ApiCallId ||
                    (this.ApiCallId != null &&
                    this.ApiCallId.Equals(input.ApiCallId))
                ) && 
                (
                    this.ApiCallVariableOutId == input.ApiCallVariableOutId ||
                    (this.ApiCallVariableOutId != null &&
                    this.ApiCallVariableOutId.Equals(input.ApiCallVariableOutId))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DefaultValue != null)
                    hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                if (this.IsEncrypted != null)
                    hashCode = hashCode * 59 + this.IsEncrypted.GetHashCode();
                if (this.ApiCallId != null)
                    hashCode = hashCode * 59 + this.ApiCallId.GetHashCode();
                if (this.ApiCallVariableOutId != null)
                    hashCode = hashCode * 59 + this.ApiCallVariableOutId.GetHashCode();
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