using Cassio.Produtos.Domain.Entities;
using Cassio.Produtos.Infra.Data.Context.Mappers;
using Microsoft.EntityFrameworkCore;

namespace Cassio.Produtos.Infra.Data.Context
{
    public class ProductsContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("CONNECTION_STRING"));
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductMap());
        }
      
    }
}
