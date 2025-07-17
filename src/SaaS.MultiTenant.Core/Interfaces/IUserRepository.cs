using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SaaS.MultiTenant.Core.Entities;

namespace SaaS.MultiTenant.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(Guid id);
        Task<User> GetByEmailAsync(string email);
        Task<IEnumerable<User>> GetByTenantIdAsync(Guid tenantId);
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(Guid id);
    }
} 