using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FacultyInformationSystemWebAPI.Model;
using FacultyInformationSystemWebAPI.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace FacultyInformationSystemWebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(UserRoles.Admin)]
    public class FacultiesController : ControllerBase
    {
        private readonly FIS_DBContext _context;

        public FacultiesController(FIS_DBContext context)
        {
            _context = context;
        }

        // GET: api/Faculties
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Faculty>>> GetFaculties()
        {
            return await _context.Faculties.ToListAsync();
        }

        // GET: api/Faculties/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Faculty>> GetFaculty(int id)
        {
            var faculty = await _context.Faculties.FindAsync(id);

            if (faculty == null)
            {
                return NotFound();
            }

            return faculty;
        }

        //[HttpGet("{username}")]
        //public async Task<ActionResult<Faculty>> GetFaculty(string username)
        //{
        //    var faculty = await _context.Faculties.FirstOrDefault(username);

        //    if (faculty == null)
        //    {
        //        return NotFound();
        //    }

        //    return faculty;
        //}

        // PUT: api/Faculties/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFaculty(int id, Faculty faculty)
        {
            if (id != faculty.FacultyId)
            {
                return BadRequest();
            }

            _context.Entry(faculty).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FacultyExists(id))
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

        // POST: api/Faculties
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Faculty>> PostFaculty(Faculty faculty)
        //{
        //    _context.Faculties.Add(faculty);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetFaculty", new { id = faculty.FacultyId }, faculty);
        //}

        [HttpPost]
        // public async Task<ActionResult<Faculty>> PostFaculty([FromQuery] Faculty faculty)
        public async Task<ActionResult<Faculty>> PostFaculty(Faculty faculty)
        {
            _context.Faculties.Add(faculty);
            await _context.SaveChangesAsync();

            return Ok(faculty);
        }

        // DELETE: api/Faculties/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFaculty(int id)
        {
            var faculty = await _context.Faculties.FindAsync(id);
            if (faculty == null)
            {
                return NotFound();
            }

            _context.Faculties.Remove(faculty);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FacultyExists(int id)
        {
            return _context.Faculties.Any(e => e.FacultyId == id);
        }
    }
}

