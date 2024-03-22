using System.Collections.Immutable;
using WebJobMatchingAPI.Data;
using WebJobMatchingAPI.DTO;
using WebJobMatchingAPI.Entities;

namespace WebJobMatchingAPI.Repositories.Impl
{
    public class UserRepository : IUserRepository
    {
        private readonly DBContext _context;
        public UserRepository(DBContext context) 
        { 
            _context = context;
        }

        public List<UsersDTO> findAll()
        {
            var listUsers = _context.Users.Select(u => new UsersDTO
            {
                FirstName = u.FirstName,
                LastName = u.LastName,
                Email = u.Email,
                UserName = u.UserName,
                Password = u.Password
            });
            return listUsers.ToList();
        }

        public UsersDTO findById(Guid id)
        {
            var user = _context.Users.SingleOrDefault(u => u.ID == id);
            if (user == null)
            {
                return null;
            }
            return new UsersDTO
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                UserName = user.UserName,
                Password = user.Password
            };
        }

        public UsersDTO save(UsersDTO userDTO)
        {
            var user = new Users
            {
                ID = Guid.NewGuid(),
                FirstName = userDTO.FirstName,
                LastName = userDTO.LastName,
                Email = userDTO.Email,
                UserName = userDTO.UserName,
                Password = userDTO.Password
            };
            _context.Users.Add(user);
            return userDTO;
        }

        public void update(Guid id, UsersDTO userDTO)
        {
            var user = _context.Users.SingleOrDefault(u => u.ID == id);
            if (user != null)
            {
                user.FirstName = userDTO.FirstName;
                user.LastName = userDTO.LastName;
                user.Email = userDTO.Email;
                user.UserName = userDTO.UserName;
                user.Password = userDTO.Password;
                _context.SaveChangesAsync();
            };
        }

        public void delete(Guid id)
        {
            var user = _context.Users.SingleOrDefault(u => u.ID == id);
            if (user != null)
            {
                user.IsDeleted = true;
                _context.SaveChanges();
            }
        }
    }
}
