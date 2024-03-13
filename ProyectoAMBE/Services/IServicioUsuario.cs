using ProyectoAMBE.Data;
using ProyectoAMBE.Models;

namespace ProyectoAMBE.Services
{
    public interface IServicioUsuario
    {
        Task<Usuarios> CrearUsuario(PersonaViewModel model);

        Task<Roles> CrearRol(Roles roles);

    }
}
