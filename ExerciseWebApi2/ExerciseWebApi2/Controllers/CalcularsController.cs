using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExerciseWebApi2.Model;

namespace ExerciseWebApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcularsController : ControllerBase
    {
        private readonly CalcularContext _context;

        public CalcularsController(CalcularContext context)
        {
            _context = context;
        }

        // GET: api/Calculars
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Calcular>>> GetCalculars()
        {
            return await _context.Calculars.ToListAsync();
        }

        // GET: api/Calculars/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Calcular>> GetCalcular(int id)
        {
            var calcular = await _context.Calculars.FindAsync(id);

            if (calcular == null)
            {
                return NotFound();
            }

            return calcular;
        }

        // PUT: api/Calculars/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCalcular(int id, Calcular calcular)
        {
            if (id != calcular.Id)
            {
                return BadRequest();
            }

            _context.Entry(calcular).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CalcularExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Calculars
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Calcular>> PostCalcular(Calcular calcular)
        {
            _context.Calculars.Add(calcular);
            await _context.SaveChangesAsync();
			calcular.Peso = calcular.Volume * calcular.Densidade * 9.81;

            return CreatedAtAction("GetCalcular", new { id = calcular.Id }, calcular);
        }

        // DELETE: api/Calculars/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Calcular>> DeleteCalcular(int id)
        {
            var calcular = await _context.Calculars.FindAsync(id);
            if (calcular == null)
            {
                return NotFound();
            }

            _context.Calculars.Remove(calcular);
            await _context.SaveChangesAsync();

            return calcular;
        }

        private bool CalcularExists(int id)
        {
            return _context.Calculars.Any(e => e.Id == id);
        }
    }
}
