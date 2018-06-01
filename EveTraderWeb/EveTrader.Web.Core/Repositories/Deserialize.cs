using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EveTrader.Web.Core
{
	public static class Deserialize<T>
	{
		public static async Task<T> DeserializeTAsync(HttpResponseMessage response)
		{
			return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
		}
	}
}
