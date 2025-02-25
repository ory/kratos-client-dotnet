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
    ///  Class for testing FrontendApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class FrontendApiTests : IDisposable
    {
        private FrontendApi instance;

        public FrontendApiTests()
        {
            instance = new FrontendApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FrontendApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' FrontendApi
            //Assert.IsType<FrontendApi>(instance);
        }

        /// <summary>
        /// Test CreateBrowserLoginFlow
        /// </summary>
        [Fact]
        public void CreateBrowserLoginFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? refresh = null;
            //string? aal = null;
            //string? returnTo = null;
            //string? cookie = null;
            //string? loginChallenge = null;
            //string? organization = null;
            //string? via = null;
            //var response = instance.CreateBrowserLoginFlow(refresh, aal, returnTo, cookie, loginChallenge, organization, via);
            //Assert.IsType<KratosLoginFlow>(response);
        }

        /// <summary>
        /// Test CreateBrowserLogoutFlow
        /// </summary>
        [Fact]
        public void CreateBrowserLogoutFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? cookie = null;
            //string? returnTo = null;
            //var response = instance.CreateBrowserLogoutFlow(cookie, returnTo);
            //Assert.IsType<KratosLogoutFlow>(response);
        }

        /// <summary>
        /// Test CreateBrowserRecoveryFlow
        /// </summary>
        [Fact]
        public void CreateBrowserRecoveryFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? returnTo = null;
            //var response = instance.CreateBrowserRecoveryFlow(returnTo);
            //Assert.IsType<KratosRecoveryFlow>(response);
        }

        /// <summary>
        /// Test CreateBrowserRegistrationFlow
        /// </summary>
        [Fact]
        public void CreateBrowserRegistrationFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? returnTo = null;
            //string? loginChallenge = null;
            //string? afterVerificationReturnTo = null;
            //string? organization = null;
            //var response = instance.CreateBrowserRegistrationFlow(returnTo, loginChallenge, afterVerificationReturnTo, organization);
            //Assert.IsType<KratosRegistrationFlow>(response);
        }

        /// <summary>
        /// Test CreateBrowserSettingsFlow
        /// </summary>
        [Fact]
        public void CreateBrowserSettingsFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? returnTo = null;
            //string? cookie = null;
            //var response = instance.CreateBrowserSettingsFlow(returnTo, cookie);
            //Assert.IsType<KratosSettingsFlow>(response);
        }

        /// <summary>
        /// Test CreateBrowserVerificationFlow
        /// </summary>
        [Fact]
        public void CreateBrowserVerificationFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? returnTo = null;
            //var response = instance.CreateBrowserVerificationFlow(returnTo);
            //Assert.IsType<KratosVerificationFlow>(response);
        }

        /// <summary>
        /// Test CreateFedcmFlow
        /// </summary>
        [Fact]
        public void CreateFedcmFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.CreateFedcmFlow();
            //Assert.IsType<KratosCreateFedcmFlowResponse>(response);
        }

        /// <summary>
        /// Test CreateNativeLoginFlow
        /// </summary>
        [Fact]
        public void CreateNativeLoginFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? refresh = null;
            //string? aal = null;
            //string? xSessionToken = null;
            //bool? returnSessionTokenExchangeCode = null;
            //string? returnTo = null;
            //string? organization = null;
            //string? via = null;
            //var response = instance.CreateNativeLoginFlow(refresh, aal, xSessionToken, returnSessionTokenExchangeCode, returnTo, organization, via);
            //Assert.IsType<KratosLoginFlow>(response);
        }

        /// <summary>
        /// Test CreateNativeRecoveryFlow
        /// </summary>
        [Fact]
        public void CreateNativeRecoveryFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.CreateNativeRecoveryFlow();
            //Assert.IsType<KratosRecoveryFlow>(response);
        }

        /// <summary>
        /// Test CreateNativeRegistrationFlow
        /// </summary>
        [Fact]
        public void CreateNativeRegistrationFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? returnSessionTokenExchangeCode = null;
            //string? returnTo = null;
            //string? organization = null;
            //var response = instance.CreateNativeRegistrationFlow(returnSessionTokenExchangeCode, returnTo, organization);
            //Assert.IsType<KratosRegistrationFlow>(response);
        }

        /// <summary>
        /// Test CreateNativeSettingsFlow
        /// </summary>
        [Fact]
        public void CreateNativeSettingsFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? xSessionToken = null;
            //var response = instance.CreateNativeSettingsFlow(xSessionToken);
            //Assert.IsType<KratosSettingsFlow>(response);
        }

        /// <summary>
        /// Test CreateNativeVerificationFlow
        /// </summary>
        [Fact]
        public void CreateNativeVerificationFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? returnTo = null;
            //var response = instance.CreateNativeVerificationFlow(returnTo);
            //Assert.IsType<KratosVerificationFlow>(response);
        }

        /// <summary>
        /// Test DisableMyOtherSessions
        /// </summary>
        [Fact]
        public void DisableMyOtherSessionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? xSessionToken = null;
            //string? cookie = null;
            //var response = instance.DisableMyOtherSessions(xSessionToken, cookie);
            //Assert.IsType<KratosDeleteMySessionsCount>(response);
        }

        /// <summary>
        /// Test DisableMySession
        /// </summary>
        [Fact]
        public void DisableMySessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string? xSessionToken = null;
            //string? cookie = null;
            //instance.DisableMySession(id, xSessionToken, cookie);
        }

        /// <summary>
        /// Test ExchangeSessionToken
        /// </summary>
        [Fact]
        public void ExchangeSessionTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string initCode = null;
            //string returnToCode = null;
            //var response = instance.ExchangeSessionToken(initCode, returnToCode);
            //Assert.IsType<KratosSuccessfulNativeLogin>(response);
        }

        /// <summary>
        /// Test GetFlowError
        /// </summary>
        [Fact]
        public void GetFlowErrorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetFlowError(id);
            //Assert.IsType<KratosFlowError>(response);
        }

        /// <summary>
        /// Test GetLoginFlow
        /// </summary>
        [Fact]
        public void GetLoginFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string? cookie = null;
            //var response = instance.GetLoginFlow(id, cookie);
            //Assert.IsType<KratosLoginFlow>(response);
        }

        /// <summary>
        /// Test GetRecoveryFlow
        /// </summary>
        [Fact]
        public void GetRecoveryFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string? cookie = null;
            //var response = instance.GetRecoveryFlow(id, cookie);
            //Assert.IsType<KratosRecoveryFlow>(response);
        }

        /// <summary>
        /// Test GetRegistrationFlow
        /// </summary>
        [Fact]
        public void GetRegistrationFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string? cookie = null;
            //var response = instance.GetRegistrationFlow(id, cookie);
            //Assert.IsType<KratosRegistrationFlow>(response);
        }

        /// <summary>
        /// Test GetSettingsFlow
        /// </summary>
        [Fact]
        public void GetSettingsFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string? xSessionToken = null;
            //string? cookie = null;
            //var response = instance.GetSettingsFlow(id, xSessionToken, cookie);
            //Assert.IsType<KratosSettingsFlow>(response);
        }

        /// <summary>
        /// Test GetVerificationFlow
        /// </summary>
        [Fact]
        public void GetVerificationFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string? cookie = null;
            //var response = instance.GetVerificationFlow(id, cookie);
            //Assert.IsType<KratosVerificationFlow>(response);
        }

        /// <summary>
        /// Test GetWebAuthnJavaScript
        /// </summary>
        [Fact]
        public void GetWebAuthnJavaScriptTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetWebAuthnJavaScript();
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test ListMySessions
        /// </summary>
        [Fact]
        public void ListMySessionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? perPage = null;
            //long? page = null;
            //long? pageSize = null;
            //string? pageToken = null;
            //string? xSessionToken = null;
            //string? cookie = null;
            //var response = instance.ListMySessions(perPage, page, pageSize, pageToken, xSessionToken, cookie);
            //Assert.IsType<List<KratosSession>>(response);
        }

        /// <summary>
        /// Test PerformNativeLogout
        /// </summary>
        [Fact]
        public void PerformNativeLogoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //KratosPerformNativeLogoutBody kratosPerformNativeLogoutBody = null;
            //instance.PerformNativeLogout(kratosPerformNativeLogoutBody);
        }

        /// <summary>
        /// Test ToSession
        /// </summary>
        [Fact]
        public void ToSessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? xSessionToken = null;
            //string? cookie = null;
            //string? tokenizeAs = null;
            //var response = instance.ToSession(xSessionToken, cookie, tokenizeAs);
            //Assert.IsType<KratosSession>(response);
        }

        /// <summary>
        /// Test UpdateFedcmFlow
        /// </summary>
        [Fact]
        public void UpdateFedcmFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //KratosUpdateFedcmFlowBody kratosUpdateFedcmFlowBody = null;
            //var response = instance.UpdateFedcmFlow(kratosUpdateFedcmFlowBody);
            //Assert.IsType<KratosSuccessfulNativeLogin>(response);
        }

        /// <summary>
        /// Test UpdateLoginFlow
        /// </summary>
        [Fact]
        public void UpdateLoginFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string flow = null;
            //KratosUpdateLoginFlowBody kratosUpdateLoginFlowBody = null;
            //string? xSessionToken = null;
            //string? cookie = null;
            //var response = instance.UpdateLoginFlow(flow, kratosUpdateLoginFlowBody, xSessionToken, cookie);
            //Assert.IsType<KratosSuccessfulNativeLogin>(response);
        }

        /// <summary>
        /// Test UpdateLogoutFlow
        /// </summary>
        [Fact]
        public void UpdateLogoutFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? token = null;
            //string? returnTo = null;
            //string? cookie = null;
            //instance.UpdateLogoutFlow(token, returnTo, cookie);
        }

        /// <summary>
        /// Test UpdateRecoveryFlow
        /// </summary>
        [Fact]
        public void UpdateRecoveryFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string flow = null;
            //KratosUpdateRecoveryFlowBody kratosUpdateRecoveryFlowBody = null;
            //string? token = null;
            //string? cookie = null;
            //var response = instance.UpdateRecoveryFlow(flow, kratosUpdateRecoveryFlowBody, token, cookie);
            //Assert.IsType<KratosRecoveryFlow>(response);
        }

        /// <summary>
        /// Test UpdateRegistrationFlow
        /// </summary>
        [Fact]
        public void UpdateRegistrationFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string flow = null;
            //KratosUpdateRegistrationFlowBody kratosUpdateRegistrationFlowBody = null;
            //string? cookie = null;
            //var response = instance.UpdateRegistrationFlow(flow, kratosUpdateRegistrationFlowBody, cookie);
            //Assert.IsType<KratosSuccessfulNativeRegistration>(response);
        }

        /// <summary>
        /// Test UpdateSettingsFlow
        /// </summary>
        [Fact]
        public void UpdateSettingsFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string flow = null;
            //KratosUpdateSettingsFlowBody kratosUpdateSettingsFlowBody = null;
            //string? xSessionToken = null;
            //string? cookie = null;
            //var response = instance.UpdateSettingsFlow(flow, kratosUpdateSettingsFlowBody, xSessionToken, cookie);
            //Assert.IsType<KratosSettingsFlow>(response);
        }

        /// <summary>
        /// Test UpdateVerificationFlow
        /// </summary>
        [Fact]
        public void UpdateVerificationFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string flow = null;
            //KratosUpdateVerificationFlowBody kratosUpdateVerificationFlowBody = null;
            //string? token = null;
            //string? cookie = null;
            //var response = instance.UpdateVerificationFlow(flow, kratosUpdateVerificationFlowBody, token, cookie);
            //Assert.IsType<KratosVerificationFlow>(response);
        }
    }
}
