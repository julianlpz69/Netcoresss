namespace Core.Entities;

public class Pais : BaseEntity
{
    public int Id { get; set;}
    public string  NombrePais { get; set; }

    public ICollection<Estado> Estados { get; set; }
}
