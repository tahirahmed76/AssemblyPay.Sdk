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
    /// ChargeLinks
    /// </summary>
    [DataContract(Name = "charge_links")]
    public partial class ChargeLinks : IEquatable<ChargeLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeLinks" /> class.
        /// </summary>
        /// <param name="self">self.</param>
        /// <param name="buyers">buyers.</param>
        /// <param name="sellers">sellers.</param>
        /// <param name="status">status.</param>
        /// <param name="fees">fees.</param>
        /// <param name="transactions">transactions.</param>
        /// <param name="batchTransactions">batchTransactions.</param>
        public ChargeLinks(string self = default(string), string buyers = default(string), string sellers = default(string), string status = default(string), string fees = default(string), string transactions = default(string), string batchTransactions = default(string))
        {
            this.Self = self;
            this.Buyers = buyers;
            this.Sellers = sellers;
            this.Status = status;
            this.Fees = fees;
            this.Transactions = transactions;
            this.BatchTransactions = batchTransactions;
        }

        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name = "self", EmitDefaultValue = false)]
        public string Self { get; set; }

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
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Fees
        /// </summary>
        [DataMember(Name = "fees", EmitDefaultValue = false)]
        public string Fees { get; set; }

        /// <summary>
        /// Gets or Sets Transactions
        /// </summary>
        [DataMember(Name = "transactions", EmitDefaultValue = false)]
        public string Transactions { get; set; }

        /// <summary>
        /// Gets or Sets BatchTransactions
        /// </summary>
        [DataMember(Name = "batch_transactions", EmitDefaultValue = false)]
        public string BatchTransactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChargeLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Buyers: ").Append(Buyers).Append("\n");
            sb.Append("  Sellers: ").Append(Sellers).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Fees: ").Append(Fees).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
            sb.Append("  BatchTransactions: ").Append(BatchTransactions).Append("\n");
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
            return this.Equals(input as ChargeLinks);
        }

        /// <summary>
        /// Returns true if ChargeLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of ChargeLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargeLinks input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Self == input.Self ||
                    (this.Self != null &&
                    this.Self.Equals(input.Self))
                ) && 
                (
                    this.Buyers == input.Buyers ||
                    (this.Buyers != null &&
                    this.Buyers.Equals(input.Buyers))
                ) && 
                (
                    this.Sellers == input.Sellers ||
                    (this.Sellers != null &&
                    this.Sellers.Equals(input.Sellers))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Fees == input.Fees ||
                    (this.Fees != null &&
                    this.Fees.Equals(input.Fees))
                ) && 
                (
                    this.Transactions == input.Transactions ||
                    (this.Transactions != null &&
                    this.Transactions.Equals(input.Transactions))
                ) && 
                (
                    this.BatchTransactions == input.BatchTransactions ||
                    (this.BatchTransactions != null &&
                    this.BatchTransactions.Equals(input.BatchTransactions))
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
                if (this.Self != null)
                {
                    hashCode = (hashCode * 59) + this.Self.GetHashCode();
                }
                if (this.Buyers != null)
                {
                    hashCode = (hashCode * 59) + this.Buyers.GetHashCode();
                }
                if (this.Sellers != null)
                {
                    hashCode = (hashCode * 59) + this.Sellers.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Fees != null)
                {
                    hashCode = (hashCode * 59) + this.Fees.GetHashCode();
                }
                if (this.Transactions != null)
                {
                    hashCode = (hashCode * 59) + this.Transactions.GetHashCode();
                }
                if (this.BatchTransactions != null)
                {
                    hashCode = (hashCode * 59) + this.BatchTransactions.GetHashCode();
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