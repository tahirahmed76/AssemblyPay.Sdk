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
    /// DepositRequestBody
    /// </summary>
    [DataContract(Name = "deposit_requestBody")]
    public partial class DepositRequestBody : IEquatable<DepositRequestBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DepositRequestBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DepositRequestBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DepositRequestBody" /> class.
        /// </summary>
        /// <param name="accountId">Account to deposit from. (required) (default to &quot;c1824ad0-73f1-0138-3700-0a58a9feac09&quot;).</param>
        /// <param name="amount">Amount (in cents) to deposit. (required).</param>
        public DepositRequestBody(string accountId = "c1824ad0-73f1-0138-3700-0a58a9feac09", int amount = default(int))
        {
            // to ensure "accountId" is required (not null)
            if (accountId == null) {
                throw new ArgumentNullException("accountId is a required property for DepositRequestBody and cannot be null");
            }
            this.AccountId = accountId;
            this.Amount = amount;
        }

        /// <summary>
        /// Account to deposit from.
        /// </summary>
        /// <value>Account to deposit from.</value>
        [DataMember(Name = "account_id", IsRequired = true, EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// Amount (in cents) to deposit.
        /// </summary>
        /// <value>Amount (in cents) to deposit.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public int Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DepositRequestBody {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(input as DepositRequestBody);
        }

        /// <summary>
        /// Returns true if DepositRequestBody instances are equal
        /// </summary>
        /// <param name="input">Instance of DepositRequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DepositRequestBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
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
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
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