namespace NRProject.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using NRProject.Data.Common.Models;
    using NRProject.Web.ViewModels.Jobs;

    public interface IJobPostService
    {
        Task CreateAsync(string title, string content,int jobCategoryId, string userId);

        ICollection<IndexJobsPostsViewModel> GetAllJobPosts();

        T GetById<T>(int id);

        ICollection<IndexJobsPostsViewModel> GetJobPostsByCategory(int jobCategoryId);
    }
}
