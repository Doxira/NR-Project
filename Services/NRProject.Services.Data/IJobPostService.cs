namespace NRProject.Services.Data
{
    using System.Threading.Tasks;

    using NRProject.Data.Common.Models;

    public interface IJobPostService
    {
        Task CreateAsync(string title, string content, string userId);
    }
}
