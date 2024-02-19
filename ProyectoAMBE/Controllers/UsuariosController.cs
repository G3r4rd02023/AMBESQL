using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoAMBE.Data;
using ProyectoAMBE.Models;
using ProyectoAMBE.Services;

namespace ProyectoAMBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly TransportedbContext _context;
        private readonly IServicioUsuario _servicioUsuario;
        private readonly IServicioBitacora _bitacora;

        public UsuariosController(TransportedbContext context, IServicioUsuario servicioUsuario, IServicioBitacora servicioBitacora)
        {
            _context = context;
            _servicioUsuario = servicioUsuario;
            _bitacora = servicioBitacora;
        }

        [HttpPost]
        public async Task<ActionResult<Usuarios>> CrearUsuario(PersonaViewModel model)
        {

            var usuarioNuevo = await _servicioUsuario.CrearUsuario(model);
            await _context.Usuarios.AddAsync(usuarioNuevo);
            await _context.SaveChangesAsync();
            //await _bitacora.AgregarRegistro("Creó", "Usuarios");
            return Ok();
        }

        // GET: api/Usuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuarios>>> ObtenerUsuarios()
        {
            
            if (_context.Usuarios == null)
            {
                return NotFound();
            }
            
            var usuarios = await _context.Usuarios.ToListAsync();
            //await _bitacora.AgregarRegistro("Consultó", "Institutos");
            //devuelve la lista de todos los institutos
            return Ok(usuarios);
        }

       
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuarios>> BuscarUsuario(int id)
        {
            
            if (_context.Usuarios == null)
            {
                return NotFound();
            }           
            var usuario = await _context.Usuarios.FindAsync(id);            
            if (usuario == null)
            {
                return NotFound();
            }
            //await _bitacora.AgregarRegistro("Consultó", "Institutos");
            //devuelve el instituto encontrado
            return Ok(usuario);
        }
    }
}
