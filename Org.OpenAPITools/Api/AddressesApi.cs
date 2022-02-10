/*
 * Assembly API
 *
 * Assembly (formely PromisePay) is a powerful payments engine custom-built for platforms and marketplaces.
 *
 * The version of the OpenAPI document: 2.0
 * Contact: support@assemblypayments.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using AssemblyPay.Sdk.Client;
using AssemblyPay.Sdk.Model;
using System;

namespace AssemblyPay.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAddressesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Show Address
        /// </summary>
        /// <remarks>
        /// Show details of a specific Address using a given address &#x60;:id&#x60;.
        /// </remarks>
        /// <exception cref="AssemblyPay.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Address ID</param>
        /// <returns>Address</returns>
        Address ShowAddress(string id);

        /// <summary>
        /// Show Address
        /// </summary>
        /// <remarks>
        /// Show details of a specific Address using a given address &#x60;:id&#x60;.
        /// </remarks>
        /// <exception cref="AssemblyPay.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Address ID</param>
        /// <returns>ApiResponse of Address</returns>
        ApiResponse<Address> ShowAddressWithHttpInfo(string id);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAddressesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Show Address
        /// </summary>
        /// <remarks>
        /// Show details of a specific Address using a given address &#x60;:id&#x60;.
        /// </remarks>
        /// <exception cref="AssemblyPay.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Address ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Address</returns>
        System.Threading.Tasks.Task<Address> ShowAddressAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Show Address
        /// </summary>
        /// <remarks>
        /// Show details of a specific Address using a given address &#x60;:id&#x60;.
        /// </remarks>
        /// <exception cref="AssemblyPay.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Address ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Address)</returns>
        System.Threading.Tasks.Task<ApiResponse<Address>> ShowAddressWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAddressesApi : IAddressesApiSync, IAddressesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AddressesApi : IAddressesApi
    {
        private AssemblyPay.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AddressesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AddressesApi(string basePath)
        {
            this.Configuration = AssemblyPay.Sdk.Client.Configuration.MergeConfigurations(
                AssemblyPay.Sdk.Client.GlobalConfiguration.Instance,
                new AssemblyPay.Sdk.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AssemblyPay.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new AssemblyPay.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AssemblyPay.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AddressesApi(AssemblyPay.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = AssemblyPay.Sdk.Client.Configuration.MergeConfigurations(
                AssemblyPay.Sdk.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new AssemblyPay.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new AssemblyPay.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = AssemblyPay.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AddressesApi(AssemblyPay.Sdk.Client.ISynchronousClient client, AssemblyPay.Sdk.Client.IAsynchronousClient asyncClient, AssemblyPay.Sdk.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = AssemblyPay.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public AssemblyPay.Sdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public AssemblyPay.Sdk.Client.ISynchronousClient Client { get; set; }

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
        public AssemblyPay.Sdk.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public AssemblyPay.Sdk.Client.ExceptionFactory ExceptionFactory
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
        /// Show Address Show details of a specific Address using a given address &#x60;:id&#x60;.
        /// </summary>
        /// <exception cref="AssemblyPay.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Address ID</param>
        /// <returns>Address</returns>
        public Address ShowAddress(string id)
        {
            AssemblyPay.Sdk.Client.ApiResponse<Address> localVarResponse = ShowAddressWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Show Address Show details of a specific Address using a given address &#x60;:id&#x60;.
        /// </summary>
        /// <exception cref="AssemblyPay.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Address ID</param>
        /// <returns>ApiResponse of Address</returns>
        public AssemblyPay.Sdk.Client.ApiResponse<Address> ShowAddressWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new AssemblyPay.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling AddressesApi->ShowAddress");
            }

            AssemblyPay.Sdk.Client.RequestOptions localVarRequestOptions = new AssemblyPay.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = AssemblyPay.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = AssemblyPay.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", AssemblyPay.Sdk.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + AssemblyPay.Sdk.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (oAuth2ClientCredentials) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<Address>("/addresses/{id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ShowAddress", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Show Address Show details of a specific Address using a given address &#x60;:id&#x60;.
        /// </summary>
        /// <exception cref="AssemblyPay.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Address ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Address</returns>
        public async System.Threading.Tasks.Task<Address> ShowAddressAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            AssemblyPay.Sdk.Client.ApiResponse<Address> localVarResponse = await ShowAddressWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Show Address Show details of a specific Address using a given address &#x60;:id&#x60;.
        /// </summary>
        /// <exception cref="AssemblyPay.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Address ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Address)</returns>
        public async System.Threading.Tasks.Task<AssemblyPay.Sdk.Client.ApiResponse<Address>> ShowAddressWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new AssemblyPay.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling AddressesApi->ShowAddress");
            }


            AssemblyPay.Sdk.Client.RequestOptions localVarRequestOptions = new AssemblyPay.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = AssemblyPay.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = AssemblyPay.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", AssemblyPay.Sdk.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + AssemblyPay.Sdk.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (oAuth2ClientCredentials) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<Address>("/addresses/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ShowAddress", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
