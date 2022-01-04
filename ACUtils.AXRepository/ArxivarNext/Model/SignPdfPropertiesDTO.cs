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
    /// Class of settings of pdf signature
    /// </summary>
    [DataContract]
        public partial class SignPdfPropertiesDTO :  IEquatable<SignPdfPropertiesDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignPdfPropertiesDTO" /> class.
        /// </summary>
        /// <param name="page">Page Number.</param>
        /// <param name="positionX">X Positin.</param>
        /// <param name="positionY">Y Position.</param>
        /// <param name="sizeWidth">Width.</param>
        /// <param name="sizeHeight">Heigth.</param>
        /// <param name="reason">Reason.</param>
        /// <param name="showCN">Label of Common Name.</param>
        /// <param name="showEmail">Show Email.</param>
        /// <param name="showCF">Show Fiscal Code.</param>
        /// <param name="showIssuer">Show Issuer.</param>
        /// <param name="showTime">Show Datetime of Signature.</param>
        public SignPdfPropertiesDTO(int? page = default(int?), int? positionX = default(int?), int? positionY = default(int?), int? sizeWidth = default(int?), int? sizeHeight = default(int?), string reason = default(string), bool? showCN = default(bool?), bool? showEmail = default(bool?), bool? showCF = default(bool?), bool? showIssuer = default(bool?), bool? showTime = default(bool?))
        {
            this.Page = page;
            this.PositionX = positionX;
            this.PositionY = positionY;
            this.SizeWidth = sizeWidth;
            this.SizeHeight = sizeHeight;
            this.Reason = reason;
            this.ShowCN = showCN;
            this.ShowEmail = showEmail;
            this.ShowCF = showCF;
            this.ShowIssuer = showIssuer;
            this.ShowTime = showTime;
        }
        
        /// <summary>
        /// Page Number
        /// </summary>
        /// <value>Page Number</value>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public int? Page { get; set; }

        /// <summary>
        /// X Positin
        /// </summary>
        /// <value>X Positin</value>
        [DataMember(Name="positionX", EmitDefaultValue=false)]
        public int? PositionX { get; set; }

        /// <summary>
        /// Y Position
        /// </summary>
        /// <value>Y Position</value>
        [DataMember(Name="positionY", EmitDefaultValue=false)]
        public int? PositionY { get; set; }

        /// <summary>
        /// Width
        /// </summary>
        /// <value>Width</value>
        [DataMember(Name="sizeWidth", EmitDefaultValue=false)]
        public int? SizeWidth { get; set; }

        /// <summary>
        /// Heigth
        /// </summary>
        /// <value>Heigth</value>
        [DataMember(Name="sizeHeight", EmitDefaultValue=false)]
        public int? SizeHeight { get; set; }

        /// <summary>
        /// Reason
        /// </summary>
        /// <value>Reason</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Label of Common Name
        /// </summary>
        /// <value>Label of Common Name</value>
        [DataMember(Name="showCN", EmitDefaultValue=false)]
        public bool? ShowCN { get; set; }

        /// <summary>
        /// Show Email
        /// </summary>
        /// <value>Show Email</value>
        [DataMember(Name="showEmail", EmitDefaultValue=false)]
        public bool? ShowEmail { get; set; }

        /// <summary>
        /// Show Fiscal Code
        /// </summary>
        /// <value>Show Fiscal Code</value>
        [DataMember(Name="showCF", EmitDefaultValue=false)]
        public bool? ShowCF { get; set; }

        /// <summary>
        /// Show Issuer
        /// </summary>
        /// <value>Show Issuer</value>
        [DataMember(Name="showIssuer", EmitDefaultValue=false)]
        public bool? ShowIssuer { get; set; }

        /// <summary>
        /// Show Datetime of Signature
        /// </summary>
        /// <value>Show Datetime of Signature</value>
        [DataMember(Name="showTime", EmitDefaultValue=false)]
        public bool? ShowTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignPdfPropertiesDTO {\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  PositionX: ").Append(PositionX).Append("\n");
            sb.Append("  PositionY: ").Append(PositionY).Append("\n");
            sb.Append("  SizeWidth: ").Append(SizeWidth).Append("\n");
            sb.Append("  SizeHeight: ").Append(SizeHeight).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  ShowCN: ").Append(ShowCN).Append("\n");
            sb.Append("  ShowEmail: ").Append(ShowEmail).Append("\n");
            sb.Append("  ShowCF: ").Append(ShowCF).Append("\n");
            sb.Append("  ShowIssuer: ").Append(ShowIssuer).Append("\n");
            sb.Append("  ShowTime: ").Append(ShowTime).Append("\n");
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
            return this.Equals(input as SignPdfPropertiesDTO);
        }

        /// <summary>
        /// Returns true if SignPdfPropertiesDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SignPdfPropertiesDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignPdfPropertiesDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
                ) && 
                (
                    this.PositionX == input.PositionX ||
                    (this.PositionX != null &&
                    this.PositionX.Equals(input.PositionX))
                ) && 
                (
                    this.PositionY == input.PositionY ||
                    (this.PositionY != null &&
                    this.PositionY.Equals(input.PositionY))
                ) && 
                (
                    this.SizeWidth == input.SizeWidth ||
                    (this.SizeWidth != null &&
                    this.SizeWidth.Equals(input.SizeWidth))
                ) && 
                (
                    this.SizeHeight == input.SizeHeight ||
                    (this.SizeHeight != null &&
                    this.SizeHeight.Equals(input.SizeHeight))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.ShowCN == input.ShowCN ||
                    (this.ShowCN != null &&
                    this.ShowCN.Equals(input.ShowCN))
                ) && 
                (
                    this.ShowEmail == input.ShowEmail ||
                    (this.ShowEmail != null &&
                    this.ShowEmail.Equals(input.ShowEmail))
                ) && 
                (
                    this.ShowCF == input.ShowCF ||
                    (this.ShowCF != null &&
                    this.ShowCF.Equals(input.ShowCF))
                ) && 
                (
                    this.ShowIssuer == input.ShowIssuer ||
                    (this.ShowIssuer != null &&
                    this.ShowIssuer.Equals(input.ShowIssuer))
                ) && 
                (
                    this.ShowTime == input.ShowTime ||
                    (this.ShowTime != null &&
                    this.ShowTime.Equals(input.ShowTime))
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
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.PositionX != null)
                    hashCode = hashCode * 59 + this.PositionX.GetHashCode();
                if (this.PositionY != null)
                    hashCode = hashCode * 59 + this.PositionY.GetHashCode();
                if (this.SizeWidth != null)
                    hashCode = hashCode * 59 + this.SizeWidth.GetHashCode();
                if (this.SizeHeight != null)
                    hashCode = hashCode * 59 + this.SizeHeight.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.ShowCN != null)
                    hashCode = hashCode * 59 + this.ShowCN.GetHashCode();
                if (this.ShowEmail != null)
                    hashCode = hashCode * 59 + this.ShowEmail.GetHashCode();
                if (this.ShowCF != null)
                    hashCode = hashCode * 59 + this.ShowCF.GetHashCode();
                if (this.ShowIssuer != null)
                    hashCode = hashCode * 59 + this.ShowIssuer.GetHashCode();
                if (this.ShowTime != null)
                    hashCode = hashCode * 59 + this.ShowTime.GetHashCode();
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
