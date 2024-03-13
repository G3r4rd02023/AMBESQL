using ProyectoAMBE.Data;
using ProyectoAMBE.Models;

namespace ProyectoAMBE.Services
{
    public class ServicioUsuario : IServicioUsuario
    {

        private readonly AmbedbContext _context;

        public ServicioUsuario(AmbedbContext context)
        {
            _context = context;
        }

        public async Task<Roles> CrearRol(Roles rol)
        {
            var nuevoRol = new Roles
            {
                IdInstituto = rol.IdInstituto,
                Descripcion = rol.Descripcion,
                CreadoPor = rol.CreadoPor,
                FechaCreacion = rol.FechaCreacion,
                ModificadoPor = rol.ModificadoPor,
                FechaModificacion = rol.FechaModificacion,
            };

            await _context.Roles.AddAsync(nuevoRol);
            await _context.SaveChangesAsync();

            var nuevoInstitutoRol = new InstitutoRoles
            {
                IdInstituto = rol.IdInstituto,
                IdRol = nuevoRol.IdRol,
            };
            await _context.InstitutoRoles.AddAsync(nuevoInstitutoRol);
            await _context.SaveChangesAsync();

            return nuevoRol;
        }

        public async Task<Usuarios> CrearUsuario(PersonaViewModel model)
        {
            var nuevaPersona = new Personas
            {
                IdInstituto = model.IdInstituto,
                IdTipoPersona = model.IdTipoPersona,
                PrimerNombre = model.PrimerNombre,
                SegundoNombre = model.SegundoNombre,
                PrimerApellido = model.PrimerApellido,
                SegundoApellido = model.SegundoApellido,
                FechaNacimiento = model.FechaNacimiento,
                Genero = model.Genero,
                Estado = model.Estado,
                CreadoPor = model.CreadoPor,
                ModificadoPor = model.ModificadoPor
            };

            await _context.Personas.AddAsync(nuevaPersona);
            await _context.SaveChangesAsync();

            var nuevoUsuario = new Usuarios
            {
                IdPersona = nuevaPersona.IdPersona,
                Usuario = model.Usuario,
                IdInstituto = model.IdInstituto,
                NombreUsuario = model.NombreUsuario,
                CorreoElectronico = model.CorreoElectronico,
                Contraseña = model.Contraseña,
                Estado = model.Estado,
                IdRol = model.IdRol,
                FechaUltimaConexion = model.FechaUltimaConexion,
                CreadoPor = model.CreadoPor,
                ModificadoPor = model.ModificadoPor

            };

            await _context.Usuarios.AddAsync(nuevoUsuario);
            await _context.SaveChangesAsync();

            var nuevoUserInstituto = new InstitutoUsuarios
            {
                IdInstituto = model.IdInstituto,
                IdUsuario = nuevoUsuario.IdUsuario,
            };

            await _context.InstitutoUsuarios.AddAsync(nuevoUserInstituto);
            await _context.SaveChangesAsync();

            return nuevoUsuario;

        }
    }
}
