namespace NRProject.Data.Common.Models
{
    using NRProject.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class JobPosts : BaseDeletableModel<int>
    {
        public JobPosts()
        {
            this.JobOffers = new HashSet<JobOffers>();
        }
        public string Title { get; set; }

        public string Content { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int JobCategoryId { get; set; }

        public virtual JobCategory JobCategory { get; set; }

        public virtual ICollection<JobOffers> JobOffers { get; set; }
    }
}
