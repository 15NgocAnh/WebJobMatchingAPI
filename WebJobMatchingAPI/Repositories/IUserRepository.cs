using WebJobMatchingAPI.DTO;

namespace WebJobMatchingAPI.Repositories
{
    public interface IUserRepository
    {
        List<UsersDTO> findAll();
        UsersDTO findById(Guid id);
        UsersDTO save(UsersDTO user);
        void update(Guid id, UsersDTO user);
        void delete(Guid id);
    }
}
