using IOApiClient.ESI.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace IOApiClient.ESI.Api
{
	public class UniverseApi
	{
		private readonly ApiClient apiClient;

		public UniverseApi(ApiClient apiClient)
		{
			this.apiClient = apiClient;
		}
		/*
		public async Task<ApiResponse<List<int?>>> Categories(string datasource = null, string ifNoneMatch = null)
		{
			var localVarPath = "/v1/universe/categories/";

			var respone = await apiClient.CallApi(null, localVarPath, HttpMethod.Get, null);
			int statusCode = (int) respone.StatusCode;
			var test = (List<int?>) JsonConvert.DeserializeObject(respone.Content.ReadAsStringAsync().Result, typeof(List<int>));
			return new ApiResponse<List<int?>>(statusCode, respone.Headers., test);
			throw new NotImplementedException();
		}*/
	}
}
