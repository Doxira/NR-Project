namespace NRProject.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using NRProject.Data;
    using NRProject.Data.Common.Models;
    using NRProject.Data.Common.Repositories;
    using NRProject.Web.ViewModels.Jobs;
    using NRProject.Services.Mapping;
    using System.Linq;

    public class JobsController : BaseController
    {

        private readonly IRepository<JobCategory> jobrepo;

        public JobsController(IRepository<JobCategory>jobrepo)
        {
            this.jobrepo = jobrepo;
        }

        public IActionResult Index()
        {
            var viewModel = new JobsViewModel();
            var jobCategories = this.jobrepo.All().To<IndexJobsCategoryViewModel>()
                .ToList();
            viewModel.JobCategories = jobCategories;

            return this.View(viewModel);

        }
    }
}
