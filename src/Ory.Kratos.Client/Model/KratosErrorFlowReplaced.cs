/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v0.13.1
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
    /// Is sent when a flow is replaced by a different flow of the same class
    /// </summary>
    [DataContract(Name = "errorFlowReplaced")]
    public partial class KratosErrorFlowReplaced : IEquatable<KratosErrorFlowReplaced>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosErrorFlowReplaced" /> class.
        /// </summary>
        /// <param name="error">error.</param>
        /// <param name="useFlowId">The flow ID that should be used for the new flow as it contains the correct messages..</param>
        public KratosErrorFlowReplaced(KratosGenericError error = default(KratosGenericError), string useFlowId = default(string))
        {
            this.Error = error;
            this.UseFlowId = useFlowId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public KratosGenericError Error { get; set; }

        /// <summary>
        /// The flow ID that should be used for the new flow as it contains the correct messages.
        /// </summary>
        /// <value>The flow ID that should be used for the new flow as it contains the correct messages.</value>
        [DataMember(Name = "use_flow_id", EmitDefaultValue = false)]
        public string UseFlowId { get; set; }

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
            sb.Append("class KratosErrorFlowReplaced {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  UseFlowId: ").Append(UseFlowId).Append("\n");
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
            return this.Equals(input as KratosErrorFlowReplaced);
        }

        /// <summary>
        /// Returns true if KratosErrorFlowReplaced instances are equal
        /// </summary>
        /// <param name="input">Instance of KratosErrorFlowReplaced to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KratosErrorFlowReplaced input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.UseFlowId == input.UseFlowId ||
                    (this.UseFlowId != null &&
                    this.UseFlowId.Equals(input.UseFlowId))
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
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
                }
                if (this.UseFlowId != null)
                {
                    hashCode = (hashCode * 59) + this.UseFlowId.GetHashCode();
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
