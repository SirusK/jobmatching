using System.ComponentModel.DataAnnotations;

namespace JobMatching
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearsOfExperience { get; set; }
        public IEnumerable<string> HardSkills { get; set; } // string or enum
        public IEnumerable<string> SoftSkills { get; set; }
    }
}