namespace WebJobMatchingAPI.Entities
{
    public class User_Role
    {
        public int Role_id { get; set; }
        public Guid User_id { get; set; }

        public Users user { get; set; }
        public Roles role { get; set; }
    }
}
