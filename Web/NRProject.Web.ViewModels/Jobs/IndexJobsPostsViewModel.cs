using NRProject.Data.Common.Models;
using NRProject.Data.Models;
using NRProject.Services.Mapping;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NRProject.Web.ViewModels.Jobs
{
    public class IndexJobsPostsViewModel : IMapFrom<JobPosts>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public int JobCategoryId { get; set; }

        public virtual JobCategory JobCategory { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public int ApplicationUserId { get; set; }

        public DateTime CreatedOn { get; set; }

        public virtual ICollection<JobOffers> JobOffers { get; set; }

    }
}