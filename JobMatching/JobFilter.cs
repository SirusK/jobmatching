namespace JobMatching
{
    public class JobFilter
    {
        public int YearsOfExperience { get;set; }
        public IEnumerable<string> HardSkills { get; set; }
        public IEnumerable<string> SoftSkills { get; set; }
    }
}