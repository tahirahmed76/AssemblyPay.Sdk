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
    /// FeeRequestBody
    /// </summary>
    [DataContract(Name = "fee_requestBody")]
    public partial class FeeRequestBody : IEquatable<FeeRequestBody>, IValidatableObject
    {
        /// <summary>
        /// Fee type:   1. Fixed   2. Percentage   3. Percentage with Cap   4. Percentage with Min 
        /// </summary>
        /// <value>Fee type:   1. Fixed   2. Percentage   3. Percentage with Cap   4. Percentage with Min </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FeeTypeIdEnum
        {
            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            [EnumMember(Value = "1")]
            _1 = 1,

            /// <summary>
            /// Enum _2 for value: 2
            /// </summary>
            [EnumMember(Value = "2")]
            _2 = 2,

            /// <summary>
            /// Enum _3 for value: 3
            /// </summary>
            [EnumMember(Value = "3")]
            _3 = 3,

            /// <summary>
            /// Enum _4 for value: 4
            /// </summary>
            [EnumMember(Value = "4")]
            _4 = 4

        }


        /// <summary>
        /// Fee type:   1. Fixed   2. Percentage   3. Percentage with Cap   4. Percentage with Min 
        /// </summary>
        /// <value>Fee type:   1. Fixed   2. Percentage   3. Percentage with Cap   4. Percentage with Min </value>
        [DataMember(Name = "fee_type_id", IsRequired = true, EmitDefaultValue = false)]
        public FeeTypeIdEnum FeeTypeId { get; set; }
        /// <summary>
        /// Who pays the Fee. Allowed values are (buyer or seller). If this field has a value of buyer, then the buyer will have to pay the fee on top of the actual payment (example for an item of 100 and a fee of 2, then the buyer would have to pay 102) If this field has a value of seller, then the seller will end up receiving the amount - the fee (example for an item of 100 and a fee of 2, then the seller would end up receiving 98)
        /// </summary>
        /// <value>Who pays the Fee. Allowed values are (buyer or seller). If this field has a value of buyer, then the buyer will have to pay the fee on top of the actual payment (example for an item of 100 and a fee of 2, then the buyer would have to pay 102) If this field has a value of seller, then the seller will end up receiving the amount - the fee (example for an item of 100 and a fee of 2, then the seller would end up receiving 98)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ToEnum
        {
            /// <summary>
            /// Enum Buyer for value: buyer
            /// </summary>
            [EnumMember(Value = "buyer")]
            Buyer = 1,

            /// <summary>
            /// Enum Seller for value: seller
            /// </summary>
            [EnumMember(Value = "seller")]
            Seller = 2,

            /// <summary>
            /// Enum Cc for value: cc
            /// </summary>
            [EnumMember(Value = "cc")]
            Cc = 3,

            /// <summary>
            /// Enum IntWire for value: int_wire
            /// </summary>
            [EnumMember(Value = "int_wire")]
            IntWire = 4

        }


        /// <summary>
        /// Who pays the Fee. Allowed values are (buyer or seller). If this field has a value of buyer, then the buyer will have to pay the fee on top of the actual payment (example for an item of 100 and a fee of 2, then the buyer would have to pay 102) If this field has a value of seller, then the seller will end up receiving the amount - the fee (example for an item of 100 and a fee of 2, then the seller would end up receiving 98)
        /// </summary>
        /// <value>Who pays the Fee. Allowed values are (buyer or seller). If this field has a value of buyer, then the buyer will have to pay the fee on top of the actual payment (example for an item of 100 and a fee of 2, then the buyer would have to pay 102) If this field has a value of seller, then the seller will end up receiving the amount - the fee (example for an item of 100 and a fee of 2, then the seller would end up receiving 98)</value>
        [DataMember(Name = "to", EmitDefaultValue = false)]
        public ToEnum? To { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeeRequestBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FeeRequestBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeeRequestBody" /> class.
        /// </summary>
        /// <param name="name">Name (required) (default to &quot;Seller Success Fee&quot;).</param>
        /// <param name="feeTypeId">Fee type:   1. Fixed   2. Percentage   3. Percentage with Cap   4. Percentage with Min  (required) (default to FeeTypeIdEnum._2).</param>
        /// <param name="amount">Amount in cents; if the fee type is percentage, then this shows the percentage in hundredths (For example, an amount of 5 refers to 0.05% in fees.) (required) (default to 200).</param>
        /// <param name="cap">Cap the Fee.</param>
        /// <param name="min">Minimum Fee.</param>
        /// <param name="max">Maximum Fee.</param>
        /// <param name="to">Who pays the Fee. Allowed values are (buyer or seller). If this field has a value of buyer, then the buyer will have to pay the fee on top of the actual payment (example for an item of 100 and a fee of 2, then the buyer would have to pay 102) If this field has a value of seller, then the seller will end up receiving the amount - the fee (example for an item of 100 and a fee of 2, then the seller would end up receiving 98).</param>
        public FeeRequestBody(string name = "Seller Success Fee", FeeTypeIdEnum feeTypeId = FeeTypeIdEnum._2, int amount = 200, string cap = default(string), int min = default(int), int max = default(int), ToEnum? to = default(ToEnum?))
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for FeeRequestBody and cannot be null");
            }
            this.Name = name;
            this.FeeTypeId = feeTypeId;
            this.Amount = amount;
            this.Cap = cap;
            this.Min = min;
            this.Max = max;
            this.To = to;
        }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Amount in cents; if the fee type is percentage, then this shows the percentage in hundredths (For example, an amount of 5 refers to 0.05% in fees.)
        /// </summary>
        /// <value>Amount in cents; if the fee type is percentage, then this shows the percentage in hundredths (For example, an amount of 5 refers to 0.05% in fees.)</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public int Amount { get; set; }

        /// <summary>
        /// Cap the Fee
        /// </summary>
        /// <value>Cap the Fee</value>
        [DataMember(Name = "cap", EmitDefaultValue = false)]
        public string Cap { get; set; }

        /// <summary>
        /// Minimum Fee
        /// </summary>
        /// <value>Minimum Fee</value>
        [DataMember(Name = "min", EmitDefaultValue = false)]
        public int Min { get; set; }

        /// <summary>
        /// Maximum Fee
        /// </summary>
        /// <value>Maximum Fee</value>
        [DataMember(Name = "max", EmitDefaultValue = false)]
        public int Max { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FeeRequestBody {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FeeTypeId: ").Append(FeeTypeId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Cap: ").Append(Cap).Append("\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
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
            return this.Equals(input as FeeRequestBody);
        }

        /// <summary>
        /// Returns true if FeeRequestBody instances are equal
        /// </summary>
        /// <param name="input">Instance of FeeRequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeeRequestBody input)
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
                    this.FeeTypeId == input.FeeTypeId ||
                    this.FeeTypeId.Equals(input.FeeTypeId)
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.Cap == input.Cap ||
                    (this.Cap != null &&
                    this.Cap.Equals(input.Cap))
                ) && 
                (
                    this.Min == input.Min ||
                    this.Min.Equals(input.Min)
                ) && 
                (
                    this.Max == input.Max ||
                    this.Max.Equals(input.Max)
                ) && 
                (
                    this.To == input.To ||
                    this.To.Equals(input.To)
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
                hashCode = (hashCode * 59) + this.FeeTypeId.GetHashCode();
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.Cap != null)
                {
                    hashCode = (hashCode * 59) + this.Cap.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Min.GetHashCode();
                hashCode = (hashCode * 59) + this.Max.GetHashCode();
                hashCode = (hashCode * 59) + this.To.GetHashCode();
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
