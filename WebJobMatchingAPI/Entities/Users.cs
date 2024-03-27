using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using WebJobMatchingAPI.DTO;
using System.Reflection.Metadata;

namespace WebJobMatchingAPI.Entities
{
    [Table("users")]
    public class Users 
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(10)]
        public string LastName { get; set; }

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        [Required]
        [MinLength(8)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[#$^+=!*()@%&]).{8,}$", ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, and one digit.")]
        public string? Password { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        public string? PhoneNumber { get; set; }
        public DateOnly BirthDay { get; set; }

        
        //public Blob image { get; set; }
        public List<Skills> Skills { get; set; }
        public string? Experience { get; set; }
        public string? Education { get; set; }
        public string? Location { get; set; }
        public bool IsEmailConfirmed { get; set; } = false;
        public bool IsMale { get; set; }
        public bool IsLocked { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
        public List<User_Role> Roles { get; set; }

    }

}
