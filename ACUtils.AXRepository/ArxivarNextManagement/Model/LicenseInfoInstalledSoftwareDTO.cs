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
    /// Class of installed modules/software
    /// </summary>
    [DataContract]
    public partial class LicenseInfoInstalledSoftwareDTO :  IEquatable<LicenseInfoInstalledSoftwareDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseInfoInstalledSoftwareDTO" /> class.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="specification">Details.</param>
        /// <param name="machineKey">Machine Key.</param>
        /// <param name="creationDate">Creation date.</param>
        /// <param name="version">Software associations.</param>
        public LicenseInfoInstalledSoftwareDTO(string name = default(string), string specification = default(string), string machineKey = default(string), DateTime? creationDate = default(DateTime?), string version = default(string))
        {
            this.Name = name;
            this.Specification = specification;
            this.MachineKey = machineKey;
            this.CreationDate = creationDate;
            this.Version = version;
        }
        
        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Details
        /// </summary>
        /// <value>Details</value>
        [DataMember(Name="specification", EmitDefaultValue=false)]
        public string Specification { get; set; }

        /// <summary>
        /// Machine Key
        /// </summary>
        /// <value>Machine Key</value>
        [DataMember(Name="machineKey", EmitDefaultValue=false)]
        public string MachineKey { get; set; }

        /// <summary>
        /// Creation date
        /// </summary>
        /// <value>Creation date</value>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Software associations
        /// </summary>
        /// <value>Software associations</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LicenseInfoInstalledSoftwareDTO {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Specification: ").Append(Specification).Append("\n");
            sb.Append("  MachineKey: ").Append(MachineKey).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as LicenseInfoInstalledSoftwareDTO);
        }

        /// <summary>
        /// Returns true if LicenseInfoInstalledSoftwareDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of LicenseInfoInstalledSoftwareDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicenseInfoInstalledSoftwareDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Specification == input.Specification ||
                    (this.Specification != null &&
                    this.Specification.Equals(input.Specification))
                ) && 
                (
                    this.MachineKey == input.MachineKey ||
                    (this.MachineKey != null &&
                    this.MachineKey.Equals(input.MachineKey))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Specification != null)
                    hashCode = hashCode * 59 + this.Specification.GetHashCode();
                if (this.MachineKey != null)
                    hashCode = hashCode * 59 + this.MachineKey.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
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
