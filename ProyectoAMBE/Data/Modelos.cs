namespace ProyectoAMBE.Data;

public partial class Modelos
{
    public int IdModelo { get; set; }

    public int IdMarca { get; set; }

    public string NombreModelo { get; set; }

    public string Estado { get; set; }

    public string CreadoPor { get; set; }

    public DateTime FechaDeCreacion { get; set; }

    public string ModificadoPor { get; set; }

    public DateTime FechaDeModificacion { get; set; }

    //public virtual Marcas IdMarcaNavigation { get; set; }

    //public virtual ICollection<Unidades> Unidades { get; set; } = new List<Unidades>();
}
