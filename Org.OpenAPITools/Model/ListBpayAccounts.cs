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
    /// ListBpayAccounts
    /// </summary>
    [DataContract(Name = "list_bpay_accounts")]
    public partial class ListBpayAccounts : IEquatable<ListBpayAccounts>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListBpayAccounts" /> class.
        /// </summary>
        /// <param name="bpayAccounts">bpayAccounts.</param>
        /// <param name="links">links.</param>
        /// <param name="meta">meta.</param>
        public ListBpayAccounts(List<ListBpayAccountsBpayAccounts> bpayAccounts = default(List<ListBpayAccountsBpayAccounts>), AddressAddressesLinks links = default(AddressAddressesLinks), ListBpayAccountsMeta meta = default(ListBpayAccountsMeta))
        {
            this.BpayAccounts = bpayAccounts;
            this.Links = links;
            this.Meta = meta;
        }

        /// <summary>
        /// Gets or Sets BpayAccounts
        /// </summary>
        [DataMember(Name = "bpay_accounts", EmitDefaultValue = false)]
        public List<ListBpayAccountsBpayAccounts> BpayAccounts { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public AddressAddressesLinks Links { get; set; }

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
            sb.Append("class ListBpayAccounts {\n");
            sb.Append("  BpayAccounts: ").Append(BpayAccounts).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as ListBpayAccounts);
        }

        /// <summary>
        /// Returns true if ListBpayAccounts instances are equal
        /// </summary>
        /// <param name="input">Instance of ListBpayAccounts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListBpayAccounts input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BpayAccounts == input.BpayAccounts ||
                    this.BpayAccounts != null &&
                    input.BpayAccounts != null &&
                    this.BpayAccounts.SequenceEqual(input.BpayAccounts)
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
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
                if (this.BpayAccounts != null)
                {
                    hashCode = (hashCode * 59) + this.BpayAccounts.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
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
