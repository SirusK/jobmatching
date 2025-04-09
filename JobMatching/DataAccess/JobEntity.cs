using System.ComponentModel.DataAnnotations;

namespace JobMatching.DataAccess
{
    public class JobEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearsOfExperience { get; set; }
        public string HardSkills { get; set; } // string or enum
        public string SoftSkills { get; set; }
    }
}