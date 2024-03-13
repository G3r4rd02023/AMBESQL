namespace ProyectoAMBE.Data;

public partial class Unidades
{
    public int IdUnidad { get; set; }

    public string NumeroUnidad { get; set; }

    public string Placa { get; set; }

    public string Color { get; set; }

    public int Capacidad { get; set; }

    public string Chasis { get; set; }

    public int IdPersonaConductor { get; set; }

    public int IdModelo { get; set; }

    public int IdMarca { get; set; }

    public int IdInstituto { get; set; }

    public string CreadoPor { get; set; }

    public DateTime FechaDeCreacion { get; set; }

    public string ModificadoPor { get; set; }

    public DateTime FechaDeModificacion { get; set; }

    //public virtual Institutos IdInstitutoNavigation { get; set; }

    //public virtual Personas IdMarcaNavigation { get; set; }

    //public virtual Modelos IdModeloNavigation { get; set; }

    //public virtual Personas IdPersonaConductorNavigation { get; set; }

    //public virtual ICollection<Viajes> Viajes { get; set; } = new List<Viajes>();
}
