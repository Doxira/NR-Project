using NRProject.Data.Common.Models;
using NRProject.Services.Mapping;
using System.Collections.Generic;

namespace NRProject.Web.ViewModels.Jobs
{
    public class IndexJobsCategoryViewModel : IMapFrom<JobCategory>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //public virtual ICollection<JobPosts> JobPosts { get; set; }
    }
}