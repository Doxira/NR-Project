namespace NRProject.Data.Common.Models
{
    using NRProject.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class JobPosts : BaseDeletableModel<int>
    {
        public JobPosts()
        {
            this.JobOffers = new HashSet<JobOffers>();
        }

        [Required]
        public string Title { get; set; }

        [Required]
        [StringLength(1000, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 20)]
        public string Content { get; set; }

        
        public string UserId { get; set; }

        [Required]
        public virtual ApplicationUser User { get; set; }

        public int JobCategoryId { get; set; }

        [Required]
        public virtual JobCategory JobCategory { get; set; }

        [Required]
        public virtual ICollection<JobOffers> JobOffers { get; set; }
    }
}
