﻿using EVETrader.Core.Data;
using EVETrader.Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVETrader.Core.Repositories
{

    public interface ISalesOrderRepository
    {
        Task<List<SalesOrder>> ListAllAsync();
        Task<SalesOrder> GetAsync(int id);
        Task<SalesOrder> UpdateAsync(SalesOrder salesOrder);
        Task<SalesOrder> CreateAsync(SalesOrder salesOrder);
        Task<SalesOrder> DeleteAsync(int id);
        bool Any(int id);
    }
    public class SalesOrderRepository : ISalesOrderRepository
    {
        private readonly ApplicationDbContext _context;

        public SalesOrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Any(int id)
        {
            return _context.SalesOrders.Any(s => s.Id == id);
        }

        public async Task<SalesOrder> CreateAsync(SalesOrder salesOrder)
        {
           await _context.SalesOrders.AddAsync(salesOrder);
           await _context.SaveChangesAsync();
            return salesOrder;
        }

        public async Task<SalesOrder> DeleteAsync(int id)
        {
            var salesOrder = await _context.SalesOrders.FindAsync(id);
            _context.SalesOrders.Remove(salesOrder);
            await _context.SaveChangesAsync();

            return salesOrder;
        }

        public Task<SalesOrder> GetAsync(int id)
        {
            return _context.SalesOrders.Include(s => s.Buyer).Include(s => s.Trader).FirstOrDefaultAsync(s => s.Id == id);
            
        }

        public Task<List<SalesOrder>> ListAllAsync()
        {
            var salesOrder = _context.SalesOrders.Include(u => u.Buyer).Include(u => u.Trader).ToListAsync();
            return salesOrder;
        }

        public async Task<SalesOrder> UpdateAsync(SalesOrder salesOrder)
        {
            _context.Entry(salesOrder).State = EntityState.Modified;

            await  _context.SaveChangesAsync();

            return salesOrder;

            
        }
    }
}