using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Configuration;

public class ProductoPersonaConfiguracion : IEntityTypeConfiguration<ProductoPersona>
{
    public void Configure(EntityTypeBuilder<ProductoPersona> builder)
    {
        builder.ToTable("productoPersona");
        
    }
}
