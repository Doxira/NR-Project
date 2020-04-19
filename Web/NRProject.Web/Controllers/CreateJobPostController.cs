namespace NRProject.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using NRProject.Data.Common.Models;
    using NRProject.Data.Common.Repositories;
    using NRProject.Web.ViewModels.JobPost;

    public class CreateJobPostController
    {
        private readonly IRepository<JobPosts> jobPostsRepo;

        public CreateJobPostController(IRepository<JobPosts> jobPostsRepo)
        {
            this.jobPostsRepo = jobPostsRepo;
        }

        public IActionResult Create()
        {
            var inputmodel = new InputJobPostViewModel();
            
        }
    }
}
