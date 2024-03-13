namespace ProyectoAMBE.Data;

public partial class Grados
{
    public int IdGrado { get; set; }

    public int IdInstituto { get; set; }

    public string Grado { get; set; }

    public string Estado { get; set; }

    public string CreadoPor { get; set; }

    public DateTime FechaDeCreacion { get; set; }

    public string ModificadoPor { get; set; }

    public DateTime FechaDeModificacion { get; set; }

    //public virtual Institutos IdInstitutoNavigation { get; set; }

    //public virtual ICollection<Secciones> Secciones { get; set; } = new List<Secciones>();
}
