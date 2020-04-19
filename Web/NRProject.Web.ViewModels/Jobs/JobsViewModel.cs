namespace NRProject.Web.ViewModels.Jobs
{
    using System.Collections;
    using System.Collections.Generic;

    public class JobsViewModel
    {
        public IEnumerable<IndexJobsCategoryViewModel> JobCategories { get; set; }

        public IEnumerable<IndexJobsPostsViewModel> JobPosts { get; set; }
    }
}
