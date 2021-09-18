/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * The version of the OpenAPI document: v0.7.6-alpha.3
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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Kratos.Client.Client.OpenAPIDateConverter;
using System.Reflection;

namespace Ory.Kratos.Client.Model
{
    /// <summary>
    /// KratosSubmitSelfServiceSettingsFlowBody
    /// </summary>
    [JsonConverter(typeof(KratosSubmitSelfServiceSettingsFlowBodyJsonConverter))]
    [DataContract(Name = "submitSelfServiceSettingsFlowBody")]
    public partial class KratosSubmitSelfServiceSettingsFlowBody : AbstractOpenAPISchema, IEquatable<KratosSubmitSelfServiceSettingsFlowBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosSubmitSelfServiceSettingsFlowBody" /> class
        /// with the <see cref="KratosSubmitSelfServiceSettingsFlowWithOidcMethodBody" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosSubmitSelfServiceSettingsFlowWithOidcMethodBody.</param>
        public KratosSubmitSelfServiceSettingsFlowBody(KratosSubmitSelfServiceSettingsFlowWithOidcMethodBody actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosSubmitSelfServiceSettingsFlowBody" /> class
        /// with the <see cref="KratosSubmitSelfServiceSettingsFlowWithPasswordMethodBody" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosSubmitSelfServiceSettingsFlowWithPasswordMethodBody.</param>
        public KratosSubmitSelfServiceSettingsFlowBody(KratosSubmitSelfServiceSettingsFlowWithPasswordMethodBody actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosSubmitSelfServiceSettingsFlowBody" /> class
        /// with the <see cref="KratosSubmitSelfServiceSettingsFlowWithProfileMethodBody" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosSubmitSelfServiceSettingsFlowWithProfileMethodBody.</param>
        public KratosSubmitSelfServiceSettingsFlowBody(KratosSubmitSelfServiceSettingsFlowWithProfileMethodBody actualInstance)
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
                if (value.GetType() == typeof(KratosSubmitSelfServiceSettingsFlowWithOidcMethodBody))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KratosSubmitSelfServiceSettingsFlowWithPasswordMethodBody))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KratosSubmitSelfServiceSettingsFlowWithProfileMethodBody))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: KratosSubmitSelfServiceSettingsFlowWithOidcMethodBody, KratosSubmitSelfServiceSettingsFlowWithPasswordMethodBody, KratosSubmitSelfServiceSettingsFlowWithProfileMethodBody");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `KratosSubmitSelfServiceSettingsFlowWithOidcMethodBody`. If the actual instance is not `KratosSubmitSelfServiceSettingsFlowWithOidcMethodBody`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosSubmitSelfServiceSettingsFlowWithOidcMethodBody</returns>
        public KratosSubmitSelfServiceSettingsFlowWithOidcMethodBody GetKratosSubmitSelfServiceSettingsFlowWithOidcMethodBody()
        {
            return (KratosSubmitSelfServiceSettingsFlowWithOidcMethodBody)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KratosSubmitSelfServiceSettingsFlowWithPasswordMethodBody`. If the actual instance is not `KratosSubmitSelfServiceSettingsFlowWithPasswordMethodBody`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosSubmitSelfServiceSettingsFlowWithPasswordMethodBody</returns>
        public KratosSubmitSelfServiceSettingsFlowWithPasswordMethodBody GetKratosSubmitSelfServiceSettingsFlowWithPasswordMethodBody()
        {
            return (KratosSubmitSelfServiceSettingsFlowWithPasswordMethodBody)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KratosSubmitSelfServiceSettingsFlowWithProfileMethodBody`. If the actual instance is not `KratosSubmitSelfServiceSettingsFlowWithProfileMethodBody`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosSubmitSelfServiceSettingsFlowWithProfileMethodBody</returns>
        public KratosSubmitSelfServiceSettingsFlowWithProfileMethodBody GetKratosSubmitSelfServiceSettingsFlowWithProfileMethodBody()
        {
            return (KratosSubmitSelfServiceSettingsFlowWithProfileMethodBody)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KratosSubmitSelfServiceSettingsFlowBody {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, KratosSubmitSelfServiceSettingsFlowBody.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of KratosSubmitSelfServiceSettingsFlowBody
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of KratosSubmitSelfServiceSettingsFlowBody</returns>
        public static KratosSubmitSelfServiceSettingsFlowBody FromJson(string jsonString)
        {
            KratosSubmitSelfServiceSettingsFlowBody newKratosSubmitSelfServiceSettingsFlowBody = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newKratosSubmitSelfServiceSettingsFlowBody;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosSubmitSelfServiceSettingsFlowWithOidcMethodBody).GetProperty("AdditionalProperties") == null)
                {
                    newKratosSubmitSelfServiceSettingsFlowBody = new KratosSubmitSelfServiceSettingsFlowBody(JsonConvert.DeserializeObject<KratosSubmitSelfServiceSettingsFlowWithOidcMethodBody>(jsonString, KratosSubmitSelfServiceSettingsFlowBody.SerializerSettings));
                }
                else
                {
                    newKratosSubmitSelfServiceSettingsFlowBody = new KratosSubmitSelfServiceSettingsFlowBody(JsonConvert.DeserializeObject<KratosSubmitSelfServiceSettingsFlowWithOidcMethodBody>(jsonString, KratosSubmitSelfServiceSettingsFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosSubmitSelfServiceSettingsFlowWithOidcMethodBody");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KratosSubmitSelfServiceSettingsFlowWithOidcMethodBody: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosSubmitSelfServiceSettingsFlowWithPasswordMethodBody).GetProperty("AdditionalProperties") == null)
                {
                    newKratosSubmitSelfServiceSettingsFlowBody = new KratosSubmitSelfServiceSettingsFlowBody(JsonConvert.DeserializeObject<KratosSubmitSelfServiceSettingsFlowWithPasswordMethodBody>(jsonString, KratosSubmitSelfServiceSettingsFlowBody.SerializerSettings));
                }
                else
                {
                    newKratosSubmitSelfServiceSettingsFlowBody = new KratosSubmitSelfServiceSettingsFlowBody(JsonConvert.DeserializeObject<KratosSubmitSelfServiceSettingsFlowWithPasswordMethodBody>(jsonString, KratosSubmitSelfServiceSettingsFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosSubmitSelfServiceSettingsFlowWithPasswordMethodBody");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KratosSubmitSelfServiceSettingsFlowWithPasswordMethodBody: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosSubmitSelfServiceSettingsFlowWithProfileMethodBody).GetProperty("AdditionalProperties") == null)
                {
                    newKratosSubmitSelfServiceSettingsFlowBody = new KratosSubmitSelfServiceSettingsFlowBody(JsonConvert.DeserializeObject<KratosSubmitSelfServiceSettingsFlowWithProfileMethodBody>(jsonString, KratosSubmitSelfServiceSettingsFlowBody.SerializerSettings));
                }
                else
                {
                    newKratosSubmitSelfServiceSettingsFlowBody = new KratosSubmitSelfServiceSettingsFlowBody(JsonConvert.DeserializeObject<KratosSubmitSelfServiceSettingsFlowWithProfileMethodBody>(jsonString, KratosSubmitSelfServiceSettingsFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosSubmitSelfServiceSettingsFlowWithProfileMethodBody");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KratosSubmitSelfServiceSettingsFlowWithProfileMethodBody: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newKratosSubmitSelfServiceSettingsFlowBody;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as KratosSubmitSelfServiceSettingsFlowBody);
        }

        /// <summary>
        /// Returns true if KratosSubmitSelfServiceSettingsFlowBody instances are equal
        /// </summary>
        /// <param name="input">Instance of KratosSubmitSelfServiceSettingsFlowBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KratosSubmitSelfServiceSettingsFlowBody input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
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

    /// <summary>
    /// Custom JSON converter for KratosSubmitSelfServiceSettingsFlowBody
    /// </summary>
    public class KratosSubmitSelfServiceSettingsFlowBodyJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(KratosSubmitSelfServiceSettingsFlowBody).GetMethod("ToJson").Invoke(value, null)));
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
            if(reader.TokenType != JsonToken.Null)
            {
                return KratosSubmitSelfServiceSettingsFlowBody.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
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
