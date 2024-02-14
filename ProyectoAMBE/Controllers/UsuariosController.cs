using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

    }
}
