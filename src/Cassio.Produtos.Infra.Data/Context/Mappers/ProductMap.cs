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

            builder.Property(p => p.Id)
                .HasColumnName("ID");

            builder.Property(p => p.Description)
                .HasColumnName("DESCRIPTION");

            builder.Property(p => p.StockQuantity)
               .HasColumnName("QUANTITY");

            builder.Property(p => p.BarCode)
               .HasColumnName("BAR_CODE");

            builder.Property(p => p.SalePrice)
                .HasColumnName("SALE_PRICE");

            builder.Property(p => p.ExpirationDate)
               .HasColumnName("EXPIRATION_DATE");

            builder.Property(p => p.ManufactoringDate)
                .HasColumnName("MANUFACTORING_DATE");

            builder.OwnsOne(p => p.Mensure)
                .Property(p => p.Quantity)
                .HasColumnName("MEASURE_QUANTITY");

            builder.OwnsOne(p => p.Mensure)
                .Property(p => p.UnityMeasurement)
                .HasColumnName("MEASURE_UNITY_MEASUREMENT");

            builder.HasOne(p => p.Category)
                .WithMany()
                .HasForeignKey(p => p.CategoryId)
                .HasPrincipalKey(p => p.Id);

            builder.HasOne(p => p.Location)
                .WithMany()
                .HasForeignKey(p => p.LocationId)
                .HasPrincipalKey(p => p.Id);

            builder.HasOne(p => p.Supplier)
                .WithMany()
                .HasForeignKey(p => p.SupplierId)
                .HasPrincipalKey(p => p.Id);
        }
    }
}
