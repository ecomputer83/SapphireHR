using Microsoft.EntityFrameworkCore;
using SapphireHR.Database;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Data.Service.Repositories
{
    public class ApplicationRepository : GenericRepository<Application, ApplicationDbContext>
    {
        public ApplicationRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Task<Application> GetApplicationDetail(int ApplicationId)
        {
            return Task.FromResult(new Application());
        }
        public Task AddApplicationFaceToView(ApplicationFaceToView model)
        {
            return Task.CompletedTask;
        }

        public Task UpdateApplicatioFaceToView(ApplicationFaceToView model, int Id)
        {
            return Task.CompletedTask;
        }

        public Task<ApplicationFaceToView> ReadApplicationFaceToView(int Id)
        {
            return Task.FromResult(new ApplicationFaceToView());
        }


        public Task RemoveApplicationFaceToView(int Id)
        {
            return Task.CompletedTask;
        }

        public Task AddApplicationSkills(ApplicationSkills model)
        {
            return Task.CompletedTask;
        }

        public Task UpdateApplicationSkills(ApplicationSkills model, int Id)
        {
            return Task.CompletedTask;
        }

        public Task ReadApplicationSkills(int Id)
        {
            return Task.CompletedTask;
        }
        
        public Task RemoveApplicationSkills(int Id)
        {
            return Task.CompletedTask;
        }

        public Task AddApplicationInterview(ApplicationInterview model)
        {
            return Task.CompletedTask;
        }

        public Task UpdateApplicationInterview(ApplicationInterview model, int Id)
        {
            return Task.CompletedTask;
        }
        public Task ReadApplicationInterview(int Id)
        {
            return Task.CompletedTask;
        }
        
        public Task RemoveApplicationInterview(int Id)
        {
            return Task.CompletedTask;
        }
        
        public Task AddApplicationNegotiation(ApplicationNegotiation model)
        {
            return Task.CompletedTask;
        }
        
        public Task UpdateApplicationNegotiation(ApplicationNegotiation model, int Id)
        {
            return Task.CompletedTask;
        }
        
        public Task ReadApplicationNegotiation(int Id)
        {
            return Task.CompletedTask;
        }
        
        public Task RemoveApplicationNegotiation(int Id)
        {
            return Task.CompletedTask;
        }
        
        public Task AddApplicationScore(ApplicationScore model)
        {
            return Task.CompletedTask;
        }
        
        public Task UpdateApplicationScore(ApplicationScore model, int Id)
        {
            return Task.CompletedTask;
        }
        
        public Task ReadApplicationScore(int Id)
        {
            return Task.CompletedTask;
        }
        
        public Task RemoveApplicationScore(int Id)
        {
            return Task.CompletedTask;
        }
    }
}
