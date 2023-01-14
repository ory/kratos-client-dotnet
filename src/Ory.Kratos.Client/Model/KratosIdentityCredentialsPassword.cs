/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v0.11.1
 * Contact: office@ory.sh
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
using OpenAPIDateConverter = Ory.Kratos.Client.Client.OpenAPIDateConverter;

namespace Ory.Kratos.Client.Model
{
    /// <summary>
    /// KratosIdentityCredentialsPassword
    /// </summary>
    [DataContract(Name = "identityCredentialsPassword")]
    public partial class KratosIdentityCredentialsPassword : IEquatable<KratosIdentityCredentialsPassword>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosIdentityCredentialsPassword" /> class.
        /// </summary>
        /// <param name="hashedPassword">HashedPassword is a hash-representation of the password..</param>
        public KratosIdentityCredentialsPassword(string hashedPassword = default(string))
        {
            this.HashedPassword = hashedPassword;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// HashedPassword is a hash-representation of the password.
        /// </summary>
        /// <value>HashedPassword is a hash-representation of the password.</value>
        [DataMember(Name = "hashed_password", EmitDefaultValue = false)]
        public string HashedPassword { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KratosIdentityCredentialsPassword {\n");
            sb.Append("  HashedPassword: ").Append(HashedPassword).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
            return this.Equals(input as KratosIdentityCredentialsPassword);
        }

        /// <summary>
        /// Returns true if KratosIdentityCredentialsPassword instances are equal
        /// </summary>
        /// <param name="input">Instance of KratosIdentityCredentialsPassword to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KratosIdentityCredentialsPassword input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.HashedPassword == input.HashedPassword ||
                    (this.HashedPassword != null &&
                    this.HashedPassword.Equals(input.HashedPassword))
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
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
                if (this.HashedPassword != null)
                {
                    hashCode = (hashCode * 59) + this.HashedPassword.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
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
