namespace ProyectoAMBE.Data;

public partial class Secciones
{
    public int IdSeccion { get; set; }

    public int IdInstituto { get; set; }

    public int IdGrado { get; set; }

    public string Seccion { get; set; }

    public string Estado { get; set; }

    public string CreadoPor { get; set; }

    public DateTime FechaDeCreacion { get; set; }

    public string ModificadoPor { get; set; }

    public DateTime FechaDeModificacion { get; set; }


}
