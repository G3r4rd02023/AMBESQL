namespace ProyectoAMBE.Data;

public partial class Parentescos
{
    public int IdParentesco { get; set; }

    public int IdPersonaAlumno { get; set; }

    public int IdPersonaResponsable { get; set; }

    public int IdInstituto { get; set; }

    public string Parentesco { get; set; }

    public string CreadoPor { get; set; }

    public DateTime FechaDeCreacion { get; set; }

    public string ModificadoPor { get; set; }

    public DateTime FechaDeModificacion { get; set; }

    //public virtual Institutos IdInstitutoNavigation { get; set; }

    //public virtual Personas IdPersonaAlumnoNavigation { get; set; }

    //public virtual Personas IdPersonaResponsableNavigation { get; set; }
}
