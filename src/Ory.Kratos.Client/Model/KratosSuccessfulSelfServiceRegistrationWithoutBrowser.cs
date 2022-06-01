/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * The version of the OpenAPI document: v0.10.1
 * Contact: hi@ory.sh
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
    /// The Response for Registration Flows via API
    /// </summary>
    [DataContract(Name = "successfulSelfServiceRegistrationWithoutBrowser")]
    public partial class KratosSuccessfulSelfServiceRegistrationWithoutBrowser : IEquatable<KratosSuccessfulSelfServiceRegistrationWithoutBrowser>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosSuccessfulSelfServiceRegistrationWithoutBrowser" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KratosSuccessfulSelfServiceRegistrationWithoutBrowser()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosSuccessfulSelfServiceRegistrationWithoutBrowser" /> class.
        /// </summary>
        /// <param name="identity">identity (required).</param>
        /// <param name="session">session.</param>
        /// <param name="sessionToken">The Session Token  This field is only set when the session hook is configured as a post-registration hook.  A session token is equivalent to a session cookie, but it can be sent in the HTTP Authorization Header:  Authorization: bearer ${session-token}  The session token is only issued for API flows, not for Browser flows!.</param>
        public KratosSuccessfulSelfServiceRegistrationWithoutBrowser(KratosIdentity identity = default(KratosIdentity), KratosSession session = default(KratosSession), string sessionToken = default(string))
        {
            // to ensure "identity" is required (not null)
            if (identity == null) {
                throw new ArgumentNullException("identity is a required property for KratosSuccessfulSelfServiceRegistrationWithoutBrowser and cannot be null");
            }
            this.Identity = identity;
            this.Session = session;
            this.SessionToken = sessionToken;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Identity
        /// </summary>
        [DataMember(Name = "identity", IsRequired = true, EmitDefaultValue = false)]
        public KratosIdentity Identity { get; set; }

        /// <summary>
        /// Gets or Sets Session
        /// </summary>
        [DataMember(Name = "session", EmitDefaultValue = false)]
        public KratosSession Session { get; set; }

        /// <summary>
        /// The Session Token  This field is only set when the session hook is configured as a post-registration hook.  A session token is equivalent to a session cookie, but it can be sent in the HTTP Authorization Header:  Authorization: bearer ${session-token}  The session token is only issued for API flows, not for Browser flows!
        /// </summary>
        /// <value>The Session Token  This field is only set when the session hook is configured as a post-registration hook.  A session token is equivalent to a session cookie, but it can be sent in the HTTP Authorization Header:  Authorization: bearer ${session-token}  The session token is only issued for API flows, not for Browser flows!</value>
        [DataMember(Name = "session_token", EmitDefaultValue = false)]
        public string SessionToken { get; set; }

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
            sb.Append("class KratosSuccessfulSelfServiceRegistrationWithoutBrowser {\n");
            sb.Append("  Identity: ").Append(Identity).Append("\n");
            sb.Append("  Session: ").Append(Session).Append("\n");
            sb.Append("  SessionToken: ").Append(SessionToken).Append("\n");
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
            return this.Equals(input as KratosSuccessfulSelfServiceRegistrationWithoutBrowser);
        }

        /// <summary>
        /// Returns true if KratosSuccessfulSelfServiceRegistrationWithoutBrowser instances are equal
        /// </summary>
        /// <param name="input">Instance of KratosSuccessfulSelfServiceRegistrationWithoutBrowser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KratosSuccessfulSelfServiceRegistrationWithoutBrowser input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Identity == input.Identity ||
                    (this.Identity != null &&
                    this.Identity.Equals(input.Identity))
                ) && 
                (
                    this.Session == input.Session ||
                    (this.Session != null &&
                    this.Session.Equals(input.Session))
                ) && 
                (
                    this.SessionToken == input.SessionToken ||
                    (this.SessionToken != null &&
                    this.SessionToken.Equals(input.SessionToken))
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
                if (this.Identity != null)
                {
                    hashCode = (hashCode * 59) + this.Identity.GetHashCode();
                }
                if (this.Session != null)
                {
                    hashCode = (hashCode * 59) + this.Session.GetHashCode();
                }
                if (this.SessionToken != null)
                {
                    hashCode = (hashCode * 59) + this.SessionToken.GetHashCode();
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
