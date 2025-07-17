using Microsoft.AspNetCore.Mvc;
using SaaS.MultiTenant.Application.Services;
using SaaS.MultiTenant.Core.Entities;

namespace SaaS.MultiTenant.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TenantController : ControllerBase
    {
        private readonly TenantService _tenantService;
        public TenantController(TenantService tenantService)
        {
            _tenantService = tenantService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _tenantService.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var tenant = await _tenantService.GetByIdAsync(id);
            if (tenant == null) return NotFound();
            return Ok(tenant);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Tenant tenant)
        {
            tenant.Id = Guid.NewGuid();
            tenant.CreatedAt = DateTime.UtcNow;
            await _tenantService.AddAsync(tenant);
            return CreatedAtAction(nameof(GetById), new { id = tenant.Id }, tenant);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, Tenant tenant)
        {
            if (id != tenant.Id) return BadRequest();
            await _tenantService.UpdateAsync(tenant);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _tenantService.DeleteAsync(id);
            return NoContent();
        }
    }
} 