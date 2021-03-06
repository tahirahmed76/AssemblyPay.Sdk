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
    /// BankAccountBankAccountsLinks
    /// </summary>
    [DataContract(Name = "bank_account_bank_accounts_links")]
    public partial class BankAccountBankAccountsLinks : IEquatable<BankAccountBankAccountsLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountBankAccountsLinks" /> class.
        /// </summary>
        /// <param name="self">self.</param>
        /// <param name="users">users.</param>
        /// <param name="directDebitAuthorities">directDebitAuthorities.</param>
        public BankAccountBankAccountsLinks(string self = default(string), string users = default(string), string directDebitAuthorities = default(string))
        {
            this.Self = self;
            this.Users = users;
            this.DirectDebitAuthorities = directDebitAuthorities;
        }

        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name = "self", EmitDefaultValue = false)]
        public string Self { get; set; }

        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name = "users", EmitDefaultValue = false)]
        public string Users { get; set; }

        /// <summary>
        /// Gets or Sets DirectDebitAuthorities
        /// </summary>
        [DataMember(Name = "direct_debit_authorities", EmitDefaultValue = false)]
        public string DirectDebitAuthorities { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BankAccountBankAccountsLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  DirectDebitAuthorities: ").Append(DirectDebitAuthorities).Append("\n");
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
            return this.Equals(input as BankAccountBankAccountsLinks);
        }

        /// <summary>
        /// Returns true if BankAccountBankAccountsLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of BankAccountBankAccountsLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankAccountBankAccountsLinks input)
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
                    this.Users == input.Users ||
                    (this.Users != null &&
                    this.Users.Equals(input.Users))
                ) && 
                (
                    this.DirectDebitAuthorities == input.DirectDebitAuthorities ||
                    (this.DirectDebitAuthorities != null &&
                    this.DirectDebitAuthorities.Equals(input.DirectDebitAuthorities))
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
                if (this.Users != null)
                {
                    hashCode = (hashCode * 59) + this.Users.GetHashCode();
                }
                if (this.DirectDebitAuthorities != null)
                {
                    hashCode = (hashCode * 59) + this.DirectDebitAuthorities.GetHashCode();
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
