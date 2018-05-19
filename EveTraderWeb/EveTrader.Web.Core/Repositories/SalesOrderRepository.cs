using EveTrader.Web.Core.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace EveTrader.Web.Core
{
	public interface ISalesOrderRepository
	{
		Task<IEnumerable<SalesOrder>> ListAllAsync();
		Task<SalesOrder> AddAsync(SalesOrder salesOrder);
		Task<SalesOrder> GetAsync(int salesOrderId);
		Task<SalesOrder> GetAsync(int salesOrderId, int characterId);
		Task<SalesOrder> UpdateAsync(SalesOrder salesOrder);
		Task<SalesOrder> DeleteAsync(SalesOrder salesOrder);
	}

	public class SalesOrderRepository : ISalesOrderRepository
	{
		private readonly HttpClient httpClient;

		public SalesOrderRepository(HttpClient httpClient)
		{
			this.httpClient = httpClient;
			httpClient.DefaultRequestHeaders.Clear();
			httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			httpClient.BaseAddress = new Uri("http://localhost:56362");
		}

		public Task<SalesOrder> AddAsync(SalesOrder salesOrder)
		{
			throw new NotImplementedException();
		}

		public async Task<HttpResponseMessage> CallAPiAsync(HttpMethod httpmethod ,string url, string content)
		{

			HttpRequestMessage test = new HttpRequestMessage(httpmethod, url);
			test.Content = new StringContent(content);
			return await httpClient.SendAsync(test);

		}

		public async Task<HttpResponseMessage> CallAPiAsync(HttpMethod httpmethod, string url)
		{

			HttpRequestMessage test = new HttpRequestMessage(httpmethod, url);
			return await httpClient.SendAsync(test);

		}

		public Task<SalesOrder> DeleteAsync(SalesOrder salesOrder)
		{
			throw new NotImplementedException();
		}

		public Task<SalesOrder> GetAsync(int salesOrderId)
		{
			throw new NotImplementedException();
		}

		public Task<SalesOrder> GetAsync(int salesOrderId, int characterId)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<SalesOrder>> ListAll()
		{
			var response = await CallAPiAsync(HttpMethod.Get, "/api/SalesOrders");
			var test = (List<SalesOrder>) JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result, typeof(List<SalesOrder>));
			return test;

			throw new NotImplementedException();
		}

		public Task<IEnumerable<SalesOrder>> ListAllAsync()
		{
			throw new NotImplementedException();
		}

		public Task<SalesOrder> UpdateAsync(SalesOrder salesOrder)
		{
			throw new NotImplementedException();
		}
	}
}
