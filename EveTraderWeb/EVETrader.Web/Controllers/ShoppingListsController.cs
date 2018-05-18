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
    public class ShoppingListsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShoppingListsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ShoppingLists
        public async Task<IActionResult> Index()
        {
            var shoppingList = new List<ShoppingList>();

            var shoppingList1 = new ShoppingList()
            {
                Id = 1,
                Quantity = 2,
                TypeID = 13
            };
            var shoppingList2 = new ShoppingList()
            {
                Id = 5,
                Quantity = 0,
                TypeID = 20
            };
            shoppingList.Add(shoppingList1);
            shoppingList.Add(shoppingList2);
            return View(shoppingList);
        }

        // GET: ShoppingLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoppingList = await _context.ShoppingLists
                .SingleOrDefaultAsync(m => m.Id == id);
            if (shoppingList == null)
            {
                return NotFound();
            }

            return View(shoppingList);
        }

        // GET: ShoppingLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ShoppingLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Quantity,TypeID")] ShoppingList shoppingList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shoppingList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shoppingList);
        }


        

        // GET: ShoppingLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoppingList = await _context.ShoppingLists.SingleOrDefaultAsync(m => m.Id == id);
            if (shoppingList == null)
            {
                return NotFound();
            }
            return View(shoppingList);
        }

        // POST: ShoppingLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Quantity,TypeID")] ShoppingList shoppingList)
        {
            if (id != shoppingList.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shoppingList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShoppingListExists(shoppingList.Id))
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
            return View(shoppingList);
        }

        // GET: ShoppingLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoppingList = await _context.ShoppingLists
                .SingleOrDefaultAsync(m => m.Id == id);
            if (shoppingList == null)
            {
                return NotFound();
            }

            return View(shoppingList);
        }

        // POST: ShoppingLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shoppingList = await _context.ShoppingLists.SingleOrDefaultAsync(m => m.Id == id);
            _context.ShoppingLists.Remove(shoppingList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShoppingListExists(int id)
        {
            return _context.ShoppingLists.Any(e => e.Id == id);
        }
    }
}
