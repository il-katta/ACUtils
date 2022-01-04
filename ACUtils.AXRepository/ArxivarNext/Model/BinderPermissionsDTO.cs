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
    /// Class of binder permission
    /// </summary>
    [DataContract]
        public partial class BinderPermissionsDTO :  IEquatable<BinderPermissionsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BinderPermissionsDTO" /> class.
        /// </summary>
        /// <param name="spread">Spread to binders.</param>
        /// <param name="usersPermissions">List of user permissions.</param>
        /// <param name="permissionsProperties">Permission Properties.</param>
        public BinderPermissionsDTO(bool? spread = default(bool?), List<UserPermissionDTO> usersPermissions = default(List<UserPermissionDTO>), List<PermissionPropertiesDTO> permissionsProperties = default(List<PermissionPropertiesDTO>))
        {
            this.Spread = spread;
            this.UsersPermissions = usersPermissions;
            this.PermissionsProperties = permissionsProperties;
        }
        
        /// <summary>
        /// Spread to binders
        /// </summary>
        /// <value>Spread to binders</value>
        [DataMember(Name="spread", EmitDefaultValue=false)]
        public bool? Spread { get; set; }

        /// <summary>
        /// List of user permissions
        /// </summary>
        /// <value>List of user permissions</value>
        [DataMember(Name="usersPermissions", EmitDefaultValue=false)]
        public List<UserPermissionDTO> UsersPermissions { get; set; }

        /// <summary>
        /// Permission Properties
        /// </summary>
        /// <value>Permission Properties</value>
        [DataMember(Name="permissionsProperties", EmitDefaultValue=false)]
        public List<PermissionPropertiesDTO> PermissionsProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BinderPermissionsDTO {\n");
            sb.Append("  Spread: ").Append(Spread).Append("\n");
            sb.Append("  UsersPermissions: ").Append(UsersPermissions).Append("\n");
            sb.Append("  PermissionsProperties: ").Append(PermissionsProperties).Append("\n");
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
            return this.Equals(input as BinderPermissionsDTO);
        }

        /// <summary>
        /// Returns true if BinderPermissionsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of BinderPermissionsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BinderPermissionsDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Spread == input.Spread ||
                    (this.Spread != null &&
                    this.Spread.Equals(input.Spread))
                ) && 
                (
                    this.UsersPermissions == input.UsersPermissions ||
                    this.UsersPermissions != null &&
                    input.UsersPermissions != null &&
                    this.UsersPermissions.SequenceEqual(input.UsersPermissions)
                ) && 
                (
                    this.PermissionsProperties == input.PermissionsProperties ||
                    this.PermissionsProperties != null &&
                    input.PermissionsProperties != null &&
                    this.PermissionsProperties.SequenceEqual(input.PermissionsProperties)
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
                if (this.Spread != null)
                    hashCode = hashCode * 59 + this.Spread.GetHashCode();
                if (this.UsersPermissions != null)
                    hashCode = hashCode * 59 + this.UsersPermissions.GetHashCode();
                if (this.PermissionsProperties != null)
                    hashCode = hashCode * 59 + this.PermissionsProperties.GetHashCode();
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
