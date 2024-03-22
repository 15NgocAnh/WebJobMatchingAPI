using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public class UsersController : ControllerBase
    {
        private readonly DBContext _context;

        public UsersController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Users>>> GetAllUsers()
        {
            return Ok(await _context.Users.ToListAsync());
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Users>> GetUserById(Guid id)
        {
            try
            {
                var user = await _context.Users.FindAsync(id);
                if (user == null) return NotFound();
                return user;
            }
            catch
            {
                return BadRequest();
            }
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUserById(Guid id, UsersDTO userDTO)
        {
            try
            {
                var user = await _context.Users.SingleOrDefaultAsync(u => u.ID == id);
                if (user == null) return NotFound();
                if (id != user.ID)
                {
                    return BadRequest();
                }

                //user = ConvertDTOToEntity(userDTO);

                user.FirstName = userDTO.FirstName;
                user.LastName = userDTO.LastName;
                user.Email = userDTO.Email;
                user.BirthDay = userDTO.BirthDay;
                user.PhoneNumber = userDTO.PhoneNumber;
                user.UserName = userDTO.UserName;
                user.Password = userDTO.Password;
                user.IsDeleted = userDTO.IsDeleted;
                user.IsLocked = userDTO.IsLocked;
                user.IsMale = userDTO.IsMale;
                user.Skills = userDTO.Skills;
                user.Education = userDTO.Education;

                // Thiết lập trạng thái của đối tượng user thành Modified
                _context.Entry(user).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsersExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                // Update xong thi tra ve trang thai nocontent
                return NoContent();
            } catch
            {
                return BadRequest();
            }
        }

        // POST: api/Users
        [HttpPost]
        public async Task<ActionResult<Users>> createUser(UsersDTO userDTO)
        {
            try
            {
                var newUser = new Users
                {
                    ID = Guid.NewGuid(),
                    Password = userDTO.Password,
                    FirstName = userDTO.FirstName,
                    LastName = userDTO.LastName,
                    Email = userDTO.Email,
                    PhoneNumber = userDTO.PhoneNumber,
                    UserName = userDTO.UserName,

                };
                _context.Users.Add(newUser);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetUsers", newUser);
            }
            catch {  return BadRequest(); }
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsers(Guid id)
        {
            var users = await _context.Users.FindAsync(id);
            if (users == null)
            {
                return NotFound();
            }

            _context.Users.Remove(users);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UsersExists(Guid id)
        {
            return _context.Users.Any(e => e.ID == id);
        }

    }
}
