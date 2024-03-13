namespace ProyectoAMBE.Data;

public partial class Notificaciones
{
    public int IdNotificacion { get; set; }

    public int IdInstituto { get; set; }

    public int IdPersona { get; set; }

    public string Mensaje { get; set; }

    public DateTime Fecha { get; set; }

    //public virtual Institutos IdInstitutoNavigation { get; set; }

    //public virtual Personas IdPersonaNavigation { get; set; }
}
