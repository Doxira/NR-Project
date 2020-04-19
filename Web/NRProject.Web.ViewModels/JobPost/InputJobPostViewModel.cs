namespace NRProject.Web.ViewModels.JobPost
{
    using System.ComponentModel.DataAnnotations;

    using NRProject.Data.Common.Models;
    using NRProject.Services.Mapping;

    public class InputJobPostViewModel : IMapFrom<JobPosts>
    {
        [Required]
        [StringLength(40, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 5)]
        public string Title { get; set; }

        [Required]
        [StringLength(1000, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 20)]
        public string Content { get; set; }

        [Required]
        public virtual JobCategory JobCategory { get; set; }
    }
}
