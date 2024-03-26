using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoAMBE.Data;

namespace ProyectoAMBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnidadesController : ControllerBase
    {
        private readonly AmbedbContext _context;

        public UnidadesController(AmbedbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Unidades>>> ObtenerUnidades()
        {
            if (_context.Unidades == null)
            {
                return NotFound();
            }

            var unidades = await _context.Unidades                
                .ToListAsync();
            return Ok(unidades);
        }

        [HttpPost]
        public async Task<ActionResult<Unidades>> CrearUnidad(Unidades unidad)
        {
            await _context.Unidades.AddAsync(unidad);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditarUnidad(int id, Unidades unidad)
        {
            if (id != unidad.IdUnidad)
            {
                return BadRequest();
            }
            _context.Entry(unidad).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
