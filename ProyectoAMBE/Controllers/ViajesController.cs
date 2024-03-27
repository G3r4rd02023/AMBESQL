using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoAMBE.Data;

namespace ProyectoAMBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViajesController : ControllerBase
    {
        private readonly AmbedbContext _context;

        public ViajesController(AmbedbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Viajes>>> ObtenerViajes()
        {
            if (_context.Viajes == null)
            {
                return NotFound();
            }

            var viajes = await _context.Viajes               
                .ToListAsync();
            return Ok(viajes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Viajes>> BuscarViaje(int id)
        {

            if (_context.Viajes == null)
            {
                return NotFound();
            }

            var viaje = await _context.Viajes.FindAsync(id);

            if (viaje == null)
            {
                return NotFound();
            }

            return Ok(viaje);
        }

        [HttpPost]
        public async Task<ActionResult<Viajes>> CrearViaje(Viajes viaje)
        {
            await _context.Viajes.AddAsync(viaje);
            await _context.SaveChangesAsync();
            return Ok();
        }


    }
}
