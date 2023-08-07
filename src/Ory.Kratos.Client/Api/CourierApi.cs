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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Ory.Kratos.Client.Client;
using Ory.Kratos.Client.Model;

namespace Ory.Kratos.Client.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICourierApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get a Message
        /// </summary>
        /// <remarks>
        /// Gets a specific messages by the given ID.
        /// </remarks>
        /// <exception cref="Ory.Kratos.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">MessageID is the ID of the message.</param>
        /// <returns>KratosMessage</returns>
        KratosMessage GetCourierMessage(string id);

        /// <summary>
        /// Get a Message
        /// </summary>
        /// <remarks>
        /// Gets a specific messages by the given ID.
        /// </remarks>
        /// <exception cref="Ory.Kratos.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">MessageID is the ID of the message.</param>
        /// <returns>ApiResponse of KratosMessage</returns>
        ApiResponse<KratosMessage> GetCourierMessageWithHttpInfo(string id);
        /// <summary>
        /// List Messages
        /// </summary>
        /// <remarks>
        /// Lists all messages by given status and recipient.
        /// </remarks>
        /// <exception cref="Ory.Kratos.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Items per Page  This is the number of items per page to return. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional, default to 250)</param>
        /// <param name="pageToken">Next Page Token  The next page token. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional)</param>
        /// <param name="status">Status filters out messages based on status. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <param name="recipient">Recipient filters out messages based on recipient. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <returns>List&lt;KratosMessage&gt;</returns>
        List<KratosMessage> ListCourierMessages(long? pageSize = default(long?), string pageToken = default(string), KratosCourierMessageStatus? status = default(KratosCourierMessageStatus?), string recipient = default(string));

        /// <summary>
        /// List Messages
        /// </summary>
        /// <remarks>
        /// Lists all messages by given status and recipient.
        /// </remarks>
        /// <exception cref="Ory.Kratos.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Items per Page  This is the number of items per page to return. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional, default to 250)</param>
        /// <param name="pageToken">Next Page Token  The next page token. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional)</param>
        /// <param name="status">Status filters out messages based on status. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <param name="recipient">Recipient filters out messages based on recipient. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <returns>ApiResponse of List&lt;KratosMessage&gt;</returns>
        ApiResponse<List<KratosMessage>> ListCourierMessagesWithHttpInfo(long? pageSize = default(long?), string pageToken = default(string), KratosCourierMessageStatus? status = default(KratosCourierMessageStatus?), string recipient = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICourierApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get a Message
        /// </summary>
        /// <remarks>
        /// Gets a specific messages by the given ID.
        /// </remarks>
        /// <exception cref="Ory.Kratos.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">MessageID is the ID of the message.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of KratosMessage</returns>
        System.Threading.Tasks.Task<KratosMessage> GetCourierMessageAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get a Message
        /// </summary>
        /// <remarks>
        /// Gets a specific messages by the given ID.
        /// </remarks>
        /// <exception cref="Ory.Kratos.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">MessageID is the ID of the message.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (KratosMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<KratosMessage>> GetCourierMessageWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// List Messages
        /// </summary>
        /// <remarks>
        /// Lists all messages by given status and recipient.
        /// </remarks>
        /// <exception cref="Ory.Kratos.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Items per Page  This is the number of items per page to return. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional, default to 250)</param>
        /// <param name="pageToken">Next Page Token  The next page token. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional)</param>
        /// <param name="status">Status filters out messages based on status. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <param name="recipient">Recipient filters out messages based on recipient. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;KratosMessage&gt;</returns>
        System.Threading.Tasks.Task<List<KratosMessage>> ListCourierMessagesAsync(long? pageSize = default(long?), string pageToken = default(string), KratosCourierMessageStatus? status = default(KratosCourierMessageStatus?), string recipient = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List Messages
        /// </summary>
        /// <remarks>
        /// Lists all messages by given status and recipient.
        /// </remarks>
        /// <exception cref="Ory.Kratos.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Items per Page  This is the number of items per page to return. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional, default to 250)</param>
        /// <param name="pageToken">Next Page Token  The next page token. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional)</param>
        /// <param name="status">Status filters out messages based on status. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <param name="recipient">Recipient filters out messages based on recipient. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;KratosMessage&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<KratosMessage>>> ListCourierMessagesWithHttpInfoAsync(long? pageSize = default(long?), string pageToken = default(string), KratosCourierMessageStatus? status = default(KratosCourierMessageStatus?), string recipient = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICourierApi : ICourierApiSync, ICourierApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CourierApi : ICourierApi
    {
        private Ory.Kratos.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CourierApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CourierApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CourierApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CourierApi(string basePath)
        {
            this.Configuration = Ory.Kratos.Client.Client.Configuration.MergeConfigurations(
                Ory.Kratos.Client.Client.GlobalConfiguration.Instance,
                new Ory.Kratos.Client.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Ory.Kratos.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Ory.Kratos.Client.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Ory.Kratos.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CourierApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CourierApi(Ory.Kratos.Client.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Ory.Kratos.Client.Client.Configuration.MergeConfigurations(
                Ory.Kratos.Client.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Ory.Kratos.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Ory.Kratos.Client.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Ory.Kratos.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CourierApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public CourierApi(Ory.Kratos.Client.Client.ISynchronousClient client, Ory.Kratos.Client.Client.IAsynchronousClient asyncClient, Ory.Kratos.Client.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Ory.Kratos.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Ory.Kratos.Client.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Ory.Kratos.Client.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Ory.Kratos.Client.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Ory.Kratos.Client.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get a Message Gets a specific messages by the given ID.
        /// </summary>
        /// <exception cref="Ory.Kratos.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">MessageID is the ID of the message.</param>
        /// <returns>KratosMessage</returns>
        public KratosMessage GetCourierMessage(string id)
        {
            Ory.Kratos.Client.Client.ApiResponse<KratosMessage> localVarResponse = GetCourierMessageWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Message Gets a specific messages by the given ID.
        /// </summary>
        /// <exception cref="Ory.Kratos.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">MessageID is the ID of the message.</param>
        /// <returns>ApiResponse of KratosMessage</returns>
        public Ory.Kratos.Client.Client.ApiResponse<KratosMessage> GetCourierMessageWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Ory.Kratos.Client.Client.ApiException(400, "Missing required parameter 'id' when calling CourierApi->GetCourierMessage");
            }

            Ory.Kratos.Client.Client.RequestOptions localVarRequestOptions = new Ory.Kratos.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ory.Kratos.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Ory.Kratos.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", Ory.Kratos.Client.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (oryAccessToken) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<KratosMessage>("/admin/courier/messages/{id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCourierMessage", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a Message Gets a specific messages by the given ID.
        /// </summary>
        /// <exception cref="Ory.Kratos.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">MessageID is the ID of the message.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of KratosMessage</returns>
        public async System.Threading.Tasks.Task<KratosMessage> GetCourierMessageAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Ory.Kratos.Client.Client.ApiResponse<KratosMessage> localVarResponse = await GetCourierMessageWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Message Gets a specific messages by the given ID.
        /// </summary>
        /// <exception cref="Ory.Kratos.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">MessageID is the ID of the message.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (KratosMessage)</returns>
        public async System.Threading.Tasks.Task<Ory.Kratos.Client.Client.ApiResponse<KratosMessage>> GetCourierMessageWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Ory.Kratos.Client.Client.ApiException(400, "Missing required parameter 'id' when calling CourierApi->GetCourierMessage");
            }


            Ory.Kratos.Client.Client.RequestOptions localVarRequestOptions = new Ory.Kratos.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ory.Kratos.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Ory.Kratos.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", Ory.Kratos.Client.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (oryAccessToken) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<KratosMessage>("/admin/courier/messages/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCourierMessage", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List Messages Lists all messages by given status and recipient.
        /// </summary>
        /// <exception cref="Ory.Kratos.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Items per Page  This is the number of items per page to return. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional, default to 250)</param>
        /// <param name="pageToken">Next Page Token  The next page token. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional)</param>
        /// <param name="status">Status filters out messages based on status. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <param name="recipient">Recipient filters out messages based on recipient. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <returns>List&lt;KratosMessage&gt;</returns>
        public List<KratosMessage> ListCourierMessages(long? pageSize = default(long?), string pageToken = default(string), KratosCourierMessageStatus? status = default(KratosCourierMessageStatus?), string recipient = default(string))
        {
            Ory.Kratos.Client.Client.ApiResponse<List<KratosMessage>> localVarResponse = ListCourierMessagesWithHttpInfo(pageSize, pageToken, status, recipient);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List Messages Lists all messages by given status and recipient.
        /// </summary>
        /// <exception cref="Ory.Kratos.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Items per Page  This is the number of items per page to return. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional, default to 250)</param>
        /// <param name="pageToken">Next Page Token  The next page token. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional)</param>
        /// <param name="status">Status filters out messages based on status. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <param name="recipient">Recipient filters out messages based on recipient. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <returns>ApiResponse of List&lt;KratosMessage&gt;</returns>
        public Ory.Kratos.Client.Client.ApiResponse<List<KratosMessage>> ListCourierMessagesWithHttpInfo(long? pageSize = default(long?), string pageToken = default(string), KratosCourierMessageStatus? status = default(KratosCourierMessageStatus?), string recipient = default(string))
        {
            Ory.Kratos.Client.Client.RequestOptions localVarRequestOptions = new Ory.Kratos.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ory.Kratos.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Ory.Kratos.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(Ory.Kratos.Client.Client.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
            }
            if (pageToken != null)
            {
                localVarRequestOptions.QueryParameters.Add(Ory.Kratos.Client.Client.ClientUtils.ParameterToMultiMap("", "page_token", pageToken));
            }
            if (status != null)
            {
                localVarRequestOptions.QueryParameters.Add(Ory.Kratos.Client.Client.ClientUtils.ParameterToMultiMap("", "status", status));
            }
            if (recipient != null)
            {
                localVarRequestOptions.QueryParameters.Add(Ory.Kratos.Client.Client.ClientUtils.ParameterToMultiMap("", "recipient", recipient));
            }

            // authentication (oryAccessToken) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<KratosMessage>>("/admin/courier/messages", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListCourierMessages", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List Messages Lists all messages by given status and recipient.
        /// </summary>
        /// <exception cref="Ory.Kratos.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Items per Page  This is the number of items per page to return. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional, default to 250)</param>
        /// <param name="pageToken">Next Page Token  The next page token. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional)</param>
        /// <param name="status">Status filters out messages based on status. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <param name="recipient">Recipient filters out messages based on recipient. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;KratosMessage&gt;</returns>
        public async System.Threading.Tasks.Task<List<KratosMessage>> ListCourierMessagesAsync(long? pageSize = default(long?), string pageToken = default(string), KratosCourierMessageStatus? status = default(KratosCourierMessageStatus?), string recipient = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Ory.Kratos.Client.Client.ApiResponse<List<KratosMessage>> localVarResponse = await ListCourierMessagesWithHttpInfoAsync(pageSize, pageToken, status, recipient, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List Messages Lists all messages by given status and recipient.
        /// </summary>
        /// <exception cref="Ory.Kratos.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Items per Page  This is the number of items per page to return. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional, default to 250)</param>
        /// <param name="pageToken">Next Page Token  The next page token. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional)</param>
        /// <param name="status">Status filters out messages based on status. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <param name="recipient">Recipient filters out messages based on recipient. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;KratosMessage&gt;)</returns>
        public async System.Threading.Tasks.Task<Ory.Kratos.Client.Client.ApiResponse<List<KratosMessage>>> ListCourierMessagesWithHttpInfoAsync(long? pageSize = default(long?), string pageToken = default(string), KratosCourierMessageStatus? status = default(KratosCourierMessageStatus?), string recipient = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Ory.Kratos.Client.Client.RequestOptions localVarRequestOptions = new Ory.Kratos.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ory.Kratos.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Ory.Kratos.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(Ory.Kratos.Client.Client.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
            }
            if (pageToken != null)
            {
                localVarRequestOptions.QueryParameters.Add(Ory.Kratos.Client.Client.ClientUtils.ParameterToMultiMap("", "page_token", pageToken));
            }
            if (status != null)
            {
                localVarRequestOptions.QueryParameters.Add(Ory.Kratos.Client.Client.ClientUtils.ParameterToMultiMap("", "status", status));
            }
            if (recipient != null)
            {
                localVarRequestOptions.QueryParameters.Add(Ory.Kratos.Client.Client.ClientUtils.ParameterToMultiMap("", "recipient", recipient));
            }

            // authentication (oryAccessToken) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<KratosMessage>>("/admin/courier/messages", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListCourierMessages", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}