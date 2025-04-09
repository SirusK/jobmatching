using Microsoft.EntityFrameworkCore;

namespace JobMatching.DataAccess
{
    public class JobRepository
    {
        public JobDbContext _dbContext;

        public JobRepository()
        {
            _dbContext = new JobDbContext();
        }

        public async Task<IEnumerable<Job>> GetJobsAsync(JobFilter jobFilter)
        {
            //TODO: filter skill, automapper
            var result = await _dbContext.Jobs.Where(job => job.YearsOfExperience <= jobFilter.YearsOfExperience).ToListAsync();
            return result.Select(job => new Job
            {
                Id = job.Id,
                Name = job.Name,
                YearsOfExperience = job.YearsOfExperience,
                HardSkills = job.HardSkills.Split(";"),
                SoftSkills = job.SoftSkills.Split(";"),
            });
        }

        public async Task<IEnumerable<Job>> GetAllJobsAsync()
        {
            var result = await _dbContext.Jobs.ToListAsync();
            return result.Select(job => new Job
            {
                Id = job.Id,
                Name = job.Name,
                YearsOfExperience = job.YearsOfExperience,
                HardSkills = job.HardSkills.Split(";"),
                SoftSkills = job.SoftSkills.Split(";"),
            });
        }

        public async Task CreateJobAsync(JobEntity job)
        {
            _dbContext.Jobs.Add(job);
            await _dbContext.SaveChangesAsync();
        }
    }
}
