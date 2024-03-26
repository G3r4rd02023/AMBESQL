using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoAMBE.Data;

namespace ProyectoAMBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelosController : ControllerBase
    {
        private readonly AmbedbContext _context;

        public ModelosController(AmbedbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Modelos>>> ObtenerModelos()
        {
            if (_context.Modelos == null)
            {
                return NotFound();
            }

            var modelos = await _context.Modelos               
                .ToListAsync();
            return Ok(modelos);
        }

        [HttpPost]
        public async Task<ActionResult<Modelos>> CrearModelo(Modelos modelo)
        {
            await _context.Modelos.AddAsync(modelo);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
