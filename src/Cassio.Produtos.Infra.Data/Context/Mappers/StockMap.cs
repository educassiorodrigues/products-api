using Cassio.Produtos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cassio.Produtos.Infra.Data.Context.Mappers
{
    public class StockMap : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.ToTable("STOCKS");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id)
                .HasColumnName("ID");

            builder.Property(s => s.Description)
                .HasColumnName("DESCRIPTION")
                .IsRequired();

            builder.OwnsOne(s => s.Address)
                .Property(s => s.Number)
                .HasColumnName("ADDRESS_NUMBER");

            builder.OwnsOne(s => s.Address)
                .Property(s => s.City)
                .HasColumnName("ADDRESS_CITY");

            builder.OwnsOne(s => s.Address)
                .Property(s => s.Complement)
                .HasColumnName("ADDRESS_COMPLEMENT");

            builder.OwnsOne(s => s.Address)
                .Property(s => s.Country)
                .HasColumnName("ADDRESS_COUNTRY");

            builder.OwnsOne(s => s.Address)
                .Property(s => s.Neighborhood)
                .HasColumnName("ADDRESS_NEIGHBORHOOD");

            builder.OwnsOne(s => s.Address)
                .Property(s => s.State)
                .HasColumnName("ADDRESS_STATE");

            builder.HasMany(s => s.Products)
                .WithOne(p => p.Location)
                .HasForeignKey(p => p.LocationId);
        }
    }
}
