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
		/// <param name="token">Auth token</param>
		/// <param name="path">URL path.</param>
		/// <param name="method">HTTP method.</param>
		/// <param name="content">HTTP body (POST request)</param>
		/// <param name="headers">Header parameters.</param>
		/// <returns>The Task instance.</returns>
		public async Task<Object> CallApi(string token, string path, HttpMethod method, HttpContent content, HttpHeaders headers )
		{
			client.DefaultRequestHeaders.Clear();
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			//client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearrer", token);
			var requestUri = new Uri(path);
			HttpRequestMessage request = new HttpRequestMessage() { Method = method, Content = content, RequestUri = requestUri };

			var response = await client.SendAsync(request);
			return (Object)response;
		}
	}

	public class SalesOrderApi
	{
		public SalesOrderApi(EveTraderApiClient eveTraderApiClient)
		{

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
