namespace Core.Entities;

public class TipoPersona : BaseEntity
{
    public int Id { get; set;}
    public string  Descripcion { get; set;}
    public ICollection<Persona> Personas { get; set; }
}
