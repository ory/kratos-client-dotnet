/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * The version of the OpenAPI document: v0.7.6-alpha.6
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
    /// KratosUiNodeAnchorAttributes
    /// </summary>
    [DataContract(Name = "uiNodeAnchorAttributes")]
    public partial class KratosUiNodeAnchorAttributes : IEquatable<KratosUiNodeAnchorAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUiNodeAnchorAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KratosUiNodeAnchorAttributes()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUiNodeAnchorAttributes" /> class.
        /// </summary>
        /// <param name="href">The link&#39;s href (destination) URL.  format: uri (required).</param>
        /// <param name="title">title (required).</param>
        public KratosUiNodeAnchorAttributes(string href = default(string), KratosUiText title = default(KratosUiText))
        {
            // to ensure "href" is required (not null)
            if (href == null) {
                throw new ArgumentNullException("href is a required property for KratosUiNodeAnchorAttributes and cannot be null");
            }
            this.Href = href;
            // to ensure "title" is required (not null)
            if (title == null) {
                throw new ArgumentNullException("title is a required property for KratosUiNodeAnchorAttributes and cannot be null");
            }
            this.Title = title;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The link&#39;s href (destination) URL.  format: uri
        /// </summary>
        /// <value>The link&#39;s href (destination) URL.  format: uri</value>
        [DataMember(Name = "href", IsRequired = true, EmitDefaultValue = false)]
        public string Href { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = false)]
        public KratosUiText Title { get; set; }

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
            sb.Append("class KratosUiNodeAnchorAttributes {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as KratosUiNodeAnchorAttributes);
        }

        /// <summary>
        /// Returns true if KratosUiNodeAnchorAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of KratosUiNodeAnchorAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KratosUiNodeAnchorAttributes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
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
