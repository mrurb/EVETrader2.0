using System;
using System.Collections.Generic;
using System.Text;

namespace EVETrader.Core.Model
{
	public class ShoppingList
	{
		public int Id { get; set; }
		public int Quantity { get; set; }
		public int TypeId { get; set; }
		public virtual SalesOrder SalesOrder { get; set; }
	}
}
