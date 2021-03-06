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
    /// payee details. only filled for specific payment types (fast payments - npp)
    /// </summary>
    [DataContract(Name = "transaction_payee_details")]
    public partial class TransactionPayeeDetails : IEquatable<TransactionPayeeDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionPayeeDetails" /> class.
        /// </summary>
        /// <param name="debtorName">debtorName.</param>
        /// <param name="debtorLegalName">debtorLegalName.</param>
        /// <param name="debtorBsb">debtorBsb.</param>
        /// <param name="debtorAccount">debtorAccount.</param>
        /// <param name="clearingSystemTransactionId">clearingSystemTransactionId.</param>
        /// <param name="remittanceInformation">remittanceInformation.</param>
        /// <param name="payId">payId.</param>
        /// <param name="payIdType">payIdType.</param>
        /// <param name="endToEndId">endToEndId.</param>
        /// <param name="nppPayinInternalId">nppPayinInternalId.</param>
        public TransactionPayeeDetails(string debtorName = default(string), string debtorLegalName = default(string), string debtorBsb = default(string), string debtorAccount = default(string), string clearingSystemTransactionId = default(string), string remittanceInformation = default(string), string payId = default(string), string payIdType = default(string), string endToEndId = default(string), string nppPayinInternalId = default(string))
        {
            this.DebtorName = debtorName;
            this.DebtorLegalName = debtorLegalName;
            this.DebtorBsb = debtorBsb;
            this.DebtorAccount = debtorAccount;
            this.ClearingSystemTransactionId = clearingSystemTransactionId;
            this.RemittanceInformation = remittanceInformation;
            this.PayId = payId;
            this.PayIdType = payIdType;
            this.EndToEndId = endToEndId;
            this.NppPayinInternalId = nppPayinInternalId;
        }

        /// <summary>
        /// Gets or Sets DebtorName
        /// </summary>
        [DataMember(Name = "debtor_name", EmitDefaultValue = false)]
        public string DebtorName { get; set; }

        /// <summary>
        /// Gets or Sets DebtorLegalName
        /// </summary>
        [DataMember(Name = "debtor_legal_name", EmitDefaultValue = false)]
        public string DebtorLegalName { get; set; }

        /// <summary>
        /// Gets or Sets DebtorBsb
        /// </summary>
        [DataMember(Name = "debtor_bsb", EmitDefaultValue = false)]
        public string DebtorBsb { get; set; }

        /// <summary>
        /// Gets or Sets DebtorAccount
        /// </summary>
        [DataMember(Name = "debtor_account", EmitDefaultValue = false)]
        public string DebtorAccount { get; set; }

        /// <summary>
        /// Gets or Sets ClearingSystemTransactionId
        /// </summary>
        [DataMember(Name = "clearing_system_transaction_id", EmitDefaultValue = false)]
        public string ClearingSystemTransactionId { get; set; }

        /// <summary>
        /// Gets or Sets RemittanceInformation
        /// </summary>
        [DataMember(Name = "remittance_information", EmitDefaultValue = false)]
        public string RemittanceInformation { get; set; }

        /// <summary>
        /// Gets or Sets PayId
        /// </summary>
        [DataMember(Name = "pay_id", EmitDefaultValue = false)]
        public string PayId { get; set; }

        /// <summary>
        /// Gets or Sets PayIdType
        /// </summary>
        [DataMember(Name = "pay_id_type", EmitDefaultValue = false)]
        public string PayIdType { get; set; }

        /// <summary>
        /// Gets or Sets EndToEndId
        /// </summary>
        [DataMember(Name = "end_to_end_id", EmitDefaultValue = false)]
        public string EndToEndId { get; set; }

        /// <summary>
        /// Gets or Sets NppPayinInternalId
        /// </summary>
        [DataMember(Name = "npp_payin_internal_id", EmitDefaultValue = false)]
        public string NppPayinInternalId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionPayeeDetails {\n");
            sb.Append("  DebtorName: ").Append(DebtorName).Append("\n");
            sb.Append("  DebtorLegalName: ").Append(DebtorLegalName).Append("\n");
            sb.Append("  DebtorBsb: ").Append(DebtorBsb).Append("\n");
            sb.Append("  DebtorAccount: ").Append(DebtorAccount).Append("\n");
            sb.Append("  ClearingSystemTransactionId: ").Append(ClearingSystemTransactionId).Append("\n");
            sb.Append("  RemittanceInformation: ").Append(RemittanceInformation).Append("\n");
            sb.Append("  PayId: ").Append(PayId).Append("\n");
            sb.Append("  PayIdType: ").Append(PayIdType).Append("\n");
            sb.Append("  EndToEndId: ").Append(EndToEndId).Append("\n");
            sb.Append("  NppPayinInternalId: ").Append(NppPayinInternalId).Append("\n");
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
            return this.Equals(input as TransactionPayeeDetails);
        }

        /// <summary>
        /// Returns true if TransactionPayeeDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionPayeeDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionPayeeDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DebtorName == input.DebtorName ||
                    (this.DebtorName != null &&
                    this.DebtorName.Equals(input.DebtorName))
                ) && 
                (
                    this.DebtorLegalName == input.DebtorLegalName ||
                    (this.DebtorLegalName != null &&
                    this.DebtorLegalName.Equals(input.DebtorLegalName))
                ) && 
                (
                    this.DebtorBsb == input.DebtorBsb ||
                    (this.DebtorBsb != null &&
                    this.DebtorBsb.Equals(input.DebtorBsb))
                ) && 
                (
                    this.DebtorAccount == input.DebtorAccount ||
                    (this.DebtorAccount != null &&
                    this.DebtorAccount.Equals(input.DebtorAccount))
                ) && 
                (
                    this.ClearingSystemTransactionId == input.ClearingSystemTransactionId ||
                    (this.ClearingSystemTransactionId != null &&
                    this.ClearingSystemTransactionId.Equals(input.ClearingSystemTransactionId))
                ) && 
                (
                    this.RemittanceInformation == input.RemittanceInformation ||
                    (this.RemittanceInformation != null &&
                    this.RemittanceInformation.Equals(input.RemittanceInformation))
                ) && 
                (
                    this.PayId == input.PayId ||
                    (this.PayId != null &&
                    this.PayId.Equals(input.PayId))
                ) && 
                (
                    this.PayIdType == input.PayIdType ||
                    (this.PayIdType != null &&
                    this.PayIdType.Equals(input.PayIdType))
                ) && 
                (
                    this.EndToEndId == input.EndToEndId ||
                    (this.EndToEndId != null &&
                    this.EndToEndId.Equals(input.EndToEndId))
                ) && 
                (
                    this.NppPayinInternalId == input.NppPayinInternalId ||
                    (this.NppPayinInternalId != null &&
                    this.NppPayinInternalId.Equals(input.NppPayinInternalId))
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
                if (this.DebtorName != null)
                {
                    hashCode = (hashCode * 59) + this.DebtorName.GetHashCode();
                }
                if (this.DebtorLegalName != null)
                {
                    hashCode = (hashCode * 59) + this.DebtorLegalName.GetHashCode();
                }
                if (this.DebtorBsb != null)
                {
                    hashCode = (hashCode * 59) + this.DebtorBsb.GetHashCode();
                }
                if (this.DebtorAccount != null)
                {
                    hashCode = (hashCode * 59) + this.DebtorAccount.GetHashCode();
                }
                if (this.ClearingSystemTransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.ClearingSystemTransactionId.GetHashCode();
                }
                if (this.RemittanceInformation != null)
                {
                    hashCode = (hashCode * 59) + this.RemittanceInformation.GetHashCode();
                }
                if (this.PayId != null)
                {
                    hashCode = (hashCode * 59) + this.PayId.GetHashCode();
                }
                if (this.PayIdType != null)
                {
                    hashCode = (hashCode * 59) + this.PayIdType.GetHashCode();
                }
                if (this.EndToEndId != null)
                {
                    hashCode = (hashCode * 59) + this.EndToEndId.GetHashCode();
                }
                if (this.NppPayinInternalId != null)
                {
                    hashCode = (hashCode * 59) + this.NppPayinInternalId.GetHashCode();
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
