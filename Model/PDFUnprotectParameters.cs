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


namespace PassportPDF.Model
{
    /// <summary>
    /// Represents the parameters for an unprotect action.
    /// </summary>
    [DataContract]
    public partial class PdfUnprotectParameters :  IEquatable<PdfUnprotectParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfUnprotectParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfUnprotectParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfUnprotectParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="password">Specifies the password to be used to unprotect the PDF. (required).</param>
        public PdfUnprotectParameters(string fileId, string password)
        {
            FileId = fileId;
            Password = password;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the password to be used to unprotect the PDF.
        /// </summary>
        [DataMember(Name="Password")]
        public string Password { get; set; }

        /// <summary>
        /// Returns the String presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
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
            return Equals(input as PdfUnprotectParameters);
        }

        /// <summary>
        /// Returns true if PdfUnprotectParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfUnprotectParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfUnprotectParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    FileId == input.FileId ||
                    (FileId != null &&
                    FileId.Equals(input.FileId))
                ) && 
                (
                    Password == input.Password ||
                    (Password != null &&
                    Password.Equals(input.Password))
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
                if (FileId != null)
                    hashCode = hashCode * 59 + FileId.GetHashCode();
                if (Password != null)
                    hashCode = hashCode * 59 + Password.GetHashCode();
                return hashCode;
            }
        }
    }

}
