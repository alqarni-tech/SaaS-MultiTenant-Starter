using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SaaS.MultiTenant.Core.Entities;

namespace SaaS.MultiTenant.Core.Interfaces
{
    public interface ITenantRepository
    {
        Task<Tenant> GetByIdAsync(Guid id);
        Task<Tenant> GetByNameAsync(string name);
        Task<IEnumerable<Tenant>> GetAllAsync();
        Task AddAsync(Tenant tenant);
        Task UpdateAsync(Tenant tenant);
        Task DeleteAsync(Guid id);
    }
} 