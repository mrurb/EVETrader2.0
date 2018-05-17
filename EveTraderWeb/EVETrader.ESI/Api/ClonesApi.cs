/* 
 * EVE Swagger Interface
 *
 * An OpenAPI for EVE Online
 *
 * OpenAPI spec version: 0.8.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IClonesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get clones
        /// </summary>
        /// <remarks>
        /// A list of the character&#39;s clones  - --  This route is cached for up to 120 seconds
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag (optional)</param>
        /// <param name="token">Access token to use if unable to set a header (optional)</param>
        /// <param name="userAgent">Client identifier, takes precedence over headers (optional)</param>
        /// <param name="xUserAgent">Client identifier, takes precedence over User-Agent (optional)</param>
        /// <returns>GetCharactersCharacterIdClonesOk</returns>
        GetCharactersCharacterIdClonesOk GetCharactersCharacterIdClones (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null, string userAgent = null, string xUserAgent = null);

        /// <summary>
        /// Get clones
        /// </summary>
        /// <remarks>
        /// A list of the character&#39;s clones  - --  This route is cached for up to 120 seconds
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag (optional)</param>
        /// <param name="token">Access token to use if unable to set a header (optional)</param>
        /// <param name="userAgent">Client identifier, takes precedence over headers (optional)</param>
        /// <param name="xUserAgent">Client identifier, takes precedence over User-Agent (optional)</param>
        /// <returns>ApiResponse of GetCharactersCharacterIdClonesOk</returns>
        ApiResponse<GetCharactersCharacterIdClonesOk> GetCharactersCharacterIdClonesWithHttpInfo (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null, string userAgent = null, string xUserAgent = null);
        /// <summary>
        /// Get active implants
        /// </summary>
        /// <remarks>
        /// Return implants on the active clone of a character  - --  This route is cached for up to 300 seconds
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag (optional)</param>
        /// <param name="token">Access token to use if unable to set a header (optional)</param>
        /// <param name="userAgent">Client identifier, takes precedence over headers (optional)</param>
        /// <param name="xUserAgent">Client identifier, takes precedence over User-Agent (optional)</param>
        /// <returns>List&lt;int?&gt;</returns>
        List<int?> GetCharactersCharacterIdImplants (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null, string userAgent = null, string xUserAgent = null);

        /// <summary>
        /// Get active implants
        /// </summary>
        /// <remarks>
        /// Return implants on the active clone of a character  - --  This route is cached for up to 300 seconds
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag (optional)</param>
        /// <param name="token">Access token to use if unable to set a header (optional)</param>
        /// <param name="userAgent">Client identifier, takes precedence over headers (optional)</param>
        /// <param name="xUserAgent">Client identifier, takes precedence over User-Agent (optional)</param>
        /// <returns>ApiResponse of List&lt;int?&gt;</returns>
        ApiResponse<List<int?>> GetCharactersCharacterIdImplantsWithHttpInfo (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null, string userAgent = null, string xUserAgent = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get clones
        /// </summary>
        /// <remarks>
        /// A list of the character&#39;s clones  - --  This route is cached for up to 120 seconds
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag (optional)</param>
        /// <param name="token">Access token to use if unable to set a header (optional)</param>
        /// <param name="userAgent">Client identifier, takes precedence over headers (optional)</param>
        /// <param name="xUserAgent">Client identifier, takes precedence over User-Agent (optional)</param>
        /// <returns>Task of GetCharactersCharacterIdClonesOk</returns>
        System.Threading.Tasks.Task<GetCharactersCharacterIdClonesOk> GetCharactersCharacterIdClonesAsync (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null, string userAgent = null, string xUserAgent = null);

        /// <summary>
        /// Get clones
        /// </summary>
        /// <remarks>
        /// A list of the character&#39;s clones  - --  This route is cached for up to 120 seconds
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag (optional)</param>
        /// <param name="token">Access token to use if unable to set a header (optional)</param>
        /// <param name="userAgent">Client identifier, takes precedence over headers (optional)</param>
        /// <param name="xUserAgent">Client identifier, takes precedence over User-Agent (optional)</param>
        /// <returns>Task of ApiResponse (GetCharactersCharacterIdClonesOk)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetCharactersCharacterIdClonesOk>> GetCharactersCharacterIdClonesAsyncWithHttpInfo (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null, string userAgent = null, string xUserAgent = null);
        /// <summary>
        /// Get active implants
        /// </summary>
        /// <remarks>
        /// Return implants on the active clone of a character  - --  This route is cached for up to 300 seconds
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag (optional)</param>
        /// <param name="token">Access token to use if unable to set a header (optional)</param>
        /// <param name="userAgent">Client identifier, takes precedence over headers (optional)</param>
        /// <param name="xUserAgent">Client identifier, takes precedence over User-Agent (optional)</param>
        /// <returns>Task of List&lt;int?&gt;</returns>
        System.Threading.Tasks.Task<List<int?>> GetCharactersCharacterIdImplantsAsync (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null, string userAgent = null, string xUserAgent = null);

        /// <summary>
        /// Get active implants
        /// </summary>
        /// <remarks>
        /// Return implants on the active clone of a character  - --  This route is cached for up to 300 seconds
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag (optional)</param>
        /// <param name="token">Access token to use if unable to set a header (optional)</param>
        /// <param name="userAgent">Client identifier, takes precedence over headers (optional)</param>
        /// <param name="xUserAgent">Client identifier, takes precedence over User-Agent (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;int?&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<int?>>> GetCharactersCharacterIdImplantsAsyncWithHttpInfo (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null, string userAgent = null, string xUserAgent = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ClonesApi : IClonesApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClonesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ClonesApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClonesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ClonesApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
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
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
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
        /// Get clones A list of the character&#39;s clones  - --  This route is cached for up to 120 seconds
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag (optional)</param>
        /// <param name="token">Access token to use if unable to set a header (optional)</param>
        /// <param name="userAgent">Client identifier, takes precedence over headers (optional)</param>
        /// <param name="xUserAgent">Client identifier, takes precedence over User-Agent (optional)</param>
        /// <returns>GetCharactersCharacterIdClonesOk</returns>
        public GetCharactersCharacterIdClonesOk GetCharactersCharacterIdClones (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null, string userAgent = null, string xUserAgent = null)
        {
             ApiResponse<GetCharactersCharacterIdClonesOk> localVarResponse = GetCharactersCharacterIdClonesWithHttpInfo(characterId, datasource, ifNoneMatch, token, userAgent, xUserAgent);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get clones A list of the character&#39;s clones  - --  This route is cached for up to 120 seconds
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag (optional)</param>
        /// <param name="token">Access token to use if unable to set a header (optional)</param>
        /// <param name="userAgent">Client identifier, takes precedence over headers (optional)</param>
        /// <param name="xUserAgent">Client identifier, takes precedence over User-Agent (optional)</param>
        /// <returns>ApiResponse of GetCharactersCharacterIdClonesOk</returns>
        public ApiResponse< GetCharactersCharacterIdClonesOk > GetCharactersCharacterIdClonesWithHttpInfo (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null, string userAgent = null, string xUserAgent = null)
        {
            // verify the required parameter 'characterId' is set
            if (characterId == null)
                throw new ApiException(400, "Missing required parameter 'characterId' when calling ClonesApi->GetCharactersCharacterIdClones");

            var localVarPath = "/v3/characters/{character_id}/clones/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (characterId != null) localVarPathParams.Add("character_id", Configuration.ApiClient.ParameterToString(characterId)); // path parameter
            if (datasource != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "datasource", datasource)); // query parameter
            if (token != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "token", token)); // query parameter
            if (userAgent != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "user_agent", userAgent)); // query parameter
            if (ifNoneMatch != null) localVarHeaderParams.Add("If-None-Match", Configuration.ApiClient.ParameterToString(ifNoneMatch)); // header parameter
            if (xUserAgent != null) localVarHeaderParams.Add("X-User-Agent", Configuration.ApiClient.ParameterToString(xUserAgent)); // header parameter

            // authentication (evesso) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCharactersCharacterIdClones", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetCharactersCharacterIdClonesOk>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GetCharactersCharacterIdClonesOk) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetCharactersCharacterIdClonesOk)));
        }

        /// <summary>
        /// Get clones A list of the character&#39;s clones  - --  This route is cached for up to 120 seconds
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag (optional)</param>
        /// <param name="token">Access token to use if unable to set a header (optional)</param>
        /// <param name="userAgent">Client identifier, takes precedence over headers (optional)</param>
        /// <param name="xUserAgent">Client identifier, takes precedence over User-Agent (optional)</param>
        /// <returns>Task of GetCharactersCharacterIdClonesOk</returns>
        public async System.Threading.Tasks.Task<GetCharactersCharacterIdClonesOk> GetCharactersCharacterIdClonesAsync (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null, string userAgent = null, string xUserAgent = null)
        {
             ApiResponse<GetCharactersCharacterIdClonesOk> localVarResponse = await GetCharactersCharacterIdClonesAsyncWithHttpInfo(characterId, datasource, ifNoneMatch, token, userAgent, xUserAgent);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get clones A list of the character&#39;s clones  - --  This route is cached for up to 120 seconds
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag (optional)</param>
        /// <param name="token">Access token to use if unable to set a header (optional)</param>
        /// <param name="userAgent">Client identifier, takes precedence over headers (optional)</param>
        /// <param name="xUserAgent">Client identifier, takes precedence over User-Agent (optional)</param>
        /// <returns>Task of ApiResponse (GetCharactersCharacterIdClonesOk)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GetCharactersCharacterIdClonesOk>> GetCharactersCharacterIdClonesAsyncWithHttpInfo (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null, string userAgent = null, string xUserAgent = null)
        {
            // verify the required parameter 'characterId' is set
            if (characterId == null)
                throw new ApiException(400, "Missing required parameter 'characterId' when calling ClonesApi->GetCharactersCharacterIdClones");

            var localVarPath = "/v3/characters/{character_id}/clones/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (characterId != null) localVarPathParams.Add("character_id", Configuration.ApiClient.ParameterToString(characterId)); // path parameter
            if (datasource != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "datasource", datasource)); // query parameter
            if (token != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "token", token)); // query parameter
            if (userAgent != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "user_agent", userAgent)); // query parameter
            if (ifNoneMatch != null) localVarHeaderParams.Add("If-None-Match", Configuration.ApiClient.ParameterToString(ifNoneMatch)); // header parameter
            if (xUserAgent != null) localVarHeaderParams.Add("X-User-Agent", Configuration.ApiClient.ParameterToString(xUserAgent)); // header parameter

            // authentication (evesso) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCharactersCharacterIdClones", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetCharactersCharacterIdClonesOk>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GetCharactersCharacterIdClonesOk) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetCharactersCharacterIdClonesOk)));
        }

        /// <summary>
        /// Get active implants Return implants on the active clone of a character  - --  This route is cached for up to 300 seconds
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag (optional)</param>
        /// <param name="token">Access token to use if unable to set a header (optional)</param>
        /// <param name="userAgent">Client identifier, takes precedence over headers (optional)</param>
        /// <param name="xUserAgent">Client identifier, takes precedence over User-Agent (optional)</param>
        /// <returns>List&lt;int?&gt;</returns>
        public List<int?> GetCharactersCharacterIdImplants (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null, string userAgent = null, string xUserAgent = null)
        {
             ApiResponse<List<int?>> localVarResponse = GetCharactersCharacterIdImplantsWithHttpInfo(characterId, datasource, ifNoneMatch, token, userAgent, xUserAgent);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get active implants Return implants on the active clone of a character  - --  This route is cached for up to 300 seconds
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag (optional)</param>
        /// <param name="token">Access token to use if unable to set a header (optional)</param>
        /// <param name="userAgent">Client identifier, takes precedence over headers (optional)</param>
        /// <param name="xUserAgent">Client identifier, takes precedence over User-Agent (optional)</param>
        /// <returns>ApiResponse of List&lt;int?&gt;</returns>
        public ApiResponse< List<int?> > GetCharactersCharacterIdImplantsWithHttpInfo (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null, string userAgent = null, string xUserAgent = null)
        {
            // verify the required parameter 'characterId' is set
            if (characterId == null)
                throw new ApiException(400, "Missing required parameter 'characterId' when calling ClonesApi->GetCharactersCharacterIdImplants");

            var localVarPath = "/v1/characters/{character_id}/implants/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (characterId != null) localVarPathParams.Add("character_id", Configuration.ApiClient.ParameterToString(characterId)); // path parameter
            if (datasource != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "datasource", datasource)); // query parameter
            if (token != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "token", token)); // query parameter
            if (userAgent != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "user_agent", userAgent)); // query parameter
            if (ifNoneMatch != null) localVarHeaderParams.Add("If-None-Match", Configuration.ApiClient.ParameterToString(ifNoneMatch)); // header parameter
            if (xUserAgent != null) localVarHeaderParams.Add("X-User-Agent", Configuration.ApiClient.ParameterToString(xUserAgent)); // header parameter

            // authentication (evesso) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCharactersCharacterIdImplants", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<int?>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<int?>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<int?>)));
        }

        /// <summary>
        /// Get active implants Return implants on the active clone of a character  - --  This route is cached for up to 300 seconds
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag (optional)</param>
        /// <param name="token">Access token to use if unable to set a header (optional)</param>
        /// <param name="userAgent">Client identifier, takes precedence over headers (optional)</param>
        /// <param name="xUserAgent">Client identifier, takes precedence over User-Agent (optional)</param>
        /// <returns>Task of List&lt;int?&gt;</returns>
        public async System.Threading.Tasks.Task<List<int?>> GetCharactersCharacterIdImplantsAsync (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null, string userAgent = null, string xUserAgent = null)
        {
             ApiResponse<List<int?>> localVarResponse = await GetCharactersCharacterIdImplantsAsyncWithHttpInfo(characterId, datasource, ifNoneMatch, token, userAgent, xUserAgent);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get active implants Return implants on the active clone of a character  - --  This route is cached for up to 300 seconds
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag (optional)</param>
        /// <param name="token">Access token to use if unable to set a header (optional)</param>
        /// <param name="userAgent">Client identifier, takes precedence over headers (optional)</param>
        /// <param name="xUserAgent">Client identifier, takes precedence over User-Agent (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;int?&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<int?>>> GetCharactersCharacterIdImplantsAsyncWithHttpInfo (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null, string userAgent = null, string xUserAgent = null)
        {
            // verify the required parameter 'characterId' is set
            if (characterId == null)
                throw new ApiException(400, "Missing required parameter 'characterId' when calling ClonesApi->GetCharactersCharacterIdImplants");

            var localVarPath = "/v1/characters/{character_id}/implants/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (characterId != null) localVarPathParams.Add("character_id", Configuration.ApiClient.ParameterToString(characterId)); // path parameter
            if (datasource != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "datasource", datasource)); // query parameter
            if (token != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "token", token)); // query parameter
            if (userAgent != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "user_agent", userAgent)); // query parameter
            if (ifNoneMatch != null) localVarHeaderParams.Add("If-None-Match", Configuration.ApiClient.ParameterToString(ifNoneMatch)); // header parameter
            if (xUserAgent != null) localVarHeaderParams.Add("X-User-Agent", Configuration.ApiClient.ParameterToString(xUserAgent)); // header parameter

            // authentication (evesso) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCharactersCharacterIdImplants", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<int?>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<int?>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<int?>)));
        }

    }
}
