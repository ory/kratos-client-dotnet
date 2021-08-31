/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * The version of the OpenAPI document: v0.7.3-alpha.2
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
    /// Port An open port on a container
    /// </summary>
    [DataContract(Name = "Port")]
    public partial class KratosPort : IEquatable<KratosPort>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosPort" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KratosPort()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosPort" /> class.
        /// </summary>
        /// <param name="iP">IP.</param>
        /// <param name="privatePort">Port on the container (required).</param>
        /// <param name="publicPort">Port exposed on the host.</param>
        /// <param name="type">type (required).</param>
        public KratosPort(string iP = default(string), int privatePort = default(int), int publicPort = default(int), string type = default(string))
        {
            this.PrivatePort = privatePort;
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for KratosPort and cannot be null");
            this.IP = iP;
            this.PublicPort = publicPort;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// IP
        /// </summary>
        /// <value>IP</value>
        [DataMember(Name = "IP", EmitDefaultValue = false)]
        public string IP { get; set; }

        /// <summary>
        /// Port on the container
        /// </summary>
        /// <value>Port on the container</value>
        [DataMember(Name = "PrivatePort", IsRequired = true, EmitDefaultValue = false)]
        public int PrivatePort { get; set; }

        /// <summary>
        /// Port exposed on the host
        /// </summary>
        /// <value>Port exposed on the host</value>
        [DataMember(Name = "PublicPort", EmitDefaultValue = false)]
        public int PublicPort { get; set; }

        /// <summary>
        /// type
        /// </summary>
        /// <value>type</value>
        [DataMember(Name = "Type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

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
            sb.Append("class KratosPort {\n");
            sb.Append("  IP: ").Append(IP).Append("\n");
            sb.Append("  PrivatePort: ").Append(PrivatePort).Append("\n");
            sb.Append("  PublicPort: ").Append(PublicPort).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as KratosPort);
        }

        /// <summary>
        /// Returns true if KratosPort instances are equal
        /// </summary>
        /// <param name="input">Instance of KratosPort to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KratosPort input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IP == input.IP ||
                    (this.IP != null &&
                    this.IP.Equals(input.IP))
                ) && 
                (
                    this.PrivatePort == input.PrivatePort ||
                    this.PrivatePort.Equals(input.PrivatePort)
                ) && 
                (
                    this.PublicPort == input.PublicPort ||
                    this.PublicPort.Equals(input.PublicPort)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.IP != null)
                    hashCode = hashCode * 59 + this.IP.GetHashCode();
                hashCode = hashCode * 59 + this.PrivatePort.GetHashCode();
                hashCode = hashCode * 59 + this.PublicPort.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
