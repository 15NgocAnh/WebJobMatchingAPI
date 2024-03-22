using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebJobMatchingAPI.Data;
using WebJobMatchingAPI.DTO;
using WebJobMatchingAPI.Entities;

namespace WebJobMatchingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly DBContext _context;

        public JobsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Jobs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Jobs>>> GetAll ()
        {
            return await _context.Jobs.ToListAsync();
        }

        // GET: api/Jobs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Jobs>> GetById(Guid id)
        {
            try
            {
                var jobs = await _context.Jobs.FindAsync(id);

                if (jobs == null)
                {
                    return NotFound();
                }

                return jobs;
            } catch { return BadRequest(); }
        }

        // POST: api/Jobs
        [HttpPost]
        public async Task<ActionResult<Jobs>> Create(JobsDTO jobDTO)
        {
            try
            {
                var job = new Jobs
                {
                    Name = jobDTO.Name,
                };
                _context.Jobs.Add(job);
                await _context.SaveChangesAsync();

                return Ok(job);
            } catch { return BadRequest(); }
        }


        // PUT: api/Jobs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, JobsDTO jobDTO)
        {
            try
            {
                var job = await _context.Jobs.FindAsync(id);
                if (job != null)
                {
                    _context.Entry(job).State = EntityState.Modified;
                    try
                    {
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!JobsExists(id))
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
                else { return NotFound(); }
            } catch { return BadRequest(); }
        }

        // DELETE: api/Jobs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> SoftDelete(Guid id)
        {
            try
            {
                var jobs = await _context.Jobs.FindAsync(id);
                if (jobs == null)
                {
                    return NotFound();
                }
                jobs.IsDelete = true;
                await _context.SaveChangesAsync();

                return NoContent();
            } catch { return BadRequest(); }
        }

        private bool JobsExists(Guid id)
        {
            return _context.Jobs.Any(e => e.Id == id);
        }
    }
}
