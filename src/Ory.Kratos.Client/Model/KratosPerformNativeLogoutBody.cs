/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.3.6
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
    /// Perform Native Logout Request Body
    /// </summary>
    [DataContract(Name = "performNativeLogoutBody")]
    public partial class KratosPerformNativeLogoutBody : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosPerformNativeLogoutBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KratosPerformNativeLogoutBody()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosPerformNativeLogoutBody" /> class.
        /// </summary>
        /// <param name="sessionToken">The Session Token  Invalidate this session token. (required).</param>
        public KratosPerformNativeLogoutBody(string sessionToken = default(string))
        {
            // to ensure "sessionToken" is required (not null)
            if (sessionToken == null)
            {
                throw new ArgumentNullException("sessionToken is a required property for KratosPerformNativeLogoutBody and cannot be null");
            }
            this.SessionToken = sessionToken;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The Session Token  Invalidate this session token.
        /// </summary>
        /// <value>The Session Token  Invalidate this session token.</value>
        [DataMember(Name = "session_token", IsRequired = true, EmitDefaultValue = true)]
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
            sb.Append("class KratosPerformNativeLogoutBody {\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
