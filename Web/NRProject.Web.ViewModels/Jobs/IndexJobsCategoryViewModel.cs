using NRProject.Data.Common.Models;
using NRProject.Services.Mapping;

namespace NRProject.Web.ViewModels.Jobs
{
    public class IndexJobsCategoryViewModel : IMapFrom<JobCategory>
    {
        public string Name { get; set; }
    }
}