using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EVETrader.Web.Models;
using EveTrader.Web.Core;
using EveTrader.Web.Core.Models;

namespace EVETrader.Web.Controllers
{
    public class SalesOrdersController : Controller
    {

		public ISalesOrderRepository salesOrderRepository { get; }

		public SalesOrdersController( ISalesOrderRepository salesOrderRepository)
        {
			this.salesOrderRepository = salesOrderRepository;
        }

        // GET: SalesOrders
        public async Task<IActionResult> Index()
        {
			var test = await salesOrderRepository.ListAllAsync();
			var salesOrder = new List<SalesOrderIndexView>();
			foreach (var item in test)
			{
				salesOrder.Add(new SalesOrderIndexView()
				{
					Id = item.Id,
					BuyerID = item.BuyerID,
					Destination = item.Destination,
					Tip = item.Tip,
					Published = item.Published
				});
			}

            return View(salesOrder);
        }

        // GET: SalesOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
			if (id == null)
			{
				return NotFound();
			}

			var salesOrder = await salesOrderRepository.GetAsync((int)id);
			
			var salesOrderView = new SalesOrderDetailsView()
            {
                BuyerUsername = salesOrder.BuyerID,
				TraderUsername = salesOrder.TraderID,
                Destination = salesOrder.Destination,
                Published = salesOrder.Published,
                EstimatedPrice = 10,
                Id = salesOrder.Id,
				ShoppingList = new List<ShoppingListViewModel>()
				{
					new ShoppingListViewModel()
					{
						Id = 10,
						TypeId = 10,
						Quantity = 10
					},
					new ShoppingListViewModel()
					{
						Id = 100,
						TypeId = 100,
						Quantity = 100
					}
				}
                
            };
            

            //var salesOrder = await _context.SalesOrders
                //.SingleOrDefaultAsync(m => m.Id == id);
            if (salesOrder == null)
            {
                return NotFound();
            }

            return View(salesOrderView);
        }

        // GET: SalesOrders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SalesOrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Destination,estimatedPrice,Tip,Published")] SalesOrderCreateView SalesOrderView)
        {
            if (ModelState.IsValid)
            {
				var salesOrder = new SalesOrder()
				{
					TraderID = SalesOrderView.TraderUsername,
					BuyerID = SalesOrderView.BuyerUsername,
					Destination = SalesOrderView.Destination,
					Tip = SalesOrderView.Tip
				};
				var response = await salesOrderRepository.AddAsync(salesOrder);
                return RedirectToAction(nameof(Index));
            }
            return View(SalesOrderView);
        }

        // GET: SalesOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
			var salesOrder = await salesOrderRepository.GetAsync((int)id);

			var salesOrderView = new SalesOrderUpdateView()
			{
				BuyerUsername = salesOrder.BuyerID,
				TraderUsername = salesOrder.TraderID,
				Destination = salesOrder.Destination,
				Published = salesOrder.Published,
				Id = salesOrder.Id

			};
			if (salesOrder == null)
            {
                return NotFound();
            }
            return View(salesOrderView);
        }

        // POST: SalesOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Destination,estimatedPrice,Tip,Published")] SalesOrderUpdateView salesOrderView)
        {
            if (id != salesOrderView.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
					var salesOrder = new SalesOrder()
					{
						TraderID = salesOrderView.TraderUsername,
						BuyerID = salesOrderView.BuyerUsername,
						Destination = salesOrderView.Destination,
						Tip = salesOrderView.Tip,
						Id = salesOrderView.Id
					};
					var response = await salesOrderRepository.UpdateAsync(salesOrder);
                return RedirectToAction(nameof(Index));
            }
            return View(salesOrderView);
        }

        // GET: SalesOrders/Delete/5
        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
			var salesOrder = await salesOrderRepository.GetAsync((int)id);

			var salesOrderView = new SalesOrderDetailsView()
			{
				BuyerUsername = salesOrder.BuyerID,
				TraderUsername = salesOrder.TraderID,
				Destination = salesOrder.Destination,
				Published = salesOrder.Published,
				EstimatedPrice = 10,
				Id = salesOrder.Id

			};



			
			if (salesOrder == null)
            {
                return NotFound();
            }

            return View(salesOrderView);
        }

        // POST: SalesOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
			var salesOrder = await salesOrderRepository.DeleteAsync(id);
			return RedirectToAction(nameof(Index));
        }


        // GET: SalesOrders/AddItem/1
        public IActionResult AddItem(int? id)
        {
            ViewBag.SalesOrderId = id;
            return View();
        }

        // POST: SalesOrders/AddItem
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddItem([Bind("Id,Quantity,TypeID")] ShoppingListViewModel shoppingListViewModel)
        {
            if (ModelState.IsValid)
            {
                //_context.Add(shoppingListViewModel);
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shoppingListViewModel);
        }


        private bool SalesOrderExists(int id)
        {
            return false; //_context.SalesOrders.Any(e => e.Id == id);
        }
    }
}
