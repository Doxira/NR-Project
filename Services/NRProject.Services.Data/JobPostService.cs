namespace NRProject.Services.Data
{

    using NRProject.Data.Common.Models;
    using NRProject.Data.Common.Repositories;
    using System.Threading.Tasks;

    public class JobPostService : IJobPostService
    {
        private readonly IDeletableEntityRepository<JobPosts> jobpostsrepo;

        public JobPostService(IDeletableEntityRepository<JobPosts> jobpostsrepo)
        {
            this.jobpostsrepo = jobpostsrepo;
        }

        public async Task CreateAsync(string title, string content,int jobCategoryId,string userId)
        {
            var jobpost = new JobPosts
            {
                Title = title,
                Content = content,
                JobCategoryId = jobCategoryId,
                UserId = userId,
            };
            await this.jobpostsrepo.AddAsync(jobpost);
            await this.jobpostsrepo.SaveChangesAsync();           
        }
    }
}
