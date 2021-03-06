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
    /// UpdateItemRequestBody
    /// </summary>
    [DataContract(Name = "update_item_requestBody")]
    public partial class UpdateItemRequestBody : IEquatable<UpdateItemRequestBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateItemRequestBody" /> class.
        /// </summary>
        /// <param name="amount">The cost in cents.</param>
        /// <param name="name">A name for the item.</param>
        /// <param name="buyerId">Marketplace / Pltform buyer ID.</param>
        /// <param name="sellerId">Marketplace / Platform Seller ID.</param>
        /// <param name="description">A description of the item.</param>
        /// <param name="customDescriptor">When &#x60;custom_descriptors&#x60; are enabled, this is the information to appear on credit card and direct debit statements..</param>
        public UpdateItemRequestBody(int amount = default(int), string name = default(string), string buyerId = default(string), string sellerId = default(string), string description = default(string), string customDescriptor = default(string))
        {
            this.Amount = amount;
            this.Name = name;
            this.BuyerId = buyerId;
            this.SellerId = sellerId;
            this.Description = description;
            this.CustomDescriptor = customDescriptor;
        }

        /// <summary>
        /// The cost in cents
        /// </summary>
        /// <value>The cost in cents</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public int Amount { get; set; }

        /// <summary>
        /// A name for the item
        /// </summary>
        /// <value>A name for the item</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Marketplace / Pltform buyer ID
        /// </summary>
        /// <value>Marketplace / Pltform buyer ID</value>
        [DataMember(Name = "buyer_id", EmitDefaultValue = false)]
        public string BuyerId { get; set; }

        /// <summary>
        /// Marketplace / Platform Seller ID
        /// </summary>
        /// <value>Marketplace / Platform Seller ID</value>
        [DataMember(Name = "seller_id", EmitDefaultValue = false)]
        public string SellerId { get; set; }

        /// <summary>
        /// A description of the item
        /// </summary>
        /// <value>A description of the item</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

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
            sb.Append("class UpdateItemRequestBody {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  BuyerId: ").Append(BuyerId).Append("\n");
            sb.Append("  SellerId: ").Append(SellerId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as UpdateItemRequestBody);
        }

        /// <summary>
        /// Returns true if UpdateItemRequestBody instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateItemRequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateItemRequestBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.BuyerId != null)
                {
                    hashCode = (hashCode * 59) + this.BuyerId.GetHashCode();
                }
                if (this.SellerId != null)
                {
                    hashCode = (hashCode * 59) + this.SellerId.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
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
