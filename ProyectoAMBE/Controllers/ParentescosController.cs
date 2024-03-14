using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoAMBE.Data;

namespace ProyectoAMBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentescosController : ControllerBase
    {
        private readonly AmbedbContext _context;

        public ParentescosController(AmbedbContext context)
        {
            _context = context;
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
        public async Task<ActionResult<Parentescos>> CrearParentesco(Parentescos parentesco)
        {
            await _context.Parentescos.AddAsync(parentesco);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
