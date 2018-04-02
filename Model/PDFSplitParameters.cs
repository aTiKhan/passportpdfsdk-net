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
    /// Represents the parameters for a split action.
    /// </summary>
    [DataContract]
    public partial class PDFSplitParameters :  IEquatable<PDFSplitParameters>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets SplitMethod
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SplitMethodEnum
        {
            
            /// <summary>
            /// Enum SplitByNumberOfPages for "SplitByNumberOfPages"
            /// </summary>
            [EnumMember(Value = "SplitByNumberOfPages")]
            SplitByNumberOfPages = 1,
            
            /// <summary>
            /// Enum SplitByFileSize for "SplitByFileSize"
            /// </summary>
            [EnumMember(Value = "SplitByFileSize")]
            SplitByFileSize = 2,
            
            /// <summary>
            /// Enum SplitByTopLevelBookmarks for "SplitByTopLevelBookmarks"
            /// </summary>
            [EnumMember(Value = "SplitByTopLevelBookmarks")]
            SplitByTopLevelBookmarks = 3
        }

        /// <summary>
        /// Gets or Sets SplitMethod
        /// </summary>
        [DataMember(Name="splitMethod", EmitDefaultValue=false)]
        public SplitMethodEnum SplitMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFSplitParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PDFSplitParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFSplitParameters" /> class.
        /// </summary>
        /// <param name="SplitMethod">SplitMethod (required) (default to SplitMethodEnum.SplitByNumberOfPages).</param>
        /// <param name="FileId">FileId (required).</param>
        /// <param name="SplitValue">SplitValue.</param>
        /// <param name="ImmediateDownload">ImmediateDownload.</param>
        public PDFSplitParameters(SplitMethodEnum SplitMethod = SplitMethodEnum.SplitByNumberOfPages, string FileId = default(string), int? SplitValue = default(int?), bool? ImmediateDownload = default(bool?))
        {
            // to ensure "SplitMethod" is required (not null)
            if (SplitMethod == null)
            {
                throw new InvalidDataException("SplitMethod is a required property for PDFSplitParameters and cannot be null");
            }
            else
            {
                this.SplitMethod = SplitMethod;
            }
            // to ensure "FileId" is required (not null)
            if (FileId == null)
            {
                throw new InvalidDataException("FileId is a required property for PDFSplitParameters and cannot be null");
            }
            else
            {
                this.FileId = FileId;
            }
            this.SplitValue = SplitValue;
            this.ImmediateDownload = ImmediateDownload;
        }
        

        /// <summary>
        /// Gets or Sets FileId
        /// </summary>
        [DataMember(Name="fileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Gets or Sets SplitValue
        /// </summary>
        [DataMember(Name="splitValue", EmitDefaultValue=false)]
        public int? SplitValue { get; set; }

        /// <summary>
        /// Gets or Sets ImmediateDownload
        /// </summary>
        [DataMember(Name="immediateDownload", EmitDefaultValue=false)]
        public bool? ImmediateDownload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFSplitParameters {\n");
            sb.Append("  SplitMethod: ").Append(SplitMethod).Append("\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  SplitValue: ").Append(SplitValue).Append("\n");
            sb.Append("  ImmediateDownload: ").Append(ImmediateDownload).Append("\n");
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
            return this.Equals(input as PDFSplitParameters);
        }

        /// <summary>
        /// Returns true if PDFSplitParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFSplitParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFSplitParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SplitMethod == input.SplitMethod ||
                    (this.SplitMethod != null &&
                    this.SplitMethod.Equals(input.SplitMethod))
                ) && 
                (
                    this.FileId == input.FileId ||
                    (this.FileId != null &&
                    this.FileId.Equals(input.FileId))
                ) && 
                (
                    this.SplitValue == input.SplitValue ||
                    (this.SplitValue != null &&
                    this.SplitValue.Equals(input.SplitValue))
                ) && 
                (
                    this.ImmediateDownload == input.ImmediateDownload ||
                    (this.ImmediateDownload != null &&
                    this.ImmediateDownload.Equals(input.ImmediateDownload))
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
                if (this.SplitMethod != null)
                    hashCode = hashCode * 59 + this.SplitMethod.GetHashCode();
                if (this.FileId != null)
                    hashCode = hashCode * 59 + this.FileId.GetHashCode();
                if (this.SplitValue != null)
                    hashCode = hashCode * 59 + this.SplitValue.GetHashCode();
                if (this.ImmediateDownload != null)
                    hashCode = hashCode * 59 + this.ImmediateDownload.GetHashCode();
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