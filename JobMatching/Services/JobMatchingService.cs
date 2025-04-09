using JobMatching.DataAccess;

namespace JobMatching.Services
{
    public class JobMatchingService : IJobMatchingService
    {
        private readonly JobRepository _jobRepository;

        public JobMatchingService(JobRepository jobRepository)
        {
            _jobRepository = jobRepository ?? throw new ArgumentNullException(nameof(jobRepository));
        }

        public async Task<IEnumerable<Job>> GetMatchingJobAsync(JobFilter jobFilter)
        {
            // temp solution
            // TODO: partial match e.g. 50% match, 70% match, move matching logic to repository level
            var result = await _jobRepository.GetJobsAsync(jobFilter);
            result.Where(job => 
                job.HardSkills.All(reqHardSkill => jobFilter.HardSkills.Any(hs => hs == reqHardSkill)) 
                && job.SoftSkills.All(reqSoftSkill => jobFilter.SoftSkills.Any(ss => ss == reqSoftSkill)));
            return result;
        }
    }
}
