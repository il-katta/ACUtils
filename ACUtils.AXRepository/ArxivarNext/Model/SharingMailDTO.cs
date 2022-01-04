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
    /// SharingMailDTO
    /// </summary>
    [DataContract]
        public partial class SharingMailDTO :  IEquatable<SharingMailDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharingMailDTO" /> class.
        /// </summary>
        /// <param name="mailSubject">Subject..</param>
        /// <param name="mailBodyHeader">Body Header..</param>
        /// <param name="mailBodyContent">Body Content..</param>
        /// <param name="mailBodyFooter">Body Footer..</param>
        /// <param name="lang">Lang code..</param>
        public SharingMailDTO(string mailSubject = default(string), string mailBodyHeader = default(string), string mailBodyContent = default(string), string mailBodyFooter = default(string), string lang = default(string))
        {
            this.MailSubject = mailSubject;
            this.MailBodyHeader = mailBodyHeader;
            this.MailBodyContent = mailBodyContent;
            this.MailBodyFooter = mailBodyFooter;
            this.Lang = lang;
        }
        
        /// <summary>
        /// Subject.
        /// </summary>
        /// <value>Subject.</value>
        [DataMember(Name="mailSubject", EmitDefaultValue=false)]
        public string MailSubject { get; set; }

        /// <summary>
        /// Body Header.
        /// </summary>
        /// <value>Body Header.</value>
        [DataMember(Name="mailBodyHeader", EmitDefaultValue=false)]
        public string MailBodyHeader { get; set; }

        /// <summary>
        /// Body Content.
        /// </summary>
        /// <value>Body Content.</value>
        [DataMember(Name="mailBodyContent", EmitDefaultValue=false)]
        public string MailBodyContent { get; set; }

        /// <summary>
        /// Body Footer.
        /// </summary>
        /// <value>Body Footer.</value>
        [DataMember(Name="mailBodyFooter", EmitDefaultValue=false)]
        public string MailBodyFooter { get; set; }

        /// <summary>
        /// Lang code.
        /// </summary>
        /// <value>Lang code.</value>
        [DataMember(Name="lang", EmitDefaultValue=false)]
        public string Lang { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SharingMailDTO {\n");
            sb.Append("  MailSubject: ").Append(MailSubject).Append("\n");
            sb.Append("  MailBodyHeader: ").Append(MailBodyHeader).Append("\n");
            sb.Append("  MailBodyContent: ").Append(MailBodyContent).Append("\n");
            sb.Append("  MailBodyFooter: ").Append(MailBodyFooter).Append("\n");
            sb.Append("  Lang: ").Append(Lang).Append("\n");
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
            return this.Equals(input as SharingMailDTO);
        }

        /// <summary>
        /// Returns true if SharingMailDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SharingMailDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharingMailDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MailSubject == input.MailSubject ||
                    (this.MailSubject != null &&
                    this.MailSubject.Equals(input.MailSubject))
                ) && 
                (
                    this.MailBodyHeader == input.MailBodyHeader ||
                    (this.MailBodyHeader != null &&
                    this.MailBodyHeader.Equals(input.MailBodyHeader))
                ) && 
                (
                    this.MailBodyContent == input.MailBodyContent ||
                    (this.MailBodyContent != null &&
                    this.MailBodyContent.Equals(input.MailBodyContent))
                ) && 
                (
                    this.MailBodyFooter == input.MailBodyFooter ||
                    (this.MailBodyFooter != null &&
                    this.MailBodyFooter.Equals(input.MailBodyFooter))
                ) && 
                (
                    this.Lang == input.Lang ||
                    (this.Lang != null &&
                    this.Lang.Equals(input.Lang))
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
                if (this.MailSubject != null)
                    hashCode = hashCode * 59 + this.MailSubject.GetHashCode();
                if (this.MailBodyHeader != null)
                    hashCode = hashCode * 59 + this.MailBodyHeader.GetHashCode();
                if (this.MailBodyContent != null)
                    hashCode = hashCode * 59 + this.MailBodyContent.GetHashCode();
                if (this.MailBodyFooter != null)
                    hashCode = hashCode * 59 + this.MailBodyFooter.GetHashCode();
                if (this.Lang != null)
                    hashCode = hashCode * 59 + this.Lang.GetHashCode();
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
