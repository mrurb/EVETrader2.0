namespace EVETrader.Web.Models
{
    public class ShoppingListViewModel
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int TypeId { get; set; }
		/// <summary>
		/// Salesorder id
		/// </summary>
		public int SalesOrderId { get; set; }
	}
}