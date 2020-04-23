namespace NRProject.Web.ViewModels.JobPost
{
    using NRProject.Data.Common.Models;
    using NRProject.Services.Mapping;

    public class InputJobPostCategoryViewModel : IMapFrom<JobCategory>
    {
        public int JobCategoryId { get; set; }

        public string Name { get; set; }
    }
}