/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.3.5
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
    /// KratosUiNodeAnchorAttributes
    /// </summary>
    [DataContract(Name = "uiNodeAnchorAttributes")]
    public partial class KratosUiNodeAnchorAttributes : IValidatableObject
    {
        /// <summary>
        /// NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is \&quot;a\&quot;. text Text input Input img Image a Anchor script Script
        /// </summary>
        /// <value>NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is \&quot;a\&quot;. text Text input Input img Image a Anchor script Script</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NodeTypeEnum
        {
            /// <summary>
            /// Enum Text for value: text
            /// </summary>
            [EnumMember(Value = "text")]
            Text = 1,

            /// <summary>
            /// Enum Input for value: input
            /// </summary>
            [EnumMember(Value = "input")]
            Input = 2,

            /// <summary>
            /// Enum Img for value: img
            /// </summary>
            [EnumMember(Value = "img")]
            Img = 3,

            /// <summary>
            /// Enum A for value: a
            /// </summary>
            [EnumMember(Value = "a")]
            A = 4,

            /// <summary>
            /// Enum Script for value: script
            /// </summary>
            [EnumMember(Value = "script")]
            Script = 5
        }


        /// <summary>
        /// NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is \&quot;a\&quot;. text Text input Input img Image a Anchor script Script
        /// </summary>
        /// <value>NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is \&quot;a\&quot;. text Text input Input img Image a Anchor script Script</value>
        [DataMember(Name = "node_type", IsRequired = true, EmitDefaultValue = true)]
        public NodeTypeEnum NodeType { get; set; }
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
        /// <param name="id">A unique identifier (required).</param>
        /// <param name="nodeType">NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is \&quot;a\&quot;. text Text input Input img Image a Anchor script Script (required).</param>
        /// <param name="title">title (required).</param>
        public KratosUiNodeAnchorAttributes(string href = default(string), string id = default(string), NodeTypeEnum nodeType = default(NodeTypeEnum), KratosUiText title = default(KratosUiText))
        {
            // to ensure "href" is required (not null)
            if (href == null)
            {
                throw new ArgumentNullException("href is a required property for KratosUiNodeAnchorAttributes and cannot be null");
            }
            this.Href = href;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for KratosUiNodeAnchorAttributes and cannot be null");
            }
            this.Id = id;
            this.NodeType = nodeType;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for KratosUiNodeAnchorAttributes and cannot be null");
            }
            this.Title = title;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The link&#39;s href (destination) URL.  format: uri
        /// </summary>
        /// <value>The link&#39;s href (destination) URL.  format: uri</value>
        [DataMember(Name = "href", IsRequired = true, EmitDefaultValue = true)]
        public string Href { get; set; }

        /// <summary>
        /// A unique identifier
        /// </summary>
        /// <value>A unique identifier</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
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
            StringBuilder sb = new StringBuilder();
            sb.Append("class KratosUiNodeAnchorAttributes {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NodeType: ").Append(NodeType).Append("\n");
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
