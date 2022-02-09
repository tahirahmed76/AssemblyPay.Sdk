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
    /// CallbackRequestBody
    /// </summary>
    [DataContract(Name = "callback_requestBody")]
    public partial class CallbackRequestBody : IEquatable<CallbackRequestBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackRequestBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CallbackRequestBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackRequestBody" /> class.
        /// </summary>
        /// <param name="url">URL to which the callbacks will notify (required) (default to &quot;https://httpbin.org&quot;).</param>
        /// <param name="objectType">Object or entity to which the callbacks refer. Please refer to [Callbacks](https://developer.assemblypayments.com/docs/callbacks) for a list of object types. (required) (default to &quot;users&quot;).</param>
        /// <param name="enabled">Toggle whether callback is active or inactive. (required) (default to &quot;true&quot;).</param>
        public CallbackRequestBody(string url = "https://httpbin.org", string objectType = "users", string enabled = "true")
        {
            // to ensure "url" is required (not null)
            if (url == null) {
                throw new ArgumentNullException("url is a required property for CallbackRequestBody and cannot be null");
            }
            this.Url = url;
            // to ensure "objectType" is required (not null)
            if (objectType == null) {
                throw new ArgumentNullException("objectType is a required property for CallbackRequestBody and cannot be null");
            }
            this.ObjectType = objectType;
            // to ensure "enabled" is required (not null)
            if (enabled == null) {
                throw new ArgumentNullException("enabled is a required property for CallbackRequestBody and cannot be null");
            }
            this.Enabled = enabled;
        }

        /// <summary>
        /// URL to which the callbacks will notify
        /// </summary>
        /// <value>URL to which the callbacks will notify</value>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Object or entity to which the callbacks refer. Please refer to [Callbacks](https://developer.assemblypayments.com/docs/callbacks) for a list of object types.
        /// </summary>
        /// <value>Object or entity to which the callbacks refer. Please refer to [Callbacks](https://developer.assemblypayments.com/docs/callbacks) for a list of object types.</value>
        [DataMember(Name = "object_type", IsRequired = true, EmitDefaultValue = false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// Toggle whether callback is active or inactive.
        /// </summary>
        /// <value>Toggle whether callback is active or inactive.</value>
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = false)]
        public string Enabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CallbackRequestBody {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(input as CallbackRequestBody);
        }

        /// <summary>
        /// Returns true if CallbackRequestBody instances are equal
        /// </summary>
        /// <param name="input">Instance of CallbackRequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallbackRequestBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.ObjectType == input.ObjectType ||
                    (this.ObjectType != null &&
                    this.ObjectType.Equals(input.ObjectType))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
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
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.ObjectType != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectType.GetHashCode();
                }
                if (this.Enabled != null)
                {
                    hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
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