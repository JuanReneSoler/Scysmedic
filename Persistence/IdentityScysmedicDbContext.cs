using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Persistence
{
    public partial class IdentityScysmedicDbContext : IdentityDbContext
    {
        public IdentityScysmedicDbContext()
        {
        }

        public IdentityScysmedicDbContext(DbContextOptions<IdentityScysmedicDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=ScysmedicDB;Trusted_Connection=True;");
            }
        }
    }
}
