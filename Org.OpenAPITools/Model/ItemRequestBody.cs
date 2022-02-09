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
    /// ItemRequestBody
    /// </summary>
    [DataContract(Name = "item_requestBody")]
    public partial class ItemRequestBody : IEquatable<ItemRequestBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemRequestBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ItemRequestBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemRequestBody" /> class.
        /// </summary>
        /// <param name="id">Unique ID that can be generated by the platform. Cannot contain ’.’ character. Contact Assembly support if you want item IDs to be generated automatically. (required) (default to &quot;7190770-1-2908&quot;).</param>
        /// <param name="name">A name for the item (required) (default to &quot;Item 7190770-1-2908&quot;).</param>
        /// <param name="amount">The cost in cents (required).</param>
        /// <param name="currency">[ISO 4217 alpha-3](https://en.wikipedia.org/wiki/ISO_4217#Active_codes) currency code. This is an optional field and if not provided, the item will be created with the default currency of the marketplace..</param>
        /// <param name="paymentType">Payment type: 2. Express (required).</param>
        /// <param name="buyerId">Marketplace / Pltform buyer ID (required) (default to &quot;buyer-719013950014&quot;).</param>
        /// <param name="sellerId">Marketplace / Platform Seller ID (required) (default to &quot;seller-71718579&quot;).</param>
        /// <param name="feeIds">A comma separated list of fee IDs to apply.</param>
        /// <param name="description">A description of the item.</param>
        /// <param name="buyerUrl">Link for the buyer CTA (Call To Action).</param>
        /// <param name="sellerUrl">Link for the seller CTA (Call To Action).</param>
        /// <param name="taxInvoice">Toggle to generate tax invoice once Item is complete.</param>
        /// <param name="customDescriptor">When &#x60;custom_descriptors&#x60; are enabled, this is the information to appear on credit card and direct debit statements..</param>
        public ItemRequestBody(string id = "7190770-1-2908", string name = "Item 7190770-1-2908", int amount = default(int), string currency = default(string), int paymentType = default(int), string buyerId = "buyer-719013950014", string sellerId = "seller-71718579", string feeIds = default(string), string description = default(string), string buyerUrl = default(string), string sellerUrl = default(string), bool taxInvoice = default(bool), string customDescriptor = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for ItemRequestBody and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for ItemRequestBody and cannot be null");
            }
            this.Name = name;
            this.Amount = amount;
            this.PaymentType = paymentType;
            // to ensure "buyerId" is required (not null)
            if (buyerId == null) {
                throw new ArgumentNullException("buyerId is a required property for ItemRequestBody and cannot be null");
            }
            this.BuyerId = buyerId;
            // to ensure "sellerId" is required (not null)
            if (sellerId == null) {
                throw new ArgumentNullException("sellerId is a required property for ItemRequestBody and cannot be null");
            }
            this.SellerId = sellerId;
            this.Currency = currency;
            this.FeeIds = feeIds;
            this.Description = description;
            this.BuyerUrl = buyerUrl;
            this.SellerUrl = sellerUrl;
            this.TaxInvoice = taxInvoice;
            this.CustomDescriptor = customDescriptor;
        }

        /// <summary>
        /// Unique ID that can be generated by the platform. Cannot contain ’.’ character. Contact Assembly support if you want item IDs to be generated automatically.
        /// </summary>
        /// <value>Unique ID that can be generated by the platform. Cannot contain ’.’ character. Contact Assembly support if you want item IDs to be generated automatically.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// A name for the item
        /// </summary>
        /// <value>A name for the item</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The cost in cents
        /// </summary>
        /// <value>The cost in cents</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public int Amount { get; set; }

        /// <summary>
        /// [ISO 4217 alpha-3](https://en.wikipedia.org/wiki/ISO_4217#Active_codes) currency code. This is an optional field and if not provided, the item will be created with the default currency of the marketplace.
        /// </summary>
        /// <value>[ISO 4217 alpha-3](https://en.wikipedia.org/wiki/ISO_4217#Active_codes) currency code. This is an optional field and if not provided, the item will be created with the default currency of the marketplace.</value>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Payment type: 2. Express
        /// </summary>
        /// <value>Payment type: 2. Express</value>
        [DataMember(Name = "payment_type", IsRequired = true, EmitDefaultValue = false)]
        public int PaymentType { get; set; }

        /// <summary>
        /// Marketplace / Pltform buyer ID
        /// </summary>
        /// <value>Marketplace / Pltform buyer ID</value>
        [DataMember(Name = "buyer_id", IsRequired = true, EmitDefaultValue = false)]
        public string BuyerId { get; set; }

        /// <summary>
        /// Marketplace / Platform Seller ID
        /// </summary>
        /// <value>Marketplace / Platform Seller ID</value>
        [DataMember(Name = "seller_id", IsRequired = true, EmitDefaultValue = false)]
        public string SellerId { get; set; }

        /// <summary>
        /// A comma separated list of fee IDs to apply
        /// </summary>
        /// <value>A comma separated list of fee IDs to apply</value>
        [DataMember(Name = "fee_ids", EmitDefaultValue = false)]
        public string FeeIds { get; set; }

        /// <summary>
        /// A description of the item
        /// </summary>
        /// <value>A description of the item</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Link for the buyer CTA (Call To Action)
        /// </summary>
        /// <value>Link for the buyer CTA (Call To Action)</value>
        [DataMember(Name = "buyer_url", EmitDefaultValue = false)]
        public string BuyerUrl { get; set; }

        /// <summary>
        /// Link for the seller CTA (Call To Action)
        /// </summary>
        /// <value>Link for the seller CTA (Call To Action)</value>
        [DataMember(Name = "seller_url", EmitDefaultValue = false)]
        public string SellerUrl { get; set; }

        /// <summary>
        /// Toggle to generate tax invoice once Item is complete
        /// </summary>
        /// <value>Toggle to generate tax invoice once Item is complete</value>
        [DataMember(Name = "tax_invoice", EmitDefaultValue = true)]
        public bool TaxInvoice { get; set; }

        /// <summary>
        /// When &#x60;custom_descriptors&#x60; are enabled, this is the information to appear on credit card and direct debit statements.
        /// </summary>
        /// <value>When &#x60;custom_descriptors&#x60; are enabled, this is the information to appear on credit card and direct debit statements.</value>
        [DataMember(Name = "custom_descriptor", EmitDefaultValue = false)]
        public string CustomDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ItemRequestBody {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
            sb.Append("  BuyerId: ").Append(BuyerId).Append("\n");
            sb.Append("  SellerId: ").Append(SellerId).Append("\n");
            sb.Append("  FeeIds: ").Append(FeeIds).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  BuyerUrl: ").Append(BuyerUrl).Append("\n");
            sb.Append("  SellerUrl: ").Append(SellerUrl).Append("\n");
            sb.Append("  TaxInvoice: ").Append(TaxInvoice).Append("\n");
            sb.Append("  CustomDescriptor: ").Append(CustomDescriptor).Append("\n");
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
            return this.Equals(input as ItemRequestBody);
        }

        /// <summary>
        /// Returns true if ItemRequestBody instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemRequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemRequestBody input)
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
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.PaymentType == input.PaymentType ||
                    this.PaymentType.Equals(input.PaymentType)
                ) && 
                (
                    this.BuyerId == input.BuyerId ||
                    (this.BuyerId != null &&
                    this.BuyerId.Equals(input.BuyerId))
                ) && 
                (
                    this.SellerId == input.SellerId ||
                    (this.SellerId != null &&
                    this.SellerId.Equals(input.SellerId))
                ) && 
                (
                    this.FeeIds == input.FeeIds ||
                    (this.FeeIds != null &&
                    this.FeeIds.Equals(input.FeeIds))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.BuyerUrl == input.BuyerUrl ||
                    (this.BuyerUrl != null &&
                    this.BuyerUrl.Equals(input.BuyerUrl))
                ) && 
                (
                    this.SellerUrl == input.SellerUrl ||
                    (this.SellerUrl != null &&
                    this.SellerUrl.Equals(input.SellerUrl))
                ) && 
                (
                    this.TaxInvoice == input.TaxInvoice ||
                    this.TaxInvoice.Equals(input.TaxInvoice)
                ) && 
                (
                    this.CustomDescriptor == input.CustomDescriptor ||
                    (this.CustomDescriptor != null &&
                    this.CustomDescriptor.Equals(input.CustomDescriptor))
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
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PaymentType.GetHashCode();
                if (this.BuyerId != null)
                {
                    hashCode = (hashCode * 59) + this.BuyerId.GetHashCode();
                }
                if (this.SellerId != null)
                {
                    hashCode = (hashCode * 59) + this.SellerId.GetHashCode();
                }
                if (this.FeeIds != null)
                {
                    hashCode = (hashCode * 59) + this.FeeIds.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.BuyerUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BuyerUrl.GetHashCode();
                }
                if (this.SellerUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SellerUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TaxInvoice.GetHashCode();
                if (this.CustomDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.CustomDescriptor.GetHashCode();
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
