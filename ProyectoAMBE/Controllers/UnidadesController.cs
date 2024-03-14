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
        public async Task<ActionResult<IEnumerable<Unidades>>> ObtenerUnidades(int idInstituto)
        {
            if (_context.Unidades == null)
            {
                return NotFound();
            }

            var marcas = await _context.Unidades
                .Where(m => m.IdInstituto == idInstituto)
                .ToListAsync();
            return Ok(marcas);
        }

        [HttpPost]
        public async Task<ActionResult<Unidades>> CrearUnidad(Unidades unidad)
        {
            await _context.Unidades.AddAsync(unidad);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
