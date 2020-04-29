using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NRProject.Data.Models;
using NRProject.Services.Data;

namespace NRProject.Web.Controllers
{
    public class MyJobsController : BaseController
    {
        private readonly IJobPostService jobPostService;
        private readonly UserManager<ApplicationUser> userManager;

        public MyJobsController(IJobPostService jobPostService, UserManager<ApplicationUser> userManager)
        {
            this.jobPostService = jobPostService;
            this.userManager = userManager;
        }
        [Authorize]
         public IActionResult PostByUser()
        {
            var user = this.userManager.GetUserId(this.User);
            var model = this.jobPostService.GetJobPostsByUser(user);
            return this.View(model);
        }
     }
}
