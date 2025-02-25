/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.3.4
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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Kratos.Client.Client.OpenAPIDateConverter;
using System.Reflection;

namespace Ory.Kratos.Client.Model
{
    /// <summary>
    /// Update Verification Flow Request Body
    /// </summary>
    [JsonConverter(typeof(KratosUpdateVerificationFlowBodyJsonConverter))]
    [DataContract(Name = "updateVerificationFlowBody")]
    public partial class KratosUpdateVerificationFlowBody : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateVerificationFlowBody" /> class
        /// with the <see cref="KratosUpdateVerificationFlowWithLinkMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosUpdateVerificationFlowWithLinkMethod.</param>
        public KratosUpdateVerificationFlowBody(KratosUpdateVerificationFlowWithLinkMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateVerificationFlowBody" /> class
        /// with the <see cref="KratosUpdateVerificationFlowWithCodeMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosUpdateVerificationFlowWithCodeMethod.</param>
        public KratosUpdateVerificationFlowBody(KratosUpdateVerificationFlowWithCodeMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(KratosUpdateVerificationFlowWithCodeMethod) || value is KratosUpdateVerificationFlowWithCodeMethod)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KratosUpdateVerificationFlowWithLinkMethod) || value is KratosUpdateVerificationFlowWithLinkMethod)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: KratosUpdateVerificationFlowWithCodeMethod, KratosUpdateVerificationFlowWithLinkMethod");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `KratosUpdateVerificationFlowWithLinkMethod`. If the actual instance is not `KratosUpdateVerificationFlowWithLinkMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosUpdateVerificationFlowWithLinkMethod</returns>
        public KratosUpdateVerificationFlowWithLinkMethod GetKratosUpdateVerificationFlowWithLinkMethod()
        {
            return (KratosUpdateVerificationFlowWithLinkMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KratosUpdateVerificationFlowWithCodeMethod`. If the actual instance is not `KratosUpdateVerificationFlowWithCodeMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosUpdateVerificationFlowWithCodeMethod</returns>
        public KratosUpdateVerificationFlowWithCodeMethod GetKratosUpdateVerificationFlowWithCodeMethod()
        {
            return (KratosUpdateVerificationFlowWithCodeMethod)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KratosUpdateVerificationFlowBody {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, KratosUpdateVerificationFlowBody.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of KratosUpdateVerificationFlowBody
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of KratosUpdateVerificationFlowBody</returns>
        public static KratosUpdateVerificationFlowBody FromJson(string jsonString)
        {
            KratosUpdateVerificationFlowBody newKratosUpdateVerificationFlowBody = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newKratosUpdateVerificationFlowBody;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosUpdateVerificationFlowWithCodeMethod).GetProperty("AdditionalProperties") == null)
                {
                    newKratosUpdateVerificationFlowBody = new KratosUpdateVerificationFlowBody(JsonConvert.DeserializeObject<KratosUpdateVerificationFlowWithCodeMethod>(jsonString, KratosUpdateVerificationFlowBody.SerializerSettings));
                }
                else
                {
                    newKratosUpdateVerificationFlowBody = new KratosUpdateVerificationFlowBody(JsonConvert.DeserializeObject<KratosUpdateVerificationFlowWithCodeMethod>(jsonString, KratosUpdateVerificationFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosUpdateVerificationFlowWithCodeMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KratosUpdateVerificationFlowWithCodeMethod: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosUpdateVerificationFlowWithLinkMethod).GetProperty("AdditionalProperties") == null)
                {
                    newKratosUpdateVerificationFlowBody = new KratosUpdateVerificationFlowBody(JsonConvert.DeserializeObject<KratosUpdateVerificationFlowWithLinkMethod>(jsonString, KratosUpdateVerificationFlowBody.SerializerSettings));
                }
                else
                {
                    newKratosUpdateVerificationFlowBody = new KratosUpdateVerificationFlowBody(JsonConvert.DeserializeObject<KratosUpdateVerificationFlowWithLinkMethod>(jsonString, KratosUpdateVerificationFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosUpdateVerificationFlowWithLinkMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KratosUpdateVerificationFlowWithLinkMethod: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + String.Join(",", matchedTypes));
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newKratosUpdateVerificationFlowBody;
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

    /// <summary>
    /// Custom JSON converter for KratosUpdateVerificationFlowBody
    /// </summary>
    public class KratosUpdateVerificationFlowBodyJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(KratosUpdateVerificationFlowBody).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch(reader.TokenType) 
            {
                case JsonToken.StartObject:
                    return KratosUpdateVerificationFlowBody.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return KratosUpdateVerificationFlowBody.FromJson(JArray.Load(reader).ToString(Formatting.None));
                default:
                    return null;
            }
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
