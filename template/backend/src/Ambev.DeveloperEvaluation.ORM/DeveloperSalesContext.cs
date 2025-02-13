using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace Ambev.DeveloperEvaluation.ORM
{
    public class DeveloperSalesContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<BoughtProducts> BoughtProducts { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Rating> Rate { get; set; }

        public DeveloperSalesContext(DbContextOptions<DeveloperSalesContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

    }

    public class DeveloperSalesDbContextFactory : IDesignTimeDbContextFactory<DeveloperSalesContext>
    {
        public DeveloperSalesContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<DeveloperSalesContext>();
            var connectionString = configuration.GetConnectionString("DeveloperSalesConnection");

            builder.UseNpgsql(
                   connectionString,
                   b => b.MigrationsAssembly("Ambev.DeveloperEvaluation.WebApi")
            );

            return new DeveloperSalesContext(builder.Options);
        }
    }
}
