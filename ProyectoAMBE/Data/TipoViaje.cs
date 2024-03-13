using System;
using System.Collections.Generic;

namespace ProyectoAMBE.Data;

public partial class TipoViaje
{
    public int IdTipoViaje { get; set; }

    public string Evento { get; set; }

    public string Descripcion { get; set; }

    public string CreadoPor { get; set; }

    public DateTime FechaDeCreacion { get; set; }

    public string ModificadoPor { get; set; }

    public DateTime FechaDeModificacion { get; set; }
}
