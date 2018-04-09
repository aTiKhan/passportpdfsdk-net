/* 
 * PassportPDF
 *
 * Copyright © 2018 ORPALIS - http://www.orpalis.com
 *
 * OpenAPI spec version: v1
 * Contact: contact@orpalis.com
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
using SwaggerDateConverter = PassportPDF.Client.SwaggerDateConverter;

namespace PassportPDF.Model
{
    /// <summary>
    /// Represents the parameters for a save as TIFF action.
    /// </summary>
    [DataContract]
    public partial class ImageSaveAsTIFFParameters :  IEquatable<ImageSaveAsTIFFParameters>, IValidatableObject
    {
        /// <summary>
        /// Specifies the compression to be used for the TIFF output.
        /// </summary>
        /// <value>Specifies the compression to be used for the TIFF output.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CompressionEnum
        {
            
            /// <summary>
            /// Enum Deflate for "Deflate"
            /// </summary>
            [EnumMember(Value = "Deflate")]
            Deflate = 1,
            
            /// <summary>
            /// Enum CCITT3 for "CCITT3"
            /// </summary>
            [EnumMember(Value = "CCITT3")]
            CCITT3 = 2,
            
            /// <summary>
            /// Enum CCITT4 for "CCITT4"
            /// </summary>
            [EnumMember(Value = "CCITT4")]
            CCITT4 = 3,
            
            /// <summary>
            /// Enum LZW for "LZW"
            /// </summary>
            [EnumMember(Value = "LZW")]
            LZW = 4,
            
            /// <summary>
            /// Enum JPEG for "JPEG"
            /// </summary>
            [EnumMember(Value = "JPEG")]
            JPEG = 5,
            
            /// <summary>
            /// Enum RLE for "RLE"
            /// </summary>
            [EnumMember(Value = "RLE")]
            RLE = 6,
            
            /// <summary>
            /// Enum Auto for "Auto"
            /// </summary>
            [EnumMember(Value = "Auto")]
            Auto = 7
        }

        /// <summary>
        /// Specifies the compression to be used for the TIFF output.
        /// </summary>
        /// <value>Specifies the compression to be used for the TIFF output.</value>
        [DataMember(Name="compression", EmitDefaultValue=false)]
        public CompressionEnum? Compression { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSaveAsTIFFParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageSaveAsTIFFParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSaveAsTIFFParameters" /> class.
        /// </summary>
        /// <param name="FileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="PageRange">Specifies the number of the page, or the range of pages to be saved as TIFF. (default to &quot;*&quot;).</param>
        /// <param name="Compression">Specifies the compression to be used for the TIFF output. (default to CompressionEnum.Auto).</param>
        /// <param name="JpegQuality">Specifies the level of quality to be used if JPEG compression is used, from 1 (poorest) to 100 (greatest). (default to 75).</param>
        /// <param name="UseCMYK">Specifies whether the TIFF shall be saved in CMYK color space or not..</param>
        public ImageSaveAsTIFFParameters(string FileId = default(string), string PageRange = "*", CompressionEnum? Compression = CompressionEnum.Auto, int? JpegQuality = 75, bool? UseCMYK = default(bool?))
        {
            // to ensure "FileId" is required (not null)
            if (FileId == null)
            {
                throw new InvalidDataException("FileId is a required property for ImageSaveAsTIFFParameters and cannot be null");
            }
            else
            {
                this.FileId = FileId;
            }
            // use default value if no "PageRange" provided
            if (PageRange == null)
            {
                this.PageRange = "*";
            }
            else
            {
                this.PageRange = PageRange;
            }
            // use default value if no "Compression" provided
            if (Compression == null)
            {
                this.Compression = CompressionEnum.Auto;
            }
            else
            {
                this.Compression = Compression;
            }
            // use default value if no "JpegQuality" provided
            if (JpegQuality == null)
            {
                this.JpegQuality = 75;
            }
            else
            {
                this.JpegQuality = JpegQuality;
            }
            this.UseCMYK = UseCMYK;
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="fileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to be saved as TIFF.
        /// </summary>
        /// <value>Specifies the number of the page, or the range of pages to be saved as TIFF.</value>
        [DataMember(Name="pageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }


        /// <summary>
        /// Specifies the level of quality to be used if JPEG compression is used, from 1 (poorest) to 100 (greatest).
        /// </summary>
        /// <value>Specifies the level of quality to be used if JPEG compression is used, from 1 (poorest) to 100 (greatest).</value>
        [DataMember(Name="jpegQuality", EmitDefaultValue=false)]
        public int? JpegQuality { get; set; }

        /// <summary>
        /// Specifies whether the TIFF shall be saved in CMYK color space or not.
        /// </summary>
        /// <value>Specifies whether the TIFF shall be saved in CMYK color space or not.</value>
        [DataMember(Name="useCMYK", EmitDefaultValue=false)]
        public bool? UseCMYK { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageSaveAsTIFFParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  Compression: ").Append(Compression).Append("\n");
            sb.Append("  JpegQuality: ").Append(JpegQuality).Append("\n");
            sb.Append("  UseCMYK: ").Append(UseCMYK).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as ImageSaveAsTIFFParameters);
        }

        /// <summary>
        /// Returns true if ImageSaveAsTIFFParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageSaveAsTIFFParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageSaveAsTIFFParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileId == input.FileId ||
                    (this.FileId != null &&
                    this.FileId.Equals(input.FileId))
                ) && 
                (
                    this.PageRange == input.PageRange ||
                    (this.PageRange != null &&
                    this.PageRange.Equals(input.PageRange))
                ) && 
                (
                    this.Compression == input.Compression ||
                    (this.Compression != null &&
                    this.Compression.Equals(input.Compression))
                ) && 
                (
                    this.JpegQuality == input.JpegQuality ||
                    (this.JpegQuality != null &&
                    this.JpegQuality.Equals(input.JpegQuality))
                ) && 
                (
                    this.UseCMYK == input.UseCMYK ||
                    (this.UseCMYK != null &&
                    this.UseCMYK.Equals(input.UseCMYK))
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
                if (this.FileId != null)
                    hashCode = hashCode * 59 + this.FileId.GetHashCode();
                if (this.PageRange != null)
                    hashCode = hashCode * 59 + this.PageRange.GetHashCode();
                if (this.Compression != null)
                    hashCode = hashCode * 59 + this.Compression.GetHashCode();
                if (this.JpegQuality != null)
                    hashCode = hashCode * 59 + this.JpegQuality.GetHashCode();
                if (this.UseCMYK != null)
                    hashCode = hashCode * 59 + this.UseCMYK.GetHashCode();
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
