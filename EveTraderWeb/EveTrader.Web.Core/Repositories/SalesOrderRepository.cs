using EveTrader.Web.Core.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace EveTrader.Web.Core
{
    public class SalesOrderRepository : ISalesOrderRepository
	{
		private readonly HttpClient httpClient;

		public SalesOrderRepository(HttpClient httpClient)
		{
			this.httpClient = httpClient;
			httpClient.BaseAddress = new Uri("http://localhost:")
		}

		public void CallAPi()
		{
			httpClient.BaseAddress = new Uri("https://localhost:");
		}

		public SalesOrder Add(SalesOrder salesOrder)
		{
			throw new NotImplementedException();
		}

		public SalesOrder Delete(SalesOrder salesOrder)
		{
			throw new NotImplementedException();
		}

		public SalesOrder Get(int salesOrderId)
		{
			throw new NotImplementedException();
		}

		public SalesOrder Get(int salesOrderId, int characterId)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<SalesOrder> ListAll()
		{
			httpClient.GetAsync()
			throw new NotImplementedException();
		}

		public SalesOrder Update(SalesOrder salesOrder)
		{
			throw new NotImplementedException();
		}
	}

	interface ISalesOrderRepository
	{
		IEnumerable<SalesOrder> ListAll();
		SalesOrder Add(SalesOrder salesOrder);
		SalesOrder Get(int salesOrderId);
		SalesOrder Get(int salesOrderId, int characterId);
		SalesOrder Update(SalesOrder salesOrder);
		SalesOrder Delete(SalesOrder salesOrder);
	}
}
