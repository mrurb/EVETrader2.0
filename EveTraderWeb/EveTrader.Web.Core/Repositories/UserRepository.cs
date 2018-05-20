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
		private readonly IApi api;

		public UserRepository(IApi api)
		{
			this.api = api;
		}

		public async Task<User> CreateUser(User user)
		{
			var userString = JsonConvert.SerializeObject(user);
			var response = await api.CallAPiAsync(HttpMethod.Post, $"/api/Users", userString);
			return (User)JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result, typeof(User));
		}

		public async Task<User> GetAsync(int id)
		{
			var response = await api.CallAPiAsync(HttpMethod.Get, $"/api/Users/{id}");
			return (User)JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result, typeof(User));
		}
	}
}
