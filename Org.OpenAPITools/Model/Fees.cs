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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace AssemblyPay.Sdk.Model
{
    /// <summary>
    /// Fees
    /// </summary>
    [DataContract(Name = "fees")]
    public partial class Fees : IEquatable<Fees>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Fees" /> class.
        /// </summary>
        /// <param name="fees">fees.</param>
        /// <param name="meta">meta.</param>
        /// <param name="links">links.</param>
        public Fees(List<Fee> fees = default(List<Fee>), ListBpayAccountsMeta meta = default(ListBpayAccountsMeta), AddressAddressesLinks links = default(AddressAddressesLinks))
        {
            this._Fees = fees;
            this.Meta = meta;
            this.Links = links;
        }

        /// <summary>
        /// Gets or Sets _Fees
        /// </summary>
        [DataMember(Name = "fees", EmitDefaultValue = false)]
        public List<Fee> _Fees { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name = "meta", EmitDefaultValue = false)]
        public ListBpayAccountsMeta Meta { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public AddressAddressesLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Fees {\n");
            sb.Append("  _Fees: ").Append(_Fees).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as Fees);
        }

        /// <summary>
        /// Returns true if Fees instances are equal
        /// </summary>
        /// <param name="input">Instance of Fees to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Fees input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this._Fees == input._Fees ||
                    this._Fees != null &&
                    input._Fees != null &&
                    this._Fees.SequenceEqual(input._Fees)
                ) && 
                (
                    this.Meta == input.Meta ||
                    (this.Meta != null &&
                    this.Meta.Equals(input.Meta))
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
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
                if (this._Fees != null)
                {
                    hashCode = (hashCode * 59) + this._Fees.GetHashCode();
                }
                if (this.Meta != null)
                {
                    hashCode = (hashCode * 59) + this.Meta.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
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
