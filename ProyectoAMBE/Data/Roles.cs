using System;
using System.Collections.Generic;

namespace ProyectoAMBE.Data;

public partial class Roles
{
    public int IdRol { get; set; }

    public int? IdInstituto { get; set; }

    public string? Descripcion { get; set; }

    public string? CreadoPor { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public string? ModificadoPor { get; set; }

    public DateTime? FechaModificacion { get; set; }

    //public virtual Institutos? IdInstitutoNavigation { get; set; }

    //public virtual ICollection<InstitutoRoles> InstitutoRoles { get; set; } = new List<InstitutoRoles>();

    //public virtual ICollection<Permisos> Permisos { get; set; } = new List<Permisos>();

    //public virtual ICollection<Usuarios> Usuarios { get; set; } = new List<Usuarios>();
}
