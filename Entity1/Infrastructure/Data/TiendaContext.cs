using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class TiendaContext : DbContext
{
    public TiendaContext(DbContextOptions<TiendaContext> options) : base(options)
    {
    }

    public DbSet<Producto> Productos { get; set; }
    public DbSet<Pais> Paises{ get; set; }
    public DbSet<Estado> Estados { get; set; }
    public DbSet<Region> Regiones { get; set; }
    public DbSet<Persona> Personas { get; set; }
    public DbSet<TipoPersona> TipoPersonas { get; set;}
    public DbSet<ProductoPersona> ProductosPersonas { get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        modelBuilder.Entity<Pais>() 
            .HasMany<Estado>(g => g.Estados) 
            .WithOne(s => s.Pais) 
            .HasForeignKey(s => s.IdPaisFk);

        modelBuilder.Entity<Estado>() 
            .HasMany<Region>(g => g.Regiones) 
            .WithOne(s => s.Estado) 
            .HasForeignKey(s => s.IdEstadoFk);    


        modelBuilder.Entity<TipoPersona>() 
            .HasMany<Persona>(g => g.Personas) 
            .WithOne(s => s.TipoPersona) 
            .HasForeignKey(s => s.IdTipoPerFk);    


  
        modelBuilder.Entity<ProductoPersona> ( ).HasKey(sc => new { sc.IdProducto, sc.IdPersona });

        modelBuilder.Entity<ProductoPersona> ( )
            .HasOne< Producto >(sc => sc.Producto)
            .WithMany(s => s.ProductosPersonas)
            .HasForeignKey(sc => sc.IdProducto);


        modelBuilder.Entity<ProductoPersona> ( )
            .HasOne<Persona>(sc => sc.Persona)
            .WithMany(s => s.ProductosPersonas)
            .HasForeignKey(sc => sc.IdPersona);


    }

}
