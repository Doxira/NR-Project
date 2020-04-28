using NRProject.Data.Common.Models;
using NRProject.Data.Common.Repositories;
using NRProject.Services.Mapping;
using NRProject.Web.ViewModels.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NRProject.Services.Data
{
    public  class CategoryService : ICategoryService
    {
        private readonly IRepository<JobCategory> categoryRepository;

        public CategoryService(IRepository<JobCategory> categoryRepository)
        { 
            this.categoryRepository = categoryRepository;
        }

        public ICollection<IndexJobsCategoryViewModel> GetAll()
        {
            var all = this.categoryRepository.All().To<IndexJobsCategoryViewModel>().ToList();
            return all;
        }
    }
}
