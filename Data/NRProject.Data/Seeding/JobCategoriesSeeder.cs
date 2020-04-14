namespace NRProject.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using NRProject.Data.Common.Models;

    public class JobCategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.JobCategories.Any())
            {
                return;
            }

            var jobCategories = new List<string> { "Auto Repair", "House Maintance", "Gardening", "Photography", "Others" };
            foreach (var jobCategory in jobCategories)
            {
                 dbContext.JobCategories.AddAsync(new JobCategory
                 {
                    Name = jobCategory,
                 });
            }
        }
    }
}
