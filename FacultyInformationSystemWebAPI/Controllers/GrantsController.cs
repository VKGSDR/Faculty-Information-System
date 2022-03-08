using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FacultyInformationSystemWebAPI.Model;

namespace FacultyInformationSystemWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrantsController : ControllerBase
    {
        private readonly FIS_DBContext _context;

        public GrantsController(FIS_DBContext context)
        {
            _context = context;
        }

        // GET: api/Grants
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Grant>>> GetGrants()
        {
            return await _context.Grants.ToListAsync();
        }

        // GET: api/Grants/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Grant>> GetGrant(int id)
        {
            var grant = await _context.Grants.FindAsync(id);

            if (grant == null)
            {
                return NotFound();
            }

            return grant;
        }

        [HttpGet]
        [Route("FacultyGrant")]
        public IEnumerable<Grant> GetGrantDetailsbyFacultyID(int id)
        {
            List<Grant> grant = _context.Grants.Where(g => g.FacultyId == id).ToList();
            
            return grant;
        }

        // PUT: api/Grants/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGrant(int id, Grant grant)
        {
            if (id != grant.GrantId)
            {
                return BadRequest();
            }

            _context.Entry(grant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GrantExists(id))
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

        // POST: api/Grants
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754

        [HttpPost]
        public async Task<ActionResult<Grant>> PostGrant(Grant grant)
        {
            _context.Grants.Add(grant);
            await _context.SaveChangesAsync();

            return Ok(grant);
        }

        // DELETE: api/Grants/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGrant(int id)
        {
            var grant = await _context.Grants.FindAsync(id);
            if (grant == null)
            {
                return NotFound();
            }
            _context.Grants.Remove(grant);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GrantExists(int id)
        {
            return _context.Grants.Any(e => e.GrantId == id);
        }
    }
}
