using EveTrader.Web.Core.Models;
using EveTrader.Web.Core.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EveTrader.Web.Core
{
	public interface IShoppingListRepository
	{
		/// <summary>
		/// Get all shopping lists for one salesorder
		/// </summary>
		/// <param name="id">SalesOrder id</param>
		/// <returns></returns>
		Task<IEnumerable<ShoppingList>> GetShoppingList(int id);
	}

	public class ShoppingListRepository : IShoppingListRepository
	{
		private readonly IApi api;

		public ShoppingListRepository(IApi api)
		{
			this.api = api;
		}

		public async Task<IEnumerable<ShoppingList>> GetShoppingList(int id)
		{
			var shoppinglists = await api.CallAPiAsync(HttpMethod.Get, $"/api/ShoppingLists/{id}");
			return JsonConvert.DeserializeObject<IEnumerable<ShoppingList>>(await shoppinglists.Content.ReadAsStringAsync());
		}
	}
}
