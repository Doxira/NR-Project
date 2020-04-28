﻿namespace NRProject.Web.Controllers
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
        //private readonly IRepository<JobCategory> jobrepo;
        private readonly ICategoryService categoryService;
        public JobsController(/*IRepository<JobCategory> jobrepo,*/IJobPostService jobPost, ICategoryService categoryService)
        {
            //this.jobrepo = jobrepo;
            this.jobPost = jobPost;
            this.categoryService = categoryService;
        } 

        public IActionResult Index()
        {
            var viewModel = new JobsViewModel();
            //var jobCategories = this.jobrepo.All().To<IndexJobsCategoryViewModel>()
            //    .ToList();
            var jobCategories = categoryService.GetAll();
            viewModel.JobCategories = jobCategories;
            var settings = this.jobPost.GetAllJobPosts();
            viewModel.JobPosts = settings;
            return this.View(viewModel);
        }

        public IActionResult PostById(int id)
        {
            var postViewModelById = this.jobPost.GetById<PostByIdViewModel>(id);
            return this.View("PostById",postViewModelById);
        }

        public IActionResult PostByCategory(int jobCategoryId)
        {
            var jobPostByCategory = this.jobPost.GetJobPostsByCategory(jobCategoryId);
            return this.View();
        }
    }
}
