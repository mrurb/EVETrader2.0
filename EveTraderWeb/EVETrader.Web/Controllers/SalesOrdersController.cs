using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EVETrader.Core.Data;
using EVETrader.Core.Model;

namespace EVETrader.Web.Controllers
{
    public class SalesOrdersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SalesOrdersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SalesOrders
        public async Task<IActionResult> Index()
        {
            var salesOrder1 = new SalesOrder()
            {
                Id = 1,
                estimatedPrice = 1203
            };
            var salesOrder2 = new SalesOrder()
            {
                Id = 3,
                estimatedPrice = 333
            };
            var salesOrder = new List<SalesOrder>();
            salesOrder.Add(salesOrder1);
            salesOrder.Add(salesOrder2);
            return View(salesOrder);
        }

        // GET: SalesOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var salesOrder = new SalesOrder();
            if (id == null)
            {
                return NotFound();
            }

            //var salesOrder = await _context.SalesOrders
                //.SingleOrDefaultAsync(m => m.Id == id);
            if (salesOrder == null)
            {
                return NotFound();
            }

            return View(salesOrder);
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
        public async Task<IActionResult> Create([Bind("Id,Destination,estimatedPrice,Tip,Published")] SalesOrder salesOrder)
        {
            if (ModelState.IsValid)
            {
                //_context.Add(salesOrder);
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(salesOrder);
        }

        // GET: SalesOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var salesOrder = new SalesOrder();
            //var salesOrder = await _context.SalesOrders.SingleOrDefaultAsync(m => m.Id == id);
            if (salesOrder == null)
            {
                return NotFound();
            }
            return View(salesOrder);
        }

        // POST: SalesOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Destination,estimatedPrice,Tip,Published")] SalesOrder salesOrder)
        {
            if (id != salesOrder.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //_context.Update(salesOrder);
                    //await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SalesOrderExists(salesOrder.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(salesOrder);
        }

        // GET: SalesOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var salesOrder = new SalesOrder();
            //var salesOrder = await _context.SalesOrders
                //.SingleOrDefaultAsync(m => m.Id == id);
            if (salesOrder == null)
            {
                return NotFound();
            }

            return View(salesOrder);
        }

        // POST: SalesOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //var salesOrder = await _context.SalesOrders.SingleOrDefaultAsync(m => m.Id == id);
            //_context.SalesOrders.Remove(salesOrder);
            //await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SalesOrderExists(int id)
        {
            return false; //_context.SalesOrders.Any(e => e.Id == id);
        }
    }
}
