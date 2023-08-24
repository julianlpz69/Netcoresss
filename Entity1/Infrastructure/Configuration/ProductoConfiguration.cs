using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
{
    public void Configure(EntityTypeBuilder<Producto> builder)
    {
        builder.ToTable("producto");

        builder.Property(p => p.Nombre)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(p => p.StockMin)
            .IsRequired()
            .HasColumnType("int");

    }
}
