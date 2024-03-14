using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoAMBE.Data;

namespace ProyectoAMBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoViajesController : ControllerBase
    {
        private readonly AmbedbContext _context;

        public TipoViajesController(AmbedbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoViaje>>> ObtenerEventos()
        {
            if (_context.TipoViaje == null)
            {
                return NotFound();
            }

            var eventos = await _context.TipoViaje.ToListAsync();
            return Ok(eventos);
        }

        [HttpPost]
        public async Task<ActionResult<TipoViaje>> CrearEvento(TipoViaje tipoViaje)
        {
            await _context.TipoViaje.AddAsync(tipoViaje);
            await _context.SaveChangesAsync();
            return Ok();
        }



    }
}
