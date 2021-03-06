/* 
 * Telstra Messaging API
 *
 *  The Telstra SMS Messaging API allows your applications to send and receive SMS text messages from Australia's leading network operator.  It also allows your application to track the delivery status of both sent and received SMS messages. 
 *
 * OpenAPI spec version: 2.2.4
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using com.telstra.messaging.Client;
using com.telstra.messaging.Model;

namespace com.telstra.messaging.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// AuthGeneratetokenPost
        /// </summary>
        /// <remarks>
        /// generate auth token
        /// </remarks>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oAuthClientId"></param>
        /// <param name="oAuthClientSecret"></param>
        /// <returns>AuthgeneratetokenpostResponse</returns>
        AuthgeneratetokenpostResponse OauthTokenPost (string oAuthClientId, string oAuthClientSecret);

        /// <summary>
        /// AuthGeneratetokenPost
        /// </summary>
        /// <remarks>
        /// generate auth token
        /// </remarks>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oAuthClientId"></param>
        /// <param name="oAuthClientSecret"></param>
        /// <returns>ApiResponse of AuthgeneratetokenpostResponse</returns>
        ApiResponse<AuthgeneratetokenpostResponse> OauthTokenPostWithHttpInfo (string oAuthClientId, string oAuthClientSecret);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// AuthGeneratetokenPost
        /// </summary>
        /// <remarks>
        /// generate auth token
        /// </remarks>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oAuthClientId"></param>
        /// <param name="oAuthClientSecret"></param>
        /// <returns>Task of AuthgeneratetokenpostResponse</returns>
        System.Threading.Tasks.Task<AuthgeneratetokenpostResponse> OauthTokenPostAsync (string oAuthClientId, string oAuthClientSecret);

        /// <summary>
        /// AuthGeneratetokenPost
        /// </summary>
        /// <remarks>
        /// generate auth token
        /// </remarks>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oAuthClientId"></param>
        /// <param name="oAuthClientSecret"></param>
        /// <returns>Task of ApiResponse (AuthgeneratetokenpostResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuthgeneratetokenpostResponse>> OauthTokenPostAsyncWithHttpInfo (string oAuthClientId, string oAuthClientSecret);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuthApi : IAuthApi
    {
        private com.telstra.messaging.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = com.telstra.messaging.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = com.telstra.messaging.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public com.telstra.messaging.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// AuthGeneratetokenPost generate auth token
        /// </summary>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oAuthClientId"></param>
        /// <param name="oAuthClientSecret"></param>
        /// <returns>AuthgeneratetokenpostResponse</returns>
        public AuthgeneratetokenpostResponse OauthTokenPost (string oAuthClientId, string oAuthClientSecret)
        {
             ApiResponse<AuthgeneratetokenpostResponse> localVarResponse = OauthTokenPostWithHttpInfo(oAuthClientId, oAuthClientSecret);
             return localVarResponse.Data;
        }

        /// <summary>
        /// AuthGeneratetokenPost generate auth token
        /// </summary>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oAuthClientId"></param>
        /// <param name="oAuthClientSecret"></param>
        /// <returns>ApiResponse of AuthgeneratetokenpostResponse</returns>
        public ApiResponse< AuthgeneratetokenpostResponse > OauthTokenPostWithHttpInfo (string oAuthClientId, string oAuthClientSecret)
        {
            // verify the required parameter 'oAuthClientId' is set
            if (oAuthClientId == null)
                throw new ApiException(400, "Missing required parameter 'oAuthClientId' when calling AuthApi->OauthTokenPost");
            // verify the required parameter 'oAuthClientSecret' is set
            if (oAuthClientSecret == null)
                throw new ApiException(400, "Missing required parameter 'oAuthClientSecret' when calling AuthApi->OauthTokenPost");

            var localVarPath = "/oauth/token";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (oAuthClientId != null) localVarFormParams.Add("oAuthClientId", Configuration.ApiClient.ParameterToString(oAuthClientId)); // form parameter
            if (oAuthClientSecret != null) localVarFormParams.Add("oAuthClientSecret", Configuration.ApiClient.ParameterToString(oAuthClientSecret)); // form parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OauthTokenPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AuthgeneratetokenpostResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AuthgeneratetokenpostResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthgeneratetokenpostResponse)));
        }

        /// <summary>
        /// AuthGeneratetokenPost generate auth token
        /// </summary>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oAuthClientId"></param>
        /// <param name="oAuthClientSecret"></param>
        /// <returns>Task of AuthgeneratetokenpostResponse</returns>
        public async System.Threading.Tasks.Task<AuthgeneratetokenpostResponse> OauthTokenPostAsync (string oAuthClientId, string oAuthClientSecret)
        {
             ApiResponse<AuthgeneratetokenpostResponse> localVarResponse = await OauthTokenPostAsyncWithHttpInfo(oAuthClientId, oAuthClientSecret);
             return localVarResponse.Data;

        }

        /// <summary>
        /// AuthGeneratetokenPost generate auth token
        /// </summary>
        /// <exception cref="com.telstra.messaging.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oAuthClientId"></param>
        /// <param name="oAuthClientSecret"></param>
        /// <returns>Task of ApiResponse (AuthgeneratetokenpostResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AuthgeneratetokenpostResponse>> OauthTokenPostAsyncWithHttpInfo (string oAuthClientId, string oAuthClientSecret)
        {
            // verify the required parameter 'oAuthClientId' is set
            if (oAuthClientId == null)
                throw new ApiException(400, "Missing required parameter 'oAuthClientId' when calling AuthApi->OauthTokenPost");
            // verify the required parameter 'oAuthClientSecret' is set
            if (oAuthClientSecret == null)
                throw new ApiException(400, "Missing required parameter 'oAuthClientSecret' when calling AuthApi->OauthTokenPost");

            var localVarPath = "/oauth/token";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (oAuthClientId != null) localVarFormParams.Add("oAuthClientId", Configuration.ApiClient.ParameterToString(oAuthClientId)); // form parameter
            if (oAuthClientSecret != null) localVarFormParams.Add("oAuthClientSecret", Configuration.ApiClient.ParameterToString(oAuthClientSecret)); // form parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OauthTokenPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AuthgeneratetokenpostResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AuthgeneratetokenpostResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthgeneratetokenpostResponse)));
        }

    }
}
