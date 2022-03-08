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
    public class PublicationsController : ControllerBase
    {
        private readonly FIS_DBContext _context;

        public PublicationsController(FIS_DBContext context)
        {
            _context = context;
        }

        // GET: api/Publications
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Publication>>> GetPublications()
        {
            return await _context.Publications.ToListAsync();
        }

        // GET: api/Publications/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Publication>> GetPublication(string id)
        {
            var publication = await _context.Publications.FindAsync(id);

            if (publication == null)
            {
                return NotFound();
            }

            return publication;
        }

        [HttpGet]
        [Route("FacultyPublication")]
        public IEnumerable<Publication> GetPublicationDetailsbyFacultyID(int id)
        {
            List<Publication> publications = _context.Publications.Where(p => p.FacultyId == id).ToList();
            return publications;
        }


        // PUT: api/Publications/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPublication(string id, Publication publication)
        {
            if (id != publication.PublicationId)
            {
                return BadRequest();
            }

            _context.Entry(publication).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PublicationExists(id))
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

        // POST: api/Publications
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Publication>> PostPublication(Publication publication)
        {
            _context.Publications.Add(publication);
            await _context.SaveChangesAsync();
            //try
            //{

            //}
            //catch (DbUpdateException)
            //{
            //    if (PublicationExists(publication.PublicationId))
            //    {
            //        return Conflict();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}
            return Ok(publication);
            //return CreatedAtAction("GetPublication", new { id = publication.PublicationId }, publication);
        }

        // DELETE: api/Publications/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePublication(string id)
        {
            var publication = await _context.Publications.FindAsync(id);
            if (publication == null)
            {
                return NotFound();
            }

            _context.Publications.Remove(publication);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PublicationExists(string id)
        {
            return _context.Publications.Any(e => e.PublicationId == id);
        }
    }
}
