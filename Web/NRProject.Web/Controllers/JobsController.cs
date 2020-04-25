namespace NRProject.Web.Controllers
{
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;
    using NRProject.Data;
    using NRProject.Data.Common.Models;
    using NRProject.Data.Common.Repositories;
    using NRProject.Services.Data;
    using NRProject.Services.Mapping;
    using NRProject.Web.ViewModels.Jobs;

    public class JobsController : BaseController
    {
        private readonly IJobPostService jobPost;
        private readonly IRepository<JobCategory> jobrepo;
        private readonly IDeletableEntityRepository<JobPosts> jobPostRepo;
        public JobsController(IRepository<JobCategory> jobrepo,IJobPostService jobPost,IDeletableEntityRepository<JobPosts>jobPostRepo)
        {
            this.jobrepo = jobrepo;
            this.jobPost = jobPost;
            this.jobPostRepo = jobPostRepo;
        } 

        public IActionResult Index()
        {
            var viewModel = new JobsViewModel();
            var jobCategories = this.jobrepo.All().To<IndexJobsCategoryViewModel>()
                .ToList();
            viewModel.JobCategories = jobCategories;
            var settings = jobPost.GetAllJobPosts();
            viewModel.JobPosts = settings;
            return this.View(viewModel);
        }

        //[HttpGet]
        //public IActionResult Something()
        //{
        //    var setting = jobPost.GetAllJobPosts();
        //    return Ok(setting);
        //}
    }
}
