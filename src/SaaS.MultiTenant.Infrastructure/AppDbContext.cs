using Microsoft.EntityFrameworkCore;
using SaaS.MultiTenant.Core.Entities;

namespace SaaS.MultiTenant.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<User> Users { get; set; }
    }
} 