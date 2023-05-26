using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BigBangTest.Models;

namespace BigBangTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotelsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MotelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Motels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Motel>>> GetMotel()
        {
          if (_context.Motel == null)
          {
              return NotFound();
          }
            return await _context.Motel.ToListAsync();
        }

        // GET: api/Motels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Motel>> GetMotel(int id)
        {
          if (_context.Motel == null)
          {
              return NotFound();
          }
            var motel = await _context.Motel.FindAsync(id);

            if (motel == null)
            {
                return NotFound();
            }

            return motel;
        }

        // PUT: api/Motels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMotel(int id, Motel motel)
        {
            if (id != motel.motel_Id)
            {
                return BadRequest();
            }

            _context.Entry(motel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MotelExists(id))
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

        // POST: api/Motels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Motel>> PostMotel(Motel motel)
        {
          if (_context.Motel == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Motel'  is null.");
          }
            _context.Motel.Add(motel);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MotelExists(motel.motel_Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMotel", new { id = motel.motel_Id }, motel);
        }

        // DELETE: api/Motels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMotel(int id)
        {
            if (_context.Motel == null)
            {
                return NotFound();
            }
            var motel = await _context.Motel.FindAsync(id);
            if (motel == null)
            {
                return NotFound();
            }

            _context.Motel.Remove(motel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MotelExists(int id)
        {
            return (_context.Motel?.Any(e => e.motel_Id == id)).GetValueOrDefault();
        }
    }
}
