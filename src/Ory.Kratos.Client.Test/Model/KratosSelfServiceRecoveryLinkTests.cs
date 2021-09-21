/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * The version of the OpenAPI document: v0.7.6-alpha.6
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
    ///  Class for testing KratosSelfServiceRecoveryLink
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class KratosSelfServiceRecoveryLinkTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for KratosSelfServiceRecoveryLink
        //private KratosSelfServiceRecoveryLink instance;

        public KratosSelfServiceRecoveryLinkTests()
        {
            // TODO uncomment below to create an instance of KratosSelfServiceRecoveryLink
            //instance = new KratosSelfServiceRecoveryLink();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of KratosSelfServiceRecoveryLink
        /// </summary>
        [Fact]
        public void KratosSelfServiceRecoveryLinkInstanceTest()
        {
            // TODO uncomment below to test "IsType" KratosSelfServiceRecoveryLink
            //Assert.IsType<KratosSelfServiceRecoveryLink>(instance);
        }


        /// <summary>
        /// Test the property 'ExpiresAt'
        /// </summary>
        [Fact]
        public void ExpiresAtTest()
        {
            // TODO unit test for the property 'ExpiresAt'
        }
        /// <summary>
        /// Test the property 'RecoveryLink'
        /// </summary>
        [Fact]
        public void RecoveryLinkTest()
        {
            // TODO unit test for the property 'RecoveryLink'
        }

    }

}
