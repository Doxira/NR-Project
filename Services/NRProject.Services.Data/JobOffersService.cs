namespace NRProject.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using NRProject.Data.Common.Repositories;
    using NRProject.Data.Models;
    using NRProject.Web.ViewModels.JobOfers;

    public class JobOffersService : IJobOffersService
    {
        private readonly IDeletableEntityRepository<JobOffers> jobOffersRepo;

        public JobOffersService(IDeletableEntityRepository<JobOffers> jobOffersRepo)
        {
            this.jobOffersRepo = jobOffersRepo;
        }
        public async Task CreateAsync(int jobPostId, string description, string applicationUserId)
        {
            var jobOffer = new JobOffers
            {
                JobPostsId = jobPostId,
                Description = description,
                ApplicationUserId = applicationUserId,
            };
            await this.jobOffersRepo.AddAsync(jobOffer);
            await this.jobOffersRepo.SaveChangesAsync();
        }
    }
}
