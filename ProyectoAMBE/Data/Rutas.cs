namespace ProyectoAMBE.Data;

public partial class Rutas
{
    public int IdRuta { get; set; }

    public int IdInstituto { get; set; }

    public string NombreRuta { get; set; }

    public string Origen { get; set; }

    public string Destino { get; set; }

    public string DistanciaRecorrida { get; set; }

    public string Colonias { get; set; }

    public string Departamento { get; set; }

    public string Municipio { get; set; }

    public string Descripcion { get; set; }

    public string CreadoPor { get; set; }

    public DateTime FechaDeCreacion { get; set; }

    public string ModificadoPor { get; set; }

    public DateTime FechaDeModificacion { get; set; }


}
