using System;
using System.Collections.Generic;
using System.Text;

namespace EVETrader.Core.Model
{
	public class SalesOrder
	{
		public int Id { get; set; }
		public User Trader { get; set; }
		public User Buyer { get; set; }
		public int Destination { get; set; }
		public double estimatedPrice { get; set; }
		public double Tip { get; set; }
		public bool Published { get; set; }
		public bool Finished { get; set; }
		public List<ShoppingList> ShoppingList { get; set; }
	}
}
