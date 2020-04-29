namespace NRProject.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;

    using NRProject.Data.Common.Models;

   public class JobOffers : BaseDeletableModel<int>
    {
        public int Id { get; set; }

        public int JobPostsId { get; set; }

        public virtual JobPosts JobPosts { get; set; }

        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public string Description { get; set; }


    }
}
