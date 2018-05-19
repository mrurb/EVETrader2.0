namespace EveTrader.Web.Core.Models
{
	public class ShoppingList
	{
		public int Id { get; set; }
		public int Quantity { get; set; }
		public int TypeID { get; set; }
		public virtual SalesOrder SalesOrder { get; set; }
	}
}
