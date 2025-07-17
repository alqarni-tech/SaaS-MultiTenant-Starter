using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SaaS.MultiTenant.Core.Entities;
using SaaS.MultiTenant.Core.Interfaces;

namespace SaaS.MultiTenant.Application.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<User> GetByIdAsync(Guid id) => _userRepository.GetByIdAsync(id);
        public Task<User> GetByEmailAsync(string email) => _userRepository.GetByEmailAsync(email);
        public Task<IEnumerable<User>> GetByTenantIdAsync(Guid tenantId) => _userRepository.GetByTenantIdAsync(tenantId);
        public Task AddAsync(User user) => _userRepository.AddAsync(user);
        public Task UpdateAsync(User user) => _userRepository.UpdateAsync(user);
        public Task DeleteAsync(Guid id) => _userRepository.DeleteAsync(id);
    }
} 