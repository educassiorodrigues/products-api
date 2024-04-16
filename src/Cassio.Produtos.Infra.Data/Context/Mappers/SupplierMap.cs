using Cassio.Produtos.Domain.Entities;
using Cassio.Produtos.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cassio.Produtos.Infra.Data.Context.Mappers
{
    public class SupplierMap : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.ToTable("SUPPLIERS");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id)
                .HasColumnName("ID");

            builder.Property(s => s.Name)
               .HasColumnName("NAME")
               .IsRequired();

            builder.Property(s => s.Identification)
                .HasConversion(s => s.Number, s => new Identification(s))
                .HasColumnName("IDENTIFICATION");

            builder.OwnsOne(s => s.Address)
              .Property(a => a.Number)
              .HasColumnName("ADDRESS_NUMBER");

            builder.OwnsOne(s => s.Address)
                .Property(a => a.City)
                .HasColumnName("ADDRESS_CITY");

            builder.OwnsOne(s => s.Address)
                .Property(a => a.Complement)
                .HasColumnName("ADDRESS_COMPLEMENT");

            builder.OwnsOne(s => s.Address)
                .Property(a => a.Country)
                .HasColumnName("ADDRESS_COUNTRY");

            builder.OwnsOne(s => s.Address)
                .Property(a => a.Neighborhood)
                .HasColumnName("ADDRESS_NEIGHBORHOOD");

            builder.OwnsOne(s => s.Address)
                .Property(a => a.State)
                .HasColumnName("ADDRESS_STATE");
        }
    }
}
