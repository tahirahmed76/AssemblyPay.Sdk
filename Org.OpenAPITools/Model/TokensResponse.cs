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
    /// TokensResponse
    /// </summary>
    [DataContract(Name = "tokens_response")]
    public partial class TokensResponse : IEquatable<TokensResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokensResponse" /> class.
        /// </summary>
        /// <param name="accessToken">JWT issued by AWS Cognito..</param>
        /// <param name="expiresIn">Lifetime of access token in seconds..</param>
        /// <param name="tokenType">Authorization header value prefix. This is a constant..</param>
        public TokensResponse(string accessToken = default(string), decimal expiresIn = default(decimal), string tokenType = default(string))
        {
            this.AccessToken = accessToken;
            this.ExpiresIn = expiresIn;
            this.TokenType = tokenType;
        }

        /// <summary>
        /// JWT issued by AWS Cognito.
        /// </summary>
        /// <value>JWT issued by AWS Cognito.</value>
        [DataMember(Name = "access_token", EmitDefaultValue = false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Lifetime of access token in seconds.
        /// </summary>
        /// <value>Lifetime of access token in seconds.</value>
        [DataMember(Name = "expires_in", EmitDefaultValue = false)]
        public decimal ExpiresIn { get; set; }

        /// <summary>
        /// Authorization header value prefix. This is a constant.
        /// </summary>
        /// <value>Authorization header value prefix. This is a constant.</value>
        [DataMember(Name = "token_type", EmitDefaultValue = false)]
        public string TokenType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TokensResponse {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
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
            return this.Equals(input as TokensResponse);
        }

        /// <summary>
        /// Returns true if TokensResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TokensResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokensResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccessToken == input.AccessToken ||
                    (this.AccessToken != null &&
                    this.AccessToken.Equals(input.AccessToken))
                ) && 
                (
                    this.ExpiresIn == input.ExpiresIn ||
                    this.ExpiresIn.Equals(input.ExpiresIn)
                ) && 
                (
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))
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
                if (this.AccessToken != null)
                {
                    hashCode = (hashCode * 59) + this.AccessToken.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExpiresIn.GetHashCode();
                if (this.TokenType != null)
                {
                    hashCode = (hashCode * 59) + this.TokenType.GetHashCode();
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
