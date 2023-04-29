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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Ory.Kratos.Client.Client;
using Ory.Kratos.Client.Api;
// uncomment below to import models
//using Ory.Kratos.Client.Model;

namespace Ory.Kratos.Client.Test.Api
{
    /// <summary>
    ///  Class for testing MetadataApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MetadataApiTests : IDisposable
    {
        private MetadataApi instance;

        public MetadataApiTests()
        {
            instance = new MetadataApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MetadataApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' MetadataApi
            //Assert.IsType<MetadataApi>(instance);
        }

        /// <summary>
        /// Test GetVersion
        /// </summary>
        [Fact]
        public void GetVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetVersion();
            //Assert.IsType<KratosInlineResponse2001>(response);
        }

        /// <summary>
        /// Test IsAlive
        /// </summary>
        [Fact]
        public void IsAliveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.IsAlive();
            //Assert.IsType<KratosInlineResponse200>(response);
        }

        /// <summary>
        /// Test IsReady
        /// </summary>
        [Fact]
        public void IsReadyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.IsReady();
            //Assert.IsType<KratosInlineResponse200>(response);
        }
    }
}
