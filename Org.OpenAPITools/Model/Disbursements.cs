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
    /// Disbursements
    /// </summary>
    [DataContract(Name = "disbursements")]
    public partial class Disbursements : IEquatable<Disbursements>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Disbursements" /> class.
        /// </summary>
        /// <param name="disbursements">disbursements.</param>
        /// <param name="meta">meta.</param>
        public Disbursements(List<Disbursement> disbursements = default(List<Disbursement>), ListBpayAccountsMeta meta = default(ListBpayAccountsMeta))
        {
            this._Disbursements = disbursements;
            this.Meta = meta;
        }

        /// <summary>
        /// Gets or Sets _Disbursements
        /// </summary>
        [DataMember(Name = "disbursements", EmitDefaultValue = false)]
        public List<Disbursement> _Disbursements { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name = "meta", EmitDefaultValue = false)]
        public ListBpayAccountsMeta Meta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Disbursements {\n");
            sb.Append("  _Disbursements: ").Append(_Disbursements).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
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
            return this.Equals(input as Disbursements);
        }

        /// <summary>
        /// Returns true if Disbursements instances are equal
        /// </summary>
        /// <param name="input">Instance of Disbursements to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Disbursements input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this._Disbursements == input._Disbursements ||
                    this._Disbursements != null &&
                    input._Disbursements != null &&
                    this._Disbursements.SequenceEqual(input._Disbursements)
                ) && 
                (
                    this.Meta == input.Meta ||
                    (this.Meta != null &&
                    this.Meta.Equals(input.Meta))
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
                if (this._Disbursements != null)
                {
                    hashCode = (hashCode * 59) + this._Disbursements.GetHashCode();
                }
                if (this.Meta != null)
                {
                    hashCode = (hashCode * 59) + this.Meta.GetHashCode();
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
