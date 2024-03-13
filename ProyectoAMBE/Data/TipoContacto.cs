namespace ProyectoAMBE.Data;

public partial class TipoContacto
{
    public int IdTipoContacto { get; set; }

    public string Descripcion { get; set; }

    public string CreadoPor { get; set; }

    public DateTime FechaDeCreacion { get; set; }

    public string ModificadoPor { get; set; }

    public DateTime FechaDeModificacion { get; set; }

    //public virtual ICollection<Contactos> Contactos { get; set; } = new List<Contactos>();
}
