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
    /// Represents the parameters for a cleanup document action.
    /// </summary>
    [DataContract]
    public partial class ImageCleanupDocumentParameters :  IEquatable<ImageCleanupDocumentParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageCleanupDocumentParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageCleanupDocumentParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageCleanupDocumentParameters" /> class.
        /// </summary>
        /// <param name="FileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="PageRange">Specifies the number of the page, or the range of pages to cleanup. (default to &quot;1&quot;).</param>
        /// <param name="RemoveBlackBorders">Specifies whether the dark borders of the document image shall be replaced with white content..</param>
        /// <param name="Deskew">Specifies whether the document shall be deskewed..</param>
        /// <param name="RemovePunchHoleTop">Specifies whether punch holes shall be removed from the top margin of the document..</param>
        /// <param name="RemovePunchHoleLeft">Specifies whether punch holes shall be removed from the left margin of the document..</param>
        /// <param name="RemovePunchHoleBottom">Specifies whether punch holes shall be removed from the bottom margin of the document..</param>
        /// <param name="RemovePunchHoleRight">Specifies whether punch holes shall be removed from the right margin of the document..</param>
        /// <param name="DespeckleStrength">Specifies the strength of the despeckle filter to be applied on the image..</param>
        public ImageCleanupDocumentParameters(string FileId = default(string), string PageRange = "1", bool? RemoveBlackBorders = default(bool?), bool? Deskew = default(bool?), bool? RemovePunchHoleTop = default(bool?), bool? RemovePunchHoleLeft = default(bool?), bool? RemovePunchHoleBottom = default(bool?), bool? RemovePunchHoleRight = default(bool?), int? DespeckleStrength = default(int?))
        {
            // to ensure "FileId" is required (not null)
            if (FileId == null)
            {
                throw new InvalidDataException("FileId is a required property for ImageCleanupDocumentParameters and cannot be null");
            }
            else
            {
                this.FileId = FileId;
            }
            // use default value if no "PageRange" provided
            if (PageRange == null)
            {
                this.PageRange = "1";
            }
            else
            {
                this.PageRange = PageRange;
            }
            this.RemoveBlackBorders = RemoveBlackBorders;
            this.Deskew = Deskew;
            this.RemovePunchHoleTop = RemovePunchHoleTop;
            this.RemovePunchHoleLeft = RemovePunchHoleLeft;
            this.RemovePunchHoleBottom = RemovePunchHoleBottom;
            this.RemovePunchHoleRight = RemovePunchHoleRight;
            this.DespeckleStrength = DespeckleStrength;
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="fileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to cleanup.
        /// </summary>
        /// <value>Specifies the number of the page, or the range of pages to cleanup.</value>
        [DataMember(Name="pageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies whether the dark borders of the document image shall be replaced with white content.
        /// </summary>
        /// <value>Specifies whether the dark borders of the document image shall be replaced with white content.</value>
        [DataMember(Name="removeBlackBorders", EmitDefaultValue=false)]
        public bool? RemoveBlackBorders { get; set; }

        /// <summary>
        /// Specifies whether the document shall be deskewed.
        /// </summary>
        /// <value>Specifies whether the document shall be deskewed.</value>
        [DataMember(Name="deskew", EmitDefaultValue=false)]
        public bool? Deskew { get; set; }

        /// <summary>
        /// Specifies whether punch holes shall be removed from the top margin of the document.
        /// </summary>
        /// <value>Specifies whether punch holes shall be removed from the top margin of the document.</value>
        [DataMember(Name="removePunchHoleTop", EmitDefaultValue=false)]
        public bool? RemovePunchHoleTop { get; set; }

        /// <summary>
        /// Specifies whether punch holes shall be removed from the left margin of the document.
        /// </summary>
        /// <value>Specifies whether punch holes shall be removed from the left margin of the document.</value>
        [DataMember(Name="removePunchHoleLeft", EmitDefaultValue=false)]
        public bool? RemovePunchHoleLeft { get; set; }

        /// <summary>
        /// Specifies whether punch holes shall be removed from the bottom margin of the document.
        /// </summary>
        /// <value>Specifies whether punch holes shall be removed from the bottom margin of the document.</value>
        [DataMember(Name="removePunchHoleBottom", EmitDefaultValue=false)]
        public bool? RemovePunchHoleBottom { get; set; }

        /// <summary>
        /// Specifies whether punch holes shall be removed from the right margin of the document.
        /// </summary>
        /// <value>Specifies whether punch holes shall be removed from the right margin of the document.</value>
        [DataMember(Name="removePunchHoleRight", EmitDefaultValue=false)]
        public bool? RemovePunchHoleRight { get; set; }

        /// <summary>
        /// Specifies the strength of the despeckle filter to be applied on the image.
        /// </summary>
        /// <value>Specifies the strength of the despeckle filter to be applied on the image.</value>
        [DataMember(Name="despeckleStrength", EmitDefaultValue=false)]
        public int? DespeckleStrength { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageCleanupDocumentParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  RemoveBlackBorders: ").Append(RemoveBlackBorders).Append("\n");
            sb.Append("  Deskew: ").Append(Deskew).Append("\n");
            sb.Append("  RemovePunchHoleTop: ").Append(RemovePunchHoleTop).Append("\n");
            sb.Append("  RemovePunchHoleLeft: ").Append(RemovePunchHoleLeft).Append("\n");
            sb.Append("  RemovePunchHoleBottom: ").Append(RemovePunchHoleBottom).Append("\n");
            sb.Append("  RemovePunchHoleRight: ").Append(RemovePunchHoleRight).Append("\n");
            sb.Append("  DespeckleStrength: ").Append(DespeckleStrength).Append("\n");
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
            return this.Equals(input as ImageCleanupDocumentParameters);
        }

        /// <summary>
        /// Returns true if ImageCleanupDocumentParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageCleanupDocumentParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageCleanupDocumentParameters input)
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
                    this.RemoveBlackBorders == input.RemoveBlackBorders ||
                    (this.RemoveBlackBorders != null &&
                    this.RemoveBlackBorders.Equals(input.RemoveBlackBorders))
                ) && 
                (
                    this.Deskew == input.Deskew ||
                    (this.Deskew != null &&
                    this.Deskew.Equals(input.Deskew))
                ) && 
                (
                    this.RemovePunchHoleTop == input.RemovePunchHoleTop ||
                    (this.RemovePunchHoleTop != null &&
                    this.RemovePunchHoleTop.Equals(input.RemovePunchHoleTop))
                ) && 
                (
                    this.RemovePunchHoleLeft == input.RemovePunchHoleLeft ||
                    (this.RemovePunchHoleLeft != null &&
                    this.RemovePunchHoleLeft.Equals(input.RemovePunchHoleLeft))
                ) && 
                (
                    this.RemovePunchHoleBottom == input.RemovePunchHoleBottom ||
                    (this.RemovePunchHoleBottom != null &&
                    this.RemovePunchHoleBottom.Equals(input.RemovePunchHoleBottom))
                ) && 
                (
                    this.RemovePunchHoleRight == input.RemovePunchHoleRight ||
                    (this.RemovePunchHoleRight != null &&
                    this.RemovePunchHoleRight.Equals(input.RemovePunchHoleRight))
                ) && 
                (
                    this.DespeckleStrength == input.DespeckleStrength ||
                    (this.DespeckleStrength != null &&
                    this.DespeckleStrength.Equals(input.DespeckleStrength))
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
                if (this.RemoveBlackBorders != null)
                    hashCode = hashCode * 59 + this.RemoveBlackBorders.GetHashCode();
                if (this.Deskew != null)
                    hashCode = hashCode * 59 + this.Deskew.GetHashCode();
                if (this.RemovePunchHoleTop != null)
                    hashCode = hashCode * 59 + this.RemovePunchHoleTop.GetHashCode();
                if (this.RemovePunchHoleLeft != null)
                    hashCode = hashCode * 59 + this.RemovePunchHoleLeft.GetHashCode();
                if (this.RemovePunchHoleBottom != null)
                    hashCode = hashCode * 59 + this.RemovePunchHoleBottom.GetHashCode();
                if (this.RemovePunchHoleRight != null)
                    hashCode = hashCode * 59 + this.RemovePunchHoleRight.GetHashCode();
                if (this.DespeckleStrength != null)
                    hashCode = hashCode * 59 + this.DespeckleStrength.GetHashCode();
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
