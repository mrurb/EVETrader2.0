using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace EveTrader.Web.Core.Repositories
{
	public class EVETraderClient
	{
		public HttpClient Client { get; }
		public EVETraderClient(HttpClient client)
		{
			Client = client;
		}
	}
}
