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
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AssemblyPay.Sdk.Model
{
    /// <summary>
    /// CardAccountRequestBody
    /// </summary>
    [DataContract(Name = "card_account_requestBody")]
    public partial class CardAccountRequestBody : IEquatable<CardAccountRequestBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardAccountRequestBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CardAccountRequestBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CardAccountRequestBody" /> class.
        /// </summary>
        /// <param name="fullName">User full name with at least a space (required) (default to &quot;John Doe&quot;).</param>
        /// <param name="number">Account number (required) (default to &quot;4444111122223333&quot;).</param>
        /// <param name="expiryMonth">Expiry month (MM) (required).</param>
        /// <param name="expiryYear">Expiry year (YYYY) (required).</param>
        /// <param name="cvv">CVV / CVC (required) (default to &quot;123&quot;).</param>
        /// <param name="userId">User ID (required) (default to &quot;83f54680-9600-4bee-a6d1-84a5d0e10059&quot;).</param>
        public CardAccountRequestBody(string fullName = "John Doe", string number = "4444111122223333", int expiryMonth = default(int), int expiryYear = default(int), string cvv = "123", string userId = "83f54680-9600-4bee-a6d1-84a5d0e10059")
        {
            // to ensure "fullName" is required (not null)
            if (fullName == null) {
                throw new ArgumentNullException("fullName is a required property for CardAccountRequestBody and cannot be null");
            }
            this.FullName = fullName;
            // to ensure "number" is required (not null)
            if (number == null) {
                throw new ArgumentNullException("number is a required property for CardAccountRequestBody and cannot be null");
            }
            this.Number = number;
            this.ExpiryMonth = expiryMonth;
            this.ExpiryYear = expiryYear;
            // to ensure "cvv" is required (not null)
            if (cvv == null) {
                throw new ArgumentNullException("cvv is a required property for CardAccountRequestBody and cannot be null");
            }
            this.Cvv = cvv;
            // to ensure "userId" is required (not null)
            if (userId == null) {
                throw new ArgumentNullException("userId is a required property for CardAccountRequestBody and cannot be null");
            }
            this.UserId = userId;
        }

        /// <summary>
        /// User full name with at least a space
        /// </summary>
        /// <value>User full name with at least a space</value>
        [DataMember(Name = "full_name", IsRequired = true, EmitDefaultValue = false)]
        public string FullName { get; set; }

        /// <summary>
        /// Account number
        /// </summary>
        /// <value>Account number</value>
        [DataMember(Name = "number", IsRequired = true, EmitDefaultValue = false)]
        public string Number { get; set; }

        /// <summary>
        /// Expiry month (MM)
        /// </summary>
        /// <value>Expiry month (MM)</value>
        [DataMember(Name = "expiry_month", IsRequired = true, EmitDefaultValue = false)]
        public int ExpiryMonth { get; set; }

        /// <summary>
        /// Expiry year (YYYY)
        /// </summary>
        /// <value>Expiry year (YYYY)</value>
        [DataMember(Name = "expiry_year", IsRequired = true, EmitDefaultValue = false)]
        public int ExpiryYear { get; set; }

        /// <summary>
        /// CVV / CVC
        /// </summary>
        /// <value>CVV / CVC</value>
        [DataMember(Name = "cvv", IsRequired = true, EmitDefaultValue = false)]
        public string Cvv { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        /// <value>User ID</value>
        [DataMember(Name = "user_id", IsRequired = true, EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CardAccountRequestBody {\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  ExpiryMonth: ").Append(ExpiryMonth).Append("\n");
            sb.Append("  ExpiryYear: ").Append(ExpiryYear).Append("\n");
            sb.Append("  Cvv: ").Append(Cvv).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as CardAccountRequestBody);
        }

        /// <summary>
        /// Returns true if CardAccountRequestBody instances are equal
        /// </summary>
        /// <param name="input">Instance of CardAccountRequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardAccountRequestBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.ExpiryMonth == input.ExpiryMonth ||
                    this.ExpiryMonth.Equals(input.ExpiryMonth)
                ) && 
                (
                    this.ExpiryYear == input.ExpiryYear ||
                    this.ExpiryYear.Equals(input.ExpiryYear)
                ) && 
                (
                    this.Cvv == input.Cvv ||
                    (this.Cvv != null &&
                    this.Cvv.Equals(input.Cvv))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.FullName != null)
                {
                    hashCode = (hashCode * 59) + this.FullName.GetHashCode();
                }
                if (this.Number != null)
                {
                    hashCode = (hashCode * 59) + this.Number.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExpiryMonth.GetHashCode();
                hashCode = (hashCode * 59) + this.ExpiryYear.GetHashCode();
                if (this.Cvv != null)
                {
                    hashCode = (hashCode * 59) + this.Cvv.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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
