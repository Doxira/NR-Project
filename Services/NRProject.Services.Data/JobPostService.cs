namespace NRProject.Services.Data
{

    using NRProject.Data.Common.Models;
    using NRProject.Data.Common.Repositories;
    using NRProject.Services.Mapping;
    using NRProject.Web.ViewModels.Jobs;
    using System.Collections.Generic;
    using System.Linq;
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

        public ICollection<IndexJobsPostsViewModel> GetAllJobPosts()
        {
            var jobpostses = this.jobpostsrepo.All().To<IndexJobsPostsViewModel>().ToList();
            return jobpostses;
           
        }

        public T GetById<T>(int id)
        {
            var jobpost = this.jobpostsrepo.All().Where(x => x.Id == id).To<T>().FirstOrDefault();
            return jobpost;
        }

        public ICollection<IndexJobsPostsViewModel> GetJobPostsByCategory(JobCategory JobCategory)
        {
            var jobPostByCategory = this.jobpostsrepo.All().Where(x => x.JobCategory == JobCategory).To<IndexJobsPostsViewModel>().ToList();
            return jobPostByCategory;
        }
    }
}
