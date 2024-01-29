using Cassio.Produtos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cassio.Produtos.Infra.Data.Context.Mappers
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("PRODUCTS");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Description)
                .HasColumnName("DESCRIPTION");

            builder.Property(p => p.StockQuantity)
               .HasColumnName("QUANTITY");

            builder.Property(p => p.BarCode)
               .HasColumnName("BAR_CODE");
        }
    }
}
