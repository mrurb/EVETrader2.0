namespace EVETrader.Web.Extensions
{
	public class SalesOrderApi
	{
		private readonly ApiClient eveTraderApiClient;

		public SalesOrderApi(ApiClient eveTraderApiClient)
		{
			this.eveTraderApiClient = eveTraderApiClient;
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
