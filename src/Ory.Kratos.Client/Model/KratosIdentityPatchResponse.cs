/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.3.7
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
    /// Response for a single identity patch
    /// </summary>
    [DataContract(Name = "identityPatchResponse")]
    public partial class KratosIdentityPatchResponse : IValidatableObject
    {
        /// <summary>
        /// The action for this specific patch create ActionCreate  Create this identity. error ActionError  Error indicates that the patch failed.
        /// </summary>
        /// <value>The action for this specific patch create ActionCreate  Create this identity. error ActionError  Error indicates that the patch failed.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Enum Create for value: create
            /// </summary>
            [EnumMember(Value = "create")]
            Create = 1,

            /// <summary>
            /// Enum Error for value: error
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 2
        }


        /// <summary>
        /// The action for this specific patch create ActionCreate  Create this identity. error ActionError  Error indicates that the patch failed.
        /// </summary>
        /// <value>The action for this specific patch create ActionCreate  Create this identity. error ActionError  Error indicates that the patch failed.</value>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosIdentityPatchResponse" /> class.
        /// </summary>
        /// <param name="action">The action for this specific patch create ActionCreate  Create this identity. error ActionError  Error indicates that the patch failed..</param>
        /// <param name="error">error.</param>
        /// <param name="identity">The identity ID payload of this patch.</param>
        /// <param name="patchId">The ID of this patch response, if an ID was specified in the patch..</param>
        public KratosIdentityPatchResponse(ActionEnum? action = default(ActionEnum?), Object error = default(Object), string identity = default(string), string patchId = default(string))
        {
            this.Action = action;
            this.Error = error;
            this.Identity = identity;
            this.PatchId = patchId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public Object Error { get; set; }

        /// <summary>
        /// The identity ID payload of this patch
        /// </summary>
        /// <value>The identity ID payload of this patch</value>
        [DataMember(Name = "identity", EmitDefaultValue = false)]
        public string Identity { get; set; }

        /// <summary>
        /// The ID of this patch response, if an ID was specified in the patch.
        /// </summary>
        /// <value>The ID of this patch response, if an ID was specified in the patch.</value>
        [DataMember(Name = "patch_id", EmitDefaultValue = false)]
        public string PatchId { get; set; }

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
            sb.Append("class KratosIdentityPatchResponse {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Identity: ").Append(Identity).Append("\n");
            sb.Append("  PatchId: ").Append(PatchId).Append("\n");
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
