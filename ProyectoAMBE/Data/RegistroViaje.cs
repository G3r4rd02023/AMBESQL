namespace ProyectoAMBE.Data;

public partial class RegistroViaje
{
    public int IdRegistroViaje { get; set; }

    public int IdPersonaAlumno { get; set; }

    public int IdRuta { get; set; }

    public int IdViaje { get; set; }

    public int IdInstituto { get; set; }

    public string Observaciones { get; set; }

    public string CreadoPor { get; set; }

    public DateTime FechaDeCreacion { get; set; }

    public string ModificadoPor { get; set; }

    public DateTime FechaDeModificacion { get; set; }

    //public virtual Institutos IdInstitutoNavigation { get; set; }

    //public virtual Personas IdPersonaAlumnoNavigation { get; set; }

    //public virtual Rutas IdRutaNavigation { get; set; }

    //public virtual Viajes IdViajeNavigation { get; set; }
}
