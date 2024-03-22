using System;
using System.Collections.Generic;
using System.Data;
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
    public class RolesController : ControllerBase
    {
        private readonly DBContext _context;

        public RolesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Roles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Roles>>> GetAll()
        {
            return await _context.Roles.ToListAsync();
        }

        // GET: api/Roles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Roles>> GetById(int id)
        {
            try
            {
                var roles = await _context.Roles.FindAsync(id);

                if (roles == null)
                {
                    return NotFound();
                }

                return roles;
            }
            catch
            {
                return BadRequest();
            }
        }

        // POST: api/Roles
        [HttpPost]
        public async Task<ActionResult<Roles>> Create(RolesDTO roleDTO)
        {
            try
            {
                var role = new Roles
                {
                    Name = roleDTO.Name,
                };
                _context.Roles.Add(role);
                await _context.SaveChangesAsync();

                return Ok(role);
            }
            catch
            {
                return BadRequest();
            }
        }


        // PUT: api/Roles/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoles(int id, RolesDTO roleDTO)
        {
            try
            {
                var role = await _context.Roles.SingleOrDefaultAsync(r => r.Id == id);
                if (role != null)
                {
                    _context.Entry(role).State = EntityState.Modified;
                    try
                    {
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!RolesExists(id))
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
                else return NotFound();
            }
            catch { return BadRequest(); }
        }

        // DELETE: api/Roles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoles(int id)
        {
            try
            {
                var roles = await _context.Roles.FindAsync(id);
                if (roles == null)
                {
                    return NotFound();
                }

                _context.Roles.Remove(roles);
                await _context.SaveChangesAsync();

                return NoContent();
            } catch { return BadRequest(); }
        }

        private bool RolesExists(int id)
        {
            return _context.Roles.Any(e => e.Id == id);
        }
    }
}
