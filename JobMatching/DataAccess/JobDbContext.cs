using Microsoft.EntityFrameworkCore;

namespace JobMatching.DataAccess
{
    public class JobDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=JobMatching;Integrated Security=SSPI;TrustServerCertificate=true;");

        //public JobDbContext() : base("DbConnectString")
        //{

        //}

        public DbSet<JobEntity> Jobs { get; set; }
    }
}
