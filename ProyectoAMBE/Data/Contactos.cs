namespace ProyectoAMBE.Data;

public partial class Contactos
{
    public int IdContacto { get; set; }

    public int? IdPersona { get; set; }

    public int? IdInstituto { get; set; }

    public string Telefono { get; set; }

    public string Email { get; set; }

    public int? IdTipoContacto { get; set; }

    public string Direccion { get; set; }

    public string Bloque { get; set; }

    public string Avenida { get; set; }

    public string Calle { get; set; }

    public string Casa { get; set; }

    //public virtual Institutos IdInstitutoNavigation { get; set; }

    //public virtual Personas IdPersonaNavigation { get; set; }

    //public virtual TipoContacto IdTipoContactoNavigation { get; set; }
}
