using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoAMBE.Data;

namespace ProyectoAMBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcasController : ControllerBase
    {
        private readonly AmbedbContext _context;

        public MarcasController(AmbedbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Marcas>>> ObtenerMarcas()
        {
            if (_context.Marcas == null)
            {
                return NotFound();
            }

            var marcas = await _context.Marcas                
                .ToListAsync();
            return Ok(marcas);
        }

        [HttpPost]
        public async Task<ActionResult<Marcas>> CrearMarca(Marcas marca)
        {
            await _context.Marcas.AddAsync(marca);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarMarca(int id)
        {

            if (_context.Marcas == null)
            {
                return NotFound();
            }

            var marca = await _context.Marcas.FindAsync(id);

            if (marca == null)
            {
                return NotFound();
            }
            _context.Marcas.Remove(marca);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
