namespace ProyectoAMBE.Data;

public partial class Incidentes
{
    public int IdIncidente { get; set; }

    public int? IdViaje { get; set; }

    public string Descripcion { get; set; }

    public int? IdInstituto { get; set; }

    public string CreadoPor { get; set; }

    public DateTime? FechaDeCreacion { get; set; }

    public string ModificadoPor { get; set; }

    public DateTime? FechaDeModificacion { get; set; }

    //public virtual Institutos IdInstitutoNavigation { get; set; }

    //public virtual Viajes IdViajeNavigation { get; set; }
}
