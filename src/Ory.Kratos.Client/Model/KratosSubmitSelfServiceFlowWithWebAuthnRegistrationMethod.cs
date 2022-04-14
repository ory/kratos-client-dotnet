/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * The version of the OpenAPI document: v0.9.0-alpha.3
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
    /// KratosSubmitSelfServiceFlowWithWebAuthnRegistrationMethod
    /// </summary>
    [DataContract(Name = "submitSelfServiceFlowWithWebAuthnRegistrationMethod")]
    public partial class KratosSubmitSelfServiceFlowWithWebAuthnRegistrationMethod : IEquatable<KratosSubmitSelfServiceFlowWithWebAuthnRegistrationMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosSubmitSelfServiceFlowWithWebAuthnRegistrationMethod" /> class.
        /// </summary>
        /// <param name="webauthnRegister">Register a WebAuthn Security Key  It is expected that the JSON returned by the WebAuthn registration process is included here..</param>
        /// <param name="webauthnRegisterDisplayname">Name of the WebAuthn Security Key to be Added  A human-readable name for the security key which will be added..</param>
        public KratosSubmitSelfServiceFlowWithWebAuthnRegistrationMethod(string webauthnRegister = default(string), string webauthnRegisterDisplayname = default(string))
        {
            this.WebauthnRegister = webauthnRegister;
            this.WebauthnRegisterDisplayname = webauthnRegisterDisplayname;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Register a WebAuthn Security Key  It is expected that the JSON returned by the WebAuthn registration process is included here.
        /// </summary>
        /// <value>Register a WebAuthn Security Key  It is expected that the JSON returned by the WebAuthn registration process is included here.</value>
        [DataMember(Name = "webauthn_register", EmitDefaultValue = false)]
        public string WebauthnRegister { get; set; }

        /// <summary>
        /// Name of the WebAuthn Security Key to be Added  A human-readable name for the security key which will be added.
        /// </summary>
        /// <value>Name of the WebAuthn Security Key to be Added  A human-readable name for the security key which will be added.</value>
        [DataMember(Name = "webauthn_register_displayname", EmitDefaultValue = false)]
        public string WebauthnRegisterDisplayname { get; set; }

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
            sb.Append("class KratosSubmitSelfServiceFlowWithWebAuthnRegistrationMethod {\n");
            sb.Append("  WebauthnRegister: ").Append(WebauthnRegister).Append("\n");
            sb.Append("  WebauthnRegisterDisplayname: ").Append(WebauthnRegisterDisplayname).Append("\n");
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
            return this.Equals(input as KratosSubmitSelfServiceFlowWithWebAuthnRegistrationMethod);
        }

        /// <summary>
        /// Returns true if KratosSubmitSelfServiceFlowWithWebAuthnRegistrationMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of KratosSubmitSelfServiceFlowWithWebAuthnRegistrationMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KratosSubmitSelfServiceFlowWithWebAuthnRegistrationMethod input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.WebauthnRegister == input.WebauthnRegister ||
                    (this.WebauthnRegister != null &&
                    this.WebauthnRegister.Equals(input.WebauthnRegister))
                ) && 
                (
                    this.WebauthnRegisterDisplayname == input.WebauthnRegisterDisplayname ||
                    (this.WebauthnRegisterDisplayname != null &&
                    this.WebauthnRegisterDisplayname.Equals(input.WebauthnRegisterDisplayname))
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
                if (this.WebauthnRegister != null)
                {
                    hashCode = (hashCode * 59) + this.WebauthnRegister.GetHashCode();
                }
                if (this.WebauthnRegisterDisplayname != null)
                {
                    hashCode = (hashCode * 59) + this.WebauthnRegisterDisplayname.GetHashCode();
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