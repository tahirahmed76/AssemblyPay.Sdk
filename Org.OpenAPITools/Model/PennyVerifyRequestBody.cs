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
    /// PennyVerifyRequestBody
    /// </summary>
    [DataContract(Name = "penny_verify_requestBody")]
    public partial class PennyVerifyRequestBody : IEquatable<PennyVerifyRequestBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PennyVerifyRequestBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PennyVerifyRequestBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PennyVerifyRequestBody" /> class.
        /// </summary>
        /// <param name="amount1">First penny amount in cents. Can range from 1 to 30 cents. (required) (default to 10).</param>
        /// <param name="amount2">Second penny amount in cents. Can range from 1 to 30 cents. (required) (default to 20).</param>
        public PennyVerifyRequestBody(int amount1 = 10, int amount2 = 20)
        {
            this.Amount1 = amount1;
            this.Amount2 = amount2;
        }

        /// <summary>
        /// First penny amount in cents. Can range from 1 to 30 cents.
        /// </summary>
        /// <value>First penny amount in cents. Can range from 1 to 30 cents.</value>
        [DataMember(Name = "amount_1", IsRequired = true, EmitDefaultValue = false)]
        public int Amount1 { get; set; }

        /// <summary>
        /// Second penny amount in cents. Can range from 1 to 30 cents.
        /// </summary>
        /// <value>Second penny amount in cents. Can range from 1 to 30 cents.</value>
        [DataMember(Name = "amount_2", IsRequired = true, EmitDefaultValue = false)]
        public int Amount2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PennyVerifyRequestBody {\n");
            sb.Append("  Amount1: ").Append(Amount1).Append("\n");
            sb.Append("  Amount2: ").Append(Amount2).Append("\n");
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
            return this.Equals(input as PennyVerifyRequestBody);
        }

        /// <summary>
        /// Returns true if PennyVerifyRequestBody instances are equal
        /// </summary>
        /// <param name="input">Instance of PennyVerifyRequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PennyVerifyRequestBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount1 == input.Amount1 ||
                    this.Amount1.Equals(input.Amount1)
                ) && 
                (
                    this.Amount2 == input.Amount2 ||
                    this.Amount2.Equals(input.Amount2)
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
                hashCode = (hashCode * 59) + this.Amount1.GetHashCode();
                hashCode = (hashCode * 59) + this.Amount2.GetHashCode();
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
