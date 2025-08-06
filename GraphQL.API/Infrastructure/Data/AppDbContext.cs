using GraphQL.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.API.Infrastructure.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products => Set<Product>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Add your model configurations here
        }
        // Define DbSet properties for your entities here
        // public DbSet<YourEntity> YourEntities { get; set; }
    }
   
}
