namespace NRProject.Web.ViewModels.Jobs
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using NRProject.Data.Common.Models;
    using NRProject.Data.Models;
    using NRProject.Services.Mapping;

    public class PostByIdViewModel : IMapFrom<JobPosts>
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public int JobCategoryId { get; set; }

        public virtual JobCategory JobCategory { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UserUsername { get; set; }

        public virtual ICollection<JobOffers> JobOffers { get; set; }
    }
}
