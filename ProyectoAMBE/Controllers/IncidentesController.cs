using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoAMBE.Data;

namespace ProyectoAMBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncidentesController : ControllerBase
    {
        private readonly AmbedbContext _context;

        public IncidentesController(AmbedbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Incidentes>>> ObtenerIncidentes(int idInstituto)
        {
            if (_context.Incidentes == null)
            {
                return NotFound();
            }

            var incidentes = await _context.Incidentes
                .Where(m => m.IdInstituto == idInstituto)
                .ToListAsync();
            return Ok(incidentes);
        }

        [HttpPost]
        public async Task<ActionResult<Incidentes>> CrearRegistro(Incidentes registro)
        {
            await _context.Incidentes.AddAsync(registro);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Incidentes>> BuscarIncidente(int id)
        {

            if (_context.Incidentes == null)
            {
                return NotFound();
            }

            var incidente = await _context.Incidentes.FindAsync(id);

            if (incidente == null)
            {
                return NotFound();
            }

            return Ok(incidente);
        }
    }
}
