using SapphireHR.Database;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Data.Service.Repositories
{
    public class OnboardingRepository : GenericRepository<Onboarding, ApplicationDbContext>
    {
        public OnboardingRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Task AddOnboarding(Onboarding model)
        {
            return Task.CompletedTask;
        }

        public Task UpdateOnboarding(Onboarding model)
        {
            return Task.CompletedTask;
        }

        public Task ReadOnboarding(Onboarding model)
        {
            return Task.CompletedTask;
        }

        public Task RemoveOnboarding(Onboarding model)
        {
            return Task.CompletedTask;
        }
    }
}
