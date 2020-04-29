using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NRProject.Data.Models;
using NRProject.Services.Data;
using NRProject.Web.ViewModels.JobOfers;
using System.Threading.Tasks;

namespace NRProject.Web.Controllers
{
    public class JobOffersController : BaseController
    {
        private readonly IJobOffersService jobOffersService;
        private readonly UserManager<ApplicationUser> userManager;

        public JobOffersController(IJobOffersService jobOffersService, UserManager<ApplicationUser> userManager)
        {
            this.jobOffersService = jobOffersService;
            this.userManager = userManager;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreateJobOffer(InputJobOfferViewModel input)
        {
            var user = await this.userManager.GetUserAsync(this.User);
            await this.jobOffersService.CreateAsync(input.JobPostsId, input.Description, user.Id);
            return this.RedirectToAction("PostById", "Jobs", new { id = input.JobPostsId });
        }

    }
}
