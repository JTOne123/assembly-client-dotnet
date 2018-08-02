/* 
 * Assembly Developer API
 *
 * The Assembly API is built around the REST and a collection of open standards/protocols in order to comply with as many consumers as possible.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: help@assembly.education
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace AssemblyClient.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAcademicYearsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// View an Academic Year
        /// </summary>
        /// <remarks>
        /// Returns a single academic year for the school associated with the provided access_token.
        /// </remarks>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of the AcademicYear</param>
        /// <returns>AcademicYear</returns>
        AcademicYear AcademicYear (int? id);

        /// <summary>
        /// View an Academic Year
        /// </summary>
        /// <remarks>
        /// Returns a single academic year for the school associated with the provided access_token.
        /// </remarks>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of the AcademicYear</param>
        /// <returns>ApiResponse of AcademicYear</returns>
        ApiResponse<AcademicYear> AcademicYearWithHttpInfo (int? id);
        /// <summary>
        /// List Academic Years
        /// </summary>
        /// <remarks>
        /// Returns a list of academic years for the school associated with the provided access_token. The dates of these academic years can be used to filter data in other API endpoints.
        /// </remarks>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <returns>AcademicYearList</returns>
        AcademicYearList AcademicYears (int? perPage = null, int? page = null);

        /// <summary>
        /// List Academic Years
        /// </summary>
        /// <remarks>
        /// Returns a list of academic years for the school associated with the provided access_token. The dates of these academic years can be used to filter data in other API endpoints.
        /// </remarks>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <returns>ApiResponse of AcademicYearList</returns>
        ApiResponse<AcademicYearList> AcademicYearsWithHttpInfo (int? perPage = null, int? page = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// View an Academic Year
        /// </summary>
        /// <remarks>
        /// Returns a single academic year for the school associated with the provided access_token.
        /// </remarks>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of the AcademicYear</param>
        /// <returns>Task of AcademicYear</returns>
        System.Threading.Tasks.Task<AcademicYear> AcademicYearAsync (int? id);

        /// <summary>
        /// View an Academic Year
        /// </summary>
        /// <remarks>
        /// Returns a single academic year for the school associated with the provided access_token.
        /// </remarks>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of the AcademicYear</param>
        /// <returns>Task of ApiResponse (AcademicYear)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcademicYear>> AcademicYearAsyncWithHttpInfo (int? id);
        /// <summary>
        /// List Academic Years
        /// </summary>
        /// <remarks>
        /// Returns a list of academic years for the school associated with the provided access_token. The dates of these academic years can be used to filter data in other API endpoints.
        /// </remarks>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <returns>Task of AcademicYearList</returns>
        System.Threading.Tasks.Task<AcademicYearList> AcademicYearsAsync (int? perPage = null, int? page = null);

        /// <summary>
        /// List Academic Years
        /// </summary>
        /// <remarks>
        /// Returns a list of academic years for the school associated with the provided access_token. The dates of these academic years can be used to filter data in other API endpoints.
        /// </remarks>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (AcademicYearList)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcademicYearList>> AcademicYearsAsyncWithHttpInfo (int? perPage = null, int? page = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AcademicYearsApi : IAcademicYearsApi
    {
        private AssemblyClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AcademicYearsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AcademicYearsApi(String basePath)
        {
            this.Configuration = new AssemblyClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = AssemblyClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AcademicYearsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AcademicYearsApi(AssemblyClient.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = AssemblyClient.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = AssemblyClient.Client.Configuration.DefaultExceptionFactory;
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
        public AssemblyClient.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public AssemblyClient.Client.ExceptionFactory ExceptionFactory
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
        /// View an Academic Year Returns a single academic year for the school associated with the provided access_token.
        /// </summary>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of the AcademicYear</param>
        /// <returns>AcademicYear</returns>
        public AcademicYear AcademicYear (int? id)
        {
             ApiResponse<AcademicYear> localVarResponse = AcademicYearWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// View an Academic Year Returns a single academic year for the school associated with the provided access_token.
        /// </summary>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of the AcademicYear</param>
        /// <returns>ApiResponse of AcademicYear</returns>
        public ApiResponse< AcademicYear > AcademicYearWithHttpInfo (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AcademicYearsApi->AcademicYear");

            var localVarPath = "/academic_years/{id}";
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
                "application/vnd.assembly+json; version=1"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (bearerAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AcademicYear", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcademicYear>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AcademicYear) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcademicYear)));
        }

        /// <summary>
        /// View an Academic Year Returns a single academic year for the school associated with the provided access_token.
        /// </summary>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of the AcademicYear</param>
        /// <returns>Task of AcademicYear</returns>
        public async System.Threading.Tasks.Task<AcademicYear> AcademicYearAsync (int? id)
        {
             ApiResponse<AcademicYear> localVarResponse = await AcademicYearAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// View an Academic Year Returns a single academic year for the school associated with the provided access_token.
        /// </summary>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of the AcademicYear</param>
        /// <returns>Task of ApiResponse (AcademicYear)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcademicYear>> AcademicYearAsyncWithHttpInfo (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AcademicYearsApi->AcademicYear");

            var localVarPath = "/academic_years/{id}";
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
                "application/vnd.assembly+json; version=1"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (bearerAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AcademicYear", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcademicYear>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AcademicYear) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcademicYear)));
        }

        /// <summary>
        /// List Academic Years Returns a list of academic years for the school associated with the provided access_token. The dates of these academic years can be used to filter data in other API endpoints.
        /// </summary>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <returns>AcademicYearList</returns>
        public AcademicYearList AcademicYears (int? perPage = null, int? page = null)
        {
             ApiResponse<AcademicYearList> localVarResponse = AcademicYearsWithHttpInfo(perPage, page);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Academic Years Returns a list of academic years for the school associated with the provided access_token. The dates of these academic years can be used to filter data in other API endpoints.
        /// </summary>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <returns>ApiResponse of AcademicYearList</returns>
        public ApiResponse< AcademicYearList > AcademicYearsWithHttpInfo (int? perPage = null, int? page = null)
        {

            var localVarPath = "/academic_years";
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
                "application/vnd.assembly+json; version=1"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (perPage != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "per_page", perPage)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter

            // authentication (bearerAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AcademicYears", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcademicYearList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AcademicYearList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcademicYearList)));
        }

        /// <summary>
        /// List Academic Years Returns a list of academic years for the school associated with the provided access_token. The dates of these academic years can be used to filter data in other API endpoints.
        /// </summary>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <returns>Task of AcademicYearList</returns>
        public async System.Threading.Tasks.Task<AcademicYearList> AcademicYearsAsync (int? perPage = null, int? page = null)
        {
             ApiResponse<AcademicYearList> localVarResponse = await AcademicYearsAsyncWithHttpInfo(perPage, page);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List Academic Years Returns a list of academic years for the school associated with the provided access_token. The dates of these academic years can be used to filter data in other API endpoints.
        /// </summary>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (AcademicYearList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcademicYearList>> AcademicYearsAsyncWithHttpInfo (int? perPage = null, int? page = null)
        {

            var localVarPath = "/academic_years";
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
                "application/vnd.assembly+json; version=1"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (perPage != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "per_page", perPage)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter

            // authentication (bearerAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AcademicYears", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcademicYearList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AcademicYearList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcademicYearList)));
        }

    }
}
