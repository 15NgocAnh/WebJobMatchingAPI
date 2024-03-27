using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebJobMatchingAPI.DTO;

namespace WebJobMatchingAPI.Entities
{
    public enum Role
    {
        ROLE_ADMIN, ROLE_USER, ROLE_GUEST
    };
    
    [Table("role")]
    public class Roles 
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public Role Name { get; set; }
        public IList<User_Role> Users { get; set; }
    }
}
