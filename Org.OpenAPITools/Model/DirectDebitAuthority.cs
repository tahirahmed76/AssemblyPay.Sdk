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
    /// DirectDebitAuthority
    /// </summary>
    [DataContract(Name = "direct_debit_authority")]
    public partial class DirectDebitAuthority : IEquatable<DirectDebitAuthority>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirectDebitAuthority" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="amount">amount.</param>
        /// <param name="bankBsb">bankBsb.</param>
        /// <param name="debitUserId">debitUserId.</param>
        /// <param name="state">state.</param>
        /// <param name="related">related.</param>
        /// <param name="links">links.</param>
        public DirectDebitAuthority(string id = default(string), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), string amount = default(string), string bankBsb = default(string), string debitUserId = default(string), string state = default(string), DirectDebitAuthorityRelated related = default(DirectDebitAuthorityRelated), DirectDebitAuthorityLinks links = default(DirectDebitAuthorityLinks))
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Amount = amount;
            this.BankBsb = bankBsb;
            this.DebitUserId = debitUserId;
            this.State = state;
            this.Related = related;
            this.Links = links;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

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
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// Gets or Sets BankBsb
        /// </summary>
        [DataMember(Name = "bank_bsb", EmitDefaultValue = false)]
        public string BankBsb { get; set; }

        /// <summary>
        /// Gets or Sets DebitUserId
        /// </summary>
        [DataMember(Name = "debit_user_id", EmitDefaultValue = false)]
        public string DebitUserId { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Related
        /// </summary>
        [DataMember(Name = "related", EmitDefaultValue = false)]
        public DirectDebitAuthorityRelated Related { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public DirectDebitAuthorityLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DirectDebitAuthority {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BankBsb: ").Append(BankBsb).Append("\n");
            sb.Append("  DebitUserId: ").Append(DebitUserId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as DirectDebitAuthority);
        }

        /// <summary>
        /// Returns true if DirectDebitAuthority instances are equal
        /// </summary>
        /// <param name="input">Instance of DirectDebitAuthority to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DirectDebitAuthority input)
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
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.BankBsb == input.BankBsb ||
                    (this.BankBsb != null &&
                    this.BankBsb.Equals(input.BankBsb))
                ) && 
                (
                    this.DebitUserId == input.DebitUserId ||
                    (this.DebitUserId != null &&
                    this.DebitUserId.Equals(input.DebitUserId))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.BankBsb != null)
                {
                    hashCode = (hashCode * 59) + this.BankBsb.GetHashCode();
                }
                if (this.DebitUserId != null)
                {
                    hashCode = (hashCode * 59) + this.DebitUserId.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
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