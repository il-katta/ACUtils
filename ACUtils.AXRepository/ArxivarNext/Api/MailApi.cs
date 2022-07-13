/* 
 * WebAPI
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: data
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using ACUtils.AXRepository.ArxivarNext.Client;
using ACUtils.AXRepository.ArxivarNext.Model;

namespace ACUtils.AXRepository.ArxivarNext.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMailApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// This call insert new mail for send queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailOutInsertRequestDTO"></param>
        /// <returns>MailOutDTO</returns>
        MailOutDTO MailMailOutInsert (MailOutInsertRequestDTO mailOutInsertRequestDTO);

        /// <summary>
        /// This call insert new mail for send queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailOutInsertRequestDTO"></param>
        /// <returns>ApiResponse of MailOutDTO</returns>
        ApiResponse<MailOutDTO> MailMailOutInsertWithHttpInfo (MailOutInsertRequestDTO mailOutInsertRequestDTO);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// This call insert new mail for send queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailOutInsertRequestDTO"></param>
        /// <returns>Task of MailOutDTO</returns>
        System.Threading.Tasks.Task<MailOutDTO> MailMailOutInsertAsync (MailOutInsertRequestDTO mailOutInsertRequestDTO);

        /// <summary>
        /// This call insert new mail for send queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailOutInsertRequestDTO"></param>
        /// <returns>Task of ApiResponse (MailOutDTO)</returns>
        System.Threading.Tasks.Task<ApiResponse<MailOutDTO>> MailMailOutInsertAsyncWithHttpInfo (MailOutInsertRequestDTO mailOutInsertRequestDTO);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MailApi : IMailApi
    {
        private ACUtils.AXRepository.ArxivarNext.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MailApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MailApi(String basePath)
        {
            this.Configuration = new ACUtils.AXRepository.ArxivarNext.Client.Configuration { BasePath = basePath };

            ExceptionFactory = ACUtils.AXRepository.ArxivarNext.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MailApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MailApi(ACUtils.AXRepository.ArxivarNext.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = ACUtils.AXRepository.ArxivarNext.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = ACUtils.AXRepository.ArxivarNext.Client.Configuration.DefaultExceptionFactory;
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
        public ACUtils.AXRepository.ArxivarNext.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ACUtils.AXRepository.ArxivarNext.Client.ExceptionFactory ExceptionFactory
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
        /// This call insert new mail for send queue 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailOutInsertRequestDTO"></param>
        /// <returns>MailOutDTO</returns>
        public MailOutDTO MailMailOutInsert (MailOutInsertRequestDTO mailOutInsertRequestDTO)
        {
             ApiResponse<MailOutDTO> localVarResponse = MailMailOutInsertWithHttpInfo(mailOutInsertRequestDTO);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This call insert new mail for send queue 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailOutInsertRequestDTO"></param>
        /// <returns>ApiResponse of MailOutDTO</returns>
        public ApiResponse< MailOutDTO > MailMailOutInsertWithHttpInfo (MailOutInsertRequestDTO mailOutInsertRequestDTO)
        {
            // verify the required parameter 'mailOutInsertRequestDTO' is set
            if (mailOutInsertRequestDTO == null)
                throw new ApiException(400, "Missing required parameter 'mailOutInsertRequestDTO' when calling MailApi->MailMailOutInsert");

            var localVarPath = "/api/Mail";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
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

            if (mailOutInsertRequestDTO != null && mailOutInsertRequestDTO.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(mailOutInsertRequestDTO); // http body (model) parameter
            }
            else
            {
                localVarPostBody = mailOutInsertRequestDTO; // byte array
            }

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MailMailOutInsert", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MailOutDTO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MailOutDTO) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MailOutDTO)));
        }

        /// <summary>
        /// This call insert new mail for send queue 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailOutInsertRequestDTO"></param>
        /// <returns>Task of MailOutDTO</returns>
        public async System.Threading.Tasks.Task<MailOutDTO> MailMailOutInsertAsync (MailOutInsertRequestDTO mailOutInsertRequestDTO)
        {
             ApiResponse<MailOutDTO> localVarResponse = await MailMailOutInsertAsyncWithHttpInfo(mailOutInsertRequestDTO);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This call insert new mail for send queue 
        /// </summary>
        /// <exception cref="ACUtils.AXRepository.ArxivarNext.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailOutInsertRequestDTO"></param>
        /// <returns>Task of ApiResponse (MailOutDTO)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MailOutDTO>> MailMailOutInsertAsyncWithHttpInfo (MailOutInsertRequestDTO mailOutInsertRequestDTO)
        {
            // verify the required parameter 'mailOutInsertRequestDTO' is set
            if (mailOutInsertRequestDTO == null)
                throw new ApiException(400, "Missing required parameter 'mailOutInsertRequestDTO' when calling MailApi->MailMailOutInsert");

            var localVarPath = "/api/Mail";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
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

            if (mailOutInsertRequestDTO != null && mailOutInsertRequestDTO.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(mailOutInsertRequestDTO); // http body (model) parameter
            }
            else
            {
                localVarPostBody = mailOutInsertRequestDTO; // byte array
            }

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MailMailOutInsert", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MailOutDTO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MailOutDTO) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MailOutDTO)));
        }

    }
}
