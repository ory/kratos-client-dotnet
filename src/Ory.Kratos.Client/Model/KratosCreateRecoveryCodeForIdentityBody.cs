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
    /// Create Recovery Code for Identity Request Body
    /// </summary>
    [DataContract(Name = "createRecoveryCodeForIdentityBody")]
    public partial class KratosCreateRecoveryCodeForIdentityBody : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosCreateRecoveryCodeForIdentityBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KratosCreateRecoveryCodeForIdentityBody()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosCreateRecoveryCodeForIdentityBody" /> class.
        /// </summary>
        /// <param name="expiresIn">Code Expires In  The recovery code will expire after that amount of time has passed. Defaults to the configuration value of &#x60;selfservice.methods.code.config.lifespan&#x60;..</param>
        /// <param name="flowType">The flow type can either be &#x60;api&#x60; or &#x60;browser&#x60;..</param>
        /// <param name="identityId">Identity to Recover  The identity&#39;s ID you wish to recover. (required).</param>
        public KratosCreateRecoveryCodeForIdentityBody(string expiresIn = default(string), string flowType = default(string), string identityId = default(string))
        {
            // to ensure "identityId" is required (not null)
            if (identityId == null)
            {
                throw new ArgumentNullException("identityId is a required property for KratosCreateRecoveryCodeForIdentityBody and cannot be null");
            }
            this.IdentityId = identityId;
            this.ExpiresIn = expiresIn;
            this.FlowType = flowType;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Code Expires In  The recovery code will expire after that amount of time has passed. Defaults to the configuration value of &#x60;selfservice.methods.code.config.lifespan&#x60;.
        /// </summary>
        /// <value>Code Expires In  The recovery code will expire after that amount of time has passed. Defaults to the configuration value of &#x60;selfservice.methods.code.config.lifespan&#x60;.</value>
        [DataMember(Name = "expires_in", EmitDefaultValue = false)]
        public string ExpiresIn { get; set; }

        /// <summary>
        /// The flow type can either be &#x60;api&#x60; or &#x60;browser&#x60;.
        /// </summary>
        /// <value>The flow type can either be &#x60;api&#x60; or &#x60;browser&#x60;.</value>
        [DataMember(Name = "flow_type", EmitDefaultValue = false)]
        public string FlowType { get; set; }

        /// <summary>
        /// Identity to Recover  The identity&#39;s ID you wish to recover.
        /// </summary>
        /// <value>Identity to Recover  The identity&#39;s ID you wish to recover.</value>
        [DataMember(Name = "identity_id", IsRequired = true, EmitDefaultValue = true)]
        public string IdentityId { get; set; }

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
            sb.Append("class KratosCreateRecoveryCodeForIdentityBody {\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  FlowType: ").Append(FlowType).Append("\n");
            sb.Append("  IdentityId: ").Append(IdentityId).Append("\n");
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
            if (this.ExpiresIn != null) {
                // ExpiresIn (string) pattern
                Regex regexExpiresIn = new Regex(@"^([0-9]+(ns|us|ms|s|m|h))*$", RegexOptions.CultureInvariant);
                if (!regexExpiresIn.Match(this.ExpiresIn).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpiresIn, must match a pattern of " + regexExpiresIn, new [] { "ExpiresIn" });
                }
            }

            yield break;
        }
    }

}
