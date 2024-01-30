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

            builder.Property(p => p.SalePrice)
                .HasColumnName("SALE_PRICE");

            builder.Property(p => p.ExpirationDate)
               .HasColumnName("EXPIRATION_DATE");

            builder.Property(p => p.ManufactoringDate)
                .HasColumnName("MANUFACTORING_DATE");

            builder.Property(p => p.Supplier)
                .HasColumnName("SUPPLIER_ID");

            builder.Property(p => p.Category)
                .HasColumnName("CATEGORY_ID");

            builder.Property(p => p.Location)
                .HasColumnName("STOCK_ID");

            builder.OwnsOne(p => p.Mensure)
                .Property(p => p.Quantity)
                .HasColumnName("QUANTITY");

            builder.OwnsOne(p => p.Mensure)
                .Property(p => p.UnityMeasurement)
                .HasColumnName("UNITY_MEASUREMENT");
                
            builder.HasOne(s => s.Supplier)
                .WithMany()
                .HasForeignKey(s => s.Supplier);

            builder.HasOne(s => s.Category)
                .WithMany()
                .HasForeignKey(s => s.Category);

            builder.HasOne(s => s.Location)
                .WithMany()
                .HasForeignKey(s => s.Location);
        }
    }
}
