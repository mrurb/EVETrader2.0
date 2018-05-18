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
        public String TraderUsername { get; set; }
        [DisplayName("Buyer")]
        public String BuyerUsername { get; set; }
        [DisplayName("Destination")]
        public String Destination { get; set; }
        [DisplayName("Price")]
        public int EstimatedPrice { get; set; }
        [DisplayName("Tip")]
        public double Tip { get; set; }
        public int Published { get; set; } //hidden
        
    }

    public class SalesOrderCreateView
    {
        [DisplayName("Trader")]
        [Required]
        public String TraderUsername { get; set; }
        [DisplayName("Buyer")]
        [Required]
        public String BuyerUsername { get; set; }
        [DisplayName("Destination")]
        [Required]
        public String Destination { get; set; }
        [DisplayName("Tip")]
        public int Tip { get; set; }

    }

    public class SalesOrderDetailsView
    {
        public int Id { get; set; } //hidden
        [DisplayName("Trader")]
        public String TraderUsername { get; set; }
        [DisplayName("Buyer")]
        public String BuyerUsername { get; set; }
        [DisplayName("Destination")]
        public String Destination { get; set; }
        [DisplayName("Price")]
        public int EstimatedPrice { get; set; }
        [DisplayName("Tip")]
        public int Tip { get; set; }
        [DisplayName("Published")]
        public bool Published { get; set; }

        public List<ShoppingListViewModel> ShoppingList { get; set; }
    }

    public class SalesOrderUpdate
    {   
        public int Id { get; set; }
        [DisplayName("Trader")]
        [Required]
        public String TraderUsername { get; set; }
        [DisplayName("Buyer")]
        [Required]
        public String BuyerUsername { get; set; }
        [DisplayName("Destination")]
        [Required]
        public String Destination { get; set; }
        [DisplayName("Tip")]
        public int Tip { get; set; }
        [DisplayName("Published")]
        [Required]
        public bool Published { get; set; }
    }
}
