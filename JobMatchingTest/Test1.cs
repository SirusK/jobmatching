using JobMatching;

namespace JobMatchingTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            var repo = new JobRepository();
             await repo.CreateJobAsync(new JobEntity { Name = "Mock" });

            var xxx = repo.GetAllJobsAsync();
        }
    }
}
