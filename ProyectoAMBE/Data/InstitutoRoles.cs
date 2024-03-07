using System;
using System.Collections.Generic;

namespace ProyectoAMBE.Data;

public partial class InstitutoRoles
{
    public int IdInstitutoRol { get; set; }

    public int IdInstituto { get; set; }

    public int IdRol { get; set; }

    //public virtual Institutos IdInstitutoNavigation { get; set; } = null!;

    //public virtual Roles IdRolNavigation { get; set; } = null!;
}
