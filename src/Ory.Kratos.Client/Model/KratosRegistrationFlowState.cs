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
    /// The experimental state represents the state of a registration flow. This field is EXPERIMENTAL and subject to change!
    /// </summary>
    /// <value>The experimental state represents the state of a registration flow. This field is EXPERIMENTAL and subject to change!</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum KratosRegistrationFlowState
    {
        /// <summary>
        /// Enum ChooseMethod for value: choose_method
        /// </summary>
        [EnumMember(Value = "choose_method")]
        ChooseMethod = 1,

        /// <summary>
        /// Enum SentEmail for value: sent_email
        /// </summary>
        [EnumMember(Value = "sent_email")]
        SentEmail = 2,

        /// <summary>
        /// Enum PassedChallenge for value: passed_challenge
        /// </summary>
        [EnumMember(Value = "passed_challenge")]
        PassedChallenge = 3
    }

}
