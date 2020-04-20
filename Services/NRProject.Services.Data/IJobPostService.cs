namespace NRProject.Services.Data
{
    using System.Threading.Tasks;

    using NRProject.Data.Common.Models;

    public interface IJobPostService
    {
        void CreateAsync(string title, string content, JobCategory jobCategory);
    }
}
