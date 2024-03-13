namespace ProyectoAMBE.Data;

public partial class Roles
{
    public int IdRol { get; set; }

    public int IdInstituto { get; set; }

    public string Descripcion { get; set; }

    public string CreadoPor { get; set; }

    public DateTime FechaCreacion { get; set; }

    public string ModificadoPor { get; set; }

    public DateTime FechaModificacion { get; set; }


}
