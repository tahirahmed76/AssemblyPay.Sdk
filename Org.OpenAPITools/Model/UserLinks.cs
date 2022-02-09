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
    /// UserLinks
    /// </summary>
    [DataContract(Name = "user_links")]
    public partial class UserLinks : IEquatable<UserLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserLinks" /> class.
        /// </summary>
        /// <param name="self">self.</param>
        /// <param name="items">items.</param>
        /// <param name="cardAccounts">cardAccounts.</param>
        /// <param name="paypalAccounts">paypalAccounts.</param>
        /// <param name="payidAccounts">payidAccounts.</param>
        /// <param name="bpayAccounts">bpayAccounts.</param>
        /// <param name="bankAccounts">bankAccounts.</param>
        /// <param name="walletAccounts">walletAccounts.</param>
        public UserLinks(string self = default(string), string items = default(string), string cardAccounts = default(string), string paypalAccounts = default(string), string payidAccounts = default(string), string bpayAccounts = default(string), string bankAccounts = default(string), string walletAccounts = default(string))
        {
            this.Self = self;
            this.Items = items;
            this.CardAccounts = cardAccounts;
            this.PaypalAccounts = paypalAccounts;
            this.PayidAccounts = payidAccounts;
            this.BpayAccounts = bpayAccounts;
            this.BankAccounts = bankAccounts;
            this.WalletAccounts = walletAccounts;
        }

        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name = "self", EmitDefaultValue = false)]
        public string Self { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public string Items { get; set; }

        /// <summary>
        /// Gets or Sets CardAccounts
        /// </summary>
        [DataMember(Name = "card_accounts", EmitDefaultValue = false)]
        public string CardAccounts { get; set; }

        /// <summary>
        /// Gets or Sets PaypalAccounts
        /// </summary>
        [DataMember(Name = "paypal_accounts", EmitDefaultValue = false)]
        public string PaypalAccounts { get; set; }

        /// <summary>
        /// Gets or Sets PayidAccounts
        /// </summary>
        [DataMember(Name = "payid_accounts", EmitDefaultValue = false)]
        public string PayidAccounts { get; set; }

        /// <summary>
        /// Gets or Sets BpayAccounts
        /// </summary>
        [DataMember(Name = "bpay_accounts", EmitDefaultValue = false)]
        public string BpayAccounts { get; set; }

        /// <summary>
        /// Gets or Sets BankAccounts
        /// </summary>
        [DataMember(Name = "bank_accounts", EmitDefaultValue = false)]
        public string BankAccounts { get; set; }

        /// <summary>
        /// Gets or Sets WalletAccounts
        /// </summary>
        [DataMember(Name = "wallet_accounts", EmitDefaultValue = false)]
        public string WalletAccounts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  CardAccounts: ").Append(CardAccounts).Append("\n");
            sb.Append("  PaypalAccounts: ").Append(PaypalAccounts).Append("\n");
            sb.Append("  PayidAccounts: ").Append(PayidAccounts).Append("\n");
            sb.Append("  BpayAccounts: ").Append(BpayAccounts).Append("\n");
            sb.Append("  BankAccounts: ").Append(BankAccounts).Append("\n");
            sb.Append("  WalletAccounts: ").Append(WalletAccounts).Append("\n");
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
            return this.Equals(input as UserLinks);
        }

        /// <summary>
        /// Returns true if UserLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of UserLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserLinks input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Self == input.Self ||
                    (this.Self != null &&
                    this.Self.Equals(input.Self))
                ) && 
                (
                    this.Items == input.Items ||
                    (this.Items != null &&
                    this.Items.Equals(input.Items))
                ) && 
                (
                    this.CardAccounts == input.CardAccounts ||
                    (this.CardAccounts != null &&
                    this.CardAccounts.Equals(input.CardAccounts))
                ) && 
                (
                    this.PaypalAccounts == input.PaypalAccounts ||
                    (this.PaypalAccounts != null &&
                    this.PaypalAccounts.Equals(input.PaypalAccounts))
                ) && 
                (
                    this.PayidAccounts == input.PayidAccounts ||
                    (this.PayidAccounts != null &&
                    this.PayidAccounts.Equals(input.PayidAccounts))
                ) && 
                (
                    this.BpayAccounts == input.BpayAccounts ||
                    (this.BpayAccounts != null &&
                    this.BpayAccounts.Equals(input.BpayAccounts))
                ) && 
                (
                    this.BankAccounts == input.BankAccounts ||
                    (this.BankAccounts != null &&
                    this.BankAccounts.Equals(input.BankAccounts))
                ) && 
                (
                    this.WalletAccounts == input.WalletAccounts ||
                    (this.WalletAccounts != null &&
                    this.WalletAccounts.Equals(input.WalletAccounts))
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
                if (this.Self != null)
                {
                    hashCode = (hashCode * 59) + this.Self.GetHashCode();
                }
                if (this.Items != null)
                {
                    hashCode = (hashCode * 59) + this.Items.GetHashCode();
                }
                if (this.CardAccounts != null)
                {
                    hashCode = (hashCode * 59) + this.CardAccounts.GetHashCode();
                }
                if (this.PaypalAccounts != null)
                {
                    hashCode = (hashCode * 59) + this.PaypalAccounts.GetHashCode();
                }
                if (this.PayidAccounts != null)
                {
                    hashCode = (hashCode * 59) + this.PayidAccounts.GetHashCode();
                }
                if (this.BpayAccounts != null)
                {
                    hashCode = (hashCode * 59) + this.BpayAccounts.GetHashCode();
                }
                if (this.BankAccounts != null)
                {
                    hashCode = (hashCode * 59) + this.BankAccounts.GetHashCode();
                }
                if (this.WalletAccounts != null)
                {
                    hashCode = (hashCode * 59) + this.WalletAccounts.GetHashCode();
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
