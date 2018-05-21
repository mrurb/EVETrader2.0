using System;
using EVETrader.Core.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using EVETrader.Core.Model;
using System.Linq;

namespace XUnitTestProject
{
    public class SalesOrderTestRepository : ISalesOrderRepository
    {
        List<SalesOrder> objList;
        public SalesOrderTestRepository()
        {
            objList = new List<SalesOrder>()
            {
                new SalesOrder()
                {
                    Id = 1,
                    Buyer = new User(),
                    Trader = new User(),
                    estimatedPrice = 1000,
                    Tip = 100,
                    Destination = 10,
                    Published = false,
                    ShoppingList = new List<EVETrader.Core.Model.ShoppingList>()
                },

                new SalesOrder()
                {
                    Id = 2,
                    Buyer = new User(),
                    Trader = new User(),
                    estimatedPrice = 2000,
                    Tip = 200,
                    Destination = 20,
                    Published = false,
                    ShoppingList = new List<EVETrader.Core.Model.ShoppingList>()
                },

                new SalesOrder()
                {
                    Id = 3,
                    Buyer = new User(),
                    Trader = new User(),
                    estimatedPrice = 3000,
                    Tip = 300,
                    Destination = 30,
                    Published = false,
                    ShoppingList = new List<EVETrader.Core.Model.ShoppingList>()
                },

                new SalesOrder()
                {
                    Id = 4,
                    Buyer = new User(),
                    Trader = new User(),
                    estimatedPrice = 4000,
                    Tip = 400,
                    Destination = 40,
                    Published = false,
                    ShoppingList = new List<EVETrader.Core.Model.ShoppingList>()
                },

                new SalesOrder()
                {
                    Id = 5,
                    Buyer = new User(),
                    Trader = new User(),
                    estimatedPrice = 5000,
                    Tip = 500,
                    Destination = 50,
                    Published = false,
                    ShoppingList = new List<EVETrader.Core.Model.ShoppingList>()
                },
            };
        }

		public async Task<List<EVETrader.Core.Model.SalesOrder>> ListAllAsync()
		{
			return objList;
		}

		public bool Any(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<EVETrader.Core.Model.SalesOrder> CreateAsync(EVETrader.Core.Model.SalesOrder salesOrder)
        {
            objList.Add(salesOrder);
            return salesOrder;
            
        }

        public async Task<EVETrader.Core.Model.SalesOrder> DeleteAsync(int id)
        {
            var objToDel = objList.Find(u => u.Id == id);
            
            objList.Remove(objList.Find(u => u.Id == id));

            return objToDel;
        }

        public async Task<EVETrader.Core.Model.SalesOrder> GetAsync(int id)
        {
            return objList.Find(u => u.Id == id);
        }

        

        public async Task<EVETrader.Core.Model.SalesOrder> UpdateAsync(EVETrader.Core.Model.SalesOrder salesOrder)
        {

            var obj = objList.FirstOrDefault(x => x.Id == salesOrder.Id);
            if (obj != null) {
                obj.Buyer = salesOrder.Buyer;
                obj.Trader = salesOrder.Trader;
                obj.Destination = salesOrder.Destination;
                obj.estimatedPrice = salesOrder.estimatedPrice;
                obj.Published = salesOrder.Published;
                obj.Tip = salesOrder.Tip;
            }

            return obj;
        }
    }
}
