using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProiectCofetarie;
using ProiectCofetarie.WebAPI.Data;

namespace ProiectCofetarie.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdusController : ControllerBase
    {
        private readonly ProiectCofetarieWebAPIContext _context;

        public ProdusController(ProiectCofetarieWebAPIContext context)
        {
            _context = context;
        }

        // GET: api/Produs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produs>>> GetProduse()
        {
          if (_context.Produse == null)
          {
              return NotFound();
          }
            return await _context.Produse.ToListAsync();
        }

        // GET: api/Produs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Produs>> GetProdus(int id)
        {
          if (_context.Produse == null)
          {
              return NotFound();
          }
            var produs = await _context.Produse.FindAsync(id);

            if (produs == null)
            {
                return NotFound();
            }

            return produs;
        }

        // PUT: api/Produs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProdus(int id, Produs produs)
        {
            if (id != produs.Id)
            {
                return BadRequest();
            }

            _context.Entry(produs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProdusExists(id))
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

        // POST: api/Produs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Produs>> PostProdus(Produs produs)
        {
          if (_context.Produse == null)
          {
              return Problem("Entity set 'ProiectCofetarieWebAPIContext.Produse'  is null.");
          }
            _context.Produse.Add(produs);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProdus", new { id = produs.Id }, produs);
        }

        // DELETE: api/Produs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProdus(int id)
        {
            if (_context.Produse == null)
            {
                return NotFound();
            }
            var produs = await _context.Produse.FindAsync(id);
            if (produs == null)
            {
                return NotFound();
            }

            _context.Produse.Remove(produs);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProdusExists(int id)
        {
            return (_context.Produse?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
