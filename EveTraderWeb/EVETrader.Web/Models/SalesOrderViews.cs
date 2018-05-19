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
        public int Id { get; set; } //hidden
        [DisplayName("Trader")]
        public int TraderId { get; set; }
        [DisplayName("Buyer")]
        public int BuyerID { get; set; }
        [DisplayName("Destination")]
        public int Destination { get; set; }
        [DisplayName("Price")]
        public int EstimatedPrice { get; set; }
        [DisplayName("Tip")]
        public double Tip { get; set; }
        public bool Published { get; set; } //hidden
        
    }

    public class SalesOrderCreateView
    {
        [DisplayName("Trader")]
        [Required]
        public int TraderUsername { get; set; }
        [DisplayName("Buyer")]
        [Required]
        public int BuyerUsername { get; set; }
        [DisplayName("Destination")]
        [Required]
        public int Destination { get; set; }
        [DisplayName("Tip")]
        public int Tip { get; set; }

    }

    public class SalesOrderDetailsView
    {
        public int Id { get; set; } //hidden
        [DisplayName("Trader")]
        public int TraderUsername { get; set; }
        [DisplayName("Buyer")]
        public int BuyerUsername { get; set; }
        [DisplayName("Destination")]
        public int Destination { get; set; }
        [DisplayName("Price")]
        public int EstimatedPrice { get; set; }
        [DisplayName("Tip")]
        public int Tip { get; set; }
        [DisplayName("Published")]
        public bool Published { get; set; }

        public List<ShoppingListViewModel> ShoppingList { get; set; }
    }

    public class SalesOrderUpdateView
    {   
        public int Id { get; set; }
        [DisplayName("Trader")]
        [Required]
        public int TraderUsername { get; set; }
        [DisplayName("Buyer")]
        [Required]
        public int BuyerUsername { get; set; }
        [DisplayName("Destination")]
        [Required]
        public int Destination { get; set; }
        [DisplayName("Tip")]
        public int Tip { get; set; }
        [DisplayName("Published")]
        [Required]
        public bool Published { get; set; }
    }
}
