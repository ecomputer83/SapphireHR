using SapphireHR.Database;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Data.Service.Repositories
{
    public class ApplicantRepository : GenericRepository<Applicant, ApplicationDbContext>
    {
        public ApplicantRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Task AddApplicant(Applicant model)
        {
            return Task.CompletedTask;
        }
        
        public Task UpdateApplicant(Applicant model)
        {
            return Task.CompletedTask;
        }
        
        public Task ReadApplicant(Applicant model)
        {
            return Task.CompletedTask;
        }
        
        public Task RemoveApplicant(Applicant model)
        {
            return Task.CompletedTask;
        }
    }
}
