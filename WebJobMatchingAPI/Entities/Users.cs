using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using WebJobMatchingAPI.DTO;

namespace WebJobMatchingAPI.Entities
{
    [Table("users")]
    public class Users : UsersDTO
    {
        [Key]
        public Guid ID { get; set; }

        public List<Roles> Roles { get; set; } = null!;

    }

}
