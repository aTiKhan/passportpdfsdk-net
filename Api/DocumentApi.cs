/* 
 * PassportPDF
 *
 * Copyright © 2018 ORPALIS - http://www.orpalis.com
 *
 * OpenAPI spec version: v1
 * Contact: contact@orpalis.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using PassportPDF.Client;
using PassportPDF.Model;

namespace PassportPDF.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDocumentApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Closes a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeParameters">A DocumentCloseParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>DocumentCloseResponse</returns>
        DocumentCloseResponse Close (DocumentCloseParameters closeParameters = null);

        /// <summary>
        /// Closes a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeParameters">A DocumentCloseParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>ApiResponse of DocumentCloseResponse</returns>
        ApiResponse<DocumentCloseResponse> CloseWithHttpInfo (DocumentCloseParameters closeParameters = null);
        /// <summary>
        /// Gets the format, the page count, and a thumbnail of the provided, or a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getDocumentPreviewParameters">A GetDocumentPreviewParameters object specifying the parameters of the action.</param>
        /// <returns>GetDocumentPreviewResponse</returns>
        GetDocumentPreviewResponse GetDocumentPreview (GetDocumentPreviewParameters getDocumentPreviewParameters);

        /// <summary>
        /// Gets the format, the page count, and a thumbnail of the provided, or a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getDocumentPreviewParameters">A GetDocumentPreviewParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of GetDocumentPreviewResponse</returns>
        ApiResponse<GetDocumentPreviewResponse> GetDocumentPreviewWithHttpInfo (GetDocumentPreviewParameters getDocumentPreviewParameters);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Closes a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeParameters">A DocumentCloseParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of DocumentCloseResponse</returns>
        System.Threading.Tasks.Task<DocumentCloseResponse> CloseAsync (DocumentCloseParameters closeParameters = null);

        /// <summary>
        /// Closes a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeParameters">A DocumentCloseParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of ApiResponse (DocumentCloseResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentCloseResponse>> CloseAsyncWithHttpInfo (DocumentCloseParameters closeParameters = null);
        /// <summary>
        /// Gets the format, the page count, and a thumbnail of the provided, or a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getDocumentPreviewParameters">A GetDocumentPreviewParameters object specifying the parameters of the action.</param>
        /// <returns>Task of GetDocumentPreviewResponse</returns>
        System.Threading.Tasks.Task<GetDocumentPreviewResponse> GetDocumentPreviewAsync (GetDocumentPreviewParameters getDocumentPreviewParameters);

        /// <summary>
        /// Gets the format, the page count, and a thumbnail of the provided, or a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getDocumentPreviewParameters">A GetDocumentPreviewParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (GetDocumentPreviewResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetDocumentPreviewResponse>> GetDocumentPreviewAsyncWithHttpInfo (GetDocumentPreviewParameters getDocumentPreviewParameters);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DocumentApi : IDocumentApi
    {
        private PassportPDF.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DocumentApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = PassportPDF.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DocumentApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = PassportPDF.Client.Configuration.DefaultExceptionFactory;
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
        public PassportPDF.Client.ExceptionFactory ExceptionFactory
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
        /// Closes a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeParameters">A DocumentCloseParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>DocumentCloseResponse</returns>
        public DocumentCloseResponse Close (DocumentCloseParameters closeParameters = null)
        {
             ApiResponse<DocumentCloseResponse> localVarResponse = CloseWithHttpInfo(closeParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Closes a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeParameters">A DocumentCloseParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>ApiResponse of DocumentCloseResponse</returns>
        public ApiResponse< DocumentCloseResponse > CloseWithHttpInfo (DocumentCloseParameters closeParameters = null)
        {

            var localVarPath = "/api/document/Close";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (closeParameters != null && closeParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(closeParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = closeParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Close", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentCloseResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentCloseResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentCloseResponse)));
        }

        /// <summary>
        /// Closes a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeParameters">A DocumentCloseParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of DocumentCloseResponse</returns>
        public async System.Threading.Tasks.Task<DocumentCloseResponse> CloseAsync (DocumentCloseParameters closeParameters = null)
        {
             ApiResponse<DocumentCloseResponse> localVarResponse = await CloseAsyncWithHttpInfo(closeParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Closes a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeParameters">A DocumentCloseParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of ApiResponse (DocumentCloseResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentCloseResponse>> CloseAsyncWithHttpInfo (DocumentCloseParameters closeParameters = null)
        {

            var localVarPath = "/api/document/Close";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (closeParameters != null && closeParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(closeParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = closeParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Close", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentCloseResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentCloseResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentCloseResponse)));
        }

        /// <summary>
        /// Gets the format, the page count, and a thumbnail of the provided, or a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getDocumentPreviewParameters">A GetDocumentPreviewParameters object specifying the parameters of the action.</param>
        /// <returns>GetDocumentPreviewResponse</returns>
        public GetDocumentPreviewResponse GetDocumentPreview (GetDocumentPreviewParameters getDocumentPreviewParameters)
        {
             ApiResponse<GetDocumentPreviewResponse> localVarResponse = GetDocumentPreviewWithHttpInfo(getDocumentPreviewParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the format, the page count, and a thumbnail of the provided, or a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getDocumentPreviewParameters">A GetDocumentPreviewParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of GetDocumentPreviewResponse</returns>
        public ApiResponse< GetDocumentPreviewResponse > GetDocumentPreviewWithHttpInfo (GetDocumentPreviewParameters getDocumentPreviewParameters)
        {
            // verify the required parameter 'getDocumentPreviewParameters' is set
            if (getDocumentPreviewParameters == null)
                throw new ApiException(400, "Missing required parameter 'getDocumentPreviewParameters' when calling DocumentApi->GetDocumentPreview");

            var localVarPath = "/api/document/GetDocumentPreview";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (getDocumentPreviewParameters != null && getDocumentPreviewParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(getDocumentPreviewParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = getDocumentPreviewParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDocumentPreview", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetDocumentPreviewResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GetDocumentPreviewResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetDocumentPreviewResponse)));
        }

        /// <summary>
        /// Gets the format, the page count, and a thumbnail of the provided, or a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getDocumentPreviewParameters">A GetDocumentPreviewParameters object specifying the parameters of the action.</param>
        /// <returns>Task of GetDocumentPreviewResponse</returns>
        public async System.Threading.Tasks.Task<GetDocumentPreviewResponse> GetDocumentPreviewAsync (GetDocumentPreviewParameters getDocumentPreviewParameters)
        {
             ApiResponse<GetDocumentPreviewResponse> localVarResponse = await GetDocumentPreviewAsyncWithHttpInfo(getDocumentPreviewParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets the format, the page count, and a thumbnail of the provided, or a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getDocumentPreviewParameters">A GetDocumentPreviewParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (GetDocumentPreviewResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GetDocumentPreviewResponse>> GetDocumentPreviewAsyncWithHttpInfo (GetDocumentPreviewParameters getDocumentPreviewParameters)
        {
            // verify the required parameter 'getDocumentPreviewParameters' is set
            if (getDocumentPreviewParameters == null)
                throw new ApiException(400, "Missing required parameter 'getDocumentPreviewParameters' when calling DocumentApi->GetDocumentPreview");

            var localVarPath = "/api/document/GetDocumentPreview";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (getDocumentPreviewParameters != null && getDocumentPreviewParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(getDocumentPreviewParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = getDocumentPreviewParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDocumentPreview", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetDocumentPreviewResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GetDocumentPreviewResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetDocumentPreviewResponse)));
        }

    }
}