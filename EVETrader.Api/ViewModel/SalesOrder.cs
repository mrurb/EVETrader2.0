﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EVETrader.Api.ViewModel
{
	public class SalesOrder
	{
		public int Id { get; set; }
		public int TraderID { get; set; }
		public int BuyerID { get; set; }
		public int Destination { get; set; }
		public double Tip { get; set; }
		public bool Published { get; set; }
		public bool Finished { get; set; }
	}
}
