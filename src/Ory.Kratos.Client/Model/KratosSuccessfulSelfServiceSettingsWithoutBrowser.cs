/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * The version of the OpenAPI document: v0.7.6-alpha.1
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
    /// The Response for Settings Flows via API
    /// </summary>
    [DataContract(Name = "successfulSelfServiceSettingsWithoutBrowser")]
    public partial class KratosSuccessfulSelfServiceSettingsWithoutBrowser : IEquatable<KratosSuccessfulSelfServiceSettingsWithoutBrowser>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosSuccessfulSelfServiceSettingsWithoutBrowser" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KratosSuccessfulSelfServiceSettingsWithoutBrowser()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosSuccessfulSelfServiceSettingsWithoutBrowser" /> class.
        /// </summary>
        /// <param name="flow">flow (required).</param>
        /// <param name="identity">identity (required).</param>
        public KratosSuccessfulSelfServiceSettingsWithoutBrowser(KratosSelfServiceSettingsFlow flow = default(KratosSelfServiceSettingsFlow), KratosIdentity identity = default(KratosIdentity))
        {
            // to ensure "flow" is required (not null)
            if (flow == null) {
                throw new ArgumentNullException("flow is a required property for KratosSuccessfulSelfServiceSettingsWithoutBrowser and cannot be null");
            }
            this.Flow = flow;
            // to ensure "identity" is required (not null)
            if (identity == null) {
                throw new ArgumentNullException("identity is a required property for KratosSuccessfulSelfServiceSettingsWithoutBrowser and cannot be null");
            }
            this.Identity = identity;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Flow
        /// </summary>
        [DataMember(Name = "flow", IsRequired = true, EmitDefaultValue = false)]
        public KratosSelfServiceSettingsFlow Flow { get; set; }

        /// <summary>
        /// Gets or Sets Identity
        /// </summary>
        [DataMember(Name = "identity", IsRequired = true, EmitDefaultValue = false)]
        public KratosIdentity Identity { get; set; }

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
            var sb = new StringBuilder();
            sb.Append("class KratosSuccessfulSelfServiceSettingsWithoutBrowser {\n");
            sb.Append("  Flow: ").Append(Flow).Append("\n");
            sb.Append("  Identity: ").Append(Identity).Append("\n");
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
            return this.Equals(input as KratosSuccessfulSelfServiceSettingsWithoutBrowser);
        }

        /// <summary>
        /// Returns true if KratosSuccessfulSelfServiceSettingsWithoutBrowser instances are equal
        /// </summary>
        /// <param name="input">Instance of KratosSuccessfulSelfServiceSettingsWithoutBrowser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KratosSuccessfulSelfServiceSettingsWithoutBrowser input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Flow == input.Flow ||
                    (this.Flow != null &&
                    this.Flow.Equals(input.Flow))
                ) && 
                (
                    this.Identity == input.Identity ||
                    (this.Identity != null &&
                    this.Identity.Equals(input.Identity))
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
                if (this.Flow != null)
                    hashCode = hashCode * 59 + this.Flow.GetHashCode();
                if (this.Identity != null)
                    hashCode = hashCode * 59 + this.Identity.GetHashCode();
                if (this.AdditionalProperties != null)
                    hashCode = hashCode * 59 + this.AdditionalProperties.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
