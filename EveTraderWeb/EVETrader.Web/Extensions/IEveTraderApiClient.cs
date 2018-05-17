using EVETrader.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace EVETrader.Web.Extensions
{
    interface IEveTraderApiClient
    {
		
    }

	public class EveTraderApiClient : IEveTraderApiClient
	{
		private readonly HttpClient client;

		

		public EveTraderApiClient()
		{
			client = new HttpClient();
			client.BaseAddress = new Uri("https://esi.evetech.net");
		}

		public EveTraderApiClient(string baseUrl = "https://esi.evetech.net")
		{
			if (String.IsNullOrEmpty(baseUrl))
				throw new ArgumentException("basePath cannot be empty");

			client = new HttpClient();
			client.BaseAddress = new Uri(baseUrl);

		}
		/// <summary>
		/// Makes the asynchronous HTTP request.
		/// </summary>
		/// <param name="path">URL path.</param>
		/// <param name="method">HTTP method.</param>
		/// <param name="queryParams">Query parameters.</param>
		/// <param name="postBody">HTTP body (POST request).</param>
		/// <param name="headerParams">Header parameters.</param>
		/// <param name="formParams">Form parameters.</param>
		/// <param name="fileParams">File parameters.</param>
		/// <param name="pathParams">Path parameters.</param>
		/// <param name="contentType">Content type.</param>
		/// <returns>The Task instance.</returns>
		public async Task<Object> CallApi(string token, string path, HttpMethod method)
		{
			client.DefaultRequestHeaders.Clear();
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearrer", token);
			//HttpRequestMessage test = new HttpRequestMessage() { Method = }

			var response = await client.GetAsync(path);
			return (Object)response;
		}



	}

	interface ISalesOrderRepository
	{
		IEnumerable<SalesOrder> ListAll();
		SalesOrder Add(SalesOrder salesOrder);
		SalesOrder Get(int salesOrderId);
		SalesOrder Get(int salesOrderId, int characterId);
		SalesOrder Update(SalesOrder salesOrder);
		SalesOrder Delete(SalesOrder salesOrder);

	}
}
