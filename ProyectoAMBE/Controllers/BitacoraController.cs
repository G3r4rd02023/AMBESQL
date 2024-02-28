using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoAMBE.Data;

namespace ProyectoAMBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BitacoraController : ControllerBase
    {
        private readonly TransportedbContext _context;

        public BitacoraController(TransportedbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bitacora>>> VerBitacora()
        {
            //valida que exista la tabla 
            if (_context.Bitacora == null)
            {
                return NotFound();
            }
            //obtiene los reigstros de bitacora 
            var bitacora = await _context.Bitacora.ToListAsync();
            //devuelve la lista de todos los registros
            return Ok(bitacora);
        }

                
        [HttpPost]
        public async Task<ActionResult<Bitacora>> AgregarRegistro(Bitacora bitacora)
        {            
            await _context.Bitacora.AddAsync(bitacora);          
            await _context.SaveChangesAsync();            
            return Ok();
        }
    }
}
