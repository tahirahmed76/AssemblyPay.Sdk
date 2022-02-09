/*
 * Assembly API
 *
 * Assembly (formely PromisePay) is a powerful payments engine custom-built for platforms and marketplaces.
 *
 * The version of the OpenAPI document: 2.0
 * Contact: support@assemblypayments.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// WalletAccountBpayDetailsBpayDetails
    /// </summary>
    [DataContract(Name = "wallet_account_bpay_details_bpay_details")]
    public partial class WalletAccountBpayDetailsBpayDetails : IEquatable<WalletAccountBpayDetailsBpayDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletAccountBpayDetailsBpayDetails" /> class.
        /// </summary>
        /// <param name="billerCode">billerCode.</param>
        /// <param name="reference">reference.</param>
        /// <param name="amount">amount.</param>
        /// <param name="currency">currency.</param>
        public WalletAccountBpayDetailsBpayDetails(string billerCode = default(string), string reference = default(string), string amount = default(string), string currency = default(string))
        {
            this.BillerCode = billerCode;
            this.Reference = reference;
            this.Amount = amount;
            this.Currency = currency;
        }

        /// <summary>
        /// Gets or Sets BillerCode
        /// </summary>
        [DataMember(Name = "biller_code", EmitDefaultValue = false)]
        public string BillerCode { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WalletAccountBpayDetailsBpayDetails {\n");
            sb.Append("  BillerCode: ").Append(BillerCode).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WalletAccountBpayDetailsBpayDetails);
        }

        /// <summary>
        /// Returns true if WalletAccountBpayDetailsBpayDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of WalletAccountBpayDetailsBpayDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WalletAccountBpayDetailsBpayDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BillerCode == input.BillerCode ||
                    (this.BillerCode != null &&
                    this.BillerCode.Equals(input.BillerCode))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
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
                if (this.BillerCode != null)
                {
                    hashCode = (hashCode * 59) + this.BillerCode.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}