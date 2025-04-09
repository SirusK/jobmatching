namespace JobMatching.Services
{
    public interface IJobMatchingService
    {
        Task<IEnumerable<Job>> GetMatchingJobAsync(JobFilter jobFilter);
    }
}