using NRProject.Web.ViewModels.JobOfers;
using System.Threading.Tasks;

namespace NRProject.Services.Data
{
     public interface IJobOffersService
    {
        Task CreateAsync(int jobPostId,string Description,string ApplicationUserId);
    }
}
