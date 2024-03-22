using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebJobMatchingAPI.DTO;

namespace WebJobMatchingAPI.Entities
{
    [Table("jobs")]
    public class Jobs 
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [MaxLength(1000)]
        public string? Description { get; set; }
        public bool Status { get; set; }
        public string? Company { get; set; }
        public string? Location { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastUpdated { get; set; } = DateTime.Now;

        [Range(0, double.MaxValue)]
        public double Salary { get; set; } // 1000$ but I need it's 500$ - 1000$
        public string? TypeOfWork { get; set; }
        public string? RequiredSkills { get; set; }
        public bool IsDelete { get; set; } = false;
        public List<Users>? Applicants { get; set; }
    }
}
