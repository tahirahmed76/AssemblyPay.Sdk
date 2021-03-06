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
using System.ComponentModel.DataAnnotations;

namespace AssemblyPay.Sdk.Model
{
    /// <summary>
    /// CompanyRequestBody
    /// </summary>
    [DataContract(Name = "company_requestBody")]
    public partial class CompanyRequestBody : IEquatable<CompanyRequestBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyRequestBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CompanyRequestBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyRequestBody" /> class.
        /// </summary>
        /// <param name="name">Company name (required) (default to &quot;ABC&quot;).</param>
        /// <param name="legalName">Company legal name (required) (default to &quot;ABC Pty Ltd&quot;).</param>
        /// <param name="taxNumber">ABN / Tax number (required) (default to &quot;123456789&quot;).</param>
        /// <param name="chargeTax">Charge GST or not? allowed values are true or false.</param>
        /// <param name="addressLine1">Address line 1.</param>
        /// <param name="addressLine2">Address line 2.</param>
        /// <param name="city">City.</param>
        /// <param name="state">State.</param>
        /// <param name="zip">Zip.</param>
        /// <param name="country">3 digit country code (eg. AUS) (required) (default to &quot;AUS&quot;).</param>
        /// <param name="phone">Company phone number (default to &quot;&quot;).</param>
        /// <param name="userId">User ID to associate with the company (required) (default to &quot;buyer-70729325&quot;).</param>
        public CompanyRequestBody(string name = "ABC", string legalName = "ABC Pty Ltd", string taxNumber = "123456789", bool? chargeTax = default(bool?), string addressLine1 = default(string), string addressLine2 = default(string), string city = default(string), string state = default(string), string zip = default(string), string country = "AUS", string phone = "", string userId = "buyer-70729325")
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for CompanyRequestBody and cannot be null");
            }
            this.Name = name;
            // to ensure "legalName" is required (not null)
            if (legalName == null) {
                throw new ArgumentNullException("legalName is a required property for CompanyRequestBody and cannot be null");
            }
            this.LegalName = legalName;
            // to ensure "taxNumber" is required (not null)
            if (taxNumber == null) {
                throw new ArgumentNullException("taxNumber is a required property for CompanyRequestBody and cannot be null");
            }
            this.TaxNumber = taxNumber;
            // to ensure "country" is required (not null)
            if (country == null) {
                throw new ArgumentNullException("country is a required property for CompanyRequestBody and cannot be null");
            }
            this.Country = country;
            // to ensure "userId" is required (not null)
            if (userId == null) {
                throw new ArgumentNullException("userId is a required property for CompanyRequestBody and cannot be null");
            }
            this.UserId = userId;
            this.ChargeTax = chargeTax;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            // use default value if no "phone" provided
            this.Phone = phone ?? "";
        }

        /// <summary>
        /// Company name
        /// </summary>
        /// <value>Company name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Company legal name
        /// </summary>
        /// <value>Company legal name</value>
        [DataMember(Name = "legal_name", IsRequired = true, EmitDefaultValue = false)]
        public string LegalName { get; set; }

        /// <summary>
        /// ABN / Tax number
        /// </summary>
        /// <value>ABN / Tax number</value>
        [DataMember(Name = "tax_number", IsRequired = true, EmitDefaultValue = false)]
        public string TaxNumber { get; set; }

        /// <summary>
        /// Charge GST or not? allowed values are true or false
        /// </summary>
        /// <value>Charge GST or not? allowed values are true or false</value>
        [DataMember(Name = "charge_tax", EmitDefaultValue = true)]
        public bool? ChargeTax { get; set; }

        /// <summary>
        /// Address line 1
        /// </summary>
        /// <value>Address line 1</value>
        [DataMember(Name = "address_line1", EmitDefaultValue = false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Address line 2
        /// </summary>
        /// <value>Address line 2</value>
        [DataMember(Name = "address_line2", EmitDefaultValue = false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// City
        /// </summary>
        /// <value>City</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Zip
        /// </summary>
        /// <value>Zip</value>
        [DataMember(Name = "zip", EmitDefaultValue = false)]
        public string Zip { get; set; }

        /// <summary>
        /// 3 digit country code (eg. AUS)
        /// </summary>
        /// <value>3 digit country code (eg. AUS)</value>
        [DataMember(Name = "country", IsRequired = true, EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Company phone number
        /// </summary>
        /// <value>Company phone number</value>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// User ID to associate with the company
        /// </summary>
        /// <value>User ID to associate with the company</value>
        [DataMember(Name = "user_id", IsRequired = true, EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CompanyRequestBody {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LegalName: ").Append(LegalName).Append("\n");
            sb.Append("  TaxNumber: ").Append(TaxNumber).Append("\n");
            sb.Append("  ChargeTax: ").Append(ChargeTax).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as CompanyRequestBody);
        }

        /// <summary>
        /// Returns true if CompanyRequestBody instances are equal
        /// </summary>
        /// <param name="input">Instance of CompanyRequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyRequestBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.LegalName == input.LegalName ||
                    (this.LegalName != null &&
                    this.LegalName.Equals(input.LegalName))
                ) && 
                (
                    this.TaxNumber == input.TaxNumber ||
                    (this.TaxNumber != null &&
                    this.TaxNumber.Equals(input.TaxNumber))
                ) && 
                (
                    this.ChargeTax == input.ChargeTax ||
                    (this.ChargeTax != null &&
                    this.ChargeTax.Equals(input.ChargeTax))
                ) && 
                (
                    this.AddressLine1 == input.AddressLine1 ||
                    (this.AddressLine1 != null &&
                    this.AddressLine1.Equals(input.AddressLine1))
                ) && 
                (
                    this.AddressLine2 == input.AddressLine2 ||
                    (this.AddressLine2 != null &&
                    this.AddressLine2.Equals(input.AddressLine2))
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
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.LegalName != null)
                {
                    hashCode = (hashCode * 59) + this.LegalName.GetHashCode();
                }
                if (this.TaxNumber != null)
                {
                    hashCode = (hashCode * 59) + this.TaxNumber.GetHashCode();
                }
                if (this.ChargeTax != null)
                {
                    hashCode = (hashCode * 59) + this.ChargeTax.GetHashCode();
                }
                if (this.AddressLine1 != null)
                {
                    hashCode = (hashCode * 59) + this.AddressLine1.GetHashCode();
                }
                if (this.AddressLine2 != null)
                {
                    hashCode = (hashCode * 59) + this.AddressLine2.GetHashCode();
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
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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
