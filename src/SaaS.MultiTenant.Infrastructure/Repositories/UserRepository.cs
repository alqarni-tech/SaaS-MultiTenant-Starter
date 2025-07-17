using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SaaS.MultiTenant.Core.Entities;
using SaaS.MultiTenant.Core.Interfaces;

namespace SaaS.MultiTenant.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<User> GetByIdAsync(Guid id) => await _context.Users.FindAsync(id) ?? throw new InvalidOperationException("User not found");
        public async Task<User> GetByEmailAsync(string email) => await _context.Users.FirstOrDefaultAsync(u => u.Email == email) ?? throw new InvalidOperationException("User not found");
        public async Task<IEnumerable<User>> GetByTenantIdAsync(Guid tenantId) => await _context.Users.Where(u => u.TenantId == tenantId).ToListAsync();
        public async Task AddAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
        }
    }
} 