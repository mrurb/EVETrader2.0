using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EVETrader.Web.Models
{
    public class SalesOrderIndexView
    {
        public int id { get; set; } //hidden
        [DisplayName("Trader")]
        public String traderUsername { get; set; }
        [DisplayName("Buyer")]
        public String buyerUsername { get; set; }
        [DisplayName("Destination")]
        public String destination { get; set; }
        [DisplayName("Price")]
        public int estimatedPrice { get; set; }
        [DisplayName("Tip")]
        public double tip { get; set; }
        public int published { get; set; } //hidden
        
    }

    public class SalesOrderCreateView
    {
        [DisplayName("Trader")]
        [Required]
        public String traderUsername { get; set; }
        [DisplayName("Buyer")]
        [Required]
        public String buyerUsername { get; set; }
        [DisplayName("Destination")]
        [Required]
        public String destination { get; set; }
        [DisplayName("Tip")]
        public int tip { get; set; }

    }

    public class SalesOrderDetailsView
    {
        public int id { get; set; } //hidden
        [DisplayName("Trader")]
        public String traderUsername { get; set; }
        [DisplayName("Buyer")]
        public String buyerUsername { get; set; }
        [DisplayName("Destination")]
        public String destination { get; set; }
        [DisplayName("Price")]
        public int estimatedPrice { get; set; }
        [DisplayName("Tip")]
        public int tip { get; set; }
        [DisplayName("Published")]
        public bool published { get; set; }
    }

    public class SalesOrderUpdate
    {
        [DisplayName("Trader")]
        [Required]
        public String traderUsername { get; set; }
        [DisplayName("Buyer")]
        [Required]
        public String buyerUsername { get; set; }
        [DisplayName("Destination")]
        [Required]
        public String destination { get; set; }
        [DisplayName("Tip")]
        public int tip { get; set; }
        [DisplayName("Published")]
        [Required]
        public bool published { get; set; }
    }
}
