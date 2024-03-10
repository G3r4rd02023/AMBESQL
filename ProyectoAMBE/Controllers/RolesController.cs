using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoAMBE.Data;
using ProyectoAMBE.Services;

namespace ProyectoAMBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly AmbedbContext _context;
        private readonly IServicioUsuario _servicioUsuario;

        public RolesController(AmbedbContext context,IServicioUsuario servicioUsuario)
        {
            _context = context;
            _servicioUsuario = servicioUsuario;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Roles>>> ObtenerRoles()
        {
            //valida que exista la tabla
            if (_context.Roles == null)
            {
                return NotFound();
            }
            //obtiene la lista  
            var roles = await _context.Roles.ToListAsync();
            //devuelve la lista
            return Ok(roles);
        }

        [HttpPost]
        public async Task<ActionResult<Roles>> CrearRoles(Roles roles)
        {            
            await _servicioUsuario.CrearRol(roles);           
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarRoles(int id)
        {
            //validar que la tabla exista
            if (_context.Roles == null)
            {
                return NotFound();
            }
            //buscar por id
            var rol = await _context.Roles.FindAsync(id);
            //si no existe devolver not found
            if (rol == null)
            {
                return NotFound();
            }
            //eiminar de la bd
            _context.Roles.Remove(rol);
            //guardar los cambios
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
