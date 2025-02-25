/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.3.8
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
    /// Indicates, that the UI flow could be continued by showing a recovery ui
    /// </summary>
    [DataContract(Name = "continueWithRedirectBrowserTo")]
    public partial class KratosContinueWithRedirectBrowserTo : IValidatableObject
    {
        /// <summary>
        /// Action will always be &#x60;redirect_browser_to&#x60; redirect_browser_to ContinueWithActionRedirectBrowserToString
        /// </summary>
        /// <value>Action will always be &#x60;redirect_browser_to&#x60; redirect_browser_to ContinueWithActionRedirectBrowserToString</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Enum RedirectBrowserTo for value: redirect_browser_to
            /// </summary>
            [EnumMember(Value = "redirect_browser_to")]
            RedirectBrowserTo = 1
        }


        /// <summary>
        /// Action will always be &#x60;redirect_browser_to&#x60; redirect_browser_to ContinueWithActionRedirectBrowserToString
        /// </summary>
        /// <value>Action will always be &#x60;redirect_browser_to&#x60; redirect_browser_to ContinueWithActionRedirectBrowserToString</value>
        [DataMember(Name = "action", IsRequired = true, EmitDefaultValue = true)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosContinueWithRedirectBrowserTo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KratosContinueWithRedirectBrowserTo()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosContinueWithRedirectBrowserTo" /> class.
        /// </summary>
        /// <param name="action">Action will always be &#x60;redirect_browser_to&#x60; redirect_browser_to ContinueWithActionRedirectBrowserToString (required).</param>
        /// <param name="redirectBrowserTo">The URL to redirect the browser to (required).</param>
        public KratosContinueWithRedirectBrowserTo(ActionEnum action = default(ActionEnum), string redirectBrowserTo = default(string))
        {
            this.Action = action;
            // to ensure "redirectBrowserTo" is required (not null)
            if (redirectBrowserTo == null)
            {
                throw new ArgumentNullException("redirectBrowserTo is a required property for KratosContinueWithRedirectBrowserTo and cannot be null");
            }
            this.RedirectBrowserTo = redirectBrowserTo;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The URL to redirect the browser to
        /// </summary>
        /// <value>The URL to redirect the browser to</value>
        [DataMember(Name = "redirect_browser_to", IsRequired = true, EmitDefaultValue = true)]
        public string RedirectBrowserTo { get; set; }

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
            sb.Append("class KratosContinueWithRedirectBrowserTo {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  RedirectBrowserTo: ").Append(RedirectBrowserTo).Append("\n");
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
