using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoAMBE.Data;

namespace ProyectoAMBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificacionesController : ControllerBase
    {
        private readonly AmbedbContext _context;

        public NotificacionesController(AmbedbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Notificaciones>>> ObtenerNotificaciones(int idInstituto)
        {
            if (_context.Notificaciones == null)
            {
                return NotFound();
            }

            var notificaciones = await _context.Notificaciones
                .Where(p => p.IdInstituto == idInstituto)
                .ToListAsync();
            return Ok(notificaciones);
        }

        [HttpPost]
        public async Task<ActionResult<Notificaciones>> CrearNotificacion(Notificaciones notificacion)
        {
            await _context.Notificaciones.AddAsync(notificacion);
            await _context.SaveChangesAsync();
            return Ok();
        }

    }
}
