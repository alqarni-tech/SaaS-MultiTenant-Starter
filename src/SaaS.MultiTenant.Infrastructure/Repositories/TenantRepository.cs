using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SaaS.MultiTenant.Core.Entities;
using SaaS.MultiTenant.Core.Interfaces;

namespace SaaS.MultiTenant.Infrastructure.Repositories
{
    public class TenantRepository : ITenantRepository
    {
        private readonly AppDbContext _context;
        public TenantRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Tenant> GetByIdAsync(Guid id) => await _context.Tenants.FindAsync(id) ?? throw new InvalidOperationException("Tenant not found");
        public async Task<Tenant> GetByNameAsync(string name) => await _context.Tenants.FirstOrDefaultAsync(t => t.Name == name) ?? throw new InvalidOperationException("Tenant not found");
        public async Task<IEnumerable<Tenant>> GetAllAsync() => await _context.Tenants.ToListAsync();
        public async Task AddAsync(Tenant tenant)
        {
            _context.Tenants.Add(tenant);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Tenant tenant)
        {
            _context.Tenants.Update(tenant);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid id)
        {
            var tenant = await _context.Tenants.FindAsync(id);
            if (tenant != null)
            {
                _context.Tenants.Remove(tenant);
                await _context.SaveChangesAsync();
            }
        }
    }
} 