using JobMatching.Services;
using Microsoft.AspNetCore.Mvc;

namespace JobMatching.Controllers
{
    public class JobMatchingController : Controller
    {
        private readonly ILogger<JobMatchingController> _logger;
        private readonly IJobMatchingService _jobMatchingService;

        public JobMatchingController(ILogger<JobMatchingController> logger, IJobMatchingService jobMatchingService)
        {
            _logger = logger;
            _jobMatchingService = jobMatchingService ?? throw new ArgumentNullException(nameof(jobMatchingService));
        }

        public async Task<IEnumerable<Job>> GetMatchingJobAsync(JobFilter jobFilter)
        {
            return await _jobMatchingService.GetMatchingJobAsync(jobFilter);
            //throw new NotImplementedException();
        }
    }
}
