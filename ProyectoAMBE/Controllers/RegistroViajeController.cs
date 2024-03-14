using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoAMBE.Data;

namespace ProyectoAMBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroViajeController : ControllerBase
    {
        private readonly AmbedbContext _context;

        public RegistroViajeController(AmbedbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RegistroViaje>>> ObtenerRegistros(int idInstituto)
        {
            if (_context.RegistroViaje == null)
            {
                return NotFound();
            }

            var registros = await _context.RegistroViaje
                .Where(m => m.IdInstituto == idInstituto)
                .ToListAsync();
            return Ok(registros);
        }

        [HttpPost]
        public async Task<ActionResult<RegistroViaje>> CrearRegistro(RegistroViaje registro)
        {
            await _context.RegistroViaje.AddAsync(registro);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
