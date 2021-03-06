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
    /// MarketplaceMarketplacesBusinessInformation
    /// </summary>
    [DataContract(Name = "marketplace_marketplaces_business_information")]
    public partial class MarketplaceMarketplacesBusinessInformation : IEquatable<MarketplaceMarketplacesBusinessInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceMarketplacesBusinessInformation" /> class.
        /// </summary>
        /// <param name="principalName">principalName.</param>
        /// <param name="principalGovernmentNumber">principalGovernmentNumber.</param>
        /// <param name="incorporationDate">incorporationDate.</param>
        /// <param name="bankAccountHolder">bankAccountHolder.</param>
        /// <param name="bankAccountNumber">bankAccountNumber.</param>
        /// <param name="bankRoutingNumber">bankRoutingNumber.</param>
        /// <param name="avgTransactionValue">avgTransactionValue.</param>
        /// <param name="monthlyTransactions">monthlyTransactions.</param>
        /// <param name="monthlyDisputes">monthlyDisputes.</param>
        /// <param name="monthlyRefunds">monthlyRefunds.</param>
        /// <param name="monthlyChargebacks">monthlyChargebacks.</param>
        /// <param name="uniqueUsers">uniqueUsers.</param>
        /// <param name="companyPhone">companyPhone.</param>
        /// <param name="companyCountry">companyCountry.</param>
        /// <param name="transactionTime">transactionTime.</param>
        /// <param name="paymentsFlow">paymentsFlow.</param>
        /// <param name="businessModelDescription">businessModelDescription.</param>
        /// <param name="customerSupportEmail">customerSupportEmail.</param>
        /// <param name="bankName">bankName.</param>
        /// <param name="bankAccountType">bankAccountType.</param>
        /// <param name="bankHolderType">bankHolderType.</param>
        public MarketplaceMarketplacesBusinessInformation(string principalName = default(string), string principalGovernmentNumber = default(string), string incorporationDate = default(string), string bankAccountHolder = default(string), string bankAccountNumber = default(string), string bankRoutingNumber = default(string), string avgTransactionValue = default(string), string monthlyTransactions = default(string), string monthlyDisputes = default(string), string monthlyRefunds = default(string), string monthlyChargebacks = default(string), string uniqueUsers = default(string), string companyPhone = default(string), string companyCountry = default(string), string transactionTime = default(string), string paymentsFlow = default(string), string businessModelDescription = default(string), string customerSupportEmail = default(string), string bankName = default(string), string bankAccountType = default(string), string bankHolderType = default(string))
        {
            this.PrincipalName = principalName;
            this.PrincipalGovernmentNumber = principalGovernmentNumber;
            this.IncorporationDate = incorporationDate;
            this.BankAccountHolder = bankAccountHolder;
            this.BankAccountNumber = bankAccountNumber;
            this.BankRoutingNumber = bankRoutingNumber;
            this.AvgTransactionValue = avgTransactionValue;
            this.MonthlyTransactions = monthlyTransactions;
            this.MonthlyDisputes = monthlyDisputes;
            this.MonthlyRefunds = monthlyRefunds;
            this.MonthlyChargebacks = monthlyChargebacks;
            this.UniqueUsers = uniqueUsers;
            this.CompanyPhone = companyPhone;
            this.CompanyCountry = companyCountry;
            this.TransactionTime = transactionTime;
            this.PaymentsFlow = paymentsFlow;
            this.BusinessModelDescription = businessModelDescription;
            this.CustomerSupportEmail = customerSupportEmail;
            this.BankName = bankName;
            this.BankAccountType = bankAccountType;
            this.BankHolderType = bankHolderType;
        }

        /// <summary>
        /// Gets or Sets PrincipalName
        /// </summary>
        [DataMember(Name = "principal_name", EmitDefaultValue = false)]
        public string PrincipalName { get; set; }

        /// <summary>
        /// Gets or Sets PrincipalGovernmentNumber
        /// </summary>
        [DataMember(Name = "principal_government_number", EmitDefaultValue = false)]
        public string PrincipalGovernmentNumber { get; set; }

        /// <summary>
        /// Gets or Sets IncorporationDate
        /// </summary>
        [DataMember(Name = "incorporation_date", EmitDefaultValue = false)]
        public string IncorporationDate { get; set; }

        /// <summary>
        /// Gets or Sets BankAccountHolder
        /// </summary>
        [DataMember(Name = "bank_account_holder", EmitDefaultValue = false)]
        public string BankAccountHolder { get; set; }

        /// <summary>
        /// Gets or Sets BankAccountNumber
        /// </summary>
        [DataMember(Name = "bank_account_number", EmitDefaultValue = false)]
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets BankRoutingNumber
        /// </summary>
        [DataMember(Name = "bank_routing_number", EmitDefaultValue = false)]
        public string BankRoutingNumber { get; set; }

        /// <summary>
        /// Gets or Sets AvgTransactionValue
        /// </summary>
        [DataMember(Name = "avg_transaction_value", EmitDefaultValue = false)]
        public string AvgTransactionValue { get; set; }

        /// <summary>
        /// Gets or Sets MonthlyTransactions
        /// </summary>
        [DataMember(Name = "monthly_transactions", EmitDefaultValue = false)]
        public string MonthlyTransactions { get; set; }

        /// <summary>
        /// Gets or Sets MonthlyDisputes
        /// </summary>
        [DataMember(Name = "monthly_disputes", EmitDefaultValue = false)]
        public string MonthlyDisputes { get; set; }

        /// <summary>
        /// Gets or Sets MonthlyRefunds
        /// </summary>
        [DataMember(Name = "monthly_refunds", EmitDefaultValue = false)]
        public string MonthlyRefunds { get; set; }

        /// <summary>
        /// Gets or Sets MonthlyChargebacks
        /// </summary>
        [DataMember(Name = "monthly_chargebacks", EmitDefaultValue = false)]
        public string MonthlyChargebacks { get; set; }

        /// <summary>
        /// Gets or Sets UniqueUsers
        /// </summary>
        [DataMember(Name = "unique_users", EmitDefaultValue = false)]
        public string UniqueUsers { get; set; }

        /// <summary>
        /// Gets or Sets CompanyPhone
        /// </summary>
        [DataMember(Name = "company_phone", EmitDefaultValue = false)]
        public string CompanyPhone { get; set; }

        /// <summary>
        /// Gets or Sets CompanyCountry
        /// </summary>
        [DataMember(Name = "company_country", EmitDefaultValue = false)]
        public string CompanyCountry { get; set; }

        /// <summary>
        /// Gets or Sets TransactionTime
        /// </summary>
        [DataMember(Name = "transaction_time", EmitDefaultValue = false)]
        public string TransactionTime { get; set; }

        /// <summary>
        /// Gets or Sets PaymentsFlow
        /// </summary>
        [DataMember(Name = "payments_flow", EmitDefaultValue = false)]
        public string PaymentsFlow { get; set; }

        /// <summary>
        /// Gets or Sets BusinessModelDescription
        /// </summary>
        [DataMember(Name = "business_model_description", EmitDefaultValue = false)]
        public string BusinessModelDescription { get; set; }

        /// <summary>
        /// Gets or Sets CustomerSupportEmail
        /// </summary>
        [DataMember(Name = "customer_support_email", EmitDefaultValue = false)]
        public string CustomerSupportEmail { get; set; }

        /// <summary>
        /// Gets or Sets BankName
        /// </summary>
        [DataMember(Name = "bank_name", EmitDefaultValue = false)]
        public string BankName { get; set; }

        /// <summary>
        /// Gets or Sets BankAccountType
        /// </summary>
        [DataMember(Name = "bank_account_type", EmitDefaultValue = false)]
        public string BankAccountType { get; set; }

        /// <summary>
        /// Gets or Sets BankHolderType
        /// </summary>
        [DataMember(Name = "bank_holder_type", EmitDefaultValue = false)]
        public string BankHolderType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MarketplaceMarketplacesBusinessInformation {\n");
            sb.Append("  PrincipalName: ").Append(PrincipalName).Append("\n");
            sb.Append("  PrincipalGovernmentNumber: ").Append(PrincipalGovernmentNumber).Append("\n");
            sb.Append("  IncorporationDate: ").Append(IncorporationDate).Append("\n");
            sb.Append("  BankAccountHolder: ").Append(BankAccountHolder).Append("\n");
            sb.Append("  BankAccountNumber: ").Append(BankAccountNumber).Append("\n");
            sb.Append("  BankRoutingNumber: ").Append(BankRoutingNumber).Append("\n");
            sb.Append("  AvgTransactionValue: ").Append(AvgTransactionValue).Append("\n");
            sb.Append("  MonthlyTransactions: ").Append(MonthlyTransactions).Append("\n");
            sb.Append("  MonthlyDisputes: ").Append(MonthlyDisputes).Append("\n");
            sb.Append("  MonthlyRefunds: ").Append(MonthlyRefunds).Append("\n");
            sb.Append("  MonthlyChargebacks: ").Append(MonthlyChargebacks).Append("\n");
            sb.Append("  UniqueUsers: ").Append(UniqueUsers).Append("\n");
            sb.Append("  CompanyPhone: ").Append(CompanyPhone).Append("\n");
            sb.Append("  CompanyCountry: ").Append(CompanyCountry).Append("\n");
            sb.Append("  TransactionTime: ").Append(TransactionTime).Append("\n");
            sb.Append("  PaymentsFlow: ").Append(PaymentsFlow).Append("\n");
            sb.Append("  BusinessModelDescription: ").Append(BusinessModelDescription).Append("\n");
            sb.Append("  CustomerSupportEmail: ").Append(CustomerSupportEmail).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  BankAccountType: ").Append(BankAccountType).Append("\n");
            sb.Append("  BankHolderType: ").Append(BankHolderType).Append("\n");
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
            return this.Equals(input as MarketplaceMarketplacesBusinessInformation);
        }

        /// <summary>
        /// Returns true if MarketplaceMarketplacesBusinessInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of MarketplaceMarketplacesBusinessInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarketplaceMarketplacesBusinessInformation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PrincipalName == input.PrincipalName ||
                    (this.PrincipalName != null &&
                    this.PrincipalName.Equals(input.PrincipalName))
                ) && 
                (
                    this.PrincipalGovernmentNumber == input.PrincipalGovernmentNumber ||
                    (this.PrincipalGovernmentNumber != null &&
                    this.PrincipalGovernmentNumber.Equals(input.PrincipalGovernmentNumber))
                ) && 
                (
                    this.IncorporationDate == input.IncorporationDate ||
                    (this.IncorporationDate != null &&
                    this.IncorporationDate.Equals(input.IncorporationDate))
                ) && 
                (
                    this.BankAccountHolder == input.BankAccountHolder ||
                    (this.BankAccountHolder != null &&
                    this.BankAccountHolder.Equals(input.BankAccountHolder))
                ) && 
                (
                    this.BankAccountNumber == input.BankAccountNumber ||
                    (this.BankAccountNumber != null &&
                    this.BankAccountNumber.Equals(input.BankAccountNumber))
                ) && 
                (
                    this.BankRoutingNumber == input.BankRoutingNumber ||
                    (this.BankRoutingNumber != null &&
                    this.BankRoutingNumber.Equals(input.BankRoutingNumber))
                ) && 
                (
                    this.AvgTransactionValue == input.AvgTransactionValue ||
                    (this.AvgTransactionValue != null &&
                    this.AvgTransactionValue.Equals(input.AvgTransactionValue))
                ) && 
                (
                    this.MonthlyTransactions == input.MonthlyTransactions ||
                    (this.MonthlyTransactions != null &&
                    this.MonthlyTransactions.Equals(input.MonthlyTransactions))
                ) && 
                (
                    this.MonthlyDisputes == input.MonthlyDisputes ||
                    (this.MonthlyDisputes != null &&
                    this.MonthlyDisputes.Equals(input.MonthlyDisputes))
                ) && 
                (
                    this.MonthlyRefunds == input.MonthlyRefunds ||
                    (this.MonthlyRefunds != null &&
                    this.MonthlyRefunds.Equals(input.MonthlyRefunds))
                ) && 
                (
                    this.MonthlyChargebacks == input.MonthlyChargebacks ||
                    (this.MonthlyChargebacks != null &&
                    this.MonthlyChargebacks.Equals(input.MonthlyChargebacks))
                ) && 
                (
                    this.UniqueUsers == input.UniqueUsers ||
                    (this.UniqueUsers != null &&
                    this.UniqueUsers.Equals(input.UniqueUsers))
                ) && 
                (
                    this.CompanyPhone == input.CompanyPhone ||
                    (this.CompanyPhone != null &&
                    this.CompanyPhone.Equals(input.CompanyPhone))
                ) && 
                (
                    this.CompanyCountry == input.CompanyCountry ||
                    (this.CompanyCountry != null &&
                    this.CompanyCountry.Equals(input.CompanyCountry))
                ) && 
                (
                    this.TransactionTime == input.TransactionTime ||
                    (this.TransactionTime != null &&
                    this.TransactionTime.Equals(input.TransactionTime))
                ) && 
                (
                    this.PaymentsFlow == input.PaymentsFlow ||
                    (this.PaymentsFlow != null &&
                    this.PaymentsFlow.Equals(input.PaymentsFlow))
                ) && 
                (
                    this.BusinessModelDescription == input.BusinessModelDescription ||
                    (this.BusinessModelDescription != null &&
                    this.BusinessModelDescription.Equals(input.BusinessModelDescription))
                ) && 
                (
                    this.CustomerSupportEmail == input.CustomerSupportEmail ||
                    (this.CustomerSupportEmail != null &&
                    this.CustomerSupportEmail.Equals(input.CustomerSupportEmail))
                ) && 
                (
                    this.BankName == input.BankName ||
                    (this.BankName != null &&
                    this.BankName.Equals(input.BankName))
                ) && 
                (
                    this.BankAccountType == input.BankAccountType ||
                    (this.BankAccountType != null &&
                    this.BankAccountType.Equals(input.BankAccountType))
                ) && 
                (
                    this.BankHolderType == input.BankHolderType ||
                    (this.BankHolderType != null &&
                    this.BankHolderType.Equals(input.BankHolderType))
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
                if (this.PrincipalName != null)
                {
                    hashCode = (hashCode * 59) + this.PrincipalName.GetHashCode();
                }
                if (this.PrincipalGovernmentNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PrincipalGovernmentNumber.GetHashCode();
                }
                if (this.IncorporationDate != null)
                {
                    hashCode = (hashCode * 59) + this.IncorporationDate.GetHashCode();
                }
                if (this.BankAccountHolder != null)
                {
                    hashCode = (hashCode * 59) + this.BankAccountHolder.GetHashCode();
                }
                if (this.BankAccountNumber != null)
                {
                    hashCode = (hashCode * 59) + this.BankAccountNumber.GetHashCode();
                }
                if (this.BankRoutingNumber != null)
                {
                    hashCode = (hashCode * 59) + this.BankRoutingNumber.GetHashCode();
                }
                if (this.AvgTransactionValue != null)
                {
                    hashCode = (hashCode * 59) + this.AvgTransactionValue.GetHashCode();
                }
                if (this.MonthlyTransactions != null)
                {
                    hashCode = (hashCode * 59) + this.MonthlyTransactions.GetHashCode();
                }
                if (this.MonthlyDisputes != null)
                {
                    hashCode = (hashCode * 59) + this.MonthlyDisputes.GetHashCode();
                }
                if (this.MonthlyRefunds != null)
                {
                    hashCode = (hashCode * 59) + this.MonthlyRefunds.GetHashCode();
                }
                if (this.MonthlyChargebacks != null)
                {
                    hashCode = (hashCode * 59) + this.MonthlyChargebacks.GetHashCode();
                }
                if (this.UniqueUsers != null)
                {
                    hashCode = (hashCode * 59) + this.UniqueUsers.GetHashCode();
                }
                if (this.CompanyPhone != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyPhone.GetHashCode();
                }
                if (this.CompanyCountry != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyCountry.GetHashCode();
                }
                if (this.TransactionTime != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionTime.GetHashCode();
                }
                if (this.PaymentsFlow != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentsFlow.GetHashCode();
                }
                if (this.BusinessModelDescription != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessModelDescription.GetHashCode();
                }
                if (this.CustomerSupportEmail != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerSupportEmail.GetHashCode();
                }
                if (this.BankName != null)
                {
                    hashCode = (hashCode * 59) + this.BankName.GetHashCode();
                }
                if (this.BankAccountType != null)
                {
                    hashCode = (hashCode * 59) + this.BankAccountType.GetHashCode();
                }
                if (this.BankHolderType != null)
                {
                    hashCode = (hashCode * 59) + this.BankHolderType.GetHashCode();
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
