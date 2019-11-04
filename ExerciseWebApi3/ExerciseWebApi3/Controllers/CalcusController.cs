using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExerciseWebApi3.Model;

namespace ExerciseWebApi3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcusController : ControllerBase
    {
        private readonly ColeguinhaContext _context;

        public CalcusController(ColeguinhaContext context)
        {
            _context = context;
        }

        // GET: api/Calcus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Calcu>>> GetCalcus()
        {
            return await _context.Calcus.ToListAsync();
        }

        // GET: api/Calcus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Calcu>> GetCalcu(int id)
        {
            var calcu = await _context.Calcus.FindAsync(id);

            if (calcu == null)
            {
                return NotFound();
            }

            return calcu;
        }

        // PUT: api/Calcus/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCalcu(int id, Calcu calcu)
        {
            if (id != calcu.Id)
            {
                return BadRequest();
            }

            _context.Entry(calcu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CalcuExists(id))
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

        // POST: api/Calcus
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Calcu>> PostCalcu(Calcu calcu)
        {
            _context.Calcus.Add(calcu);
            await _context.SaveChangesAsync();

			calcu.Peso = calcu.Volume * calcu.Densidade * 9.81;

			return CreatedAtAction("GetCalcu", new { id = calcu.Id }, calcu);
        }

        // DELETE: api/Calcus/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Calcu>> DeleteCalcu(int id)
        {
            var calcu = await _context.Calcus.FindAsync(id);
            if (calcu == null)
            {
                return NotFound();
            }

            _context.Calcus.Remove(calcu);
            await _context.SaveChangesAsync();

            return calcu;
        }

        private bool CalcuExists(int id)
        {
            return _context.Calcus.Any(e => e.Id == id);
        }
    }
}
