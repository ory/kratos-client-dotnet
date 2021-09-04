/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * The version of the OpenAPI document: v0.7.3-alpha.8
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
    /// ContainerUpdateOKBody OK response to ContainerUpdate operation
    /// </summary>
    [DataContract(Name = "ContainerUpdateOKBody")]
    public partial class KratosContainerUpdateOKBody : IEquatable<KratosContainerUpdateOKBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosContainerUpdateOKBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KratosContainerUpdateOKBody()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosContainerUpdateOKBody" /> class.
        /// </summary>
        /// <param name="warnings">warnings (required).</param>
        public KratosContainerUpdateOKBody(List<string> warnings = default(List<string>))
        {
            // to ensure "warnings" is required (not null)
            this.Warnings = warnings ?? throw new ArgumentNullException("warnings is a required property for KratosContainerUpdateOKBody and cannot be null");
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// warnings
        /// </summary>
        /// <value>warnings</value>
        [DataMember(Name = "Warnings", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Warnings { get; set; }

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
            sb.Append("class KratosContainerUpdateOKBody {\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
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
            return this.Equals(input as KratosContainerUpdateOKBody);
        }

        /// <summary>
        /// Returns true if KratosContainerUpdateOKBody instances are equal
        /// </summary>
        /// <param name="input">Instance of KratosContainerUpdateOKBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KratosContainerUpdateOKBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    input.Warnings != null &&
                    this.Warnings.SequenceEqual(input.Warnings)
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
                if (this.Warnings != null)
                    hashCode = hashCode * 59 + this.Warnings.GetHashCode();
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
