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
    public class WorkHistoriesController : ControllerBase
    {
        private readonly FIS_DBContext _context;

        public WorkHistoriesController(FIS_DBContext context)
        {
            _context = context;
        }

        // GET: api/WorkHistories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkHistory>>> GetWorkHistories()
        {
            return await _context.WorkHistories.ToListAsync();
        }

        // GET: api/WorkHistories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WorkHistory>> GetWorkHistory(int id)
        {
            var workHistory = await _context.WorkHistories.FindAsync(id);

            if (workHistory == null)
            {
                return NotFound();
            }

            return workHistory;
        }

        [HttpGet]
        [Route("FacultyWorkHistory")]
        public IEnumerable<WorkHistory> GetWorkHistoryDetailsbyFacultyID(int id)
        {
            List<WorkHistory> workHistor = _context.WorkHistories.Where(wh => wh.FacultyId == id).ToList();
            return workHistor;
        }

        // PUT: api/WorkHistories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkHistory(int id, WorkHistory workHistory)
        {
            if (id != workHistory.WorkHistoryId)
            {
                return BadRequest();
            }

            _context.Entry(workHistory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkHistoryExists(id))
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

        // POST: api/WorkHistories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<WorkHistory>> PostWorkHistory(WorkHistory workHistory)
        //{
        //    _context.WorkHistories.Add(workHistory);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetWorkHistory", new { id = workHistory.WorkHistoryId }, workHistory);
        //}

        [HttpPost]
        public async Task<ActionResult<WorkHistory>> PostWorkHistory( WorkHistory workHistory)
        {
            _context.WorkHistories.Add(workHistory);
            await _context.SaveChangesAsync();
            //try
            //{
            //    await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateException)
            //{
            //    if (WorkHistoryExists(workHistory.WorkHistoryId))
            //    {
            //        return Conflict();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}
            return Ok(workHistory);
            //return CreatedAtAction("GetWorkHistory", new { id = workHistory.WorkHistoryId }, workHistory);
        }

        // DELETE: api/WorkHistories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorkHistory(int id)
        {
            var workHistory = await _context.WorkHistories.FindAsync(id);
            if (workHistory == null)
            {
                return NotFound();
            }

            _context.WorkHistories.Remove(workHistory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WorkHistoryExists(int id)
        {
            return _context.WorkHistories.Any(e => e.WorkHistoryId == id);
        }
    }
}
