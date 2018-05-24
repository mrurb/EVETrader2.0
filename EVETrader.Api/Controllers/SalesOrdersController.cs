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
using EVETrader.Core.Repositories;

namespace EVETrader.Api.Controllers
{

	[Produces("application/json")]
	[Route("api/[controller]")]
	public class SalesOrdersController : Controller
	{
		private readonly IUserRepository userRepository;
		private readonly IMapper _mapper;
		private readonly ISalesOrderRepository salesOrderRepository;

		public SalesOrdersController(IMapper mapper, ISalesOrderRepository salesOrderRepository, IUserRepository userRepository)
		{
			this.userRepository = userRepository;
			_mapper = mapper;
			this.salesOrderRepository = salesOrderRepository;
		}
		/// <summary>
		/// Gets all salesOrders.
		/// </summary>
		// GET: api/SalesOrders
		[HttpGet("")]
		public async Task<IEnumerable<ViewModel.SalesOrder>> GetSalesOrdersAsync()
		{
			var salesOrder = await salesOrderRepository.ListAllAsync();
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

            var salesOrder = await salesOrderRepository.GetAsync(id);
			if (salesOrder == null)
			{
				return NotFound();
			}

			return Ok(_mapper.Map<ViewModel.SalesOrder>(salesOrder));
		}

		/// <summary>
		/// Update salesorder - Not working
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
            var response = await salesOrderRepository.UpdateAsync(salesOrderCore);
            //_context.Entry(salesOrderCore).State = EntityState.Modified;

            /*
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
            */
			return Ok(salesOrder);
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
			if (await UserExists(salesOrder.BuyerID))
			{
                //var buyer = await _context.Users.FindAsync(salesOrder.BuyerID);
                var buyer = await userRepository.GetAsync(salesOrder.BuyerID);
                //USER REPOSITORY
                salesOrderCore.Buyer = buyer;
			}
			/*
			if (await UserExists(salesOrder.TraderID))
			{
                //var trader = await _context.Users.FindAsync(salesOrder.TraderID);
                var trader = await userRepository.GetAsync(salesOrder.TraderID);
                //USER REPOSITORY
                salesOrderCore.Trader = trader;
			}*/
			salesOrderCore.Trader = null;
			salesOrder.TraderID = 0;

			//_context.SalesOrders.Add(salesOrderCore);
            await salesOrderRepository.CreateAsync(salesOrderCore);
			//await _context.SaveChangesAsync();

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

            //var salesOrder = await _context.SalesOrders.FindAsync(id);
            var salesOrder = await salesOrderRepository.GetAsync(id);
            if (salesOrder == null)
			{
				return NotFound();
			}

            //_context.SalesOrders.Remove(salesOrder);
            await salesOrderRepository.DeleteAsync(id);
            //await _context.SaveChangesAsync();
           
			return Ok(_mapper.Map<ViewModel.SalesOrder>(salesOrder));
		}

		[HttpOptions("{id}/publish")]
		public async Task<IActionResult> PublishOrder([FromRoute]int id)
		{
			var salesOrder = await salesOrderRepository.GetAsync(id);
			salesOrder.Published = true;
			await salesOrderRepository.UpdateAsync(salesOrder);

			return Ok(_mapper.Map<ViewModel.SalesOrder>(salesOrder));
		}
		
		[HttpOptions("{id}/finish")]
		public async Task<IActionResult> FinishOrder([FromRoute]int id)
		{
			var salesOrder = await salesOrderRepository.GetAsync(id);
			salesOrder.Finished = true;
			await salesOrderRepository.UpdateAsync(salesOrder);
			return Ok(_mapper.Map<ViewModel.SalesOrder>(salesOrder));
		}
		/// <summary>
		/// set trader on order
		/// </summary>
		/// <param name="id">Sales Order ID</param>
		/// <param name="cid">Character id</param>
		/// <returns>Sales order</returns>
		[HttpOptions("{id}/settrader/{cid}")]
		public async Task<IActionResult> SetTrader([FromRoute]int id, [FromRoute] int cid)
		{
			var salesOrder = await salesOrderRepository.GetAsync(id);
			var trader = await userRepository.GetAsync(cid);
			salesOrder.Trader = trader;
			await salesOrderRepository.UpdateAsync(salesOrder);
			return Ok(_mapper.Map<ViewModel.SalesOrder>(salesOrder));
		}

		private bool SalesOrderExists(int id)
		{
            return  salesOrderRepository.Any(id);
			//return _context.SalesOrders.Any(e => e.Id == id);
		}

		private async Task<bool> UserExists(int id)
		{
            //USER REPOSITORY
            return  await userRepository.Any(id);
			//return _context.Users.Any(e => e.Id == id);
		}
	}
}