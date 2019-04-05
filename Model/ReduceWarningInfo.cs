/* 
 * PassportPDF API
 *
 * Copyright © 2019 PassportPDF - https://www.passportpdf.com
 *
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
using OpenAPIDateConverter = PassportPDF.Client.OpenAPIDateConverter;

namespace PassportPDF.Model
{
    /// <summary>
    /// Represents information about a warning that occured during a reduce action.
    /// </summary>
    [DataContract]
    public partial class ReduceWarningInfo :  IEquatable<ReduceWarningInfo>, IValidatableObject
    {
        /// <summary>
        /// The warning code.
        /// </summary>
        /// <value>The warning code.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WarningCodeEnum
        {
            /// <summary>
            /// Enum OK for value: OK
            /// </summary>
            [EnumMember(Value = "OK")]
            OK = 1,

            /// <summary>
            /// Enum ImageExtractionFailure for value: ImageExtractionFailure
            /// </summary>
            [EnumMember(Value = "ImageExtractionFailure")]
            ImageExtractionFailure = 2,

            /// <summary>
            /// Enum ColorDetectionFailure for value: ColorDetectionFailure
            /// </summary>
            [EnumMember(Value = "ColorDetectionFailure")]
            ColorDetectionFailure = 3,

            /// <summary>
            /// Enum ImageResizeFailure for value: ImageResizeFailure
            /// </summary>
            [EnumMember(Value = "ImageResizeFailure")]
            ImageResizeFailure = 4,

            /// <summary>
            /// Enum ImageCropFailure for value: ImageCropFailure
            /// </summary>
            [EnumMember(Value = "ImageCropFailure")]
            ImageCropFailure = 5,

            /// <summary>
            /// Enum ImageResolutionObtentionFailure for value: ImageResolutionObtentionFailure
            /// </summary>
            [EnumMember(Value = "ImageResolutionObtentionFailure")]
            ImageResolutionObtentionFailure = 6,

            /// <summary>
            /// Enum ImageReplacementFailure for value: ImageReplacementFailure
            /// </summary>
            [EnumMember(Value = "ImageReplacementFailure")]
            ImageReplacementFailure = 7,

            /// <summary>
            /// Enum MRCImageReplacementFailure for value: MRCImageReplacementFailure
            /// </summary>
            [EnumMember(Value = "MRCImageReplacementFailure")]
            MRCImageReplacementFailure = 8,

            /// <summary>
            /// Enum PageSelectionFailure for value: PageSelectionFailure
            /// </summary>
            [EnumMember(Value = "PageSelectionFailure")]
            PageSelectionFailure = 9,

            /// <summary>
            /// Enum ImageObtentionFailure for value: ImageObtentionFailure
            /// </summary>
            [EnumMember(Value = "ImageObtentionFailure")]
            ImageObtentionFailure = 10,

            /// <summary>
            /// Enum FileSizeReductionFailure for value: FileSizeReductionFailure
            /// </summary>
            [EnumMember(Value = "FileSizeReductionFailure")]
            FileSizeReductionFailure = 11,

            /// <summary>
            /// Enum BlankPageRemovalFailure for value: BlankPageRemovalFailure
            /// </summary>
            [EnumMember(Value = "BlankPageRemovalFailure")]
            BlankPageRemovalFailure = 12

        }

        /// <summary>
        /// The warning code.
        /// </summary>
        /// <value>The warning code.</value>
        [DataMember(Name="WarningCode", EmitDefaultValue=false)]
        public WarningCodeEnum? WarningCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReduceWarningInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ReduceWarningInfo()
        {
        }
        

        /// <summary>
        /// The number of the page processed when the warning occured.
        /// </summary>
        /// <value>The number of the page processed when the warning occured.</value>
        [DataMember(Name="PageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; private set; }

        /// <summary>
        /// The number of the image of the page processed when the warning occured.
        /// </summary>
        /// <value>The number of the image of the page processed when the warning occured.</value>
        [DataMember(Name="PageImageNumber", EmitDefaultValue=false)]
        public int? PageImageNumber { get; private set; }

        /// <summary>
        /// The warning message associated with the warning, if any.
        /// </summary>
        /// <value>The warning message associated with the warning, if any.</value>
        [DataMember(Name="ExtWarningMessage", EmitDefaultValue=false)]
        public string ExtWarningMessage { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReduceWarningInfo {\n");
            sb.Append("  WarningCode: ").Append(WarningCode).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  PageImageNumber: ").Append(PageImageNumber).Append("\n");
            sb.Append("  ExtWarningMessage: ").Append(ExtWarningMessage).Append("\n");
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
            return this.Equals(input as ReduceWarningInfo);
        }

        /// <summary>
        /// Returns true if ReduceWarningInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ReduceWarningInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReduceWarningInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WarningCode == input.WarningCode ||
                    (this.WarningCode != null &&
                    this.WarningCode.Equals(input.WarningCode))
                ) && 
                (
                    this.PageNumber == input.PageNumber ||
                    (this.PageNumber != null &&
                    this.PageNumber.Equals(input.PageNumber))
                ) && 
                (
                    this.PageImageNumber == input.PageImageNumber ||
                    (this.PageImageNumber != null &&
                    this.PageImageNumber.Equals(input.PageImageNumber))
                ) && 
                (
                    this.ExtWarningMessage == input.ExtWarningMessage ||
                    (this.ExtWarningMessage != null &&
                    this.ExtWarningMessage.Equals(input.ExtWarningMessage))
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
                if (this.WarningCode != null)
                    hashCode = hashCode * 59 + this.WarningCode.GetHashCode();
                if (this.PageNumber != null)
                    hashCode = hashCode * 59 + this.PageNumber.GetHashCode();
                if (this.PageImageNumber != null)
                    hashCode = hashCode * 59 + this.PageImageNumber.GetHashCode();
                if (this.ExtWarningMessage != null)
                    hashCode = hashCode * 59 + this.ExtWarningMessage.GetHashCode();
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
