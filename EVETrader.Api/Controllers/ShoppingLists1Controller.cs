using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EVETrader.Core.Data;
using EVETrader.Core.Model;

namespace EVETrader.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/ShoppingLists1")]
    public class ShoppingLists1Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShoppingLists1Controller(ApplicationDbContext context)
        {
            _context = context;
        }
		/*
        // GET: api/ShoppingLists1
        [HttpGet]
        public IEnumerable<EVETrader.Core.Model.ShoppingList> GetShoppingLists()
        {
            return _context.ShoppingLists;
        }*/
		/*
        // GET: api/ShoppingLists1/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetShoppingList([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

			EVETrader.Core.Model.ShoppingList shoppingList = await _context.ShoppingLists.SingleOrDefaultAsync(m => m.Id == id);

            if (shoppingList == null)
            {
                return NotFound();
            }

            return Ok(shoppingList);
        }

        // PUT: api/ShoppingLists1/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShoppingList([FromRoute] int id, [FromBody] EVETrader.Core.Model.ShoppingList shoppingList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != shoppingList.Id)
            {
                return BadRequest();
            }

            _context.Entry(shoppingList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShoppingListExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ShoppingLists1
        [HttpPost]
        public async Task<IActionResult> PostShoppingList([FromBody] EVETrader.Core.Model.ShoppingList shoppingList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ShoppingLists.Add(shoppingList);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetShoppingList", new { id = shoppingList.Id }, shoppingList);
        }

        // DELETE: api/ShoppingLists1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShoppingList([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

			EVETrader.Core.Model.ShoppingList shoppingList = await _context.ShoppingLists.SingleOrDefaultAsync(m => m.Id == id);
            if (shoppingList == null)
            {
                return NotFound();
            }

            _context.ShoppingLists.Remove(shoppingList);
            await _context.SaveChangesAsync();

            return Ok(shoppingList);
        }
		*/
        private bool ShoppingListExists(int id)
        {
            return _context.ShoppingLists.Any(e => e.Id == id);
        }
    }
}