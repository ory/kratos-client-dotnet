/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * The version of the OpenAPI document: v0.7.6-alpha.1
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
    ///  Class for testing KratosUiNodeAnchorAttributes
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class KratosUiNodeAnchorAttributesTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for KratosUiNodeAnchorAttributes
        //private KratosUiNodeAnchorAttributes instance;

        public KratosUiNodeAnchorAttributesTests()
        {
            // TODO uncomment below to create an instance of KratosUiNodeAnchorAttributes
            //instance = new KratosUiNodeAnchorAttributes();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of KratosUiNodeAnchorAttributes
        /// </summary>
        [Fact]
        public void KratosUiNodeAnchorAttributesInstanceTest()
        {
            // TODO uncomment below to test "IsType" KratosUiNodeAnchorAttributes
            //Assert.IsType<KratosUiNodeAnchorAttributes>(instance);
        }


        /// <summary>
        /// Test the property 'Href'
        /// </summary>
        [Fact]
        public void HrefTest()
        {
            // TODO unit test for the property 'Href'
        }
        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Fact]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }

    }

}
