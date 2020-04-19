namespace NRProject.Web.Controllers
{
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;
    using NRProject.Data;
    using NRProject.Data.Common.Models;
    using NRProject.Data.Common.Repositories;
    using NRProject.Services.Mapping;
    using NRProject.Web.ViewModels.Jobs;

    public class JobsController : BaseController
    {

        private readonly IRepository<JobCategory> jobrepo;

        public JobsController(IRepository<JobCategory> jobrepo)
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
