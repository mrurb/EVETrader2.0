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
		Task<SalesOrder> GetAsync(int id);
		Task<SalesOrder> GetSalesOrderForCharacterAsync(int characterId);
		Task<SalesOrder> UpdateAsync(SalesOrder salesOrder);
		Task<SalesOrder> DeleteAsync(int id);
		/// <summary>
		/// Add item to a shopping list
		/// </summary>
		/// <param name="shoppingList">item to be added</param>
		/// <param name="id">Shopping List id</param>
		/// <returns></returns>
		Task<ShoppingList> AddItemAsync(ShoppingList shoppingList, int salesOrderId);
		/// <summary>
		/// Add multiple items to a shopping list
		/// </summary>
		/// <param name="shoppingList">List of items to be added</param>
		/// <param name="salesOrderId">Shopping list id</param>
		/// <returns>List of items added</returns>
		Task<IEnumerable<ShoppingList>> AddItemsAsync(IEnumerable<ShoppingList> shoppingList, int salesOrderId);
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
		public async Task<HttpResponseMessage> CallAPiAsync(HttpMethod httpmethod, string url, string content)
		{

			HttpRequestMessage test = new HttpRequestMessage(httpmethod, url);
			httpClient.DefaultRequestHeaders.Clear();
			httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			test.Content = new StringContent(content, Encoding.UTF8, "application/json");
			var call = await httpClient.SendAsync(test);
			if (!call.IsSuccessStatusCode)
			{
				throw new Exception(call.StatusCode.ToString());
			}
			return call;
		}

		public async Task<HttpResponseMessage> CallAPiAsync(HttpMethod httpmethod, string url)
		{

			HttpRequestMessage test = new HttpRequestMessage(httpmethod, url);
			return await httpClient.SendAsync(test);

		}

		public async Task<SalesOrder> AddAsync(SalesOrder salesOrder)
		{
			var content = JsonConvert.SerializeObject(salesOrder);
			var response = await CallAPiAsync(HttpMethod.Post, "/api/SalesOrders", content);
			return (SalesOrder)JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result, typeof(SalesOrder));
		}

		public async Task<SalesOrder> DeleteAsync(int id)
		{
			var response = await CallAPiAsync(HttpMethod.Delete, $"/api/SalesOrders/{id}");
			return (SalesOrder)JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result, typeof(SalesOrder));
		}

		public async Task<SalesOrder> GetAsync(int id)
		{
			var response = await CallAPiAsync(HttpMethod.Get, $"/api/SalesOrders/{id}");
			return (SalesOrder)JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result, typeof(SalesOrder));
		}

		public async Task<SalesOrder> GetSalesOrderForCharacterAsync(int cid)
		{
			var response = await CallAPiAsync(HttpMethod.Get, $"/api/Characters/{cid}/SalesOrders");
			return (SalesOrder)JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result, typeof(SalesOrder));
		}

		public async Task<IEnumerable<SalesOrder>> ListAllAsync()
		{
			var response = await CallAPiAsync(HttpMethod.Get, "/api/SalesOrders");
			return (List<SalesOrder>)JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result, typeof(List<SalesOrder>)); ;
		}

		public async Task<SalesOrder> UpdateAsync(SalesOrder salesOrder)
		{
			var content = JsonConvert.SerializeObject(salesOrder);
			var response = await CallAPiAsync(HttpMethod.Put, $"/api/SalesOrders/{salesOrder.Id}", content);
			return (SalesOrder)JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result, typeof(SalesOrder));
		}

		public async Task<ShoppingList> AddItemAsync(ShoppingList shoppingList, int salesOrderId)
		{
			var content = JsonConvert.SerializeObject(shoppingList);
			var response = await CallAPiAsync(HttpMethod.Post, $"/api/ShoppingLists/additem/{salesOrderId}", content);
			var result = JsonConvert.DeserializeObject<ShoppingList>(response.Content.ReadAsStringAsync().Result);
			return result;
		}

		public async Task<IEnumerable<ShoppingList>> AddItemsAsync(IEnumerable<ShoppingList> shoppingList, int salesOrderId)
		{
			var content = JsonConvert.SerializeObject(shoppingList);
			var response = await CallAPiAsync(HttpMethod.Post, $"/api/ShoppingLists/additems/{salesOrderId}", content);
			return JsonConvert.DeserializeObject<IEnumerable<ShoppingList>>(response.Content.ReadAsStringAsync().Result);
		}
	}
}
