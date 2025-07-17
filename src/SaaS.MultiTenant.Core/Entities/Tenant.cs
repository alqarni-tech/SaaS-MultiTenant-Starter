using System;

namespace SaaS.MultiTenant.Core.Entities
{
    /// <summary>
    /// Represents a tenant in the multi-tenant system.
    /// </summary>
    public class Tenant
    {
        /// <summary>
        /// Gets or sets the unique identifier for the tenant.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the tenant.
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Gets or sets the connection string for the tenant.
        /// </summary>
        public required string ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the creation date of the tenant.
        /// </summary>
        public DateTime CreatedAt { get; set; }
    }
} 