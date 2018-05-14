using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EVETrader.Core.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace EVETrader.Api.Controllers
{
	[Produces("application/json")]
	[Route("api/Characters")]
	public class CharactersController : Controller
	{

		private readonly ApplicationDbContext _context;
		private readonly IMapper _mapper;

		public CharactersController(ApplicationDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		/// <summary>
		/// Gets all salesOrders for one character.
		/// </summary>
		/// <param name="cid">Character id</param>
		// GET: api/characters/1/SalesOrders
		[HttpGet("{cid}/SalesOrders")]
		[SwaggerOperation(Tags = new[] { "SalesOrders" })]
		public async Task<IActionResult> GetCharactersSalesOrder([FromRoute] int cid)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			
			var salesOrder = await _context.SalesOrders.Include(u => u.Buyer).Include(u => u.Trader).Where(s => s.Buyer.Id == cid || s.Trader.Id == cid).ToListAsync();

			if (salesOrder == null)
			{
				return NotFound();
			}

			return Ok(_mapper.Map<List<ViewModel.SalesOrder>>(salesOrder));
		}

	}
}