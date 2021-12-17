/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * The version of the OpenAPI document: v0.8.2-alpha.1
 * Contact: hi@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Ory.Kratos.Client.Api;
using Ory.Kratos.Client.Model;
using Ory.Kratos.Client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Ory.Kratos.Client.Test.Model
{
    /// <summary>
    ///  Class for testing KratosSubmitSelfServiceSettingsFlowBody
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class KratosSubmitSelfServiceSettingsFlowBodyTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for KratosSubmitSelfServiceSettingsFlowBody
        //private KratosSubmitSelfServiceSettingsFlowBody instance;

        public KratosSubmitSelfServiceSettingsFlowBodyTests()
        {
            // TODO uncomment below to create an instance of KratosSubmitSelfServiceSettingsFlowBody
            //instance = new KratosSubmitSelfServiceSettingsFlowBody();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of KratosSubmitSelfServiceSettingsFlowBody
        /// </summary>
        [Fact]
        public void KratosSubmitSelfServiceSettingsFlowBodyInstanceTest()
        {
            // TODO uncomment below to test "IsType" KratosSubmitSelfServiceSettingsFlowBody
            //Assert.IsType<KratosSubmitSelfServiceSettingsFlowBody>(instance);
        }


        /// <summary>
        /// Test the property 'CsrfToken'
        /// </summary>
        [Fact]
        public void CsrfTokenTest()
        {
            // TODO unit test for the property 'CsrfToken'
        }
        /// <summary>
        /// Test the property 'Method'
        /// </summary>
        [Fact]
        public void MethodTest()
        {
            // TODO unit test for the property 'Method'
        }
        /// <summary>
        /// Test the property 'Password'
        /// </summary>
        [Fact]
        public void PasswordTest()
        {
            // TODO unit test for the property 'Password'
        }
        /// <summary>
        /// Test the property 'Traits'
        /// </summary>
        [Fact]
        public void TraitsTest()
        {
            // TODO unit test for the property 'Traits'
        }
        /// <summary>
        /// Test the property 'Flow'
        /// </summary>
        [Fact]
        public void FlowTest()
        {
            // TODO unit test for the property 'Flow'
        }
        /// <summary>
        /// Test the property 'Link'
        /// </summary>
        [Fact]
        public void LinkTest()
        {
            // TODO unit test for the property 'Link'
        }
        /// <summary>
        /// Test the property 'Unlink'
        /// </summary>
        [Fact]
        public void UnlinkTest()
        {
            // TODO unit test for the property 'Unlink'
        }
        /// <summary>
        /// Test the property 'TotpCode'
        /// </summary>
        [Fact]
        public void TotpCodeTest()
        {
            // TODO unit test for the property 'TotpCode'
        }
        /// <summary>
        /// Test the property 'TotpUnlink'
        /// </summary>
        [Fact]
        public void TotpUnlinkTest()
        {
            // TODO unit test for the property 'TotpUnlink'
        }

    }

}
