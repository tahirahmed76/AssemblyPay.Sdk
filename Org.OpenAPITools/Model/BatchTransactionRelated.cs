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
    /// BatchTransactionRelated
    /// </summary>
    [DataContract(Name = "batch_transaction_related")]
    public partial class BatchTransactionRelated : IEquatable<BatchTransactionRelated>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchTransactionRelated" /> class.
        /// </summary>
        /// <param name="accountTo">accountTo.</param>
        public BatchTransactionRelated(BatchTransactionRelatedAccountTo accountTo = default(BatchTransactionRelatedAccountTo))
        {
            this.AccountTo = accountTo;
        }

        /// <summary>
        /// Gets or Sets AccountTo
        /// </summary>
        [DataMember(Name = "account_to", EmitDefaultValue = false)]
        public BatchTransactionRelatedAccountTo AccountTo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BatchTransactionRelated {\n");
            sb.Append("  AccountTo: ").Append(AccountTo).Append("\n");
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
            return this.Equals(input as BatchTransactionRelated);
        }

        /// <summary>
        /// Returns true if BatchTransactionRelated instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchTransactionRelated to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchTransactionRelated input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountTo == input.AccountTo ||
                    (this.AccountTo != null &&
                    this.AccountTo.Equals(input.AccountTo))
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
                if (this.AccountTo != null)
                {
                    hashCode = (hashCode * 59) + this.AccountTo.GetHashCode();
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