namespace WebJobMatchingAPI.Entities
{
    public class Jobs
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public string? Company { get; set; }
        public string? Location { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastUpdated { get; set; }
        public double Salary { get; set; } // 1000$ but I need it's 500$ - 1000$
        public string? TypeOfWork { get; set; }
        public string? RequiredSkills { get; set; }
        public List<Users>? Applicants { get; set; }
    }
}
