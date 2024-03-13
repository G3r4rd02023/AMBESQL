namespace ProyectoAMBE.Data;

public partial class Marcas
{
    public int IdMarca { get; set; }

    public string NombreMarca { get; set; }

    public string Estado { get; set; }

    public int IdInstituto { get; set; }

    public string CreadoPor { get; set; }

    public DateTime FechaDeCreacion { get; set; }

    public string ModificadoPor { get; set; }

    public DateTime FechaDeModificacion { get; set; }

    //public virtual Institutos IdInstitutoNavigation { get; set; }

    //public virtual ICollection<Modelos> Modelos { get; set; } = new List<Modelos>();
}
