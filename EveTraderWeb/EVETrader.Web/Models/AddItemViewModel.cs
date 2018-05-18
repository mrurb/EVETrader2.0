using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EVETrader.Web.Models
{
    public class AddItemViewModel
    {
        public int Quantity { get; set; }
        public int TypeId { get; set; }

        public int SalesOrderId { get; set; }
    }
}
