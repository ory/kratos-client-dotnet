/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * The version of the OpenAPI document: v0.10.1
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
    ///  Class for testing KratosAdminUpdateIdentityBody
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class KratosAdminUpdateIdentityBodyTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for KratosAdminUpdateIdentityBody
        //private KratosAdminUpdateIdentityBody instance;

        public KratosAdminUpdateIdentityBodyTests()
        {
            // TODO uncomment below to create an instance of KratosAdminUpdateIdentityBody
            //instance = new KratosAdminUpdateIdentityBody();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of KratosAdminUpdateIdentityBody
        /// </summary>
        [Fact]
        public void KratosAdminUpdateIdentityBodyInstanceTest()
        {
            // TODO uncomment below to test "IsType" KratosAdminUpdateIdentityBody
            //Assert.IsType<KratosAdminUpdateIdentityBody>(instance);
        }


        /// <summary>
        /// Test the property 'MetadataAdmin'
        /// </summary>
        [Fact]
        public void MetadataAdminTest()
        {
            // TODO unit test for the property 'MetadataAdmin'
        }
        /// <summary>
        /// Test the property 'MetadataPublic'
        /// </summary>
        [Fact]
        public void MetadataPublicTest()
        {
            // TODO unit test for the property 'MetadataPublic'
        }
        /// <summary>
        /// Test the property 'SchemaId'
        /// </summary>
        [Fact]
        public void SchemaIdTest()
        {
            // TODO unit test for the property 'SchemaId'
        }
        /// <summary>
        /// Test the property 'State'
        /// </summary>
        [Fact]
        public void StateTest()
        {
            // TODO unit test for the property 'State'
        }
        /// <summary>
        /// Test the property 'Traits'
        /// </summary>
        [Fact]
        public void TraitsTest()
        {
            // TODO unit test for the property 'Traits'
        }

    }

}
