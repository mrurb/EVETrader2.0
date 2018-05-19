using EVETrader.Core.Data;
using EVETrader.Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EVETrader.Core.Repositories
{
    public interface IUserRepository
    {
        Task<List<User>> ListAllAsync();
        Task<User> GetAsync(int id);
        Task<User> UpdateAsync(User user);
        Task<User> CreateAsync(User user);
        Task<User> DeleteAsync(int id);
    }
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<User> CreateAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> DeleteAsync(int id)
        {
            var user = await _context.Users.SingleOrDefaultAsync(m => m.Id == id);
             _context.Remove(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<User> GetAsync(int id)
        {
            var user = await _context.Users.SingleOrDefaultAsync(m => m.Id == id);
            return user;
        }

        public async Task<List<User>> ListAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> UpdateAsync(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return user;
        }
    }
}
