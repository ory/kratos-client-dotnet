/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * The version of the OpenAPI document: v0.7.3-alpha.5
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
    /// This object represents a login flow. A login flow is initiated at the \&quot;Initiate Login API / Browser Flow\&quot; endpoint by a client.  Once a login flow is completed successfully, a session cookie or session token will be issued.
    /// </summary>
    [DataContract(Name = "selfServiceLoginFlow")]
    public partial class KratosSelfServiceLoginFlow : IEquatable<KratosSelfServiceLoginFlow>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosSelfServiceLoginFlow" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KratosSelfServiceLoginFlow()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosSelfServiceLoginFlow" /> class.
        /// </summary>
        /// <param name="active">and so on..</param>
        /// <param name="createdAt">CreatedAt is a helper struct field for gobuffalo.pop..</param>
        /// <param name="expiresAt">ExpiresAt is the time (UTC) when the flow expires. If the user still wishes to log in, a new flow has to be initiated. (required).</param>
        /// <param name="forced">Forced stores whether this login flow should enforce re-authentication..</param>
        /// <param name="id">id (required).</param>
        /// <param name="issuedAt">IssuedAt is the time (UTC) when the flow started. (required).</param>
        /// <param name="requestUrl">RequestURL is the initial URL that was requested from Ory Kratos. It can be used to forward information contained in the URL&#39;s path or query for example. (required).</param>
        /// <param name="type">The flow type can either be &#x60;api&#x60; or &#x60;browser&#x60;. (required).</param>
        /// <param name="ui">ui (required).</param>
        /// <param name="updatedAt">UpdatedAt is a helper struct field for gobuffalo.pop..</param>
        public KratosSelfServiceLoginFlow(string active = default(string), DateTime createdAt = default(DateTime), DateTime expiresAt = default(DateTime), bool forced = default(bool), string id = default(string), DateTime issuedAt = default(DateTime), string requestUrl = default(string), string type = default(string), KratosUiContainer ui = default(KratosUiContainer), DateTime updatedAt = default(DateTime))
        {
            this.ExpiresAt = expiresAt;
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for KratosSelfServiceLoginFlow and cannot be null");
            this.IssuedAt = issuedAt;
            // to ensure "requestUrl" is required (not null)
            this.RequestUrl = requestUrl ?? throw new ArgumentNullException("requestUrl is a required property for KratosSelfServiceLoginFlow and cannot be null");
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for KratosSelfServiceLoginFlow and cannot be null");
            // to ensure "ui" is required (not null)
            this.Ui = ui ?? throw new ArgumentNullException("ui is a required property for KratosSelfServiceLoginFlow and cannot be null");
            this.Active = active;
            this.CreatedAt = createdAt;
            this.Forced = forced;
            this.UpdatedAt = updatedAt;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// and so on.
        /// </summary>
        /// <value>and so on.</value>
        [DataMember(Name = "active", EmitDefaultValue = false)]
        public string Active { get; set; }

        /// <summary>
        /// CreatedAt is a helper struct field for gobuffalo.pop.
        /// </summary>
        /// <value>CreatedAt is a helper struct field for gobuffalo.pop.</value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// ExpiresAt is the time (UTC) when the flow expires. If the user still wishes to log in, a new flow has to be initiated.
        /// </summary>
        /// <value>ExpiresAt is the time (UTC) when the flow expires. If the user still wishes to log in, a new flow has to be initiated.</value>
        [DataMember(Name = "expires_at", IsRequired = true, EmitDefaultValue = false)]
        public DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Forced stores whether this login flow should enforce re-authentication.
        /// </summary>
        /// <value>Forced stores whether this login flow should enforce re-authentication.</value>
        [DataMember(Name = "forced", EmitDefaultValue = true)]
        public bool Forced { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// IssuedAt is the time (UTC) when the flow started.
        /// </summary>
        /// <value>IssuedAt is the time (UTC) when the flow started.</value>
        [DataMember(Name = "issued_at", IsRequired = true, EmitDefaultValue = false)]
        public DateTime IssuedAt { get; set; }

        /// <summary>
        /// RequestURL is the initial URL that was requested from Ory Kratos. It can be used to forward information contained in the URL&#39;s path or query for example.
        /// </summary>
        /// <value>RequestURL is the initial URL that was requested from Ory Kratos. It can be used to forward information contained in the URL&#39;s path or query for example.</value>
        [DataMember(Name = "request_url", IsRequired = true, EmitDefaultValue = false)]
        public string RequestUrl { get; set; }

        /// <summary>
        /// The flow type can either be &#x60;api&#x60; or &#x60;browser&#x60;.
        /// </summary>
        /// <value>The flow type can either be &#x60;api&#x60; or &#x60;browser&#x60;.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Ui
        /// </summary>
        [DataMember(Name = "ui", IsRequired = true, EmitDefaultValue = false)]
        public KratosUiContainer Ui { get; set; }

        /// <summary>
        /// UpdatedAt is a helper struct field for gobuffalo.pop.
        /// </summary>
        /// <value>UpdatedAt is a helper struct field for gobuffalo.pop.</value>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

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
            sb.Append("class KratosSelfServiceLoginFlow {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  Forced: ").Append(Forced).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IssuedAt: ").Append(IssuedAt).Append("\n");
            sb.Append("  RequestUrl: ").Append(RequestUrl).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Ui: ").Append(Ui).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as KratosSelfServiceLoginFlow);
        }

        /// <summary>
        /// Returns true if KratosSelfServiceLoginFlow instances are equal
        /// </summary>
        /// <param name="input">Instance of KratosSelfServiceLoginFlow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KratosSelfServiceLoginFlow input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt))
                ) && 
                (
                    this.Forced == input.Forced ||
                    this.Forced.Equals(input.Forced)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IssuedAt == input.IssuedAt ||
                    (this.IssuedAt != null &&
                    this.IssuedAt.Equals(input.IssuedAt))
                ) && 
                (
                    this.RequestUrl == input.RequestUrl ||
                    (this.RequestUrl != null &&
                    this.RequestUrl.Equals(input.RequestUrl))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Ui == input.Ui ||
                    (this.Ui != null &&
                    this.Ui.Equals(input.Ui))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ExpiresAt != null)
                    hashCode = hashCode * 59 + this.ExpiresAt.GetHashCode();
                hashCode = hashCode * 59 + this.Forced.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IssuedAt != null)
                    hashCode = hashCode * 59 + this.IssuedAt.GetHashCode();
                if (this.RequestUrl != null)
                    hashCode = hashCode * 59 + this.RequestUrl.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Ui != null)
                    hashCode = hashCode * 59 + this.Ui.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
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
