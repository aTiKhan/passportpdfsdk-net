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
    /// PassportPDFPassport
    /// </summary>
    [DataContract]
    public partial class PassportPDFPassport :  IEquatable<PassportPDFPassport>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PassportPDFPassport" /> class.
        /// </summary>
        /// <param name="passportId">passportId.</param>
        /// <param name="planId">planId.</param>
        /// <param name="subscriptionDate">subscriptionDate.</param>
        /// <param name="currentTokensUsed">currentTokensUsed.</param>
        /// <param name="extraTokens">extraTokens.</param>
        /// <param name="extraTokensEndDate">extraTokensEndDate.</param>
        /// <param name="isYearlyPaid">isYearlyPaid.</param>
        /// <param name="isActive">isActive.</param>
        /// <param name="tokensPercentUsageAlert">tokensPercentUsageAlert.</param>
        /// <param name="tokensPercentUsageAlertSent">tokensPercentUsageAlertSent.</param>
        public PassportPDFPassport(string passportId = default(string), int? planId = default(int?), DateTime? subscriptionDate = default(DateTime?), long? currentTokensUsed = default(long?), long? extraTokens = default(long?), DateTime? extraTokensEndDate = default(DateTime?), bool? isYearlyPaid = default(bool?), bool? isActive = default(bool?), int? tokensPercentUsageAlert = default(int?), bool? tokensPercentUsageAlertSent = default(bool?))
        {
            this.PassportId = passportId;
            this.PlanId = planId;
            this.SubscriptionDate = subscriptionDate;
            this.CurrentTokensUsed = currentTokensUsed;
            this.ExtraTokens = extraTokens;
            this.ExtraTokensEndDate = extraTokensEndDate;
            this.IsYearlyPaid = isYearlyPaid;
            this.IsActive = isActive;
            this.TokensPercentUsageAlert = tokensPercentUsageAlert;
            this.TokensPercentUsageAlertSent = tokensPercentUsageAlertSent;
        }
        
        /// <summary>
        /// Gets or Sets PassportId
        /// </summary>
        [DataMember(Name="PassportId", EmitDefaultValue=false)]
        public string PassportId { get; set; }

        /// <summary>
        /// Gets or Sets PlanId
        /// </summary>
        [DataMember(Name="PlanId", EmitDefaultValue=false)]
        public int? PlanId { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionDate
        /// </summary>
        [DataMember(Name="SubscriptionDate", EmitDefaultValue=false)]
        public DateTime? SubscriptionDate { get; set; }

        /// <summary>
        /// Gets or Sets CurrentTokensUsed
        /// </summary>
        [DataMember(Name="CurrentTokensUsed", EmitDefaultValue=false)]
        public long? CurrentTokensUsed { get; set; }

        /// <summary>
        /// Gets or Sets ExtraTokens
        /// </summary>
        [DataMember(Name="ExtraTokens", EmitDefaultValue=false)]
        public long? ExtraTokens { get; set; }

        /// <summary>
        /// Gets or Sets ExtraTokensEndDate
        /// </summary>
        [DataMember(Name="ExtraTokensEndDate", EmitDefaultValue=false)]
        public DateTime? ExtraTokensEndDate { get; set; }

        /// <summary>
        /// Gets or Sets IsYearlyPaid
        /// </summary>
        [DataMember(Name="IsYearlyPaid", EmitDefaultValue=false)]
        public bool? IsYearlyPaid { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="IsActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or Sets TokensPercentUsageAlert
        /// </summary>
        [DataMember(Name="TokensPercentUsageAlert", EmitDefaultValue=false)]
        public int? TokensPercentUsageAlert { get; set; }

        /// <summary>
        /// Gets or Sets TokensPercentUsageAlertSent
        /// </summary>
        [DataMember(Name="TokensPercentUsageAlertSent", EmitDefaultValue=false)]
        public bool? TokensPercentUsageAlertSent { get; set; }

        /// <summary>
        /// Gets or Sets NextMonthlyTerm
        /// </summary>
        [DataMember(Name="NextMonthlyTerm", EmitDefaultValue=false)]
        public DateTime? NextMonthlyTerm { get; private set; }

        /// <summary>
        /// Gets or Sets RemainingTokens
        /// </summary>
        [DataMember(Name="RemainingTokens", EmitDefaultValue=false)]
        public long? RemainingTokens { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PassportPDFPassport {\n");
            sb.Append("  PassportId: ").Append(PassportId).Append("\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
            sb.Append("  SubscriptionDate: ").Append(SubscriptionDate).Append("\n");
            sb.Append("  CurrentTokensUsed: ").Append(CurrentTokensUsed).Append("\n");
            sb.Append("  ExtraTokens: ").Append(ExtraTokens).Append("\n");
            sb.Append("  ExtraTokensEndDate: ").Append(ExtraTokensEndDate).Append("\n");
            sb.Append("  IsYearlyPaid: ").Append(IsYearlyPaid).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  TokensPercentUsageAlert: ").Append(TokensPercentUsageAlert).Append("\n");
            sb.Append("  TokensPercentUsageAlertSent: ").Append(TokensPercentUsageAlertSent).Append("\n");
            sb.Append("  NextMonthlyTerm: ").Append(NextMonthlyTerm).Append("\n");
            sb.Append("  RemainingTokens: ").Append(RemainingTokens).Append("\n");
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
            return this.Equals(input as PassportPDFPassport);
        }

        /// <summary>
        /// Returns true if PassportPDFPassport instances are equal
        /// </summary>
        /// <param name="input">Instance of PassportPDFPassport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PassportPDFPassport input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PassportId == input.PassportId ||
                    (this.PassportId != null &&
                    this.PassportId.Equals(input.PassportId))
                ) && 
                (
                    this.PlanId == input.PlanId ||
                    (this.PlanId != null &&
                    this.PlanId.Equals(input.PlanId))
                ) && 
                (
                    this.SubscriptionDate == input.SubscriptionDate ||
                    (this.SubscriptionDate != null &&
                    this.SubscriptionDate.Equals(input.SubscriptionDate))
                ) && 
                (
                    this.CurrentTokensUsed == input.CurrentTokensUsed ||
                    (this.CurrentTokensUsed != null &&
                    this.CurrentTokensUsed.Equals(input.CurrentTokensUsed))
                ) && 
                (
                    this.ExtraTokens == input.ExtraTokens ||
                    (this.ExtraTokens != null &&
                    this.ExtraTokens.Equals(input.ExtraTokens))
                ) && 
                (
                    this.ExtraTokensEndDate == input.ExtraTokensEndDate ||
                    (this.ExtraTokensEndDate != null &&
                    this.ExtraTokensEndDate.Equals(input.ExtraTokensEndDate))
                ) && 
                (
                    this.IsYearlyPaid == input.IsYearlyPaid ||
                    (this.IsYearlyPaid != null &&
                    this.IsYearlyPaid.Equals(input.IsYearlyPaid))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.TokensPercentUsageAlert == input.TokensPercentUsageAlert ||
                    (this.TokensPercentUsageAlert != null &&
                    this.TokensPercentUsageAlert.Equals(input.TokensPercentUsageAlert))
                ) && 
                (
                    this.TokensPercentUsageAlertSent == input.TokensPercentUsageAlertSent ||
                    (this.TokensPercentUsageAlertSent != null &&
                    this.TokensPercentUsageAlertSent.Equals(input.TokensPercentUsageAlertSent))
                ) && 
                (
                    this.NextMonthlyTerm == input.NextMonthlyTerm ||
                    (this.NextMonthlyTerm != null &&
                    this.NextMonthlyTerm.Equals(input.NextMonthlyTerm))
                ) && 
                (
                    this.RemainingTokens == input.RemainingTokens ||
                    (this.RemainingTokens != null &&
                    this.RemainingTokens.Equals(input.RemainingTokens))
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
                if (this.PassportId != null)
                    hashCode = hashCode * 59 + this.PassportId.GetHashCode();
                if (this.PlanId != null)
                    hashCode = hashCode * 59 + this.PlanId.GetHashCode();
                if (this.SubscriptionDate != null)
                    hashCode = hashCode * 59 + this.SubscriptionDate.GetHashCode();
                if (this.CurrentTokensUsed != null)
                    hashCode = hashCode * 59 + this.CurrentTokensUsed.GetHashCode();
                if (this.ExtraTokens != null)
                    hashCode = hashCode * 59 + this.ExtraTokens.GetHashCode();
                if (this.ExtraTokensEndDate != null)
                    hashCode = hashCode * 59 + this.ExtraTokensEndDate.GetHashCode();
                if (this.IsYearlyPaid != null)
                    hashCode = hashCode * 59 + this.IsYearlyPaid.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.TokensPercentUsageAlert != null)
                    hashCode = hashCode * 59 + this.TokensPercentUsageAlert.GetHashCode();
                if (this.TokensPercentUsageAlertSent != null)
                    hashCode = hashCode * 59 + this.TokensPercentUsageAlertSent.GetHashCode();
                if (this.NextMonthlyTerm != null)
                    hashCode = hashCode * 59 + this.NextMonthlyTerm.GetHashCode();
                if (this.RemainingTokens != null)
                    hashCode = hashCode * 59 + this.RemainingTokens.GetHashCode();
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
