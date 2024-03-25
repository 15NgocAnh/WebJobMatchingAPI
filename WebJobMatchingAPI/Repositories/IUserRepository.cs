using WebJobMatchingAPI.DTO;

namespace WebJobMatchingAPI.Repositories
{
    public interface IUserRepository
    {
        public Task<List<UsersDTO>> findAll();
        public Task<UsersDTO> findById(Guid id);
        public Task<Guid> save(UsersDTO user);
        public Task update(Guid id, UsersDTO user);
        public Task delete(Guid id);
        public Task active(Guid id);
    }
}
