using System;
using System.Collections.Generic;
using System.Text;

namespace EVETrader.Core.Model
{
	public class ShoppingList
	{
		public int Id { get; set; }
		public int Quanttity { get; set; }
		public int TypeID { get; set; }
		public virtual SalesOrder SalesOrder { get; set; }
	}
}
