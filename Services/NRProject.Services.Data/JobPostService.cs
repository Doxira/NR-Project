namespace NRProject.Services.Data
{

    using NRProject.Data.Common.Models;
    using NRProject.Data.Common.Repositories;

    public class JobPostService : IJobPostService
    {
        private readonly IDeletableEntityRepository<JobPosts> jobpostsrepo;

        public JobPostService(IDeletableEntityRepository<JobPosts> jobpostsrepo)
        {
            this.jobpostsrepo = jobpostsrepo;
        }

        public void CreateAsync(string title, string content, JobCategory jobCategory)
        {
            var jobpost = new JobPosts
            {
                Title = title,
                Content = content,
                JobCategory = jobCategory,
            };
             this.jobpostsrepo.AddAsync(jobpost);
             this.jobpostsrepo.SaveChangesAsync();
        }
    }
}
