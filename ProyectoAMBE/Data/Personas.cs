namespace ProyectoAMBE.Data;

public partial class Personas
{
    public int IdPersona { get; set; }

    public int IdTipoPersona { get; set; }

    public int IdInstituto { get; set; }

    public string PrimerNombre { get; set; }

    public string SegundoNombre { get; set; }

    public string PrimerApellido { get; set; }

    public string SegundoApellido { get; set; }

    public DateTime FechaNacimiento { get; set; }

    public string Genero { get; set; }

    public string CreadoPor { get; set; }

    public DateTime FechaCreacion { get; set; }

    public string ModificadoPor { get; set; }

    public DateTime FechaModificacion { get; set; }

    public string Estado { get; set; }

    //public virtual ICollection<Contactos> Contactos { get; set; } = new List<Contactos>();

    //public virtual Institutos IdInstitutoNavigation { get; set; }

    //public virtual TipoPersonas IdTipoPersonaNavigation { get; set; }

    //public virtual ICollection<Notificaciones> Notificaciones { get; set; } = new List<Notificaciones>();

    //public virtual ICollection<Parentescos> ParentescosIdPersonaAlumnoNavigation { get; set; } = new List<Parentescos>();

    //public virtual ICollection<Parentescos> ParentescosIdPersonaResponsableNavigation { get; set; } = new List<Parentescos>();

    //public virtual ICollection<RegistroViaje> RegistroViaje { get; set; } = new List<RegistroViaje>();

    //public virtual ICollection<Unidades> UnidadesIdMarcaNavigation { get; set; } = new List<Unidades>();

    //public virtual ICollection<Unidades> UnidadesIdPersonaConductorNavigation { get; set; } = new List<Unidades>();

    //public virtual ICollection<Usuarios> Usuarios { get; set; } = new List<Usuarios>();

    //public virtual ICollection<Viajes> ViajesIdPersonaConductorNavigation { get; set; } = new List<Viajes>();

    //public virtual ICollection<Viajes> ViajesIdPersonaNineraNavigation { get; set; } = new List<Viajes>();
}
