/* 
 * WebAPI - Area Management
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: management
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using ACUtils.AXRepository.ArxivarNextManagement.Client;
using ACUtils.AXRepository.ArxivarNextManagement.Model;

namespace ACUtils.AXRepository.ArxivarNextManagement.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IViewManagementApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// This call returns all views
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;ViewDTO&gt;</returns>
        List<ViewDTO> ViewManagementGetList ();

        /// <summary>
        /// This call returns all views
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;ViewDTO&gt;</returns>
        ApiResponse<List<ViewDTO>> ViewManagementGetListWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// This call returns all views
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;ViewDTO&gt;</returns>
        System.Threading.Tasks.Task<List<ViewDTO>> ViewManagementGetListAsync ();

        /// <summary>
        /// This call returns all views
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;ViewDTO&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ViewDTO>>> ViewManagementGetListAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ViewManagementApi : IViewManagementApi
    {
        private ACUtils.AXRepository.ArxivarNextManagement.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ViewManagementApi(String basePath)
        {
            this.Configuration = new ACUtils.AXRepository.ArxivarNextManagement.Client.Configuration { BasePath = basePath };

            ExceptionFactory = ACUtils.AXRepository.ArxivarNextManagement.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewManagementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ViewManagementApi(ACUtils.AXRepository.ArxivarNextManagement.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = ACUtils.AXRepository.ArxivarNextManagement.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = ACUtils.AXRepository.ArxivarNextManagement.Client.Configuration.DefaultExceptionFactory;
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
        public ACUtils.AXRepository.ArxivarNextManagement.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ACUtils.AXRepository.ArxivarNextManagement.Client.ExceptionFactory ExceptionFactory
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
        /// This call returns all views 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;ViewDTO&gt;</returns>
        public List<ViewDTO> ViewManagementGetList ()
        {
             ApiResponse<List<ViewDTO>> localVarResponse = ViewManagementGetListWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// This call returns all views 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;ViewDTO&gt;</returns>
        public ApiResponse< List<ViewDTO> > ViewManagementGetListWithHttpInfo ()
        {

            var localVarPath = "/api/management/Views";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ViewManagementGetList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<ViewDTO>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ViewDTO>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ViewDTO>)));
        }

        /// <summary>
        /// This call returns all views 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;ViewDTO&gt;</returns>
        public async System.Threading.Tasks.Task<List<ViewDTO>> ViewManagementGetListAsync ()
        {
             ApiResponse<List<ViewDTO>> localVarResponse = await ViewManagementGetListAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// This call returns all views 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNextManagement.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;ViewDTO&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ViewDTO>>> ViewManagementGetListAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/management/Views";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ViewManagementGetList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<ViewDTO>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ViewDTO>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ViewDTO>)));
        }

    }
}
