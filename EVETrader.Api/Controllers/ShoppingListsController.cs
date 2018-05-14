using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EVETrader.Core.Data;
using EVETrader.Core.Model;
using AutoMapper;

namespace EVETrader.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/ShoppingLists")]
    public class ShoppingListsController : Controller
    {
        private readonly ApplicationDbContext _context;
		private readonly IMapper _mapper;

		public ShoppingListsController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
			_mapper = mapper;
        }
		
		/// <summary>
		/// Gets all salesOrders.
		/// </summary>
		// GET: api/SalesOrders
		[HttpGet]
		public IEnumerable<ViewModel.ShoppingList> GetShoppingLists()
		{
			return _mapper.Map<List<ViewModel.ShoppingList>>(_context.ShoppingLists.ToList());
		}
		
		/// <summary>
		/// Get items in a salesorder
		/// </summary>
		/// <param name="id">Salesorder id</param>
		// GET: api/ShoppingLists/5
		[HttpGet("{id}")]
        public async Task<IActionResult> GetShoppingList([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
			List<ShoppingList> shoppingList = null;
			try
			{

				shoppingList = await _context.ShoppingLists.Include(s => s.SalesOrder).Where(s => s.SalesOrder.Id == id).ToListAsync();
			}
			catch (Exception e)
			{

				throw e;
			}
            if (shoppingList == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<List<ViewModel.ShoppingList>>(shoppingList));
        }
		/*
        // PUT: api/ShoppingLists/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShoppingList([FromRoute] int id, [FromBody] ShoppingList shoppingList)
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

        // POST: api/ShoppingLists
        [HttpPost]
        public async Task<IActionResult> PostShoppingList([FromBody] ShoppingList shoppingList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ShoppingLists.Add(shoppingList);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetShoppingList", new { id = shoppingList.Id }, shoppingList);
        }

        // DELETE: api/ShoppingLists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShoppingList([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var shoppingList = await _context.ShoppingLists.SingleOrDefaultAsync(m => m.Id == id);
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