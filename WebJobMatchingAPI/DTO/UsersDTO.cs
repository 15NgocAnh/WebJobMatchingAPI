using System.ComponentModel.DataAnnotations;

namespace WebJobMatchingAPI.DTO
{
    public class UsersDTO
    {

        [Required]
        [StringLength(20)]
        public string? FirstName { get; set; }

        [Required]
        [MinLength(8)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$", ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, and one digit.")]
        public string? Password { get; set; }

        [Required]
        [StringLength(50)]
        public string? Email { get; set; }

        [Required]
        public string? UserName { get; set; }
        public string? PhoneNumber { get; set; }
        [Required]
        [StringLength(10)]
        public string? LastName { get; set; }
        public DateOnly BirthDay { get; set; }
        public List<string>? Skills { get; set; }
        public string? Experience { get; set; }
        public string? Education { get; set; }
        public string? Location { get; set; }
        public bool IsEmailConfirmed { get; set; } = false;
        public bool IsMale { get; set; }
        public bool IsLocked { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
    }

}
