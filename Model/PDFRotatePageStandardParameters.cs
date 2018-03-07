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
    /// Represents the parameters for a rotate page standard action.
    /// </summary>
    [DataContract]
    public partial class PDFRotatePageStandardParameters :  IEquatable<PDFRotatePageStandardParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFRotatePageStandardParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PDFRotatePageStandardParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFRotatePageStandardParameters" /> class.
        /// </summary>
        /// <param name="RotationAngle">RotationAngle (required).</param>
        /// <param name="FileId">FileId (required).</param>
        /// <param name="PageRange">PageRange (default to &quot;*&quot;).</param>
        /// <param name="FlipHorizontally">FlipHorizontally.</param>
        /// <param name="FlipVertically">FlipVertically.</param>
        public PDFRotatePageStandardParameters(int? RotationAngle = default(int?), string FileId = default(string), string PageRange = "*", bool? FlipHorizontally = default(bool?), bool? FlipVertically = default(bool?))
        {
            // to ensure "RotationAngle" is required (not null)
            if (RotationAngle == null)
            {
                throw new InvalidDataException("RotationAngle is a required property for PDFRotatePageStandardParameters and cannot be null");
            }
            else
            {
                this.RotationAngle = RotationAngle;
            }
            // to ensure "FileId" is required (not null)
            if (FileId == null)
            {
                throw new InvalidDataException("FileId is a required property for PDFRotatePageStandardParameters and cannot be null");
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
            this.FlipHorizontally = FlipHorizontally;
            this.FlipVertically = FlipVertically;
        }
        
        /// <summary>
        /// Gets or Sets RotationAngle
        /// </summary>
        [DataMember(Name="rotationAngle", EmitDefaultValue=false)]
        public int? RotationAngle { get; set; }

        /// <summary>
        /// Gets or Sets FileId
        /// </summary>
        [DataMember(Name="fileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Gets or Sets PageRange
        /// </summary>
        [DataMember(Name="pageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }

        /// <summary>
        /// Gets or Sets FlipHorizontally
        /// </summary>
        [DataMember(Name="flipHorizontally", EmitDefaultValue=false)]
        public bool? FlipHorizontally { get; set; }

        /// <summary>
        /// Gets or Sets FlipVertically
        /// </summary>
        [DataMember(Name="flipVertically", EmitDefaultValue=false)]
        public bool? FlipVertically { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFRotatePageStandardParameters {\n");
            sb.Append("  RotationAngle: ").Append(RotationAngle).Append("\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  FlipHorizontally: ").Append(FlipHorizontally).Append("\n");
            sb.Append("  FlipVertically: ").Append(FlipVertically).Append("\n");
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
            return this.Equals(input as PDFRotatePageStandardParameters);
        }

        /// <summary>
        /// Returns true if PDFRotatePageStandardParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFRotatePageStandardParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFRotatePageStandardParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RotationAngle == input.RotationAngle ||
                    (this.RotationAngle != null &&
                    this.RotationAngle.Equals(input.RotationAngle))
                ) && 
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
                    this.FlipHorizontally == input.FlipHorizontally ||
                    (this.FlipHorizontally != null &&
                    this.FlipHorizontally.Equals(input.FlipHorizontally))
                ) && 
                (
                    this.FlipVertically == input.FlipVertically ||
                    (this.FlipVertically != null &&
                    this.FlipVertically.Equals(input.FlipVertically))
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
                if (this.RotationAngle != null)
                    hashCode = hashCode * 59 + this.RotationAngle.GetHashCode();
                if (this.FileId != null)
                    hashCode = hashCode * 59 + this.FileId.GetHashCode();
                if (this.PageRange != null)
                    hashCode = hashCode * 59 + this.PageRange.GetHashCode();
                if (this.FlipHorizontally != null)
                    hashCode = hashCode * 59 + this.FlipHorizontally.GetHashCode();
                if (this.FlipVertically != null)
                    hashCode = hashCode * 59 + this.FlipVertically.GetHashCode();
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