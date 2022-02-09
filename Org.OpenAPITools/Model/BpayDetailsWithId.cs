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
    /// BpayDetailsWithId
    /// </summary>
    [DataContract(Name = "bpay_details_with_id")]
    public partial class BpayDetailsWithId : IEquatable<BpayDetailsWithId>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BpayDetailsWithId" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="bpayDetails">bpayDetails.</param>
        public BpayDetailsWithId(string id = default(string), BpayDetails bpayDetails = default(BpayDetails))
        {
            this.Id = id;
            this.BpayDetails = bpayDetails;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets BpayDetails
        /// </summary>
        [DataMember(Name = "bpay_details", EmitDefaultValue = false)]
        public BpayDetails BpayDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BpayDetailsWithId {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BpayDetails: ").Append(BpayDetails).Append("\n");
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
            return this.Equals(input as BpayDetailsWithId);
        }

        /// <summary>
        /// Returns true if BpayDetailsWithId instances are equal
        /// </summary>
        /// <param name="input">Instance of BpayDetailsWithId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BpayDetailsWithId input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.BpayDetails == input.BpayDetails ||
                    (this.BpayDetails != null &&
                    this.BpayDetails.Equals(input.BpayDetails))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.BpayDetails != null)
                {
                    hashCode = (hashCode * 59) + this.BpayDetails.GetHashCode();
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
