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
    /// User
    /// </summary>
    [DataContract(Name = "user")]
    public partial class User : IEquatable<User>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="fullName">fullName.</param>
        /// <param name="email">email.</param>
        /// <param name="mobile">mobile.</param>
        /// <param name="phone">phone.</param>
        /// <param name="logoUrl">logoUrl.</param>
        /// <param name="color1">color1.</param>
        /// <param name="color2">color2.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="id">id.</param>
        /// <param name="customDescriptor">customDescriptor.</param>
        /// <param name="location">location.</param>
        /// <param name="verificationStatus">verificationStatus.</param>
        /// <param name="heldState">heldState.</param>
        /// <param name="roles">roles.</param>
        /// <param name="dob">dob.</param>
        /// <param name="governmentNumber">governmentNumber.</param>
        /// <param name="driversLicense">driversLicense.</param>
        /// <param name="flags">flags.</param>
        /// <param name="related">related.</param>
        /// <param name="links">links.</param>
        public User(DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), string fullName = default(string), string email = default(string), string mobile = default(string), string phone = default(string), string logoUrl = default(string), string color1 = default(string), string color2 = default(string), string firstName = default(string), string lastName = default(string), string id = default(string), string customDescriptor = default(string), string location = default(string), string verificationStatus = default(string), bool heldState = default(bool), List<string> roles = default(List<string>), string dob = default(string), string governmentNumber = default(string), string driversLicense = default(string), Object flags = default(Object), UserRelated related = default(UserRelated), UserLinks links = default(UserLinks))
        {
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.FullName = fullName;
            this.Email = email;
            this.Mobile = mobile;
            this.Phone = phone;
            this.LogoUrl = logoUrl;
            this.Color1 = color1;
            this.Color2 = color2;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
            this.CustomDescriptor = customDescriptor;
            this.Location = location;
            this.VerificationStatus = verificationStatus;
            this.HeldState = heldState;
            this.Roles = roles;
            this.Dob = dob;
            this.GovernmentNumber = governmentNumber;
            this.DriversLicense = driversLicense;
            this.Flags = flags;
            this.Related = related;
            this.Links = links;
        }

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
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name = "full_name", EmitDefaultValue = false)]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Mobile
        /// </summary>
        [DataMember(Name = "mobile", EmitDefaultValue = false)]
        public string Mobile { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets LogoUrl
        /// </summary>
        [DataMember(Name = "logo_url", EmitDefaultValue = false)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// Gets or Sets Color1
        /// </summary>
        [DataMember(Name = "color_1", EmitDefaultValue = false)]
        public string Color1 { get; set; }

        /// <summary>
        /// Gets or Sets Color2
        /// </summary>
        [DataMember(Name = "color_2", EmitDefaultValue = false)]
        public string Color2 { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "first_name", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name = "last_name", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets CustomDescriptor
        /// </summary>
        [DataMember(Name = "custom_descriptor", EmitDefaultValue = false)]
        public string CustomDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets VerificationStatus
        /// </summary>
        [DataMember(Name = "verification_status", EmitDefaultValue = false)]
        public string VerificationStatus { get; set; }

        /// <summary>
        /// Gets or Sets HeldState
        /// </summary>
        [DataMember(Name = "held_state", EmitDefaultValue = true)]
        public bool HeldState { get; set; }

        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name = "roles", EmitDefaultValue = false)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Gets or Sets Dob
        /// </summary>
        [DataMember(Name = "dob", EmitDefaultValue = false)]
        public string Dob { get; set; }

        /// <summary>
        /// Gets or Sets GovernmentNumber
        /// </summary>
        [DataMember(Name = "government_number", EmitDefaultValue = false)]
        public string GovernmentNumber { get; set; }

        /// <summary>
        /// Gets or Sets DriversLicense
        /// </summary>
        [DataMember(Name = "drivers_license", EmitDefaultValue = false)]
        public string DriversLicense { get; set; }

        /// <summary>
        /// Gets or Sets Flags
        /// </summary>
        [DataMember(Name = "flags", EmitDefaultValue = false)]
        public Object Flags { get; set; }

        /// <summary>
        /// Gets or Sets Related
        /// </summary>
        [DataMember(Name = "related", EmitDefaultValue = false)]
        public UserRelated Related { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public UserLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Mobile: ").Append(Mobile).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  LogoUrl: ").Append(LogoUrl).Append("\n");
            sb.Append("  Color1: ").Append(Color1).Append("\n");
            sb.Append("  Color2: ").Append(Color2).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CustomDescriptor: ").Append(CustomDescriptor).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  VerificationStatus: ").Append(VerificationStatus).Append("\n");
            sb.Append("  HeldState: ").Append(HeldState).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  Dob: ").Append(Dob).Append("\n");
            sb.Append("  GovernmentNumber: ").Append(GovernmentNumber).Append("\n");
            sb.Append("  DriversLicense: ").Append(DriversLicense).Append("\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
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
            return this.Equals(input as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="input">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Mobile == input.Mobile ||
                    (this.Mobile != null &&
                    this.Mobile.Equals(input.Mobile))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.LogoUrl == input.LogoUrl ||
                    (this.LogoUrl != null &&
                    this.LogoUrl.Equals(input.LogoUrl))
                ) && 
                (
                    this.Color1 == input.Color1 ||
                    (this.Color1 != null &&
                    this.Color1.Equals(input.Color1))
                ) && 
                (
                    this.Color2 == input.Color2 ||
                    (this.Color2 != null &&
                    this.Color2.Equals(input.Color2))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CustomDescriptor == input.CustomDescriptor ||
                    (this.CustomDescriptor != null &&
                    this.CustomDescriptor.Equals(input.CustomDescriptor))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.VerificationStatus == input.VerificationStatus ||
                    (this.VerificationStatus != null &&
                    this.VerificationStatus.Equals(input.VerificationStatus))
                ) && 
                (
                    this.HeldState == input.HeldState ||
                    this.HeldState.Equals(input.HeldState)
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.Dob == input.Dob ||
                    (this.Dob != null &&
                    this.Dob.Equals(input.Dob))
                ) && 
                (
                    this.GovernmentNumber == input.GovernmentNumber ||
                    (this.GovernmentNumber != null &&
                    this.GovernmentNumber.Equals(input.GovernmentNumber))
                ) && 
                (
                    this.DriversLicense == input.DriversLicense ||
                    (this.DriversLicense != null &&
                    this.DriversLicense.Equals(input.DriversLicense))
                ) && 
                (
                    this.Flags == input.Flags ||
                    (this.Flags != null &&
                    this.Flags.Equals(input.Flags))
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
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.FullName != null)
                {
                    hashCode = (hashCode * 59) + this.FullName.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Mobile != null)
                {
                    hashCode = (hashCode * 59) + this.Mobile.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                }
                if (this.LogoUrl != null)
                {
                    hashCode = (hashCode * 59) + this.LogoUrl.GetHashCode();
                }
                if (this.Color1 != null)
                {
                    hashCode = (hashCode * 59) + this.Color1.GetHashCode();
                }
                if (this.Color2 != null)
                {
                    hashCode = (hashCode * 59) + this.Color2.GetHashCode();
                }
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.CustomDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.CustomDescriptor.GetHashCode();
                }
                if (this.Location != null)
                {
                    hashCode = (hashCode * 59) + this.Location.GetHashCode();
                }
                if (this.VerificationStatus != null)
                {
                    hashCode = (hashCode * 59) + this.VerificationStatus.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HeldState.GetHashCode();
                if (this.Roles != null)
                {
                    hashCode = (hashCode * 59) + this.Roles.GetHashCode();
                }
                if (this.Dob != null)
                {
                    hashCode = (hashCode * 59) + this.Dob.GetHashCode();
                }
                if (this.GovernmentNumber != null)
                {
                    hashCode = (hashCode * 59) + this.GovernmentNumber.GetHashCode();
                }
                if (this.DriversLicense != null)
                {
                    hashCode = (hashCode * 59) + this.DriversLicense.GetHashCode();
                }
                if (this.Flags != null)
                {
                    hashCode = (hashCode * 59) + this.Flags.GetHashCode();
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