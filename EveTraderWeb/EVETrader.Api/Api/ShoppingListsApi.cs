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
    public interface IShoppingListsApi
    {
        /// <summary>
        /// Add items to cart 
        /// </summary>
        /// <param name="salesOrderId">SalesOrder ID</param>
        /// <param name="item"></param>
        /// <returns></returns>
        void ApiShoppingListsAdditemBySalesOrderIdPost (int? salesOrderId, Items item);
        /// <summary>
        /// Add items to cart 
        /// </summary>
        /// <param name="salesOrderId">SalesOrder ID</param>
        /// <param name="items"></param>
        /// <returns></returns>
        void ApiShoppingListsAdditemsBySalesOrderIdPost (int? salesOrderId, List<Items> items);
        /// <summary>
        /// Get items in a salesorder 
        /// </summary>
        /// <param name="id">Salesorder id</param>
        /// <returns></returns>
        void ApiShoppingListsByIdGet (int? id);
        /// <summary>
        /// Gets all salesOrders. 
        /// </summary>
        /// <returns>List&lt;ShoppingList&gt;</returns>
        List<ShoppingList> ApiShoppingListsGet ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ShoppingListsApi : IShoppingListsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShoppingListsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ShoppingListsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ShoppingListsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ShoppingListsApi(String basePath)
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
        /// Add items to cart 
        /// </summary>
        /// <param name="salesOrderId">SalesOrder ID</param> 
        /// <param name="item"></param> 
        /// <returns></returns>            
        public void ApiShoppingListsAdditemBySalesOrderIdPost (int? salesOrderId, Items item)
        {
            
            // verify the required parameter 'salesOrderId' is set
            if (salesOrderId == null) throw new ApiException(400, "Missing required parameter 'salesOrderId' when calling ApiShoppingListsAdditemBySalesOrderIdPost");
            
    
            var path = "/api/ShoppingLists/additem/{SalesOrderId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "SalesOrderId" + "}", ApiClient.ParameterToString(salesOrderId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(item); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiShoppingListsAdditemBySalesOrderIdPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiShoppingListsAdditemBySalesOrderIdPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Add items to cart 
        /// </summary>
        /// <param name="salesOrderId">SalesOrder ID</param> 
        /// <param name="items"></param> 
        /// <returns></returns>            
        public void ApiShoppingListsAdditemsBySalesOrderIdPost (int? salesOrderId, List<Items> items)
        {
            
            // verify the required parameter 'salesOrderId' is set
            if (salesOrderId == null) throw new ApiException(400, "Missing required parameter 'salesOrderId' when calling ApiShoppingListsAdditemsBySalesOrderIdPost");
            
    
            var path = "/api/ShoppingLists/additems/{SalesOrderId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "SalesOrderId" + "}", ApiClient.ParameterToString(salesOrderId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(items); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiShoppingListsAdditemsBySalesOrderIdPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiShoppingListsAdditemsBySalesOrderIdPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get items in a salesorder 
        /// </summary>
        /// <param name="id">Salesorder id</param> 
        /// <returns></returns>            
        public void ApiShoppingListsByIdGet (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ApiShoppingListsByIdGet");
            
    
            var path = "/api/ShoppingLists/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ApiShoppingListsByIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiShoppingListsByIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets all salesOrders. 
        /// </summary>
        /// <returns>List&lt;ShoppingList&gt;</returns>            
        public List<ShoppingList> ApiShoppingListsGet ()
        {
            
    
            var path = "/api/ShoppingLists";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ApiShoppingListsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiShoppingListsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ShoppingList>) ApiClient.Deserialize(response.Content, typeof(List<ShoppingList>), response.Headers);
        }
    
    }
}
