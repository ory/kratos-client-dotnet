/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * The version of the OpenAPI document: v0.7.6-alpha.3
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
    ///  Class for testing KratosInlineResponse2001
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class KratosInlineResponse2001Tests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for KratosInlineResponse2001
        //private KratosInlineResponse2001 instance;

        public KratosInlineResponse2001Tests()
        {
            // TODO uncomment below to create an instance of KratosInlineResponse2001
            //instance = new KratosInlineResponse2001();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of KratosInlineResponse2001
        /// </summary>
        [Fact]
        public void KratosInlineResponse2001InstanceTest()
        {
            // TODO uncomment below to test "IsType" KratosInlineResponse2001
            //Assert.IsType<KratosInlineResponse2001>(instance);
        }


        /// <summary>
        /// Test the property '_Version'
        /// </summary>
        [Fact]
        public void _VersionTest()
        {
            // TODO unit test for the property '_Version'
        }

    }

}
