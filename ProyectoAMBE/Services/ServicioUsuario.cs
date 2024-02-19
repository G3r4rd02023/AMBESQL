﻿using ProyectoAMBE.Data;
using ProyectoAMBE.Models;

namespace ProyectoAMBE.Services
{
    public class ServicioUsuario : IServicioUsuario
    {

        private readonly TransportedbContext _context;

        public ServicioUsuario(TransportedbContext context)
        {
            _context = context;
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
            
            //await _context.Usuarios.AddAsync(nuevoUsuario);

            

            return nuevoUsuario;

        }
    }
}
