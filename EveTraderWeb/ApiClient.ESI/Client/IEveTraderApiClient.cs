using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


namespace IOApiClient.ESI.Client
{
	public interface IApiClient
    {
		
    }

	public class ApiClient : IApiClient
	{
		private readonly HttpClient client;

		

		public ApiClient()
		{
			client = new HttpClient();
			client.BaseAddress = new Uri("https://esi.evetech.net");
		}

		public ApiClient(string baseUrl = "https://esi.evetech.net")
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
		public async Task<HttpResponseMessage> CallApi(string token, string path, HttpMethod method, HttpContent content)
		{
			client.DefaultRequestHeaders.Clear();
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			//client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearrer", token);
			var requestUri = new Uri(path);
			HttpRequestMessage request = new HttpRequestMessage() { Method = method, Content = content, RequestUri = requestUri };

			var response = await client.SendAsync(request);
			return response;
		}
	}

	
}
