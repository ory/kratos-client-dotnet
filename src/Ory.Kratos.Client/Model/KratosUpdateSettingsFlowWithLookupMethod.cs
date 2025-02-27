/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.3.8
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
    /// Update Settings Flow with Lookup Method
    /// </summary>
    [DataContract(Name = "updateSettingsFlowWithLookupMethod")]
    public partial class KratosUpdateSettingsFlowWithLookupMethod : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateSettingsFlowWithLookupMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KratosUpdateSettingsFlowWithLookupMethod()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateSettingsFlowWithLookupMethod" /> class.
        /// </summary>
        /// <param name="csrfToken">CSRFToken is the anti-CSRF token.</param>
        /// <param name="lookupSecretConfirm">If set to true will save the regenerated lookup secrets.</param>
        /// <param name="lookupSecretDisable">Disables this method if true..</param>
        /// <param name="lookupSecretRegenerate">If set to true will regenerate the lookup secrets.</param>
        /// <param name="lookupSecretReveal">If set to true will reveal the lookup secrets.</param>
        /// <param name="method">Method  Should be set to \&quot;lookup\&quot; when trying to add, update, or remove a lookup pairing. (required).</param>
        /// <param name="transientPayload">Transient data to pass along to any webhooks.</param>
        public KratosUpdateSettingsFlowWithLookupMethod(string csrfToken = default(string), bool lookupSecretConfirm = default(bool), bool lookupSecretDisable = default(bool), bool lookupSecretRegenerate = default(bool), bool lookupSecretReveal = default(bool), string method = default(string), Object transientPayload = default(Object))
        {
            // to ensure "method" is required (not null)
            if (method == null)
            {
                throw new ArgumentNullException("method is a required property for KratosUpdateSettingsFlowWithLookupMethod and cannot be null");
            }
            this.Method = method;
            this.CsrfToken = csrfToken;
            this.LookupSecretConfirm = lookupSecretConfirm;
            this.LookupSecretDisable = lookupSecretDisable;
            this.LookupSecretRegenerate = lookupSecretRegenerate;
            this.LookupSecretReveal = lookupSecretReveal;
            this.TransientPayload = transientPayload;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// CSRFToken is the anti-CSRF token
        /// </summary>
        /// <value>CSRFToken is the anti-CSRF token</value>
        [DataMember(Name = "csrf_token", EmitDefaultValue = false)]
        public string CsrfToken { get; set; }

        /// <summary>
        /// If set to true will save the regenerated lookup secrets
        /// </summary>
        /// <value>If set to true will save the regenerated lookup secrets</value>
        [DataMember(Name = "lookup_secret_confirm", EmitDefaultValue = true)]
        public bool LookupSecretConfirm { get; set; }

        /// <summary>
        /// Disables this method if true.
        /// </summary>
        /// <value>Disables this method if true.</value>
        [DataMember(Name = "lookup_secret_disable", EmitDefaultValue = true)]
        public bool LookupSecretDisable { get; set; }

        /// <summary>
        /// If set to true will regenerate the lookup secrets
        /// </summary>
        /// <value>If set to true will regenerate the lookup secrets</value>
        [DataMember(Name = "lookup_secret_regenerate", EmitDefaultValue = true)]
        public bool LookupSecretRegenerate { get; set; }

        /// <summary>
        /// If set to true will reveal the lookup secrets
        /// </summary>
        /// <value>If set to true will reveal the lookup secrets</value>
        [DataMember(Name = "lookup_secret_reveal", EmitDefaultValue = true)]
        public bool LookupSecretReveal { get; set; }

        /// <summary>
        /// Method  Should be set to \&quot;lookup\&quot; when trying to add, update, or remove a lookup pairing.
        /// </summary>
        /// <value>Method  Should be set to \&quot;lookup\&quot; when trying to add, update, or remove a lookup pairing.</value>
        [DataMember(Name = "method", IsRequired = true, EmitDefaultValue = true)]
        public string Method { get; set; }

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
            sb.Append("class KratosUpdateSettingsFlowWithLookupMethod {\n");
            sb.Append("  CsrfToken: ").Append(CsrfToken).Append("\n");
            sb.Append("  LookupSecretConfirm: ").Append(LookupSecretConfirm).Append("\n");
            sb.Append("  LookupSecretDisable: ").Append(LookupSecretDisable).Append("\n");
            sb.Append("  LookupSecretRegenerate: ").Append(LookupSecretRegenerate).Append("\n");
            sb.Append("  LookupSecretReveal: ").Append(LookupSecretReveal).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
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
