using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoAMBE.Data;
using ProyectoAMBE.Services;

namespace ProyectoAMBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjetosController : ControllerBase
    {
        private readonly AmbedbContext _context;
       
        public ObjetosController(AmbedbContext context)
        {
            _context = context;            
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Objetos>>> ObtenerObjetos()
        {
            
            if (_context.Objetos == null)
            {
                return NotFound();
            }
            
            var objeto = await _context.Objetos
                .ToListAsync();
            
            return Ok(objeto);
        }

        [HttpPost]
        public async Task<ActionResult<Objetos>> CrearObjetos(Objetos objeto)
        {            
            await _context.Objetos.AddAsync(objeto);            
            await _context.SaveChangesAsync();            
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditarObjetos(int id, Objetos objeto)
        {
            if (id != objeto.IdObjeto)
            {
                return BadRequest();
            }
           
            _context.Entry(objeto).State = EntityState.Modified;                      
            await _context.SaveChangesAsync();            
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarObjetos(int id)
        {
            
            if (_context.Objetos == null)
            {
                return NotFound();
            }
            
            var objeto = await _context.Objetos.FindAsync(id);
            
            if (objeto == null)
            {
                return NotFound();
            }           
            _context.Objetos.Remove(objeto);          
            await _context.SaveChangesAsync();           
            return Ok();
        }
    }
}
