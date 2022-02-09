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
    /// WalletAccountNppDetailsNppDetails
    /// </summary>
    [DataContract(Name = "wallet_account_npp_details_npp_details")]
    public partial class WalletAccountNppDetailsNppDetails : IEquatable<WalletAccountNppDetailsNppDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletAccountNppDetailsNppDetails" /> class.
        /// </summary>
        /// <param name="payId">payId.</param>
        /// <param name="marketplacePayIds">marketplacePayIds.</param>
        /// <param name="reference">reference.</param>
        /// <param name="amount">amount.</param>
        /// <param name="currency">currency.</param>
        public WalletAccountNppDetailsNppDetails(string payId = default(string), List<WalletAccountNppDetailsNppDetailsMarketplacePayIds> marketplacePayIds = default(List<WalletAccountNppDetailsNppDetailsMarketplacePayIds>), string reference = default(string), string amount = default(string), string currency = default(string))
        {
            this.PayId = payId;
            this.MarketplacePayIds = marketplacePayIds;
            this.Reference = reference;
            this.Amount = amount;
            this.Currency = currency;
        }

        /// <summary>
        /// Gets or Sets PayId
        /// </summary>
        [DataMember(Name = "pay_id", EmitDefaultValue = false)]
        public string PayId { get; set; }

        /// <summary>
        /// Gets or Sets MarketplacePayIds
        /// </summary>
        [DataMember(Name = "marketplace_pay_ids", EmitDefaultValue = false)]
        public List<WalletAccountNppDetailsNppDetailsMarketplacePayIds> MarketplacePayIds { get; set; }

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
            sb.Append("class WalletAccountNppDetailsNppDetails {\n");
            sb.Append("  PayId: ").Append(PayId).Append("\n");
            sb.Append("  MarketplacePayIds: ").Append(MarketplacePayIds).Append("\n");
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
            return this.Equals(input as WalletAccountNppDetailsNppDetails);
        }

        /// <summary>
        /// Returns true if WalletAccountNppDetailsNppDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of WalletAccountNppDetailsNppDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WalletAccountNppDetailsNppDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PayId == input.PayId ||
                    (this.PayId != null &&
                    this.PayId.Equals(input.PayId))
                ) && 
                (
                    this.MarketplacePayIds == input.MarketplacePayIds ||
                    this.MarketplacePayIds != null &&
                    input.MarketplacePayIds != null &&
                    this.MarketplacePayIds.SequenceEqual(input.MarketplacePayIds)
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
                if (this.PayId != null)
                {
                    hashCode = (hashCode * 59) + this.PayId.GetHashCode();
                }
                if (this.MarketplacePayIds != null)
                {
                    hashCode = (hashCode * 59) + this.MarketplacePayIds.GetHashCode();
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