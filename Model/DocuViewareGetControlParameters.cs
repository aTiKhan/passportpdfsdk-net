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
    /// Represents the parameters for a GetControl action.
    /// </summary>
    [DataContract]
    public partial class DocuViewareGetControlParameters :  IEquatable<DocuViewareGetControlParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocuViewareGetControlParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocuViewareGetControlParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocuViewareGetControlParameters" /> class.
        /// </summary>
        /// <param name="SessionID">Specifies the unique identifier used to identify the user session. (required).</param>
        /// <param name="ControlState">A DocuViewareControlState object specifying the configuration of the DocuVieware control. (required).</param>
        public DocuViewareGetControlParameters(string SessionID = default(string), DocuViewareControlState ControlState = default(DocuViewareControlState))
        {
            // to ensure "SessionID" is required (not null)
            if (SessionID == null)
            {
                throw new InvalidDataException("SessionID is a required property for DocuViewareGetControlParameters and cannot be null");
            }
            else
            {
                this.SessionID = SessionID;
            }
            // to ensure "ControlState" is required (not null)
            if (ControlState == null)
            {
                throw new InvalidDataException("ControlState is a required property for DocuViewareGetControlParameters and cannot be null");
            }
            else
            {
                this.ControlState = ControlState;
            }
        }
        
        /// <summary>
        /// Specifies the unique identifier used to identify the user session.
        /// </summary>
        /// <value>Specifies the unique identifier used to identify the user session.</value>
        [DataMember(Name="sessionID", EmitDefaultValue=false)]
        public string SessionID { get; set; }

        /// <summary>
        /// A DocuViewareControlState object specifying the configuration of the DocuVieware control.
        /// </summary>
        /// <value>A DocuViewareControlState object specifying the configuration of the DocuVieware control.</value>
        [DataMember(Name="controlState", EmitDefaultValue=false)]
        public DocuViewareControlState ControlState { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocuViewareGetControlParameters {\n");
            sb.Append("  SessionID: ").Append(SessionID).Append("\n");
            sb.Append("  ControlState: ").Append(ControlState).Append("\n");
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
            return this.Equals(input as DocuViewareGetControlParameters);
        }

        /// <summary>
        /// Returns true if DocuViewareGetControlParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of DocuViewareGetControlParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocuViewareGetControlParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SessionID == input.SessionID ||
                    (this.SessionID != null &&
                    this.SessionID.Equals(input.SessionID))
                ) && 
                (
                    this.ControlState == input.ControlState ||
                    (this.ControlState != null &&
                    this.ControlState.Equals(input.ControlState))
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
                if (this.SessionID != null)
                    hashCode = hashCode * 59 + this.SessionID.GetHashCode();
                if (this.ControlState != null)
                    hashCode = hashCode * 59 + this.ControlState.GetHashCode();
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
