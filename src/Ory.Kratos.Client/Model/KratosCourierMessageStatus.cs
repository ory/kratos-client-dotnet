/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v0.13.1
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
    /// A Message&#39;s Status
    /// </summary>
    /// <value>A Message&#39;s Status</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum KratosCourierMessageStatus
    {
        /// <summary>
        /// Enum Queued for value: queued
        /// </summary>
        [EnumMember(Value = "queued")]
        Queued = 1,

        /// <summary>
        /// Enum Sent for value: sent
        /// </summary>
        [EnumMember(Value = "sent")]
        Sent = 2,

        /// <summary>
        /// Enum Processing for value: processing
        /// </summary>
        [EnumMember(Value = "processing")]
        Processing = 3,

        /// <summary>
        /// Enum Abandoned for value: abandoned
        /// </summary>
        [EnumMember(Value = "abandoned")]
        Abandoned = 4

    }

}
