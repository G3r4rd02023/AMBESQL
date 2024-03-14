using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoAMBE.Data;

namespace ProyectoAMBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactosController : ControllerBase
    {
        private readonly AmbedbContext _context;

        public ContactosController(AmbedbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Contactos>> BuscarContacto(int id)
        {

            if (_context.Contactos == null)
            {
                return NotFound();
            }

            var contacto = await _context.Contactos.FindAsync(id);

            if (contacto == null)
            {
                return NotFound();
            }

            return Ok(contacto);
        }

        [HttpPost]
        public async Task<ActionResult<Contactos>> CrearContacto(Contactos contacto)
        {
            await _context.Contactos.AddAsync(contacto);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditarContacto(int id, Contactos contacto)
        {
            if (id != contacto.IdContacto)
            {
                return BadRequest();
            }
            _context.Entry(contacto).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
