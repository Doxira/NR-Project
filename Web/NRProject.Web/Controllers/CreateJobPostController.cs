namespace NRProject.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using NRProject.Data.Common.Models;
    using NRProject.Data.Common.Repositories;
    using NRProject.Data.Models;
    using NRProject.Services.Data;
    using NRProject.Web.ViewModels.JobPost;
    using System.Threading.Tasks;

    public class CreateJobPostController : BaseController
    {
        private readonly IJobPostService jobPostService;
        private readonly UserManager<ApplicationUser> userManager;

        public CreateJobPostController(IJobPostService jobPostService, UserManager<ApplicationUser> userManager)
        {
            this.jobPostService = jobPostService;
            this.userManager = userManager;
        }

        [Authorize]
        public async Task<IActionResult> CreatePost()
        {
            var user = await this.userManager.GetUserAsync(this.User);
            if ((int)user.WorkerOrHirer == 1)
            {
                return this.RedirectToAction("Index", "Jobs");
            }
            return this.View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreatePost(InputJobPostViewModel input)
        {
            var user = await this.userManager.GetUserAsync(this.User);
            if ((int)user.WorkerOrHirer==1)
            {
                return this.RedirectToAction("Index", "Jobs");
            }
            else if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }
            await this.jobPostService.CreateAsync(input.Title, input.Content,input.JobCategoryId,user.Id);
            return this.RedirectToAction("Index", "Jobs");
        }
    }
}
