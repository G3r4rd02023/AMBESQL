﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoAMBE.Data;
using ProyectoAMBE.Models;
using ProyectoAMBE.Services;

namespace ProyectoAMBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly AmbedbContext _context;
       

        public PersonasController(AmbedbContext context)
        {
            _context = context;            
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Personas>>> ObtenerPersonas()
        {

            if (_context.Personas == null)
            {
                return NotFound();
            }
            var personas = await _context.Personas
               .ToListAsync();
            return Ok(personas);
        }

        [HttpPost]
        public async Task<ActionResult<Personas>> CrearPersona(Personas persona)
        {
            await _context.Personas.AddAsync(persona);
            await _context.SaveChangesAsync();
            return Ok();
        }


        

        [HttpGet("{id}")]
        public async Task<ActionResult<Personas>> BuscarPersona(int id)
        {
            //valida que exista la tabla personas
            if (_context.Personas == null)
            {
                return NotFound();
            }
            //buscar el persona en la bd, de acuerdo al Id
            var persona = await _context.Personas.FindAsync(id);

            //si no encuentra con ese id, devuelve not found 
            if (persona == null)
            {
                return NotFound();
            }
            //devuelve el encontrado
            return Ok(persona);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditarPersonas(int id, Personas persona)
        {
            if (id != persona.IdPersona)
            {
                return BadRequest();
            }
            //actualizar
            _context.Entry(persona).State = EntityState.Modified;
            //guarda los cambios en bd           
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}