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
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace AssemblyPay.Sdk.Model
{
    /// <summary>
    /// BankAccountBankAccountsBank
    /// </summary>
    [DataContract(Name = "bank_account_bank_accounts_bank")]
    public partial class BankAccountBankAccountsBank : IEquatable<BankAccountBankAccountsBank>, IValidatableObject
    {
        /// <summary>
        /// Defines HolderType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HolderTypeEnum
        {
            /// <summary>
            /// Enum Personal for value: personal
            /// </summary>
            [EnumMember(Value = "personal")]
            Personal = 1,

            /// <summary>
            /// Enum Business for value: business
            /// </summary>
            [EnumMember(Value = "business")]
            Business = 2

        }


        /// <summary>
        /// Gets or Sets HolderType
        /// </summary>
        [DataMember(Name = "holder_type", EmitDefaultValue = false)]
        public HolderTypeEnum? HolderType { get; set; }
        /// <summary>
        /// Defines AccountType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountTypeEnum
        {
            /// <summary>
            /// Enum Savings for value: savings
            /// </summary>
            [EnumMember(Value = "savings")]
            Savings = 1,

            /// <summary>
            /// Enum Checking for value: checking
            /// </summary>
            [EnumMember(Value = "checking")]
            Checking = 2

        }


        /// <summary>
        /// Gets or Sets AccountType
        /// </summary>
        [DataMember(Name = "account_type", EmitDefaultValue = false)]
        public AccountTypeEnum? AccountType { get; set; }
        /// <summary>
        /// Defines DirectDebitAuthorityStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectDebitAuthorityStatusEnum
        {
            /// <summary>
            /// Enum Null for value: null
            /// </summary>
            [EnumMember(Value = "null")]
            Null = 1,

            /// <summary>
            /// Enum Approved for value: approved
            /// </summary>
            [EnumMember(Value = "approved")]
            Approved = 2

        }


        /// <summary>
        /// Gets or Sets DirectDebitAuthorityStatus
        /// </summary>
        [DataMember(Name = "direct_debit_authority_status", EmitDefaultValue = false)]
        public DirectDebitAuthorityStatusEnum? DirectDebitAuthorityStatus { get; set; }

        /// <summary>
        /// Returns false as DirectDebitAuthorityStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDirectDebitAuthorityStatus()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountBankAccountsBank" /> class.
        /// </summary>
        /// <param name="bankName">bankName.</param>
        /// <param name="country">country.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="routingNumber">routingNumber.</param>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="holderType">holderType.</param>
        /// <param name="accountType">accountType.</param>
        public BankAccountBankAccountsBank(string bankName = default(string), string country = default(string), string accountName = default(string), string routingNumber = default(string), string accountNumber = default(string), HolderTypeEnum? holderType = default(HolderTypeEnum?), AccountTypeEnum? accountType = default(AccountTypeEnum?))
        {
            this.BankName = bankName;
            this.Country = country;
            this.AccountName = accountName;
            this.RoutingNumber = routingNumber;
            this.AccountNumber = accountNumber;
            this.HolderType = holderType;
            this.AccountType = accountType;
        }

        /// <summary>
        /// Gets or Sets BankName
        /// </summary>
        [DataMember(Name = "bank_name", EmitDefaultValue = false)]
        public string BankName { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets AccountName
        /// </summary>
        [DataMember(Name = "account_name", EmitDefaultValue = false)]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or Sets RoutingNumber
        /// </summary>
        [DataMember(Name = "routing_number", EmitDefaultValue = false)]
        public string RoutingNumber { get; set; }

        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name = "account_number", EmitDefaultValue = false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BankAccountBankAccountsBank {\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  RoutingNumber: ").Append(RoutingNumber).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  HolderType: ").Append(HolderType).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  DirectDebitAuthorityStatus: ").Append(DirectDebitAuthorityStatus).Append("\n");
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
            return this.Equals(input as BankAccountBankAccountsBank);
        }

        /// <summary>
        /// Returns true if BankAccountBankAccountsBank instances are equal
        /// </summary>
        /// <param name="input">Instance of BankAccountBankAccountsBank to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankAccountBankAccountsBank input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BankName == input.BankName ||
                    (this.BankName != null &&
                    this.BankName.Equals(input.BankName))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.RoutingNumber == input.RoutingNumber ||
                    (this.RoutingNumber != null &&
                    this.RoutingNumber.Equals(input.RoutingNumber))
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.HolderType == input.HolderType ||
                    this.HolderType.Equals(input.HolderType)
                ) && 
                (
                    this.AccountType == input.AccountType ||
                    this.AccountType.Equals(input.AccountType)
                ) && 
                (
                    this.DirectDebitAuthorityStatus == input.DirectDebitAuthorityStatus ||
                    this.DirectDebitAuthorityStatus.Equals(input.DirectDebitAuthorityStatus)
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
                if (this.BankName != null)
                {
                    hashCode = (hashCode * 59) + this.BankName.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.AccountName != null)
                {
                    hashCode = (hashCode * 59) + this.AccountName.GetHashCode();
                }
                if (this.RoutingNumber != null)
                {
                    hashCode = (hashCode * 59) + this.RoutingNumber.GetHashCode();
                }
                if (this.AccountNumber != null)
                {
                    hashCode = (hashCode * 59) + this.AccountNumber.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HolderType.GetHashCode();
                hashCode = (hashCode * 59) + this.AccountType.GetHashCode();
                hashCode = (hashCode * 59) + this.DirectDebitAuthorityStatus.GetHashCode();
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
