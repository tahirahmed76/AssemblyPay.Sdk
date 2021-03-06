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
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace AssemblyPay.Sdk.Model
{
    /// <summary>
    /// TokenAuthRequestBody
    /// </summary>
    [DataContract(Name = "token_auth_requestBody")]
    public partial class TokenAuthRequestBody : IEquatable<TokenAuthRequestBody>, IValidatableObject
    {
        /// <summary>
        /// Token type ID. use &#x60;bank&#x60; or &#x60;card&#x60;
        /// </summary>
        /// <value>Token type ID. use &#x60;bank&#x60; or &#x60;card&#x60;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TokenTypeEnum
        {
            /// <summary>
            /// Enum Bank for value: bank
            /// </summary>
            [EnumMember(Value = "bank")]
            Bank = 1,

            /// <summary>
            /// Enum Card for value: card
            /// </summary>
            [EnumMember(Value = "card")]
            Card = 2

        }


        /// <summary>
        /// Token type ID. use &#x60;bank&#x60; or &#x60;card&#x60;
        /// </summary>
        /// <value>Token type ID. use &#x60;bank&#x60; or &#x60;card&#x60;</value>
        [DataMember(Name = "token_type", IsRequired = true, EmitDefaultValue = false)]
        public TokenTypeEnum TokenType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenAuthRequestBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TokenAuthRequestBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenAuthRequestBody" /> class.
        /// </summary>
        /// <param name="tokenType">Token type ID. use &#x60;bank&#x60; or &#x60;card&#x60; (required) (default to TokenTypeEnum.Bank).</param>
        /// <param name="userId">Buyer or Seller ID (already created) (required) (default to &quot;seller-68611249&quot;).</param>
        public TokenAuthRequestBody(TokenTypeEnum tokenType = TokenTypeEnum.Bank, string userId = "seller-68611249")
        {
            this.TokenType = tokenType;
            // to ensure "userId" is required (not null)
            if (userId == null) {
                throw new ArgumentNullException("userId is a required property for TokenAuthRequestBody and cannot be null");
            }
            this.UserId = userId;
        }

        /// <summary>
        /// Buyer or Seller ID (already created)
        /// </summary>
        /// <value>Buyer or Seller ID (already created)</value>
        [DataMember(Name = "user_id", IsRequired = true, EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TokenAuthRequestBody {\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
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
            return this.Equals(input as TokenAuthRequestBody);
        }

        /// <summary>
        /// Returns true if TokenAuthRequestBody instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenAuthRequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenAuthRequestBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TokenType == input.TokenType ||
                    this.TokenType.Equals(input.TokenType)
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
                hashCode = (hashCode * 59) + this.TokenType.GetHashCode();
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
