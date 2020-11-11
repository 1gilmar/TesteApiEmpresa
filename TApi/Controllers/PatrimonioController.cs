using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TApi.Data;
using TApi.Models;

namespace TApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PatrimonioController : ControllerBase
    {
        private readonly DataContext _context;

        public PatrimonioController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Patrimonio
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Patrimonio>>> GetPatrimonios()
        {
            return await _context.Patrimonios.ToListAsync();
        }

        // GET: api/Patrimonio/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Patrimonio>> GetPatrimonio(int id)
        {
            var patrimonio = await _context.Patrimonios.FindAsync(id);

            if (patrimonio == null)
            {
                return NotFound();
            }

            return patrimonio;
        }

        // PUT: api/Patrimonio/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPatrimonio(int id, Patrimonio patrimonio)
        {
            if (id != patrimonio.Id)
            {
                return BadRequest();
            }

            _context.Entry(patrimonio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatrimonioExists(id))
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

        // POST: api/Patrimonio
        [HttpPost]
        public async Task<ActionResult<Patrimonio>> PostPatrimonio(Patrimonio patrimonio)
        {
            _context.Patrimonios.Add(patrimonio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPatrimonio", new { id = patrimonio.Id }, patrimonio);
        }

        // DELETE: api/Patrimonio/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Patrimonio>> DeletePatrimonio(int id)
        {
            var patrimonio = await _context.Patrimonios.FindAsync(id);
            if (patrimonio == null)
            {
                return NotFound();
            }

            _context.Patrimonios.Remove(patrimonio);
            await _context.SaveChangesAsync();

            return patrimonio;
        }

        private bool PatrimonioExists(int id)
        {
            return _context.Patrimonios.Any(e => e.Id == id);
        }
    }
}
