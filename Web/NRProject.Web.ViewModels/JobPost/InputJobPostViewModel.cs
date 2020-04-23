namespace NRProject.Web.ViewModels.JobPost
{
    using System.ComponentModel.DataAnnotations;

    using NRProject.Data.Common.Models;
    using NRProject.Services.Mapping;

    public class InputJobPostViewModel : IMapFrom<JobPosts>
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public virtual int JobCategoryId { get; set; }
    }
}
