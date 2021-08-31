/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * The version of the OpenAPI document: v0.7.3-alpha.4
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
    /// ContainerWaitOKBody OK response to ContainerWait operation
    /// </summary>
    [DataContract(Name = "ContainerWaitOKBody")]
    public partial class KratosContainerWaitOKBody : IEquatable<KratosContainerWaitOKBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosContainerWaitOKBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KratosContainerWaitOKBody()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosContainerWaitOKBody" /> class.
        /// </summary>
        /// <param name="error">error (required).</param>
        /// <param name="statusCode">Exit code of the container (required).</param>
        public KratosContainerWaitOKBody(KratosContainerWaitOKBodyError error = default(KratosContainerWaitOKBodyError), long statusCode = default(long))
        {
            // to ensure "error" is required (not null)
            this.Error = error ?? throw new ArgumentNullException("error is a required property for KratosContainerWaitOKBody and cannot be null");
            this.StatusCode = statusCode;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "Error", IsRequired = true, EmitDefaultValue = false)]
        public KratosContainerWaitOKBodyError Error { get; set; }

        /// <summary>
        /// Exit code of the container
        /// </summary>
        /// <value>Exit code of the container</value>
        [DataMember(Name = "StatusCode", IsRequired = true, EmitDefaultValue = false)]
        public long StatusCode { get; set; }

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
            sb.Append("class KratosContainerWaitOKBody {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
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
            return this.Equals(input as KratosContainerWaitOKBody);
        }

        /// <summary>
        /// Returns true if KratosContainerWaitOKBody instances are equal
        /// </summary>
        /// <param name="input">Instance of KratosContainerWaitOKBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KratosContainerWaitOKBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.StatusCode == input.StatusCode ||
                    this.StatusCode.Equals(input.StatusCode)
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
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
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
