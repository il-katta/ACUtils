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
    /// Class for additional field of type MultiValue
    /// </summary>
    [DataContract]
    public partial class AdditionalFieldManagementMultivalueDTO : AdditionalFieldManagementBaseDTO,  IEquatable<AdditionalFieldManagementMultivalueDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalFieldManagementMultivalueDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdditionalFieldManagementMultivalueDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalFieldManagementMultivalueDTO" /> class.
        /// </summary>
        /// <param name="dataGroup">Data group.</param>
        /// <param name="numMaxChar">Maximum number of characters.</param>
        /// <param name="limitToList">Possible values​limited to the list.</param>
        /// <param name="autoinsert">Automatic insert.</param>
        /// <param name="autocomplete">Autocomplete.</param>
        /// <param name="autocompleteCharacter">Autocomplete character.</param>
        /// <param name="autocompleteAlign">Possible values:  0: Left  1: Right  -1: None .</param>
        /// <param name="locked">Field locked (readonly).</param>
        public AdditionalFieldManagementMultivalueDTO(DataGroupSimpleDTO dataGroup = default(DataGroupSimpleDTO), int? numMaxChar = default(int?), bool? limitToList = default(bool?), bool? autoinsert = default(bool?), bool? autocomplete = default(bool?), string autocompleteCharacter = default(string), int? autocompleteAlign = default(int?), bool? locked = default(bool?), string className = "AdditionalFieldManagementMultivalueDTO", string key = default(string), string description = default(string), FieldGroupSimpleDTO fieldGroup = default(FieldGroupSimpleDTO), DocumentTypeSimpleDTO documentType = default(DocumentTypeSimpleDTO), string referenceId = default(string), int? order = default(int?), bool? required = default(bool?), bool? visible = default(bool?), string externalId = default(string), string formula = default(string), List<AdditionalFieldManagementTranslationDTO> translations = default(List<AdditionalFieldManagementTranslationDTO>)) : base(className, key, description, fieldGroup, documentType, referenceId, order, required, visible, externalId, formula, translations)
        {
            this.DataGroup = dataGroup;
            this.NumMaxChar = numMaxChar;
            this.LimitToList = limitToList;
            this.Autoinsert = autoinsert;
            this.Autocomplete = autocomplete;
            this.AutocompleteCharacter = autocompleteCharacter;
            this.AutocompleteAlign = autocompleteAlign;
            this.Locked = locked;
        }
        
        /// <summary>
        /// Data group
        /// </summary>
        /// <value>Data group</value>
        [DataMember(Name="dataGroup", EmitDefaultValue=false)]
        public DataGroupSimpleDTO DataGroup { get; set; }

        /// <summary>
        /// Maximum number of characters
        /// </summary>
        /// <value>Maximum number of characters</value>
        [DataMember(Name="numMaxChar", EmitDefaultValue=false)]
        public int? NumMaxChar { get; set; }

        /// <summary>
        /// Possible values​limited to the list
        /// </summary>
        /// <value>Possible values​limited to the list</value>
        [DataMember(Name="limitToList", EmitDefaultValue=false)]
        public bool? LimitToList { get; set; }

        /// <summary>
        /// Automatic insert
        /// </summary>
        /// <value>Automatic insert</value>
        [DataMember(Name="autoinsert", EmitDefaultValue=false)]
        public bool? Autoinsert { get; set; }

        /// <summary>
        /// Autocomplete
        /// </summary>
        /// <value>Autocomplete</value>
        [DataMember(Name="autocomplete", EmitDefaultValue=false)]
        public bool? Autocomplete { get; set; }

        /// <summary>
        /// Autocomplete character
        /// </summary>
        /// <value>Autocomplete character</value>
        [DataMember(Name="autocompleteCharacter", EmitDefaultValue=false)]
        public string AutocompleteCharacter { get; set; }

        /// <summary>
        /// Possible values:  0: Left  1: Right  -1: None 
        /// </summary>
        /// <value>Possible values:  0: Left  1: Right  -1: None </value>
        [DataMember(Name="autocompleteAlign", EmitDefaultValue=false)]
        public int? AutocompleteAlign { get; set; }

        /// <summary>
        /// Field locked (readonly)
        /// </summary>
        /// <value>Field locked (readonly)</value>
        [DataMember(Name="locked", EmitDefaultValue=false)]
        public bool? Locked { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalFieldManagementMultivalueDTO {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  DataGroup: ").Append(DataGroup).Append("\n");
            sb.Append("  NumMaxChar: ").Append(NumMaxChar).Append("\n");
            sb.Append("  LimitToList: ").Append(LimitToList).Append("\n");
            sb.Append("  Autoinsert: ").Append(Autoinsert).Append("\n");
            sb.Append("  Autocomplete: ").Append(Autocomplete).Append("\n");
            sb.Append("  AutocompleteCharacter: ").Append(AutocompleteCharacter).Append("\n");
            sb.Append("  AutocompleteAlign: ").Append(AutocompleteAlign).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as AdditionalFieldManagementMultivalueDTO);
        }

        /// <summary>
        /// Returns true if AdditionalFieldManagementMultivalueDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalFieldManagementMultivalueDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalFieldManagementMultivalueDTO input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.DataGroup == input.DataGroup ||
                    (this.DataGroup != null &&
                    this.DataGroup.Equals(input.DataGroup))
                ) && base.Equals(input) && 
                (
                    this.NumMaxChar == input.NumMaxChar ||
                    (this.NumMaxChar != null &&
                    this.NumMaxChar.Equals(input.NumMaxChar))
                ) && base.Equals(input) && 
                (
                    this.LimitToList == input.LimitToList ||
                    (this.LimitToList != null &&
                    this.LimitToList.Equals(input.LimitToList))
                ) && base.Equals(input) && 
                (
                    this.Autoinsert == input.Autoinsert ||
                    (this.Autoinsert != null &&
                    this.Autoinsert.Equals(input.Autoinsert))
                ) && base.Equals(input) && 
                (
                    this.Autocomplete == input.Autocomplete ||
                    (this.Autocomplete != null &&
                    this.Autocomplete.Equals(input.Autocomplete))
                ) && base.Equals(input) && 
                (
                    this.AutocompleteCharacter == input.AutocompleteCharacter ||
                    (this.AutocompleteCharacter != null &&
                    this.AutocompleteCharacter.Equals(input.AutocompleteCharacter))
                ) && base.Equals(input) && 
                (
                    this.AutocompleteAlign == input.AutocompleteAlign ||
                    (this.AutocompleteAlign != null &&
                    this.AutocompleteAlign.Equals(input.AutocompleteAlign))
                ) && base.Equals(input) && 
                (
                    this.Locked == input.Locked ||
                    (this.Locked != null &&
                    this.Locked.Equals(input.Locked))
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
                int hashCode = base.GetHashCode();
                if (this.DataGroup != null)
                    hashCode = hashCode * 59 + this.DataGroup.GetHashCode();
                if (this.NumMaxChar != null)
                    hashCode = hashCode * 59 + this.NumMaxChar.GetHashCode();
                if (this.LimitToList != null)
                    hashCode = hashCode * 59 + this.LimitToList.GetHashCode();
                if (this.Autoinsert != null)
                    hashCode = hashCode * 59 + this.Autoinsert.GetHashCode();
                if (this.Autocomplete != null)
                    hashCode = hashCode * 59 + this.Autocomplete.GetHashCode();
                if (this.AutocompleteCharacter != null)
                    hashCode = hashCode * 59 + this.AutocompleteCharacter.GetHashCode();
                if (this.AutocompleteAlign != null)
                    hashCode = hashCode * 59 + this.AutocompleteAlign.GetHashCode();
                if (this.Locked != null)
                    hashCode = hashCode * 59 + this.Locked.GetHashCode();
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
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
