using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoAMBE.Data;

namespace ProyectoAMBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradosController : ControllerBase
    {
        private readonly AmbedbContext _context;

        public GradosController(AmbedbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Grados>>> ObtenerGrados(int idInstituto)
        {
            if (_context.Grados == null)
            {
                return NotFound();
            }

            var grados = await _context.Grados
                .Where(m => m.IdInstituto == idInstituto)
                .ToListAsync();
            return Ok(grados);
        }

        [HttpPost]
        public async Task<ActionResult<Grados>> CrearGrado(Grados grado)
        {
            await _context.Grados.AddAsync(grado);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
