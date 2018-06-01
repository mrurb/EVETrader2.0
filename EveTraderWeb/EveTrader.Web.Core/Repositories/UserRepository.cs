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
    public interface IUserRepository
    {
		Task<User> GetAsync(int id);
		Task<User> CreateUser(User user);
    }

	public class UserRepository : IUserRepository
	{

		public EVETraderClient ETAClient { get; }

		public UserRepository(EVETraderClient eTAclient)
		{
			ETAClient = eTAclient;
		}

		public async Task<User> CreateUser(User user)
		{
			//var userString = JsonConvert.SerializeObject(user);
			//var response = await api.CallAPiAsync(HttpMethod.Post, $"/api/Users", userString);
			var response = await ETAClient.Client.PostAsJsonAsync($"/api/Users", user);
			return await Deserialize<User>.DeserializeTAsync(response);
		}

		public async Task<User> GetAsync(int id)
		{
			//var response = await api.CallAPiAsync(HttpMethod.Get, $"/api/Users/{id}");
			var response = await ETAClient.Client.GetAsync($"/api/Users/{id}");
			return (User)JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result, typeof(User));
		}
	}
}
