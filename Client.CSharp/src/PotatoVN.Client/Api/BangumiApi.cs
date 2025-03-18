/*
 * PotatoVN.Server
 *
 * PotatoVN 同步服务器 最新更新：支持staff同步
 *
 * The version of the OpenAPI document: v1.2
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using PotatoVN.Client.Client;
using PotatoVN.Client.Model;

namespace PotatoVN.Client.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBangumiApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 使用code换取bgm token
        /// </summary>
        /// <exception cref="PotatoVN.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>BangumiToken</returns>
        BangumiToken BangumiOauthGet(string code);

        /// <summary>
        /// 使用code换取bgm token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PotatoVN.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>ApiResponse of BangumiToken</returns>
        ApiResponse<BangumiToken> BangumiOauthGetWithHttpInfo(string code);
        /// <summary>
        /// 使用refresh token换取bgm token
        /// </summary>
        /// <exception cref="PotatoVN.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshToken"></param>
        /// <returns>BangumiToken</returns>
        BangumiToken BangumiRefreshGet(string refreshToken);

        /// <summary>
        /// 使用refresh token换取bgm token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PotatoVN.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshToken"></param>
        /// <returns>ApiResponse of BangumiToken</returns>
        ApiResponse<BangumiToken> BangumiRefreshGetWithHttpInfo(string refreshToken);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBangumiApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 使用code换取bgm token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PotatoVN.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BangumiToken</returns>
        System.Threading.Tasks.Task<BangumiToken> BangumiOauthGetAsync(string code, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// 使用code换取bgm token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PotatoVN.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (BangumiToken)</returns>
        System.Threading.Tasks.Task<ApiResponse<BangumiToken>> BangumiOauthGetWithHttpInfoAsync(string code, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        /// <summary>
        /// 使用refresh token换取bgm token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PotatoVN.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshToken"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BangumiToken</returns>
        System.Threading.Tasks.Task<BangumiToken> BangumiRefreshGetAsync(string refreshToken, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// 使用refresh token换取bgm token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PotatoVN.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshToken"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (BangumiToken)</returns>
        System.Threading.Tasks.Task<ApiResponse<BangumiToken>> BangumiRefreshGetWithHttpInfoAsync(string refreshToken, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBangumiApi : IBangumiApiSync, IBangumiApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BangumiApi : IDisposable, IBangumiApi
    {
        private PotatoVN.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BangumiApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public BangumiApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BangumiApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public BangumiApi(string basePath)
        {
            this.Configuration = PotatoVN.Client.Client.Configuration.MergeConfigurations(
                PotatoVN.Client.Client.GlobalConfiguration.Instance,
                new PotatoVN.Client.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new PotatoVN.Client.Client.ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = PotatoVN.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BangumiApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public BangumiApi(PotatoVN.Client.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = PotatoVN.Client.Client.Configuration.MergeConfigurations(
                PotatoVN.Client.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new PotatoVN.Client.Client.ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = PotatoVN.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BangumiApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public BangumiApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BangumiApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public BangumiApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = PotatoVN.Client.Client.Configuration.MergeConfigurations(
                PotatoVN.Client.Client.GlobalConfiguration.Instance,
                new PotatoVN.Client.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new PotatoVN.Client.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = PotatoVN.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BangumiApi"/> class using Configuration object.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public BangumiApi(HttpClient client, PotatoVN.Client.Client.Configuration configuration, HttpClientHandler handler = null)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = PotatoVN.Client.Client.Configuration.MergeConfigurations(
                PotatoVN.Client.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new PotatoVN.Client.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = PotatoVN.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BangumiApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public BangumiApi(PotatoVN.Client.Client.ISynchronousClient client, PotatoVN.Client.Client.IAsynchronousClient asyncClient, PotatoVN.Client.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = PotatoVN.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            this.ApiClient?.Dispose();
        }

        /// <summary>
        /// Holds the ApiClient if created
        /// </summary>
        public PotatoVN.Client.Client.ApiClient ApiClient { get; set; } = null;

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public PotatoVN.Client.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public PotatoVN.Client.Client.ISynchronousClient Client { get; set; }

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
        public PotatoVN.Client.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public PotatoVN.Client.Client.ExceptionFactory ExceptionFactory
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
        /// 使用code换取bgm token 
        /// </summary>
        /// <exception cref="PotatoVN.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>BangumiToken</returns>
        public BangumiToken BangumiOauthGet(string code)
        {
            PotatoVN.Client.Client.ApiResponse<BangumiToken> localVarResponse = BangumiOauthGetWithHttpInfo(code);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 使用code换取bgm token 
        /// </summary>
        /// <exception cref="PotatoVN.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>ApiResponse of BangumiToken</returns>
        public PotatoVN.Client.Client.ApiResponse<BangumiToken> BangumiOauthGetWithHttpInfo(string code)
        {
            // verify the required parameter 'code' is set
            if (code == null)
                throw new PotatoVN.Client.Client.ApiException(400, "Missing required parameter 'code' when calling BangumiApi->BangumiOauthGet");

            PotatoVN.Client.Client.RequestOptions localVarRequestOptions = new PotatoVN.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = PotatoVN.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = PotatoVN.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(PotatoVN.Client.Client.ClientUtils.ParameterToMultiMap("", "code", code));


            // make the HTTP request
            var localVarResponse = this.Client.Get<BangumiToken>("/bangumi/oauth", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BangumiOauthGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// 使用code换取bgm token 
        /// </summary>
        /// <exception cref="PotatoVN.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BangumiToken</returns>
        public async System.Threading.Tasks.Task<BangumiToken> BangumiOauthGetAsync(string code, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            PotatoVN.Client.Client.ApiResponse<BangumiToken> localVarResponse = await BangumiOauthGetWithHttpInfoAsync(code, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 使用code换取bgm token 
        /// </summary>
        /// <exception cref="PotatoVN.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (BangumiToken)</returns>
        public async System.Threading.Tasks.Task<PotatoVN.Client.Client.ApiResponse<BangumiToken>> BangumiOauthGetWithHttpInfoAsync(string code, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            // verify the required parameter 'code' is set
            if (code == null)
                throw new PotatoVN.Client.Client.ApiException(400, "Missing required parameter 'code' when calling BangumiApi->BangumiOauthGet");


            PotatoVN.Client.Client.RequestOptions localVarRequestOptions = new PotatoVN.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };


            var localVarContentType = PotatoVN.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = PotatoVN.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(PotatoVN.Client.Client.ClientUtils.ParameterToMultiMap("", "code", code));


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<BangumiToken>("/bangumi/oauth", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BangumiOauthGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// 使用refresh token换取bgm token 
        /// </summary>
        /// <exception cref="PotatoVN.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshToken"></param>
        /// <returns>BangumiToken</returns>
        public BangumiToken BangumiRefreshGet(string refreshToken)
        {
            PotatoVN.Client.Client.ApiResponse<BangumiToken> localVarResponse = BangumiRefreshGetWithHttpInfo(refreshToken);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 使用refresh token换取bgm token 
        /// </summary>
        /// <exception cref="PotatoVN.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshToken"></param>
        /// <returns>ApiResponse of BangumiToken</returns>
        public PotatoVN.Client.Client.ApiResponse<BangumiToken> BangumiRefreshGetWithHttpInfo(string refreshToken)
        {
            // verify the required parameter 'refreshToken' is set
            if (refreshToken == null)
                throw new PotatoVN.Client.Client.ApiException(400, "Missing required parameter 'refreshToken' when calling BangumiApi->BangumiRefreshGet");

            PotatoVN.Client.Client.RequestOptions localVarRequestOptions = new PotatoVN.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = PotatoVN.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = PotatoVN.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(PotatoVN.Client.Client.ClientUtils.ParameterToMultiMap("", "refreshToken", refreshToken));


            // make the HTTP request
            var localVarResponse = this.Client.Get<BangumiToken>("/bangumi/refresh", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BangumiRefreshGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// 使用refresh token换取bgm token 
        /// </summary>
        /// <exception cref="PotatoVN.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshToken"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BangumiToken</returns>
        public async System.Threading.Tasks.Task<BangumiToken> BangumiRefreshGetAsync(string refreshToken, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            PotatoVN.Client.Client.ApiResponse<BangumiToken> localVarResponse = await BangumiRefreshGetWithHttpInfoAsync(refreshToken, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 使用refresh token换取bgm token 
        /// </summary>
        /// <exception cref="PotatoVN.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshToken"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (BangumiToken)</returns>
        public async System.Threading.Tasks.Task<PotatoVN.Client.Client.ApiResponse<BangumiToken>> BangumiRefreshGetWithHttpInfoAsync(string refreshToken, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            // verify the required parameter 'refreshToken' is set
            if (refreshToken == null)
                throw new PotatoVN.Client.Client.ApiException(400, "Missing required parameter 'refreshToken' when calling BangumiApi->BangumiRefreshGet");


            PotatoVN.Client.Client.RequestOptions localVarRequestOptions = new PotatoVN.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };


            var localVarContentType = PotatoVN.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = PotatoVN.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(PotatoVN.Client.Client.ClientUtils.ParameterToMultiMap("", "refreshToken", refreshToken));


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<BangumiToken>("/bangumi/refresh", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BangumiRefreshGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
