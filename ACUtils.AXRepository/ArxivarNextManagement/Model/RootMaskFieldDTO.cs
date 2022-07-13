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
    /// Class of root mask field
    /// </summary>
    [DataContract]
    public partial class RootMaskFieldDTO :  IEquatable<RootMaskFieldDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RootMaskFieldDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="field">Field.</param>
        /// <param name="isSystem">Is system field.</param>
        /// <param name="_readonly">Is Readonly.</param>
        /// <param name="required">Is read-only.</param>
        /// <param name="order">Order.</param>
        public RootMaskFieldDTO(string id = default(string), FieldManagementDTO field = default(FieldManagementDTO), bool? isSystem = default(bool?), bool? _readonly = default(bool?), bool? required = default(bool?), int? order = default(int?))
        {
            this.Id = id;
            this.Field = field;
            this.IsSystem = isSystem;
            this.Readonly = _readonly;
            this.Required = required;
            this.Order = order;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Field
        /// </summary>
        /// <value>Field</value>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public FieldManagementDTO Field { get; set; }

        /// <summary>
        /// Is system field
        /// </summary>
        /// <value>Is system field</value>
        [DataMember(Name="isSystem", EmitDefaultValue=false)]
        public bool? IsSystem { get; set; }

        /// <summary>
        /// Is Readonly
        /// </summary>
        /// <value>Is Readonly</value>
        [DataMember(Name="readonly", EmitDefaultValue=false)]
        public bool? Readonly { get; set; }

        /// <summary>
        /// Is read-only
        /// </summary>
        /// <value>Is read-only</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; set; }

        /// <summary>
        /// Order
        /// </summary>
        /// <value>Order</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int? Order { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RootMaskFieldDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
            sb.Append("  Readonly: ").Append(Readonly).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
            return this.Equals(input as RootMaskFieldDTO);
        }

        /// <summary>
        /// Returns true if RootMaskFieldDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of RootMaskFieldDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RootMaskFieldDTO input)
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
                    this.Field == input.Field ||
                    (this.Field != null &&
                    this.Field.Equals(input.Field))
                ) && 
                (
                    this.IsSystem == input.IsSystem ||
                    (this.IsSystem != null &&
                    this.IsSystem.Equals(input.IsSystem))
                ) && 
                (
                    this.Readonly == input.Readonly ||
                    (this.Readonly != null &&
                    this.Readonly.Equals(input.Readonly))
                ) && 
                (
                    this.Required == input.Required ||
                    (this.Required != null &&
                    this.Required.Equals(input.Required))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
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
                if (this.Field != null)
                    hashCode = hashCode * 59 + this.Field.GetHashCode();
                if (this.IsSystem != null)
                    hashCode = hashCode * 59 + this.IsSystem.GetHashCode();
                if (this.Readonly != null)
                    hashCode = hashCode * 59 + this.Readonly.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
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
