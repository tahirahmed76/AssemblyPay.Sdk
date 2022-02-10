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
using System.ComponentModel.DataAnnotations;

namespace AssemblyPay.Sdk.Model
{
    /// <summary>
    /// Marketplace
    /// </summary>
    [DataContract(Name = "marketplace")]
    public partial class Marketplace : IEquatable<Marketplace>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Marketplace" /> class.
        /// </summary>
        /// <param name="marketplaces">marketplaces.</param>
        public Marketplace(MarketplaceMarketplaces marketplaces = default(MarketplaceMarketplaces))
        {
            this.Marketplaces = marketplaces;
        }

        /// <summary>
        /// Gets or Sets Marketplaces
        /// </summary>
        [DataMember(Name = "marketplaces", EmitDefaultValue = false)]
        public MarketplaceMarketplaces Marketplaces { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Marketplace {\n");
            sb.Append("  Marketplaces: ").Append(Marketplaces).Append("\n");
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
            return this.Equals(input as Marketplace);
        }

        /// <summary>
        /// Returns true if Marketplace instances are equal
        /// </summary>
        /// <param name="input">Instance of Marketplace to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Marketplace input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Marketplaces == input.Marketplaces ||
                    (this.Marketplaces != null &&
                    this.Marketplaces.Equals(input.Marketplaces))
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
                if (this.Marketplaces != null)
                {
                    hashCode = (hashCode * 59) + this.Marketplaces.GetHashCode();
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
