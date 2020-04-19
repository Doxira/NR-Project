using NRProject.Data.Common.Models;
using NRProject.Services.Mapping;
using System;

namespace NRProject.Web.ViewModels.Jobs
{
    public class IndexJobsPostsViewModel : IMapFrom<JobPosts>
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public int JobCategoryId { get; set; }

        public virtual JobCategory JobCategory { get; set; }

        public DateTime CreatedOn { get; set; }

    }
}