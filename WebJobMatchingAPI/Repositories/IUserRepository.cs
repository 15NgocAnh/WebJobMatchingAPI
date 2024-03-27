using WebJobMatchingAPI.DTO;

namespace WebJobMatchingAPI.Repositories
{
    public interface IUserRepository
    {
        public Task<List<UsersDTO>> findAllActive();
        public Task<List<UsersViewModel>> findAll();
        public Task<UsersDTO> findById(Guid id);
        public Task<UsersDTO> save(UsersDTO user);
        public Task update(Guid id, UsersDTO user);
        public Task delete(Guid id);
        public Task active(Guid id);
        public Task<List<UsersDTO>> search(string? keyword, string? sortBy, bool? gender, int? pageNumber);
        public Task<List<UsersDTO>> getUsersByName(string? name);
    }
}
