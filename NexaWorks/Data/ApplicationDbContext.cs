using Microsoft.EntityFrameworkCore;
using NexaWorks.Models.Entities;

namespace NexaWorks.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<ProductOperatingSystem> ProductOperatingSystems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<ProductVersion> ProductVersions { get; set; }
        public DbSet<ProductBuild> ProductBuilds { get; set; }

    }
}
