using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EveTrader.Web.Core.Repositories
{

	public interface IApi
	{
		Task<HttpResponseMessage> CallAPiAsync(HttpMethod httpMethod, string url, string content);
		Task<HttpResponseMessage> CallAPiAsync(HttpMethod httpMethod, string url);
		}
	public class API : IApi
    {

		private readonly HttpClient httpClient;


		public API(HttpClient httpClient)
		{
			this.httpClient = httpClient;
			httpClient.BaseAddress = new Uri("http://localhost:56362");
		}

		public async Task<HttpResponseMessage> CallAPiAsync(HttpMethod httpmethod, string url, string content)
		{

			HttpRequestMessage requestMessage = new HttpRequestMessage(httpmethod, url);
			httpClient.DefaultRequestHeaders.Clear();
			httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			requestMessage.Content = new StringContent(content, Encoding.UTF8, "application/json");
			var call = await httpClient.SendAsync(requestMessage);
			if (!call.IsSuccessStatusCode)
			{
				throw new Exception(call.StatusCode.ToString());
			}
			return call;
		}

		public async Task<HttpResponseMessage> CallAPiAsync(HttpMethod httpmethod, string url)
		{
			httpClient.DefaultRequestHeaders.Clear();
			httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			HttpRequestMessage test = new HttpRequestMessage(httpmethod, url);
			return await httpClient.SendAsync(test);
		}
	}
}
