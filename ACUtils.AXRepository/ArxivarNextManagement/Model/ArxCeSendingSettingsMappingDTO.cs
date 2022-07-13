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
    /// Class of ArxCe sending rule mapping
    /// </summary>
    [DataContract]
    public partial class ArxCeSendingSettingsMappingDTO :  IEquatable<ArxCeSendingSettingsMappingDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArxCeSendingSettingsMappingDTO" /> class.
        /// </summary>
        /// <param name="name">ArxCe field name.</param>
        /// <param name="description">ArxCe field description.</param>
        /// <param name="arxField">Arxivar field.</param>
        /// <param name="fieldType">Possible values:  0: String  1: Int  2: Date  3: DateTime  4: Double  5: Bit .</param>
        /// <param name="fieldValidation">Possible values:  0: None  1: FiscalCode  2: VatCode .</param>
        /// <param name="required">ArxCe required field.</param>
        /// <param name="metadataType">Possible values:  0: Generico  1: ModalitaDiFormazione  2: DatiDiRegistrazioneTipologiaDiFlusso  3: DatiDiRegistrazioneTipoRegistro  4: DatiDiRegistrazioneDataRegistrazione  5: DatiDiRegistrazioneNumeroDocumento  6: DatiDiRegistrazioneCodiceRegistro  7: ChiaveDescrittivaOggetto  8: ChiaveDescrittivaParoleChiave  9: ClassificazioneIndiceDiClassificazione  10: ClassificazioneDescrizione  11: ClassificazionePianoDiClassificazione  12: Riservato  13: IdentificativoDelFormatoProdottoSoftwareNomeProdotto  14: IdentificativoDelFormatoProdottoSoftwareVersioneProdotto  15: IdentificativoDelFormatoProdottoSoftwareProduttore  16: Note  17: SoggettiAutoreNome  18: SoggettiAutoreCognome  19: SoggettiAutoreCodiceFiscale  20: SoggettiAutoreRagioneSociale  21: SoggettiAutorePartitaIva  22: SoggettiAutoreCodiceIpa  23: SoggettiAutoreCodiceUnivocoUfficio  24: SoggettiMittenteNome  25: SoggettiMittenteCognome  26: SoggettiMittenteCodiceFiscale  27: SoggettiMittenteRagioneSociale  28: SoggettiMittentePartitaIva  29: SoggettiMittenteCodiceIpa  30: SoggettiMittenteCodiceUnivocoUfficio  31: SoggettiDestinatarioNome  32: SoggettiDestinatarioCognome  33: SoggettiDestinatarioCodiceFiscale  34: SoggettiDestinatarioRagioneSociale  35: SoggettiDestinatarioPartitaIva  36: SoggettiDestinatarioCodiceIpa  37: SoggettiDestinatarioCodiceUnivocoUfficio  38: SoggettiOperatoreNome  39: SoggettiOperatoreCognome  40: SoggettiOperatoreCodiceFiscale  41: SoggettiOperatoreRagioneSociale  42: SoggettiOperatorePartitaIva  43: SoggettiOperatoreCodiceIpa  44: SoggettiOperatoreCodiceUnivocoUfficio  45: TempoDiConservazione  46: SoggettiSoggettoCheEffettuaLaRegistrazioneNome  47: SoggettiSoggettoCheEffettuaLaRegistrazioneCognome  48: SoggettiSoggettoCheEffettuaLaRegistrazioneRagioneSociale  49: SoggettiSoggettoCheEffettuaLaRegistrazioneCodiceFiscale  50: SoggettiSoggettoCheEffettuaLaRegistrazionePartitaIva  51: SoggettiSoggettoCheEffettuaLaRegistrazioneCodiceUnivocoUfficio  52: SoggettiSoggettoCheEffettuaLaRegistrazioneCodiceIpa .</param>
        /// <param name="fieldMetadataAdvancedOptions">Metadata field advanced options.</param>
        /// <param name="allowedValues">Allowed values.</param>
        /// <param name="inputMode">Possible values:  0: Single  1: SingleSelectable .</param>
        public ArxCeSendingSettingsMappingDTO(string name = default(string), string description = default(string), FieldManagementDTO arxField = default(FieldManagementDTO), int? fieldType = default(int?), int? fieldValidation = default(int?), bool? required = default(bool?), int? metadataType = default(int?), ArxCeFieldMetadataAdvancedOptionsDTO fieldMetadataAdvancedOptions = default(ArxCeFieldMetadataAdvancedOptionsDTO), List<string> allowedValues = default(List<string>), int? inputMode = default(int?))
        {
            this.Name = name;
            this.Description = description;
            this.ArxField = arxField;
            this.FieldType = fieldType;
            this.FieldValidation = fieldValidation;
            this.Required = required;
            this.MetadataType = metadataType;
            this.FieldMetadataAdvancedOptions = fieldMetadataAdvancedOptions;
            this.AllowedValues = allowedValues;
            this.InputMode = inputMode;
        }
        
        /// <summary>
        /// ArxCe field name
        /// </summary>
        /// <value>ArxCe field name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// ArxCe field description
        /// </summary>
        /// <value>ArxCe field description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Arxivar field
        /// </summary>
        /// <value>Arxivar field</value>
        [DataMember(Name="arxField", EmitDefaultValue=false)]
        public FieldManagementDTO ArxField { get; set; }

        /// <summary>
        /// Possible values:  0: String  1: Int  2: Date  3: DateTime  4: Double  5: Bit 
        /// </summary>
        /// <value>Possible values:  0: String  1: Int  2: Date  3: DateTime  4: Double  5: Bit </value>
        [DataMember(Name="fieldType", EmitDefaultValue=false)]
        public int? FieldType { get; set; }

        /// <summary>
        /// Possible values:  0: None  1: FiscalCode  2: VatCode 
        /// </summary>
        /// <value>Possible values:  0: None  1: FiscalCode  2: VatCode </value>
        [DataMember(Name="fieldValidation", EmitDefaultValue=false)]
        public int? FieldValidation { get; set; }

        /// <summary>
        /// ArxCe required field
        /// </summary>
        /// <value>ArxCe required field</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; set; }

        /// <summary>
        /// Possible values:  0: Generico  1: ModalitaDiFormazione  2: DatiDiRegistrazioneTipologiaDiFlusso  3: DatiDiRegistrazioneTipoRegistro  4: DatiDiRegistrazioneDataRegistrazione  5: DatiDiRegistrazioneNumeroDocumento  6: DatiDiRegistrazioneCodiceRegistro  7: ChiaveDescrittivaOggetto  8: ChiaveDescrittivaParoleChiave  9: ClassificazioneIndiceDiClassificazione  10: ClassificazioneDescrizione  11: ClassificazionePianoDiClassificazione  12: Riservato  13: IdentificativoDelFormatoProdottoSoftwareNomeProdotto  14: IdentificativoDelFormatoProdottoSoftwareVersioneProdotto  15: IdentificativoDelFormatoProdottoSoftwareProduttore  16: Note  17: SoggettiAutoreNome  18: SoggettiAutoreCognome  19: SoggettiAutoreCodiceFiscale  20: SoggettiAutoreRagioneSociale  21: SoggettiAutorePartitaIva  22: SoggettiAutoreCodiceIpa  23: SoggettiAutoreCodiceUnivocoUfficio  24: SoggettiMittenteNome  25: SoggettiMittenteCognome  26: SoggettiMittenteCodiceFiscale  27: SoggettiMittenteRagioneSociale  28: SoggettiMittentePartitaIva  29: SoggettiMittenteCodiceIpa  30: SoggettiMittenteCodiceUnivocoUfficio  31: SoggettiDestinatarioNome  32: SoggettiDestinatarioCognome  33: SoggettiDestinatarioCodiceFiscale  34: SoggettiDestinatarioRagioneSociale  35: SoggettiDestinatarioPartitaIva  36: SoggettiDestinatarioCodiceIpa  37: SoggettiDestinatarioCodiceUnivocoUfficio  38: SoggettiOperatoreNome  39: SoggettiOperatoreCognome  40: SoggettiOperatoreCodiceFiscale  41: SoggettiOperatoreRagioneSociale  42: SoggettiOperatorePartitaIva  43: SoggettiOperatoreCodiceIpa  44: SoggettiOperatoreCodiceUnivocoUfficio  45: TempoDiConservazione  46: SoggettiSoggettoCheEffettuaLaRegistrazioneNome  47: SoggettiSoggettoCheEffettuaLaRegistrazioneCognome  48: SoggettiSoggettoCheEffettuaLaRegistrazioneRagioneSociale  49: SoggettiSoggettoCheEffettuaLaRegistrazioneCodiceFiscale  50: SoggettiSoggettoCheEffettuaLaRegistrazionePartitaIva  51: SoggettiSoggettoCheEffettuaLaRegistrazioneCodiceUnivocoUfficio  52: SoggettiSoggettoCheEffettuaLaRegistrazioneCodiceIpa 
        /// </summary>
        /// <value>Possible values:  0: Generico  1: ModalitaDiFormazione  2: DatiDiRegistrazioneTipologiaDiFlusso  3: DatiDiRegistrazioneTipoRegistro  4: DatiDiRegistrazioneDataRegistrazione  5: DatiDiRegistrazioneNumeroDocumento  6: DatiDiRegistrazioneCodiceRegistro  7: ChiaveDescrittivaOggetto  8: ChiaveDescrittivaParoleChiave  9: ClassificazioneIndiceDiClassificazione  10: ClassificazioneDescrizione  11: ClassificazionePianoDiClassificazione  12: Riservato  13: IdentificativoDelFormatoProdottoSoftwareNomeProdotto  14: IdentificativoDelFormatoProdottoSoftwareVersioneProdotto  15: IdentificativoDelFormatoProdottoSoftwareProduttore  16: Note  17: SoggettiAutoreNome  18: SoggettiAutoreCognome  19: SoggettiAutoreCodiceFiscale  20: SoggettiAutoreRagioneSociale  21: SoggettiAutorePartitaIva  22: SoggettiAutoreCodiceIpa  23: SoggettiAutoreCodiceUnivocoUfficio  24: SoggettiMittenteNome  25: SoggettiMittenteCognome  26: SoggettiMittenteCodiceFiscale  27: SoggettiMittenteRagioneSociale  28: SoggettiMittentePartitaIva  29: SoggettiMittenteCodiceIpa  30: SoggettiMittenteCodiceUnivocoUfficio  31: SoggettiDestinatarioNome  32: SoggettiDestinatarioCognome  33: SoggettiDestinatarioCodiceFiscale  34: SoggettiDestinatarioRagioneSociale  35: SoggettiDestinatarioPartitaIva  36: SoggettiDestinatarioCodiceIpa  37: SoggettiDestinatarioCodiceUnivocoUfficio  38: SoggettiOperatoreNome  39: SoggettiOperatoreCognome  40: SoggettiOperatoreCodiceFiscale  41: SoggettiOperatoreRagioneSociale  42: SoggettiOperatorePartitaIva  43: SoggettiOperatoreCodiceIpa  44: SoggettiOperatoreCodiceUnivocoUfficio  45: TempoDiConservazione  46: SoggettiSoggettoCheEffettuaLaRegistrazioneNome  47: SoggettiSoggettoCheEffettuaLaRegistrazioneCognome  48: SoggettiSoggettoCheEffettuaLaRegistrazioneRagioneSociale  49: SoggettiSoggettoCheEffettuaLaRegistrazioneCodiceFiscale  50: SoggettiSoggettoCheEffettuaLaRegistrazionePartitaIva  51: SoggettiSoggettoCheEffettuaLaRegistrazioneCodiceUnivocoUfficio  52: SoggettiSoggettoCheEffettuaLaRegistrazioneCodiceIpa </value>
        [DataMember(Name="metadataType", EmitDefaultValue=false)]
        public int? MetadataType { get; set; }

        /// <summary>
        /// Metadata field advanced options
        /// </summary>
        /// <value>Metadata field advanced options</value>
        [DataMember(Name="fieldMetadataAdvancedOptions", EmitDefaultValue=false)]
        public ArxCeFieldMetadataAdvancedOptionsDTO FieldMetadataAdvancedOptions { get; set; }

        /// <summary>
        /// Allowed values
        /// </summary>
        /// <value>Allowed values</value>
        [DataMember(Name="allowedValues", EmitDefaultValue=false)]
        public List<string> AllowedValues { get; set; }

        /// <summary>
        /// Possible values:  0: Single  1: SingleSelectable 
        /// </summary>
        /// <value>Possible values:  0: Single  1: SingleSelectable </value>
        [DataMember(Name="inputMode", EmitDefaultValue=false)]
        public int? InputMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArxCeSendingSettingsMappingDTO {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ArxField: ").Append(ArxField).Append("\n");
            sb.Append("  FieldType: ").Append(FieldType).Append("\n");
            sb.Append("  FieldValidation: ").Append(FieldValidation).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  MetadataType: ").Append(MetadataType).Append("\n");
            sb.Append("  FieldMetadataAdvancedOptions: ").Append(FieldMetadataAdvancedOptions).Append("\n");
            sb.Append("  AllowedValues: ").Append(AllowedValues).Append("\n");
            sb.Append("  InputMode: ").Append(InputMode).Append("\n");
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
            return this.Equals(input as ArxCeSendingSettingsMappingDTO);
        }

        /// <summary>
        /// Returns true if ArxCeSendingSettingsMappingDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ArxCeSendingSettingsMappingDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArxCeSendingSettingsMappingDTO input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ArxField == input.ArxField ||
                    (this.ArxField != null &&
                    this.ArxField.Equals(input.ArxField))
                ) && 
                (
                    this.FieldType == input.FieldType ||
                    (this.FieldType != null &&
                    this.FieldType.Equals(input.FieldType))
                ) && 
                (
                    this.FieldValidation == input.FieldValidation ||
                    (this.FieldValidation != null &&
                    this.FieldValidation.Equals(input.FieldValidation))
                ) && 
                (
                    this.Required == input.Required ||
                    (this.Required != null &&
                    this.Required.Equals(input.Required))
                ) && 
                (
                    this.MetadataType == input.MetadataType ||
                    (this.MetadataType != null &&
                    this.MetadataType.Equals(input.MetadataType))
                ) && 
                (
                    this.FieldMetadataAdvancedOptions == input.FieldMetadataAdvancedOptions ||
                    (this.FieldMetadataAdvancedOptions != null &&
                    this.FieldMetadataAdvancedOptions.Equals(input.FieldMetadataAdvancedOptions))
                ) && 
                (
                    this.AllowedValues == input.AllowedValues ||
                    this.AllowedValues != null &&
                    this.AllowedValues.SequenceEqual(input.AllowedValues)
                ) && 
                (
                    this.InputMode == input.InputMode ||
                    (this.InputMode != null &&
                    this.InputMode.Equals(input.InputMode))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ArxField != null)
                    hashCode = hashCode * 59 + this.ArxField.GetHashCode();
                if (this.FieldType != null)
                    hashCode = hashCode * 59 + this.FieldType.GetHashCode();
                if (this.FieldValidation != null)
                    hashCode = hashCode * 59 + this.FieldValidation.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.MetadataType != null)
                    hashCode = hashCode * 59 + this.MetadataType.GetHashCode();
                if (this.FieldMetadataAdvancedOptions != null)
                    hashCode = hashCode * 59 + this.FieldMetadataAdvancedOptions.GetHashCode();
                if (this.AllowedValues != null)
                    hashCode = hashCode * 59 + this.AllowedValues.GetHashCode();
                if (this.InputMode != null)
                    hashCode = hashCode * 59 + this.InputMode.GetHashCode();
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
