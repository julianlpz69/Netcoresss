using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Configuration;

public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
{
    public void Configure(EntityTypeBuilder<Persona> builder)
    {
        builder.ToTable("persona");

        builder.Property(p => p.IdPersona)
        .HasMaxLength(10)
        .IsRequired();

        builder.Property(p => p.NombrePersona)
            .IsRequired()
            .HasMaxLength(50);
 

        builder.Property(p => p.FechaNac)
            .IsRequired()
            .HasColumnType("Date");    

    }
}
