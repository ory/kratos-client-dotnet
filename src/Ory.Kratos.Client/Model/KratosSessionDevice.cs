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
    /// Device corresponding to a Session
    /// </summary>
    [DataContract(Name = "sessionDevice")]
    public partial class KratosSessionDevice : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosSessionDevice" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KratosSessionDevice()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosSessionDevice" /> class.
        /// </summary>
        /// <param name="id">Device record ID (required).</param>
        /// <param name="ipAddress">IPAddress of the client.</param>
        /// <param name="location">Geo Location corresponding to the IP Address.</param>
        /// <param name="userAgent">UserAgent of the client.</param>
        public KratosSessionDevice(string id = default(string), string ipAddress = default(string), string location = default(string), string userAgent = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for KratosSessionDevice and cannot be null");
            }
            this.Id = id;
            this.IpAddress = ipAddress;
            this.Location = location;
            this.UserAgent = userAgent;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Device record ID
        /// </summary>
        /// <value>Device record ID</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// IPAddress of the client
        /// </summary>
        /// <value>IPAddress of the client</value>
        [DataMember(Name = "ip_address", EmitDefaultValue = false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Geo Location corresponding to the IP Address
        /// </summary>
        /// <value>Geo Location corresponding to the IP Address</value>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        public string Location { get; set; }

        /// <summary>
        /// UserAgent of the client
        /// </summary>
        /// <value>UserAgent of the client</value>
        [DataMember(Name = "user_agent", EmitDefaultValue = false)]
        public string UserAgent { get; set; }

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
            sb.Append("class KratosSessionDevice {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
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
