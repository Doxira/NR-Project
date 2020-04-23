namespace NRProject.Data.Common.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class JobCategory
    {
        public JobCategory()
        {
            this.JobPosts = new HashSet<JobPosts>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<JobPosts> JobPosts { get; set; }

    }
}
