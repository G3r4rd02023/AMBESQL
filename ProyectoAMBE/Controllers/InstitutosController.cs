﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoAMBE.Data;
using ProyectoAMBE.Services;

namespace ProyectoAMBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstitutosController : ControllerBase
    {
        private readonly AmbedbContext _context;
        private readonly IServicioBitacora _bitacora;

        public InstitutosController(AmbedbContext context, IServicioBitacora bitacora)
        {
            _context = context;
            _bitacora = bitacora;
        }


        // GET: api/Institutos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Institutos>>> ObtenerInstitutos()
        {
            //valida que exista la tabla institutos
            if (_context.Institutos == null)
            {
                return NotFound();
            }
            //obtiene la lista de todos los institutos
            var institutos = await _context.Institutos.ToListAsync();
            //await _bitacora.AgregarRegistro("Consultó", "Institutos");
            //devuelve la lista de todos los institutos
            return Ok(institutos);
        }

        // GET: api/Institutos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Institutos>> BuscarInstitutos(int id)
        {
            //valida que exista la tabla institutos
            if (_context.Institutos == null)
            {
                return NotFound();
            }
            //buscar el instituto en la bd, de acuerdo al Id
            var institutos = await _context.Institutos.FindAsync(id);

            //si no encuentra instituto con ese id, devuelve not found 
            if (institutos == null)
            {
                return NotFound();
            }
            //await _bitacora.AgregarRegistro("Consultó", "Institutos");
            //devuelve el instituto encontrado
            return Ok(institutos);
        }

        // PUT: api/Institutos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> EditarInstitutos(int id, Institutos institutos)
        {
            if (id != institutos.IdInstituto)
            {
                return BadRequest();
            }
            //actualiza el instituto
            _context.Entry(institutos).State = EntityState.Modified;
            //guarda los cambios en bd           
            await _context.SaveChangesAsync();
            //await _bitacora.AgregarRegistro("Actualizó", "Institutos");
            return Ok();
        }

               
        [HttpPost]
        public async Task<ActionResult<Institutos>> CrearInstitutos(Institutos instituto)
        {           
            await _context.Institutos.AddAsync(instituto);            
            await _context.SaveChangesAsync();            
            return Ok();
        }

        // DELETE: api/Institutos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarInstitutos(int id)
        {
            //validar que la tabla exista
            if (_context.Institutos == null)
            {
                return NotFound();
            }
            //buscar el instituto por id
            var instituto = await _context.Institutos.FindAsync(id);
            //si no existe devolver not found
            if (instituto == null)
            {
                return NotFound();
            }
            //eiminar el instituto de la bd
            _context.Institutos.Remove(instituto);
            //guardar los cambios
            await _context.SaveChangesAsync();
            //await _bitacora.AgregarRegistro("Eliminó", "Institutos");
            return Ok();
        }

    }
}