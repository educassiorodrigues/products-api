using Cassio.Produtos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cassio.Produtos.Infra.Data.Context.Mappers
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("CATEGORY");

            builder.HasKey(s => s.Id);
        
            builder.Property(s => s.Id)
                .HasColumnName("ID");

            builder.Property(s => s.Description)
                .HasColumnName("DESCRIPTION")
                .IsRequired();
        }
    }

}
