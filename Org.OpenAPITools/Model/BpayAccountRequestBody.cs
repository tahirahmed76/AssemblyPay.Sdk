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
    /// BpayAccountRequestBody
    /// </summary>
    [DataContract(Name = "bpay_account_requestBody")]
    public partial class BpayAccountRequestBody : IEquatable<BpayAccountRequestBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BpayAccountRequestBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BpayAccountRequestBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BpayAccountRequestBody" /> class.
        /// </summary>
        /// <param name="userId">User ID (required) (default to &quot;725cc8c0-759b-0138-5d6d-0a58a9feac05&quot;).</param>
        /// <param name="accountName">Name assigned by the platform/marketplace to identify the account (similar to a nickname) (required) (default to &quot;My Water Bill Company&quot;).</param>
        /// <param name="billerCode">The Biller Code for the biller that will receive the payment. The Biller Code must be a numeric value with 3 to 10 digits. (required).</param>
        /// <param name="bpayCrn">Customer reference number (crn) to be used for this bpay account. The CRN must contain between 2 and 20 digits. (required) (default to &quot;987654321&quot;).</param>
        public BpayAccountRequestBody(string userId = "725cc8c0-759b-0138-5d6d-0a58a9feac05", string accountName = "My Water Bill Company", int billerCode = default(int), string bpayCrn = "987654321")
        {
            // to ensure "userId" is required (not null)
            if (userId == null) {
                throw new ArgumentNullException("userId is a required property for BpayAccountRequestBody and cannot be null");
            }
            this.UserId = userId;
            // to ensure "accountName" is required (not null)
            if (accountName == null) {
                throw new ArgumentNullException("accountName is a required property for BpayAccountRequestBody and cannot be null");
            }
            this.AccountName = accountName;
            this.BillerCode = billerCode;
            // to ensure "bpayCrn" is required (not null)
            if (bpayCrn == null) {
                throw new ArgumentNullException("bpayCrn is a required property for BpayAccountRequestBody and cannot be null");
            }
            this.BpayCrn = bpayCrn;
        }

        /// <summary>
        /// User ID
        /// </summary>
        /// <value>User ID</value>
        [DataMember(Name = "user_id", IsRequired = true, EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Name assigned by the platform/marketplace to identify the account (similar to a nickname)
        /// </summary>
        /// <value>Name assigned by the platform/marketplace to identify the account (similar to a nickname)</value>
        [DataMember(Name = "account_name", IsRequired = true, EmitDefaultValue = false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The Biller Code for the biller that will receive the payment. The Biller Code must be a numeric value with 3 to 10 digits.
        /// </summary>
        /// <value>The Biller Code for the biller that will receive the payment. The Biller Code must be a numeric value with 3 to 10 digits.</value>
        [DataMember(Name = "biller_code", IsRequired = true, EmitDefaultValue = false)]
        public int BillerCode { get; set; }

        /// <summary>
        /// Customer reference number (crn) to be used for this bpay account. The CRN must contain between 2 and 20 digits.
        /// </summary>
        /// <value>Customer reference number (crn) to be used for this bpay account. The CRN must contain between 2 and 20 digits.</value>
        [DataMember(Name = "bpay_crn", IsRequired = true, EmitDefaultValue = false)]
        public string BpayCrn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BpayAccountRequestBody {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  BillerCode: ").Append(BillerCode).Append("\n");
            sb.Append("  BpayCrn: ").Append(BpayCrn).Append("\n");
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
            return this.Equals(input as BpayAccountRequestBody);
        }

        /// <summary>
        /// Returns true if BpayAccountRequestBody instances are equal
        /// </summary>
        /// <param name="input">Instance of BpayAccountRequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BpayAccountRequestBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.BillerCode == input.BillerCode ||
                    this.BillerCode.Equals(input.BillerCode)
                ) && 
                (
                    this.BpayCrn == input.BpayCrn ||
                    (this.BpayCrn != null &&
                    this.BpayCrn.Equals(input.BpayCrn))
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
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                if (this.AccountName != null)
                {
                    hashCode = (hashCode * 59) + this.AccountName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BillerCode.GetHashCode();
                if (this.BpayCrn != null)
                {
                    hashCode = (hashCode * 59) + this.BpayCrn.GetHashCode();
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
