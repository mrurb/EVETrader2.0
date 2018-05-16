using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISalesOrdersApi
    {
        /// <summary>
        /// Gets all salesOrders for one character. 
        /// </summary>
        /// <param name="cid">Character id</param>
        /// <returns></returns>
        void ApiCharactersByCidSalesOrdersGet (int? cid);
        /// <summary>
        /// delete salesorder 
        /// </summary>
        /// <param name="id">Salesorder id</param>
        /// <returns></returns>
        void ApiSalesOrdersByIdDelete (int? id);
        /// <summary>
        /// Gets specific salesorder. 
        /// </summary>
        /// <param name="id">Salesorder id</param>
        /// <returns></returns>
        void ApiSalesOrdersByIdGet (int? id);
        /// <summary>
        /// Update salesorder 
        /// </summary>
        /// <param name="id">Salesorder id</param>
        /// <param name="salesOrder">SalesOrder</param>
        /// <returns></returns>
        void ApiSalesOrdersByIdPut (int? id, SalesOrder salesOrder);
        /// <summary>
        /// Gets all salesOrders. 
        /// </summary>
        /// <returns>List&lt;SalesOrder&gt;</returns>
        List<SalesOrder> ApiSalesOrdersGet ();
        /// <summary>
        /// Create salesorder 
        /// </summary>
        /// <param name="salesOrder">SalesOrder</param>
        /// <returns></returns>
        void ApiSalesOrdersPost (SalesOrder salesOrder);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SalesOrdersApi : ISalesOrdersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesOrdersApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SalesOrdersApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesOrdersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SalesOrdersApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Gets all salesOrders for one character. 
        /// </summary>
        /// <param name="cid">Character id</param> 
        /// <returns></returns>            
        public void ApiCharactersByCidSalesOrdersGet (int? cid)
        {
            
            // verify the required parameter 'cid' is set
            if (cid == null) throw new ApiException(400, "Missing required parameter 'cid' when calling ApiCharactersByCidSalesOrdersGet");
            
    
            var path = "/api/Characters/{cid}/SalesOrders";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "cid" + "}", ApiClient.ParameterToString(cid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiCharactersByCidSalesOrdersGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiCharactersByCidSalesOrdersGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// delete salesorder 
        /// </summary>
        /// <param name="id">Salesorder id</param> 
        /// <returns></returns>            
        public void ApiSalesOrdersByIdDelete (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ApiSalesOrdersByIdDelete");
            
    
            var path = "/api/SalesOrders/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiSalesOrdersByIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiSalesOrdersByIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets specific salesorder. 
        /// </summary>
        /// <param name="id">Salesorder id</param> 
        /// <returns></returns>            
        public void ApiSalesOrdersByIdGet (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ApiSalesOrdersByIdGet");
            
    
            var path = "/api/SalesOrders/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiSalesOrdersByIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiSalesOrdersByIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update salesorder 
        /// </summary>
        /// <param name="id">Salesorder id</param> 
        /// <param name="salesOrder">SalesOrder</param> 
        /// <returns></returns>            
        public void ApiSalesOrdersByIdPut (int? id, SalesOrder salesOrder)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ApiSalesOrdersByIdPut");
            
    
            var path = "/api/SalesOrders/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(salesOrder); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiSalesOrdersByIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiSalesOrdersByIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets all salesOrders. 
        /// </summary>
        /// <returns>List&lt;SalesOrder&gt;</returns>            
        public List<SalesOrder> ApiSalesOrdersGet ()
        {
            
    
            var path = "/api/SalesOrders";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiSalesOrdersGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiSalesOrdersGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SalesOrder>) ApiClient.Deserialize(response.Content, typeof(List<SalesOrder>), response.Headers);
        }
    
        /// <summary>
        /// Create salesorder 
        /// </summary>
        /// <param name="salesOrder">SalesOrder</param> 
        /// <returns></returns>            
        public void ApiSalesOrdersPost (SalesOrder salesOrder)
        {
            
    
            var path = "/api/SalesOrders";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(salesOrder); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiSalesOrdersPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiSalesOrdersPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
