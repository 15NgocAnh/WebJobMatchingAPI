using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using WebJobMatchingAPI.Data;
using WebJobMatchingAPI.DTO;
using WebJobMatchingAPI.Entities;

namespace WebJobMatchingAPI.Repositories.Impl
{
    public class UserRepository : IUserRepository
    {
        private readonly DBContext _context;
        private readonly IMapper _mapper;

        public UserRepository(DBContext context, IMapper mapper) 
        { 
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<UsersDTO>> findAll()
        {
            var listUsers = await _context.Users!
                .Select(u => new {u.FirstName, u.LastName, u.Email, u.Password, u.UserName, u.IsDeleted})
                .Where(u => u.IsDeleted == false)
                .ToListAsync(); ;
            return _mapper.Map<List<UsersDTO>>(listUsers);
        }

        public async Task<UsersDTO> findById(Guid id)
        {
            var user = await _context.Users!.FindAsync(id);
            return _mapper.Map<UsersDTO>(user);
        }

        public async Task<Guid> save(UsersDTO userDTO)
        {
            var user = _mapper.Map<Users>(userDTO);
                user.ID = Guid.NewGuid();
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user.ID;
        }

        public async Task update(Guid id, UsersDTO userDTO)
        {
            var user = await _context.Users!.SingleOrDefaultAsync(u => u.ID == id);
            if (user != null)
            {
                _context.Users.Update(_mapper.Map<Users>(userDTO));
                await _context.SaveChangesAsync();
            }
        }

        public async Task delete(Guid id)
        {
            var user = await _context.Users!.SingleOrDefaultAsync(u => u.ID == id);
            if (user != null)
            {
                user.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }

        public async Task active(Guid id)
        {
            var user = await _context.Users!.SingleOrDefaultAsync(u => u.ID == id);
            if (user != null)
            {
                user.IsDeleted = false;
                await _context.SaveChangesAsync();
            }
        }

    }
}
