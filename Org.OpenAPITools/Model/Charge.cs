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
    /// Charge
    /// </summary>
    [DataContract(Name = "charge")]
    public partial class Charge : IEquatable<Charge>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Charge" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="customDescriptor">customDescriptor.</param>
        /// <param name="customData">customData.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="state">state.</param>
        /// <param name="buyerFees">buyerFees.</param>
        /// <param name="sellerFees">sellerFees.</param>
        /// <param name="creditCardFee">creditCardFee.</param>
        /// <param name="status">status.</param>
        /// <param name="amount">amount.</param>
        /// <param name="dynamicDescriptor">dynamicDescriptor.</param>
        /// <param name="accountId">accountId.</param>
        /// <param name="accountType">accountType.</param>
        /// <param name="promisepayFee">promisepayFee.</param>
        /// <param name="currency">currency.</param>
        /// <param name="paymentMethod">paymentMethod.</param>
        /// <param name="buyerName">buyerName.</param>
        /// <param name="buyerEmail">buyerEmail.</param>
        /// <param name="buyerZip">buyerZip.</param>
        /// <param name="buyerCountry">buyerCountry.</param>
        /// <param name="sellerName">sellerName.</param>
        /// <param name="sellerEmail">sellerEmail.</param>
        /// <param name="sellerZip">sellerZip.</param>
        /// <param name="sellerCountry">sellerCountry.</param>
        /// <param name="related">related.</param>
        /// <param name="links">links.</param>
        public Charge(string id = default(string), string name = default(string), string customDescriptor = default(string), string customData = default(string), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), string state = default(string), int buyerFees = default(int), int sellerFees = default(int), int creditCardFee = default(int), int status = default(int), int amount = default(int), string dynamicDescriptor = default(string), Guid accountId = default(Guid), string accountType = default(string), int promisepayFee = default(int), string currency = default(string), string paymentMethod = default(string), string buyerName = default(string), string buyerEmail = default(string), string buyerZip = default(string), string buyerCountry = default(string), string sellerName = default(string), string sellerEmail = default(string), string sellerZip = default(string), string sellerCountry = default(string), ItemRelated related = default(ItemRelated), ChargeLinks links = default(ChargeLinks))
        {
            this.Id = id;
            this.Name = name;
            this.CustomDescriptor = customDescriptor;
            this.CustomData = customData;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.State = state;
            this.BuyerFees = buyerFees;
            this.SellerFees = sellerFees;
            this.CreditCardFee = creditCardFee;
            this.Status = status;
            this.Amount = amount;
            this.DynamicDescriptor = dynamicDescriptor;
            this.AccountId = accountId;
            this.AccountType = accountType;
            this.PromisepayFee = promisepayFee;
            this.Currency = currency;
            this.PaymentMethod = paymentMethod;
            this.BuyerName = buyerName;
            this.BuyerEmail = buyerEmail;
            this.BuyerZip = buyerZip;
            this.BuyerCountry = buyerCountry;
            this.SellerName = sellerName;
            this.SellerEmail = sellerEmail;
            this.SellerZip = sellerZip;
            this.SellerCountry = sellerCountry;
            this.Related = related;
            this.Links = links;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets CustomDescriptor
        /// </summary>
        [DataMember(Name = "custom_descriptor", EmitDefaultValue = false)]
        public string CustomDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name = "custom_data", EmitDefaultValue = false)]
        public string CustomData { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets BuyerFees
        /// </summary>
        [DataMember(Name = "buyer_fees", EmitDefaultValue = false)]
        public int BuyerFees { get; set; }

        /// <summary>
        /// Gets or Sets SellerFees
        /// </summary>
        [DataMember(Name = "seller_fees", EmitDefaultValue = false)]
        public int SellerFees { get; set; }

        /// <summary>
        /// Gets or Sets CreditCardFee
        /// </summary>
        [DataMember(Name = "credit_card_fee", EmitDefaultValue = false)]
        public int CreditCardFee { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public int Status { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public int Amount { get; set; }

        /// <summary>
        /// Gets or Sets DynamicDescriptor
        /// </summary>
        [DataMember(Name = "dynamic_descriptor", EmitDefaultValue = false)]
        public string DynamicDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public Guid AccountId { get; set; }

        /// <summary>
        /// Gets or Sets AccountType
        /// </summary>
        [DataMember(Name = "account_type", EmitDefaultValue = false)]
        public string AccountType { get; set; }

        /// <summary>
        /// Gets or Sets PromisepayFee
        /// </summary>
        [DataMember(Name = "promisepay_fee", EmitDefaultValue = false)]
        public int PromisepayFee { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name = "payment_method", EmitDefaultValue = false)]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets BuyerName
        /// </summary>
        [DataMember(Name = "buyer_name", EmitDefaultValue = false)]
        public string BuyerName { get; set; }

        /// <summary>
        /// Gets or Sets BuyerEmail
        /// </summary>
        [DataMember(Name = "buyer_email", EmitDefaultValue = false)]
        public string BuyerEmail { get; set; }

        /// <summary>
        /// Gets or Sets BuyerZip
        /// </summary>
        [DataMember(Name = "buyer_zip", EmitDefaultValue = false)]
        public string BuyerZip { get; set; }

        /// <summary>
        /// Gets or Sets BuyerCountry
        /// </summary>
        [DataMember(Name = "buyer_country", EmitDefaultValue = false)]
        public string BuyerCountry { get; set; }

        /// <summary>
        /// Gets or Sets SellerName
        /// </summary>
        [DataMember(Name = "seller_name", EmitDefaultValue = false)]
        public string SellerName { get; set; }

        /// <summary>
        /// Gets or Sets SellerEmail
        /// </summary>
        [DataMember(Name = "seller_email", EmitDefaultValue = false)]
        public string SellerEmail { get; set; }

        /// <summary>
        /// Gets or Sets SellerZip
        /// </summary>
        [DataMember(Name = "seller_zip", EmitDefaultValue = false)]
        public string SellerZip { get; set; }

        /// <summary>
        /// Gets or Sets SellerCountry
        /// </summary>
        [DataMember(Name = "seller_country", EmitDefaultValue = false)]
        public string SellerCountry { get; set; }

        /// <summary>
        /// Gets or Sets Related
        /// </summary>
        [DataMember(Name = "related", EmitDefaultValue = false)]
        public ItemRelated Related { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public ChargeLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Charge {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CustomDescriptor: ").Append(CustomDescriptor).Append("\n");
            sb.Append("  CustomData: ").Append(CustomData).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  BuyerFees: ").Append(BuyerFees).Append("\n");
            sb.Append("  SellerFees: ").Append(SellerFees).Append("\n");
            sb.Append("  CreditCardFee: ").Append(CreditCardFee).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  DynamicDescriptor: ").Append(DynamicDescriptor).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  PromisepayFee: ").Append(PromisepayFee).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  BuyerName: ").Append(BuyerName).Append("\n");
            sb.Append("  BuyerEmail: ").Append(BuyerEmail).Append("\n");
            sb.Append("  BuyerZip: ").Append(BuyerZip).Append("\n");
            sb.Append("  BuyerCountry: ").Append(BuyerCountry).Append("\n");
            sb.Append("  SellerName: ").Append(SellerName).Append("\n");
            sb.Append("  SellerEmail: ").Append(SellerEmail).Append("\n");
            sb.Append("  SellerZip: ").Append(SellerZip).Append("\n");
            sb.Append("  SellerCountry: ").Append(SellerCountry).Append("\n");
            sb.Append("  Related: ").Append(Related).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as Charge);
        }

        /// <summary>
        /// Returns true if Charge instances are equal
        /// </summary>
        /// <param name="input">Instance of Charge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Charge input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CustomDescriptor == input.CustomDescriptor ||
                    (this.CustomDescriptor != null &&
                    this.CustomDescriptor.Equals(input.CustomDescriptor))
                ) && 
                (
                    this.CustomData == input.CustomData ||
                    (this.CustomData != null &&
                    this.CustomData.Equals(input.CustomData))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.BuyerFees == input.BuyerFees ||
                    this.BuyerFees.Equals(input.BuyerFees)
                ) && 
                (
                    this.SellerFees == input.SellerFees ||
                    this.SellerFees.Equals(input.SellerFees)
                ) && 
                (
                    this.CreditCardFee == input.CreditCardFee ||
                    this.CreditCardFee.Equals(input.CreditCardFee)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.DynamicDescriptor == input.DynamicDescriptor ||
                    (this.DynamicDescriptor != null &&
                    this.DynamicDescriptor.Equals(input.DynamicDescriptor))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.AccountType == input.AccountType ||
                    (this.AccountType != null &&
                    this.AccountType.Equals(input.AccountType))
                ) && 
                (
                    this.PromisepayFee == input.PromisepayFee ||
                    this.PromisepayFee.Equals(input.PromisepayFee)
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && 
                (
                    this.BuyerName == input.BuyerName ||
                    (this.BuyerName != null &&
                    this.BuyerName.Equals(input.BuyerName))
                ) && 
                (
                    this.BuyerEmail == input.BuyerEmail ||
                    (this.BuyerEmail != null &&
                    this.BuyerEmail.Equals(input.BuyerEmail))
                ) && 
                (
                    this.BuyerZip == input.BuyerZip ||
                    (this.BuyerZip != null &&
                    this.BuyerZip.Equals(input.BuyerZip))
                ) && 
                (
                    this.BuyerCountry == input.BuyerCountry ||
                    (this.BuyerCountry != null &&
                    this.BuyerCountry.Equals(input.BuyerCountry))
                ) && 
                (
                    this.SellerName == input.SellerName ||
                    (this.SellerName != null &&
                    this.SellerName.Equals(input.SellerName))
                ) && 
                (
                    this.SellerEmail == input.SellerEmail ||
                    (this.SellerEmail != null &&
                    this.SellerEmail.Equals(input.SellerEmail))
                ) && 
                (
                    this.SellerZip == input.SellerZip ||
                    (this.SellerZip != null &&
                    this.SellerZip.Equals(input.SellerZip))
                ) && 
                (
                    this.SellerCountry == input.SellerCountry ||
                    (this.SellerCountry != null &&
                    this.SellerCountry.Equals(input.SellerCountry))
                ) && 
                (
                    this.Related == input.Related ||
                    (this.Related != null &&
                    this.Related.Equals(input.Related))
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.CustomDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.CustomDescriptor.GetHashCode();
                }
                if (this.CustomData != null)
                {
                    hashCode = (hashCode * 59) + this.CustomData.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BuyerFees.GetHashCode();
                hashCode = (hashCode * 59) + this.SellerFees.GetHashCode();
                hashCode = (hashCode * 59) + this.CreditCardFee.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.DynamicDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.DynamicDescriptor.GetHashCode();
                }
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.AccountType != null)
                {
                    hashCode = (hashCode * 59) + this.AccountType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PromisepayFee.GetHashCode();
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.PaymentMethod != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentMethod.GetHashCode();
                }
                if (this.BuyerName != null)
                {
                    hashCode = (hashCode * 59) + this.BuyerName.GetHashCode();
                }
                if (this.BuyerEmail != null)
                {
                    hashCode = (hashCode * 59) + this.BuyerEmail.GetHashCode();
                }
                if (this.BuyerZip != null)
                {
                    hashCode = (hashCode * 59) + this.BuyerZip.GetHashCode();
                }
                if (this.BuyerCountry != null)
                {
                    hashCode = (hashCode * 59) + this.BuyerCountry.GetHashCode();
                }
                if (this.SellerName != null)
                {
                    hashCode = (hashCode * 59) + this.SellerName.GetHashCode();
                }
                if (this.SellerEmail != null)
                {
                    hashCode = (hashCode * 59) + this.SellerEmail.GetHashCode();
                }
                if (this.SellerZip != null)
                {
                    hashCode = (hashCode * 59) + this.SellerZip.GetHashCode();
                }
                if (this.SellerCountry != null)
                {
                    hashCode = (hashCode * 59) + this.SellerCountry.GetHashCode();
                }
                if (this.Related != null)
                {
                    hashCode = (hashCode * 59) + this.Related.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
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
