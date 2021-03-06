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
    /// ItemRelated
    /// </summary>
    [DataContract(Name = "item_related")]
    public partial class ItemRelated : IEquatable<ItemRelated>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemRelated" /> class.
        /// </summary>
        /// <param name="buyers">buyers.</param>
        /// <param name="sellers">sellers.</param>
        public ItemRelated(string buyers = default(string), string sellers = default(string))
        {
            this.Buyers = buyers;
            this.Sellers = sellers;
        }

        /// <summary>
        /// Gets or Sets Buyers
        /// </summary>
        [DataMember(Name = "buyers", EmitDefaultValue = false)]
        public string Buyers { get; set; }

        /// <summary>
        /// Gets or Sets Sellers
        /// </summary>
        [DataMember(Name = "sellers", EmitDefaultValue = false)]
        public string Sellers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ItemRelated {\n");
            sb.Append("  Buyers: ").Append(Buyers).Append("\n");
            sb.Append("  Sellers: ").Append(Sellers).Append("\n");
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
            return this.Equals(input as ItemRelated);
        }

        /// <summary>
        /// Returns true if ItemRelated instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemRelated to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemRelated input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Buyers == input.Buyers ||
                    (this.Buyers != null &&
                    this.Buyers.Equals(input.Buyers))
                ) && 
                (
                    this.Sellers == input.Sellers ||
                    (this.Sellers != null &&
                    this.Sellers.Equals(input.Sellers))
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
                if (this.Buyers != null)
                {
                    hashCode = (hashCode * 59) + this.Buyers.GetHashCode();
                }
                if (this.Sellers != null)
                {
                    hashCode = (hashCode * 59) + this.Sellers.GetHashCode();
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
