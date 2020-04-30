namespace NRProject.Web.ViewModels.JobPost
{
    using System.ComponentModel.DataAnnotations;

    using NRProject.Data.Common.Models;
    using NRProject.Services.Mapping;

    public class InputJobPostViewModel : IMapFrom<JobPosts>
    {
        [Required]
        [MaxLength(30)]
        public string Title { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Content { get; set; }
        [Required]
        public virtual int JobCategoryId { get; set; }
    }
}
