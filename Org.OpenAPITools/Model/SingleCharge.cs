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
    /// SingleCharge
    /// </summary>
    [DataContract(Name = "single_charge")]
    public partial class SingleCharge : IEquatable<SingleCharge>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SingleCharge" /> class.
        /// </summary>
        /// <param name="charges">charges.</param>
        public SingleCharge(Charge charges = default(Charge))
        {
            this.Charges = charges;
        }

        /// <summary>
        /// Gets or Sets Charges
        /// </summary>
        [DataMember(Name = "charges", EmitDefaultValue = false)]
        public Charge Charges { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SingleCharge {\n");
            sb.Append("  Charges: ").Append(Charges).Append("\n");
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
            return this.Equals(input as SingleCharge);
        }

        /// <summary>
        /// Returns true if SingleCharge instances are equal
        /// </summary>
        /// <param name="input">Instance of SingleCharge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SingleCharge input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Charges == input.Charges ||
                    (this.Charges != null &&
                    this.Charges.Equals(input.Charges))
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
                if (this.Charges != null)
                {
                    hashCode = (hashCode * 59) + this.Charges.GetHashCode();
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