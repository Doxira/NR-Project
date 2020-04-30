namespace NRProject.Web.ViewModels.JobOfers
{
    using System.ComponentModel.DataAnnotations;

    using NRProject.Data.Models;
    using NRProject.Services.Mapping;

    public class InputJobOfferViewModel : IMapFrom<JobOffers>
    {
        public int Id { get; set; }

        [Required]
        public int JobPostsId { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        [Required]
        public string Description { get; set; }

        public string UserUsername { get; set; }
    }
}
