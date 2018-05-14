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
	[Route("api/[controller]")]
	public class SalesOrdersController : Controller
	{
		private readonly ApplicationDbContext _context;
		private readonly IMapper _mapper;

		public SalesOrdersController(ApplicationDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		/// <summary>
		/// Gets all salesOrders.
		/// </summary>
		// GET: api/SalesOrders
		[HttpGet]
		public IEnumerable<ViewModel.SalesOrder> GetSalesOrdersAsync()
		{
			var salesOrder = _context.SalesOrders.Include(u => u.Buyer).Include(u => u.Trader);
			return _mapper.Map<List<ViewModel.SalesOrder>>(salesOrder);
		}


		/// <summary>
		/// Gets specific salesorder.
		/// </summary>
		/// <param name="id">Salesorder id</param>
		// GET: api/SalesOrders/5
		[HttpGet("{id}")]
		public async Task<IActionResult> GetSalesOrder([FromRoute] int id)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			var salesOrder = await _context.SalesOrders.Include(u => u.Buyer).Include(u => u.Trader).SingleOrDefaultAsync(s => s.Id == id);

			if (salesOrder == null)
			{
				return NotFound();
			}

			return Ok(_mapper.Map<ViewModel.SalesOrder>(salesOrder));
		}

		/// <summary>
		/// Update salesorder
		/// </summary>
		/// <param name="id">Salesorder id</param>
		/// <param name="salesOrder">SalesOrder</param>
		// PUT: api/SalesOrders/5
		[HttpPut("{id}")]
		public async Task<IActionResult> PutSalesOrder([FromRoute] int id, [FromBody] ViewModel.SalesOrder salesOrder)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			if (id != salesOrder.Id)
			{
				return BadRequest();
			}
			var salesOrderCore = _mapper.Map<Core.Model.SalesOrder>(salesOrder);
			_context.Entry(salesOrderCore).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!SalesOrderExists(id))
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

		/// <summary>
		/// Create salesorder
		/// </summary>
		/// <param name="salesOrder">SalesOrder</param>
		// POST: api/SalesOrders
		[HttpPost]
		public async Task<IActionResult> PostSalesOrder([FromBody] ViewModel.SalesOrder salesOrder)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			var salesOrderCore = _mapper.Map<Core.Model.SalesOrder>(salesOrder);
			if (UserExists(salesOrder.BuyerID))
			{
				var buyer = await _context.Users.FindAsync(salesOrder.BuyerID);
				salesOrderCore.Buyer = buyer;
			}
			if (UserExists(salesOrder.TraderID))
			{
				var trader = await _context.Users.FindAsync(salesOrder.TraderID);
				salesOrderCore.Trader = trader;
			}


			_context.SalesOrders.Add(salesOrderCore);
			await _context.SaveChangesAsync();

			return CreatedAtAction("GetSalesOrder", new { id = salesOrder.Id }, salesOrder);
		}
		/// <summary>
		/// delete salesorder
		/// </summary>
		/// <param name="id">Salesorder id</param>
		// DELETE: api/SalesOrders/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteSalesOrder([FromRoute] int id)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			var salesOrder = await _context.SalesOrders.FindAsync(id);
			if (salesOrder == null)
			{
				return NotFound();
			}

			_context.SalesOrders.Remove(salesOrder);
			await _context.SaveChangesAsync();

			return Ok(_mapper.Map<ViewModel.SalesOrder>(salesOrder));
		}

		private bool SalesOrderExists(int id)
		{
			return _context.SalesOrders.Any(e => e.Id == id);
		}

		private bool UserExists(int id)
		{
			return _context.Users.Any(e => e.Id == id);
		}
	}
}