using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SaaS.MultiTenant.Core.Entities;
using SaaS.MultiTenant.Core.Interfaces;

namespace SaaS.MultiTenant.Application.Services
{
    public class TenantService
    {
        private readonly ITenantRepository _tenantRepository;

        public TenantService(ITenantRepository tenantRepository)
        {
            _tenantRepository = tenantRepository;
        }

        public Task<Tenant> GetByIdAsync(Guid id) => _tenantRepository.GetByIdAsync(id);
        public Task<Tenant> GetByNameAsync(string name) => _tenantRepository.GetByNameAsync(name);
        public Task<IEnumerable<Tenant>> GetAllAsync() => _tenantRepository.GetAllAsync();
        public Task AddAsync(Tenant tenant) => _tenantRepository.AddAsync(tenant);
        public Task UpdateAsync(Tenant tenant) => _tenantRepository.UpdateAsync(tenant);
        public Task DeleteAsync(Guid id) => _tenantRepository.DeleteAsync(id);
    }
} 