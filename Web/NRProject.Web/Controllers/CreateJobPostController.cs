using Microsoft.AspNetCore.Mvc;
using NRProject.Data.Common.Models;
using NRProject.Data.Common.Repositories;
using NRProject.Services.Data;
namespace NRProject.Web.Controllers
{



    public class CreateJobPostController : BaseController
    {
        private readonly IRepository<JobPosts> jobPosts;
        private readonly IJobPostService jobPostService;

        public CreateJobPostController(IRepository<JobPosts> jobPosts, IJobPostService jobPostService)
        {
            this.jobPosts = jobPosts;
            this.jobPostService = jobPostService;

        }
        public IActionResult CreatePost(string Title,string Content,JobCategory jobCategory)
        {
            return this.View();
        }
    }
}
