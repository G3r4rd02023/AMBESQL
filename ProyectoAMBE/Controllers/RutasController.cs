using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoAMBE.Data;

namespace ProyectoAMBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RutasController : ControllerBase
    {
        private readonly AmbedbContext _context;

        public RutasController(AmbedbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rutas>>> ObtenerRutas()
        {
            if (_context.Rutas == null)
            {
                return NotFound();
            }

            var rutas = await _context.Rutas.ToListAsync();
            return Ok(rutas);
        }

        [HttpPost]
        public async Task<ActionResult<Rutas>> CrearRuta(Rutas ruta)
        {
            await _context.Rutas.AddAsync(ruta);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Rutas>> BuscarRuta(int id)
        {

            if (_context.Rutas == null)
            {
                return NotFound();
            }

            var ruta = await _context.Rutas.FindAsync(id);

            if (ruta == null)
            {
                return NotFound();
            }

            return Ok(ruta);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditarRuta(int id, Rutas ruta)
        {
            if (id != ruta.IdRuta)
            {
                return BadRequest();
            }
            _context.Entry(ruta).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
