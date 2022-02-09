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
    /// CardAccountIdRequestBody
    /// </summary>
    [DataContract(Name = "card_account_id_requestBody")]
    public partial class CardAccountIdRequestBody : IEquatable<CardAccountIdRequestBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardAccountIdRequestBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CardAccountIdRequestBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CardAccountIdRequestBody" /> class.
        /// </summary>
        /// <param name="accountId">Card account ID (required) (default to &quot;725cc8c0-759b-0138-5d6d-0a58a9feac05&quot;).</param>
        /// <param name="cvv">CVV / CVC.</param>
        public CardAccountIdRequestBody(string accountId = "725cc8c0-759b-0138-5d6d-0a58a9feac05", string cvv = default(string))
        {
            // to ensure "accountId" is required (not null)
            if (accountId == null) {
                throw new ArgumentNullException("accountId is a required property for CardAccountIdRequestBody and cannot be null");
            }
            this.AccountId = accountId;
            this.Cvv = cvv;
        }

        /// <summary>
        /// Card account ID
        /// </summary>
        /// <value>Card account ID</value>
        [DataMember(Name = "account_id", IsRequired = true, EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// CVV / CVC
        /// </summary>
        /// <value>CVV / CVC</value>
        [DataMember(Name = "cvv", EmitDefaultValue = false)]
        public string Cvv { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CardAccountIdRequestBody {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Cvv: ").Append(Cvv).Append("\n");
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
            return this.Equals(input as CardAccountIdRequestBody);
        }

        /// <summary>
        /// Returns true if CardAccountIdRequestBody instances are equal
        /// </summary>
        /// <param name="input">Instance of CardAccountIdRequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardAccountIdRequestBody input)
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
                    this.Cvv == input.Cvv ||
                    (this.Cvv != null &&
                    this.Cvv.Equals(input.Cvv))
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
                if (this.Cvv != null)
                {
                    hashCode = (hashCode * 59) + this.Cvv.GetHashCode();
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
