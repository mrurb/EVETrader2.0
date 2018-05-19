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
		// GET: api/ShoppingList/5
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
		*/
		/// <summary>
		/// Add items to cart
		/// </summary>
		/// <param name="SalesOrderId">SalesOrder ID</param>
		/// <param name="items"></param>
		/// <returns></returns>

		// POST: api/ShoppingLists/id
		[HttpPost("additems/{SalesOrderId}")]
		public async Task<IActionResult> PostItems([FromRoute] int SalesOrderId, [FromBody] List<Items> items)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			var salesOrder = await _context.SalesOrders.Include(s => s.ShoppingList).SingleOrDefaultAsync(s => s.Id == SalesOrderId);
			foreach (var item in items)
			{
				ShoppingList shoppinglist = null;
				if (salesOrder.ShoppingList.Any(i => i.TypeId == item.TypeId))
				{
					shoppinglist = salesOrder.ShoppingList.SingleOrDefault(i => i.TypeId == item.TypeId);
					shoppinglist.Quantity += item.Quantity;
				}
				else
				{
					shoppinglist = new ShoppingList() { SalesOrder = salesOrder, TypeId = item.TypeId, Quantity = item.Quantity };
					salesOrder.ShoppingList.Add(shoppinglist);
				}
			}
			await _context.SaveChangesAsync();
			//Todo: needs fixed!!
			return CreatedAtAction("GetShoppingLists", new { id = 1 }, items);
		}
		
		/// <summary>
		/// Add items to cart
		/// </summary>
		/// <param name="salesOrderId">SalesOrder ID</param>
		/// <param name="item"></param>
		/// <returns></returns>

		// POST: api/ShoppingLists/id
		[HttpPost("additem/{salesOrderId}")]
		public async Task<IActionResult> PostItemTest([FromRoute] int salesOrderId, [FromBody] Items item)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			var salesOrder = await _context.SalesOrders.Include(s => s.ShoppingList).SingleOrDefaultAsync(s => s.Id == salesOrderId);
			ShoppingList shoppingList = null;
			if (salesOrder.ShoppingList.Any(i => i.TypeId == item.TypeId))
			{
				shoppingList = salesOrder.ShoppingList.SingleOrDefault(i => i.TypeId == item.TypeId);
				shoppingList.Quantity += item.Quantity;

			}
			else
			{
				shoppingList = new ShoppingList() { SalesOrder = salesOrder, TypeId = item.TypeId, Quantity = item.Quantity };
				salesOrder.ShoppingList.Add(shoppingList);
			}

			await _context.SaveChangesAsync();

			return CreatedAtAction("GetShoppingLists", new { id = shoppingList.Id}, item);
			//return CreatedAtAction("GetShoppingLists", new { id = SalesOrderId }, salesOrder.ShoppingList);
		}
		/*
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

	public class Items
	{
		public int TypeId { get; set; }
		public int Quantity { get; set; }

	}
}