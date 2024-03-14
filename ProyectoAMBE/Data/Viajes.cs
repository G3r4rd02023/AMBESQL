namespace ProyectoAMBE.Data;

public partial class Viajes
{
    public int IdViaje { get; set; }

    public DateTime Fecha { get; set; }

    public string HoraInicio { get; set; }

    public string HoraFinal { get; set; }

    public int IdPersonaConductor { get; set; }

    public int IdPersonaNinera { get; set; }

    public int IdUnidad { get; set; }

    public int IdInstituto { get; set; }

    public string Comentarios { get; set; }

    public string CreadoPor { get; set; }

    public DateTime FechaDeCreacion { get; set; }

    public string ModificadoPor { get; set; }

    public DateTime FechaDeModificacion { get; set; }

    //public virtual Institutos IdInstitutoNavigation { get; set; }

    //public virtual Personas IdPersonaConductorNavigation { get; set; }

    //public virtual Personas IdPersonaNineraNavigation { get; set; }

    //public virtual Unidades IdUnidadNavigation { get; set; }

    //public virtual ICollection<Incidentes> Incidentes { get; set; } = new List<Incidentes>();

    //public virtual ICollection<RegistroViaje> RegistroViaje { get; set; } = new List<RegistroViaje>();
}
