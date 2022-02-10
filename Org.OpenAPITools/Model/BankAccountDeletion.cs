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
    /// BankAccountDeletion
    /// </summary>
    [DataContract(Name = "bank_account_deletion")]
    public partial class BankAccountDeletion : IEquatable<BankAccountDeletion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountDeletion" /> class.
        /// </summary>
        /// <param name="bankAccount">bankAccount.</param>
        public BankAccountDeletion(string bankAccount = default(string))
        {
            this.BankAccount = bankAccount;
        }

        /// <summary>
        /// Gets or Sets BankAccount
        /// </summary>
        [DataMember(Name = "bank_account", EmitDefaultValue = false)]
        public string BankAccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BankAccountDeletion {\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
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
            return this.Equals(input as BankAccountDeletion);
        }

        /// <summary>
        /// Returns true if BankAccountDeletion instances are equal
        /// </summary>
        /// <param name="input">Instance of BankAccountDeletion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankAccountDeletion input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BankAccount == input.BankAccount ||
                    (this.BankAccount != null &&
                    this.BankAccount.Equals(input.BankAccount))
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
                if (this.BankAccount != null)
                {
                    hashCode = (hashCode * 59) + this.BankAccount.GetHashCode();
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
