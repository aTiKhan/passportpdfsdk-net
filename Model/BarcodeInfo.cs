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
    /// Represents information about a read barcode.
    /// </summary>
    [DataContract]
    public partial class BarcodeInfo :  IEquatable<BarcodeInfo>, IValidatableObject
    {
        /// <summary>
        /// Specifies the type of the barcode.
        /// </summary>
        /// <value>Specifies the type of the barcode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Linear for value: Linear
            /// </summary>
            [EnumMember(Value = "Linear")]
            Linear = 1,

            /// <summary>
            /// Enum DataMatrix for value: DataMatrix
            /// </summary>
            [EnumMember(Value = "DataMatrix")]
            DataMatrix = 2,

            /// <summary>
            /// Enum QR for value: QR
            /// </summary>
            [EnumMember(Value = "QR")]
            QR = 3,

            /// <summary>
            /// Enum MicroQR for value: MicroQR
            /// </summary>
            [EnumMember(Value = "MicroQR")]
            MicroQR = 4,

            /// <summary>
            /// Enum PDF417 for value: PDF417
            /// </summary>
            [EnumMember(Value = "PDF417")]
            PDF417 = 5,

            /// <summary>
            /// Enum Aztec for value: Aztec
            /// </summary>
            [EnumMember(Value = "Aztec")]
            Aztec = 6

        }

        /// <summary>
        /// Specifies the type of the barcode.
        /// </summary>
        /// <value>Specifies the type of the barcode.</value>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Specifies the symbology of the linear barcode, if any.
        /// </summary>
        /// <value>Specifies the symbology of the linear barcode, if any.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum Barcode1DSymbologyEnum
        {
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,

            /// <summary>
            /// Enum Industrial2of5 for value: Industrial2of5
            /// </summary>
            [EnumMember(Value = "Industrial2of5")]
            Industrial2of5 = 2,

            /// <summary>
            /// Enum Inverted2of5 for value: Inverted2of5
            /// </summary>
            [EnumMember(Value = "Inverted2of5")]
            Inverted2of5 = 3,

            /// <summary>
            /// Enum Interleaved2of5 for value: Interleaved2of5
            /// </summary>
            [EnumMember(Value = "Interleaved2of5")]
            Interleaved2of5 = 4,

            /// <summary>
            /// Enum Iata2of5 for value: Iata2of5
            /// </summary>
            [EnumMember(Value = "Iata2of5")]
            Iata2of5 = 5,

            /// <summary>
            /// Enum Matrix2of5 for value: Matrix2of5
            /// </summary>
            [EnumMember(Value = "Matrix2of5")]
            Matrix2of5 = 6,

            /// <summary>
            /// Enum Code39 for value: Code39
            /// </summary>
            [EnumMember(Value = "Code39")]
            Code39 = 7,

            /// <summary>
            /// Enum Codeabar for value: Codeabar
            /// </summary>
            [EnumMember(Value = "Codeabar")]
            Codeabar = 8,

            /// <summary>
            /// Enum BcdMatrix for value: BcdMatrix
            /// </summary>
            [EnumMember(Value = "BcdMatrix")]
            BcdMatrix = 9,

            /// <summary>
            /// Enum DataLogic2of5 for value: DataLogic2of5
            /// </summary>
            [EnumMember(Value = "DataLogic2of5")]
            DataLogic2of5 = 10,

            /// <summary>
            /// Enum Code128 for value: Code128
            /// </summary>
            [EnumMember(Value = "Code128")]
            Code128 = 11,

            /// <summary>
            /// Enum CODE93 for value: CODE93
            /// </summary>
            [EnumMember(Value = "CODE93")]
            CODE93 = 12,

            /// <summary>
            /// Enum EAN13 for value: EAN13
            /// </summary>
            [EnumMember(Value = "EAN13")]
            EAN13 = 13,

            /// <summary>
            /// Enum UPCA for value: UPCA
            /// </summary>
            [EnumMember(Value = "UPCA")]
            UPCA = 14,

            /// <summary>
            /// Enum EAN8 for value: EAN8
            /// </summary>
            [EnumMember(Value = "EAN8")]
            EAN8 = 15,

            /// <summary>
            /// Enum UPCE for value: UPCE
            /// </summary>
            [EnumMember(Value = "UPCE")]
            UPCE = 16,

            /// <summary>
            /// Enum ADD5 for value: ADD5
            /// </summary>
            [EnumMember(Value = "ADD5")]
            ADD5 = 17,

            /// <summary>
            /// Enum ADD2 for value: ADD2
            /// </summary>
            [EnumMember(Value = "ADD2")]
            ADD2 = 18

        }

        /// <summary>
        /// Specifies the symbology of the linear barcode, if any.
        /// </summary>
        /// <value>Specifies the symbology of the linear barcode, if any.</value>
        [DataMember(Name="Barcode1DSymbology", EmitDefaultValue=false)]
        public Barcode1DSymbologyEnum? Barcode1DSymbology { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BarcodeInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public BarcodeInfo()
        {
        }
        


        /// <summary>
        /// Specifies the data contained within the barcode.
        /// </summary>
        /// <value>Specifies the data contained within the barcode.</value>
        [DataMember(Name="Data", EmitDefaultValue=false)]
        public string Data { get; private set; }

        /// <summary>
        /// Specifies the horizontal top-left position of the barcode, in pixels.
        /// </summary>
        /// <value>Specifies the horizontal top-left position of the barcode, in pixels.</value>
        [DataMember(Name="X1", EmitDefaultValue=false)]
        public int? X1 { get; private set; }

        /// <summary>
        /// Specifies the horizontal top-right position of the barcode, in pixels.
        /// </summary>
        /// <value>Specifies the horizontal top-right position of the barcode, in pixels.</value>
        [DataMember(Name="X2", EmitDefaultValue=false)]
        public int? X2 { get; private set; }

        /// <summary>
        /// Specifies the horizontal bottom-left position of the barcode, in pixels.
        /// </summary>
        /// <value>Specifies the horizontal bottom-left position of the barcode, in pixels.</value>
        [DataMember(Name="X3", EmitDefaultValue=false)]
        public int? X3 { get; private set; }

        /// <summary>
        /// Specifies the horizontal bottom-right position of the barcode, in pixels.
        /// </summary>
        /// <value>Specifies the horizontal bottom-right position of the barcode, in pixels.</value>
        [DataMember(Name="X4", EmitDefaultValue=false)]
        public int? X4 { get; private set; }

        /// <summary>
        /// Specifies the vertical top-left position of the barcode, in pixels.
        /// </summary>
        /// <value>Specifies the vertical top-left position of the barcode, in pixels.</value>
        [DataMember(Name="Y1", EmitDefaultValue=false)]
        public int? Y1 { get; private set; }

        /// <summary>
        /// Specifies the vertical top-right position of the barcode, in pixels.
        /// </summary>
        /// <value>Specifies the vertical top-right position of the barcode, in pixels.</value>
        [DataMember(Name="Y2", EmitDefaultValue=false)]
        public int? Y2 { get; private set; }

        /// <summary>
        /// Specifies the vertical bottom-left position of the barcode, in pixels.
        /// </summary>
        /// <value>Specifies the vertical bottom-left position of the barcode, in pixels.</value>
        [DataMember(Name="Y3", EmitDefaultValue=false)]
        public int? Y3 { get; private set; }

        /// <summary>
        /// Specifies the vertical bottom-right position of the barcode, in pixels.
        /// </summary>
        /// <value>Specifies the vertical bottom-right position of the barcode, in pixels.</value>
        [DataMember(Name="Y4", EmitDefaultValue=false)]
        public int? Y4 { get; private set; }

        /// <summary>
        /// Specifies the left coordinates of the bounding box of the barcode, in inches.
        /// </summary>
        /// <value>Specifies the left coordinates of the bounding box of the barcode, in inches.</value>
        [DataMember(Name="BboxLeftInches", EmitDefaultValue=false)]
        public float? BboxLeftInches { get; private set; }

        /// <summary>
        /// Specifies the top coordinates of the bounding box of the barcode, in inches.
        /// </summary>
        /// <value>Specifies the top coordinates of the bounding box of the barcode, in inches.</value>
        [DataMember(Name="BboxTopInches", EmitDefaultValue=false)]
        public float? BboxTopInches { get; private set; }

        /// <summary>
        /// Specifies the width of the bounding box of the barcode, in inches.
        /// </summary>
        /// <value>Specifies the width of the bounding box of the barcode, in inches.</value>
        [DataMember(Name="BboxWidthInches", EmitDefaultValue=false)]
        public float? BboxWidthInches { get; private set; }

        /// <summary>
        /// Specifies the height of the bounding box of the barcode, in inches.
        /// </summary>
        /// <value>Specifies the height of the bounding box of the barcode, in inches.</value>
        [DataMember(Name="BboxHeightInches", EmitDefaultValue=false)]
        public float? BboxHeightInches { get; private set; }

        /// <summary>
        /// Specifies the number of the page on which the barcode was read.
        /// </summary>
        /// <value>Specifies the number of the page on which the barcode was read.</value>
        [DataMember(Name="PageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; private set; }

        /// <summary>
        /// Specifies the width, in pixels, of the page where the barcode has been decoded.
        /// </summary>
        /// <value>Specifies the width, in pixels, of the page where the barcode has been decoded.</value>
        [DataMember(Name="PagePixelWidth", EmitDefaultValue=false)]
        public int? PagePixelWidth { get; private set; }

        /// <summary>
        /// Specifies the height, in pixels, of the page where the barcode has been decoded.
        /// </summary>
        /// <value>Specifies the height, in pixels, of the page where the barcode has been decoded.</value>
        [DataMember(Name="PagePixelHeight", EmitDefaultValue=false)]
        public int? PagePixelHeight { get; private set; }

        /// <summary>
        /// Specifies the horizontal resolution, in pixel per inches, of the page where the barcode has been decoded.
        /// </summary>
        /// <value>Specifies the horizontal resolution, in pixel per inches, of the page where the barcode has been decoded.</value>
        [DataMember(Name="PageHorizontalResolution", EmitDefaultValue=false)]
        public float? PageHorizontalResolution { get; private set; }

        /// <summary>
        /// Specifies the vertical resolution, in pixel per inches, of the page where the barcode has been decoded.
        /// </summary>
        /// <value>Specifies the vertical resolution, in pixel per inches, of the page where the barcode has been decoded.</value>
        [DataMember(Name="PageVerticalResolution", EmitDefaultValue=false)]
        public float? PageVerticalResolution { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BarcodeInfo {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Barcode1DSymbology: ").Append(Barcode1DSymbology).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  X1: ").Append(X1).Append("\n");
            sb.Append("  X2: ").Append(X2).Append("\n");
            sb.Append("  X3: ").Append(X3).Append("\n");
            sb.Append("  X4: ").Append(X4).Append("\n");
            sb.Append("  Y1: ").Append(Y1).Append("\n");
            sb.Append("  Y2: ").Append(Y2).Append("\n");
            sb.Append("  Y3: ").Append(Y3).Append("\n");
            sb.Append("  Y4: ").Append(Y4).Append("\n");
            sb.Append("  BboxLeftInches: ").Append(BboxLeftInches).Append("\n");
            sb.Append("  BboxTopInches: ").Append(BboxTopInches).Append("\n");
            sb.Append("  BboxWidthInches: ").Append(BboxWidthInches).Append("\n");
            sb.Append("  BboxHeightInches: ").Append(BboxHeightInches).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  PagePixelWidth: ").Append(PagePixelWidth).Append("\n");
            sb.Append("  PagePixelHeight: ").Append(PagePixelHeight).Append("\n");
            sb.Append("  PageHorizontalResolution: ").Append(PageHorizontalResolution).Append("\n");
            sb.Append("  PageVerticalResolution: ").Append(PageVerticalResolution).Append("\n");
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
            return this.Equals(input as BarcodeInfo);
        }

        /// <summary>
        /// Returns true if BarcodeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BarcodeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BarcodeInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Barcode1DSymbology == input.Barcode1DSymbology ||
                    (this.Barcode1DSymbology != null &&
                    this.Barcode1DSymbology.Equals(input.Barcode1DSymbology))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.X1 == input.X1 ||
                    (this.X1 != null &&
                    this.X1.Equals(input.X1))
                ) && 
                (
                    this.X2 == input.X2 ||
                    (this.X2 != null &&
                    this.X2.Equals(input.X2))
                ) && 
                (
                    this.X3 == input.X3 ||
                    (this.X3 != null &&
                    this.X3.Equals(input.X3))
                ) && 
                (
                    this.X4 == input.X4 ||
                    (this.X4 != null &&
                    this.X4.Equals(input.X4))
                ) && 
                (
                    this.Y1 == input.Y1 ||
                    (this.Y1 != null &&
                    this.Y1.Equals(input.Y1))
                ) && 
                (
                    this.Y2 == input.Y2 ||
                    (this.Y2 != null &&
                    this.Y2.Equals(input.Y2))
                ) && 
                (
                    this.Y3 == input.Y3 ||
                    (this.Y3 != null &&
                    this.Y3.Equals(input.Y3))
                ) && 
                (
                    this.Y4 == input.Y4 ||
                    (this.Y4 != null &&
                    this.Y4.Equals(input.Y4))
                ) && 
                (
                    this.BboxLeftInches == input.BboxLeftInches ||
                    (this.BboxLeftInches != null &&
                    this.BboxLeftInches.Equals(input.BboxLeftInches))
                ) && 
                (
                    this.BboxTopInches == input.BboxTopInches ||
                    (this.BboxTopInches != null &&
                    this.BboxTopInches.Equals(input.BboxTopInches))
                ) && 
                (
                    this.BboxWidthInches == input.BboxWidthInches ||
                    (this.BboxWidthInches != null &&
                    this.BboxWidthInches.Equals(input.BboxWidthInches))
                ) && 
                (
                    this.BboxHeightInches == input.BboxHeightInches ||
                    (this.BboxHeightInches != null &&
                    this.BboxHeightInches.Equals(input.BboxHeightInches))
                ) && 
                (
                    this.PageNumber == input.PageNumber ||
                    (this.PageNumber != null &&
                    this.PageNumber.Equals(input.PageNumber))
                ) && 
                (
                    this.PagePixelWidth == input.PagePixelWidth ||
                    (this.PagePixelWidth != null &&
                    this.PagePixelWidth.Equals(input.PagePixelWidth))
                ) && 
                (
                    this.PagePixelHeight == input.PagePixelHeight ||
                    (this.PagePixelHeight != null &&
                    this.PagePixelHeight.Equals(input.PagePixelHeight))
                ) && 
                (
                    this.PageHorizontalResolution == input.PageHorizontalResolution ||
                    (this.PageHorizontalResolution != null &&
                    this.PageHorizontalResolution.Equals(input.PageHorizontalResolution))
                ) && 
                (
                    this.PageVerticalResolution == input.PageVerticalResolution ||
                    (this.PageVerticalResolution != null &&
                    this.PageVerticalResolution.Equals(input.PageVerticalResolution))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Barcode1DSymbology != null)
                    hashCode = hashCode * 59 + this.Barcode1DSymbology.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.X1 != null)
                    hashCode = hashCode * 59 + this.X1.GetHashCode();
                if (this.X2 != null)
                    hashCode = hashCode * 59 + this.X2.GetHashCode();
                if (this.X3 != null)
                    hashCode = hashCode * 59 + this.X3.GetHashCode();
                if (this.X4 != null)
                    hashCode = hashCode * 59 + this.X4.GetHashCode();
                if (this.Y1 != null)
                    hashCode = hashCode * 59 + this.Y1.GetHashCode();
                if (this.Y2 != null)
                    hashCode = hashCode * 59 + this.Y2.GetHashCode();
                if (this.Y3 != null)
                    hashCode = hashCode * 59 + this.Y3.GetHashCode();
                if (this.Y4 != null)
                    hashCode = hashCode * 59 + this.Y4.GetHashCode();
                if (this.BboxLeftInches != null)
                    hashCode = hashCode * 59 + this.BboxLeftInches.GetHashCode();
                if (this.BboxTopInches != null)
                    hashCode = hashCode * 59 + this.BboxTopInches.GetHashCode();
                if (this.BboxWidthInches != null)
                    hashCode = hashCode * 59 + this.BboxWidthInches.GetHashCode();
                if (this.BboxHeightInches != null)
                    hashCode = hashCode * 59 + this.BboxHeightInches.GetHashCode();
                if (this.PageNumber != null)
                    hashCode = hashCode * 59 + this.PageNumber.GetHashCode();
                if (this.PagePixelWidth != null)
                    hashCode = hashCode * 59 + this.PagePixelWidth.GetHashCode();
                if (this.PagePixelHeight != null)
                    hashCode = hashCode * 59 + this.PagePixelHeight.GetHashCode();
                if (this.PageHorizontalResolution != null)
                    hashCode = hashCode * 59 + this.PageHorizontalResolution.GetHashCode();
                if (this.PageVerticalResolution != null)
                    hashCode = hashCode * 59 + this.PageVerticalResolution.GetHashCode();
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
