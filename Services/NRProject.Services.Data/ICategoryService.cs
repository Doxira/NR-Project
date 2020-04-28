using NRProject.Web.ViewModels.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NRProject.Services.Data
{
    public interface ICategoryService
    {
        ICollection<IndexJobsCategoryViewModel> GetAll();

    }
}
