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
    public class ParentescosController : ControllerBase
    {
        private readonly AmbedbContext _context;
        private readonly IServicioUsuario _servicioUsuario;

        public ParentescosController(AmbedbContext context, IServicioUsuario servicioUsuario)
        {
            _context = context;
            _servicioUsuario = servicioUsuario;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Parentescos>>> ObtenerParentesco(int idPersona)
        {
            if (_context.Parentescos == null)
            {
                return NotFound();
            }

            var rutas = await _context.Parentescos
                .Where(p => p.IdPersonaAlumno == idPersona)
                .ToListAsync();
            return Ok(rutas);
        }

        [HttpPost]
        public async Task<ActionResult<Parentescos>> RegistrarAlumno(AlumnoViewModel model)
        {
            await _servicioUsuario.RegistrarAlumno(model);
            return Ok();
        }
    }
}
