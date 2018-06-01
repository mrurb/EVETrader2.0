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
		public EVETraderClient ETAclient { get; }

		public ShoppingListRepository(EVETraderClient eTAclient)
		{
			ETAclient = eTAclient;
		}

		public async Task<IEnumerable<ShoppingList>> GetShoppingList(int id)
		{
			//var shoppinglists = await api.CallAPiAsync(HttpMethod.Get, $"/api/ShoppingLists/{id}");
			var shoppinglists = await ETAclient.Client.GetAsync($"/api/ShoppingLists/{id}");
			return await Deserialize<IEnumerable<ShoppingList>>.DeserializeTAsync(shoppinglists);
		}
	}
}
