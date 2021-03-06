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
    /// WireDetails
    /// </summary>
    [DataContract(Name = "wire_details")]
    public partial class WireDetails : IEquatable<WireDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WireDetails" /> class.
        /// </summary>
        /// <param name="beneficiary">beneficiary.</param>
        /// <param name="addressLine1">addressLine1.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="zip">zip.</param>
        /// <param name="routingNumber">routingNumber.</param>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="bankName">bankName.</param>
        /// <param name="swift">swift.</param>
        /// <param name="reference">reference.</param>
        /// <param name="amount">amount.</param>
        /// <param name="currency">currency.</param>
        /// <param name="country">country.</param>
        public WireDetails(string beneficiary = default(string), string addressLine1 = default(string), string city = default(string), string state = default(string), string zip = default(string), string routingNumber = default(string), string accountNumber = default(string), string bankName = default(string), string swift = default(string), string reference = default(string), string amount = default(string), string currency = default(string), string country = default(string))
        {
            this.Beneficiary = beneficiary;
            this.AddressLine1 = addressLine1;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.RoutingNumber = routingNumber;
            this.AccountNumber = accountNumber;
            this.BankName = bankName;
            this.Swift = swift;
            this.Reference = reference;
            this.Amount = amount;
            this.Currency = currency;
            this.Country = country;
        }

        /// <summary>
        /// Gets or Sets Beneficiary
        /// </summary>
        [DataMember(Name = "beneficiary", EmitDefaultValue = false)]
        public string Beneficiary { get; set; }

        /// <summary>
        /// Gets or Sets AddressLine1
        /// </summary>
        [DataMember(Name = "address_line1", EmitDefaultValue = false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Zip
        /// </summary>
        [DataMember(Name = "zip", EmitDefaultValue = false)]
        public string Zip { get; set; }

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
        /// Gets or Sets BankName
        /// </summary>
        [DataMember(Name = "bank_name", EmitDefaultValue = false)]
        public string BankName { get; set; }

        /// <summary>
        /// Gets or Sets Swift
        /// </summary>
        [DataMember(Name = "swift", EmitDefaultValue = false)]
        public string Swift { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WireDetails {\n");
            sb.Append("  Beneficiary: ").Append(Beneficiary).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  RoutingNumber: ").Append(RoutingNumber).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  Swift: ").Append(Swift).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(input as WireDetails);
        }

        /// <summary>
        /// Returns true if WireDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of WireDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WireDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Beneficiary == input.Beneficiary ||
                    (this.Beneficiary != null &&
                    this.Beneficiary.Equals(input.Beneficiary))
                ) && 
                (
                    this.AddressLine1 == input.AddressLine1 ||
                    (this.AddressLine1 != null &&
                    this.AddressLine1.Equals(input.AddressLine1))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Zip == input.Zip ||
                    (this.Zip != null &&
                    this.Zip.Equals(input.Zip))
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
                    this.BankName == input.BankName ||
                    (this.BankName != null &&
                    this.BankName.Equals(input.BankName))
                ) && 
                (
                    this.Swift == input.Swift ||
                    (this.Swift != null &&
                    this.Swift.Equals(input.Swift))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
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
                if (this.Beneficiary != null)
                {
                    hashCode = (hashCode * 59) + this.Beneficiary.GetHashCode();
                }
                if (this.AddressLine1 != null)
                {
                    hashCode = (hashCode * 59) + this.AddressLine1.GetHashCode();
                }
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.Zip != null)
                {
                    hashCode = (hashCode * 59) + this.Zip.GetHashCode();
                }
                if (this.RoutingNumber != null)
                {
                    hashCode = (hashCode * 59) + this.RoutingNumber.GetHashCode();
                }
                if (this.AccountNumber != null)
                {
                    hashCode = (hashCode * 59) + this.AccountNumber.GetHashCode();
                }
                if (this.BankName != null)
                {
                    hashCode = (hashCode * 59) + this.BankName.GetHashCode();
                }
                if (this.Swift != null)
                {
                    hashCode = (hashCode * 59) + this.Swift.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
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
