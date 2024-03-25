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
        public async Task<ActionResult<IEnumerable<Grados>>> ObtenerGrados()
        {
            if (_context.Grados == null)
            {
                return NotFound();
            }

            var grados = await _context.Grados                
                .Where(g => g.Estado == "Activo")
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

        
        [HttpPut("{id}")]
        public async Task<IActionResult> EditarGrado(int id, Grados grado)
        {
            if (id != grado.IdGrado)
            {
                return BadRequest();
            }
            
            _context.Entry(grado).State = EntityState.Modified;                      
            await _context.SaveChangesAsync();            
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarGrado(int id)
        {

            if (_context.Grados == null)
            {
                return NotFound();
            }

            var grado = await _context.Grados.FindAsync(id);

            if (grado == null)
            {
                return NotFound();
            }
            grado.Estado = "Inactivo";
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}

