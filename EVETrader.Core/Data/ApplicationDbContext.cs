using EVETrader.Core.Model;
using Microsoft.EntityFrameworkCore;

namespace EVETrader.Core.Data
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<SalesOrder> SalesOrders { get; set; }
		public DbSet<ShoppingList> ShoppingLists { get; set; }
		public DbSet<User> Users { get; set; }

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
	}

}
