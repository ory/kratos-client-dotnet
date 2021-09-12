/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * The version of the OpenAPI document: v0.7.5-alpha.2
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
    /// The state represents the state of the recovery flow.  choose_method: ask the user to choose a method (e.g. recover account via email) sent_email: the email has been sent to the user passed_challenge: the request was successful and the recovery challenge was passed.
    /// </summary>
    /// <value>The state represents the state of the recovery flow.  choose_method: ask the user to choose a method (e.g. recover account via email) sent_email: the email has been sent to the user passed_challenge: the request was successful and the recovery challenge was passed.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum KratosSelfServiceRecoveryFlowState
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
