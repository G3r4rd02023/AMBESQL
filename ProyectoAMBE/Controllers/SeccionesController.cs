using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoAMBE.Data;

namespace ProyectoAMBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeccionesController : ControllerBase
    {
        private readonly AmbedbContext _context;

        public SeccionesController(AmbedbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Secciones>>> ObtenerSecciones(int idGrado)
        {
            if (_context.Secciones == null)
            {
                return NotFound();
            }

            var secciones = await _context.Secciones
                .Where(m => m.IdGrado == idGrado)
                .ToListAsync();
            return Ok(secciones);
        }

        [HttpPost]
        public async Task<ActionResult<Secciones>> CrearSeccion(Secciones seccion)
        {
            await _context.Secciones.AddAsync(seccion);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
