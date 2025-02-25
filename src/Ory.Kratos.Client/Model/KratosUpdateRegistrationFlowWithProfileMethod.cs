/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.3.6-alpha.1
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
    /// Update Registration Flow with Profile Method
    /// </summary>
    [DataContract(Name = "updateRegistrationFlowWithProfileMethod")]
    public partial class KratosUpdateRegistrationFlowWithProfileMethod : IValidatableObject
    {
        /// <summary>
        /// Screen requests navigation to a previous screen.  This must be set to credential-selection to go back to the credential selection screen. credential-selection RegistrationScreenCredentialSelection nolint:gosec // not a credential previous RegistrationScreenPrevious
        /// </summary>
        /// <value>Screen requests navigation to a previous screen.  This must be set to credential-selection to go back to the credential selection screen. credential-selection RegistrationScreenCredentialSelection nolint:gosec // not a credential previous RegistrationScreenPrevious</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ScreenEnum
        {
            /// <summary>
            /// Enum CredentialSelection for value: credential-selection
            /// </summary>
            [EnumMember(Value = "credential-selection")]
            CredentialSelection = 1,

            /// <summary>
            /// Enum Previous for value: previous
            /// </summary>
            [EnumMember(Value = "previous")]
            Previous = 2
        }


        /// <summary>
        /// Screen requests navigation to a previous screen.  This must be set to credential-selection to go back to the credential selection screen. credential-selection RegistrationScreenCredentialSelection nolint:gosec // not a credential previous RegistrationScreenPrevious
        /// </summary>
        /// <value>Screen requests navigation to a previous screen.  This must be set to credential-selection to go back to the credential selection screen. credential-selection RegistrationScreenCredentialSelection nolint:gosec // not a credential previous RegistrationScreenPrevious</value>
        [DataMember(Name = "screen", EmitDefaultValue = false)]
        public ScreenEnum? Screen { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateRegistrationFlowWithProfileMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KratosUpdateRegistrationFlowWithProfileMethod()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateRegistrationFlowWithProfileMethod" /> class.
        /// </summary>
        /// <param name="csrfToken">The Anti-CSRF Token  This token is only required when performing browser flows..</param>
        /// <param name="method">Method  Should be set to profile when trying to update a profile. (required).</param>
        /// <param name="screen">Screen requests navigation to a previous screen.  This must be set to credential-selection to go back to the credential selection screen. credential-selection RegistrationScreenCredentialSelection nolint:gosec // not a credential previous RegistrationScreenPrevious.</param>
        /// <param name="traits">Traits  The identity&#39;s traits. (required).</param>
        /// <param name="transientPayload">Transient data to pass along to any webhooks.</param>
        public KratosUpdateRegistrationFlowWithProfileMethod(string csrfToken = default(string), string method = default(string), ScreenEnum? screen = default(ScreenEnum?), Object traits = default(Object), Object transientPayload = default(Object))
        {
            // to ensure "method" is required (not null)
            if (method == null)
            {
                throw new ArgumentNullException("method is a required property for KratosUpdateRegistrationFlowWithProfileMethod and cannot be null");
            }
            this.Method = method;
            // to ensure "traits" is required (not null)
            if (traits == null)
            {
                throw new ArgumentNullException("traits is a required property for KratosUpdateRegistrationFlowWithProfileMethod and cannot be null");
            }
            this.Traits = traits;
            this.CsrfToken = csrfToken;
            this.Screen = screen;
            this.TransientPayload = transientPayload;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The Anti-CSRF Token  This token is only required when performing browser flows.
        /// </summary>
        /// <value>The Anti-CSRF Token  This token is only required when performing browser flows.</value>
        [DataMember(Name = "csrf_token", EmitDefaultValue = false)]
        public string CsrfToken { get; set; }

        /// <summary>
        /// Method  Should be set to profile when trying to update a profile.
        /// </summary>
        /// <value>Method  Should be set to profile when trying to update a profile.</value>
        [DataMember(Name = "method", IsRequired = true, EmitDefaultValue = true)]
        public string Method { get; set; }

        /// <summary>
        /// Traits  The identity&#39;s traits.
        /// </summary>
        /// <value>Traits  The identity&#39;s traits.</value>
        [DataMember(Name = "traits", IsRequired = true, EmitDefaultValue = true)]
        public Object Traits { get; set; }

        /// <summary>
        /// Transient data to pass along to any webhooks
        /// </summary>
        /// <value>Transient data to pass along to any webhooks</value>
        [DataMember(Name = "transient_payload", EmitDefaultValue = false)]
        public Object TransientPayload { get; set; }

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
            sb.Append("class KratosUpdateRegistrationFlowWithProfileMethod {\n");
            sb.Append("  CsrfToken: ").Append(CsrfToken).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Screen: ").Append(Screen).Append("\n");
            sb.Append("  Traits: ").Append(Traits).Append("\n");
            sb.Append("  TransientPayload: ").Append(TransientPayload).Append("\n");
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
