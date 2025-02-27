/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.3.8
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
    ///  Class for testing IdentityApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class IdentityApiTests : IDisposable
    {
        private IdentityApi instance;

        public IdentityApiTests()
        {
            instance = new IdentityApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IdentityApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' IdentityApi
            //Assert.IsType<IdentityApi>(instance);
        }

        /// <summary>
        /// Test BatchPatchIdentities
        /// </summary>
        [Fact]
        public void BatchPatchIdentitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //KratosPatchIdentitiesBody? kratosPatchIdentitiesBody = null;
            //var response = instance.BatchPatchIdentities(kratosPatchIdentitiesBody);
            //Assert.IsType<KratosBatchPatchIdentitiesResponse>(response);
        }

        /// <summary>
        /// Test CreateIdentity
        /// </summary>
        [Fact]
        public void CreateIdentityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //KratosCreateIdentityBody? kratosCreateIdentityBody = null;
            //var response = instance.CreateIdentity(kratosCreateIdentityBody);
            //Assert.IsType<KratosIdentity>(response);
        }

        /// <summary>
        /// Test CreateRecoveryCodeForIdentity
        /// </summary>
        [Fact]
        public void CreateRecoveryCodeForIdentityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //KratosCreateRecoveryCodeForIdentityBody? kratosCreateRecoveryCodeForIdentityBody = null;
            //var response = instance.CreateRecoveryCodeForIdentity(kratosCreateRecoveryCodeForIdentityBody);
            //Assert.IsType<KratosRecoveryCodeForIdentity>(response);
        }

        /// <summary>
        /// Test CreateRecoveryLinkForIdentity
        /// </summary>
        [Fact]
        public void CreateRecoveryLinkForIdentityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? returnTo = null;
            //KratosCreateRecoveryLinkForIdentityBody? kratosCreateRecoveryLinkForIdentityBody = null;
            //var response = instance.CreateRecoveryLinkForIdentity(returnTo, kratosCreateRecoveryLinkForIdentityBody);
            //Assert.IsType<KratosRecoveryLinkForIdentity>(response);
        }

        /// <summary>
        /// Test DeleteIdentity
        /// </summary>
        [Fact]
        public void DeleteIdentityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteIdentity(id);
        }

        /// <summary>
        /// Test DeleteIdentityCredentials
        /// </summary>
        [Fact]
        public void DeleteIdentityCredentialsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string type = null;
            //string? identifier = null;
            //instance.DeleteIdentityCredentials(id, type, identifier);
        }

        /// <summary>
        /// Test DeleteIdentitySessions
        /// </summary>
        [Fact]
        public void DeleteIdentitySessionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteIdentitySessions(id);
        }

        /// <summary>
        /// Test DisableSession
        /// </summary>
        [Fact]
        public void DisableSessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DisableSession(id);
        }

        /// <summary>
        /// Test ExtendSession
        /// </summary>
        [Fact]
        public void ExtendSessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ExtendSession(id);
            //Assert.IsType<KratosSession>(response);
        }

        /// <summary>
        /// Test GetIdentity
        /// </summary>
        [Fact]
        public void GetIdentityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? includeCredential = null;
            //var response = instance.GetIdentity(id, includeCredential);
            //Assert.IsType<KratosIdentity>(response);
        }

        /// <summary>
        /// Test GetIdentitySchema
        /// </summary>
        [Fact]
        public void GetIdentitySchemaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetIdentitySchema(id);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetSession
        /// </summary>
        [Fact]
        public void GetSessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? expand = null;
            //var response = instance.GetSession(id, expand);
            //Assert.IsType<KratosSession>(response);
        }

        /// <summary>
        /// Test ListIdentities
        /// </summary>
        [Fact]
        public void ListIdentitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? perPage = null;
            //long? page = null;
            //long? pageSize = null;
            //string? pageToken = null;
            //string? consistency = null;
            //List<string>? ids = null;
            //string? credentialsIdentifier = null;
            //string? previewCredentialsIdentifierSimilar = null;
            //List<string>? includeCredential = null;
            //string? organizationId = null;
            //var response = instance.ListIdentities(perPage, page, pageSize, pageToken, consistency, ids, credentialsIdentifier, previewCredentialsIdentifierSimilar, includeCredential, organizationId);
            //Assert.IsType<List<KratosIdentity>>(response);
        }

        /// <summary>
        /// Test ListIdentitySchemas
        /// </summary>
        [Fact]
        public void ListIdentitySchemasTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? perPage = null;
            //long? page = null;
            //long? pageSize = null;
            //string? pageToken = null;
            //var response = instance.ListIdentitySchemas(perPage, page, pageSize, pageToken);
            //Assert.IsType<List<KratosIdentitySchemaContainer>>(response);
        }

        /// <summary>
        /// Test ListIdentitySessions
        /// </summary>
        [Fact]
        public void ListIdentitySessionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //long? perPage = null;
            //long? page = null;
            //long? pageSize = null;
            //string? pageToken = null;
            //bool? active = null;
            //var response = instance.ListIdentitySessions(id, perPage, page, pageSize, pageToken, active);
            //Assert.IsType<List<KratosSession>>(response);
        }

        /// <summary>
        /// Test ListSessions
        /// </summary>
        [Fact]
        public void ListSessionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? pageSize = null;
            //string? pageToken = null;
            //bool? active = null;
            //List<string>? expand = null;
            //var response = instance.ListSessions(pageSize, pageToken, active, expand);
            //Assert.IsType<List<KratosSession>>(response);
        }

        /// <summary>
        /// Test PatchIdentity
        /// </summary>
        [Fact]
        public void PatchIdentityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<KratosJsonPatch>? kratosJsonPatch = null;
            //var response = instance.PatchIdentity(id, kratosJsonPatch);
            //Assert.IsType<KratosIdentity>(response);
        }

        /// <summary>
        /// Test UpdateIdentity
        /// </summary>
        [Fact]
        public void UpdateIdentityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //KratosUpdateIdentityBody? kratosUpdateIdentityBody = null;
            //var response = instance.UpdateIdentity(id, kratosUpdateIdentityBody);
            //Assert.IsType<KratosIdentity>(response);
        }
    }
}
