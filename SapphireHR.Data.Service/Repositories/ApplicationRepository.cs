using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
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



        public async Task<Application> GetApplicationLogin(string username, string password)
        {
            return await _context.Set<ApplicationLogin>().Include(c=>c.Application)
                .Where(a=>a.UserName.ToLower() == username.ToLower() 
                && a.Password.ToLower() == password.ToLower()).Select(p=>p.Application).FirstOrDefaultAsync();
        }
        
        public async Task AddApplicationLogin(ApplicationLogin model)
        {
            _context.Set<ApplicationLogin>().Add(model);
            await _context.SaveChangesAsync();
        }


        public async Task AddApplication(Application model)
        {
            _context.Set<Application>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateApplication(Application model, int Id)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<Application> GetApplication(int Id)
        {
            return await _context.Set<Application>().FindAsync(Id);
        }

        public async Task<Application> GetApplicationByApplicant(int vacanyId, int applicantId)
        {
            return await _context.Set<Application>().FirstOrDefaultAsync(c=>c.VacancyId == vacanyId && c.ApplicantId == applicantId);
        }

        public async Task<List<Application>> GetApplicationsByVacancy(int Id)
        {
            return await _context.Set<Application>().Where(c=>c.VacancyId == Id).ToListAsync();
        }

        public async Task<List<Application>> GetApplicationByCompany(int id)
        {
            var data = await _context.JsonFromSql(@"Select 
[a].[Id], [a].[ApplicantId], [a].[VacancyId], [a].[StartDate], [a].[NoticePeriod], [a].[ExpectedSalary], [a].[Document], [a].[CoverLetter], [a].[CreatedAt], [a].[CreatedBy], [a].[UpdatedAt], [a].[UpdatedBy], [a].[Code], [a].[Status],
[v].[Id] AS [Vacancy.Id], [v].[JobProfileId] AS [Vacancy.JobProfileId], [v].[DesignationId] AS [Vacancy.DesignationId], [v].[Quantity] AS [Vacancy.Quantity], [v].[Description] AS [Vacancy.Description], [v].[Type] AS [Vacancy.Type],
[v].[Scores] AS [Vacancy.Scores], [v].[CreatedAt] AS [Vacancy.CreatedAt], [v].[CreatedBy] AS [Vacancy.CreatedBy], [v].[UpdatedAt] AS [Vacancy.UpdatedAt], [v].[UpdatedBy] AS [Vacancy.UpdatedBy], [v].[PeriodFrom] AS [Vacancy.PeriodFrom],
[v].[PeriodTo] AS [Vacancy.PeriodTo], [v].[RequestedBy] AS [Vacancy.RequestedBy], [v].[RequestedOn] AS [Vacancy.RequestedOn],[j].[Id] AS [Vacancy.JobProfile.Id], [j].[CompanyId] AS [Vacancy.JobProfile.CompanyId], [j].[RankId] AS [Vacancy.JobProfile.RankId], [j].[DepartmentId] AS [Vacancy.JobProfile.DepartmentId], [j].[Title] AS [Vacancy.JobProfile.Title],
[j].[Experience] AS [Vacancy.JobProfile.Experience], [j].[Description] AS [Vacancy.JobProfile.Description], [j].[SalaryMin] AS [Vacancy.JobProfile.SalaryMin], [j].[SalaryMax] AS [Vacancy.JobProfile.SalaryMax], [j].[AverageSalary] AS [Vacancy.JobProfile.AverageSalary],
[j].[CreatedAt] AS [Vacancy.JobProfile.CreatedAt], [j].[CreatedBy] AS [Vacancy.JobProfile.CreatedBy], [j].[UpdatedAt] AS [Vacancy.JobProfile.UpdatedAt], [j].[UpdatedBy] AS [Vacancy.JobProfile.UpdatedBy],
[p].[Id] AS [Applicant.Id], [p].[CompanyId] AS [Applicant.CompanyId], [p].[FirstName] AS [Applicant.FirstName], [p].[LastName] AS [Applicant.LastName], [p].[Gender] AS [Applicant.Gender], [p].[Phone1] AS [Applicant.Phone1], 
[p].[Phone2] AS [Applicant.Phone2], [p].[Email] AS [Applicant.Email], [p].[Address] AS [Applicant.Address], [p].[Salutation] AS [Applicant.Salutation],
[p].[CreatedAt] AS [Applicant.CreatedAt], [p].[CreatedBy] AS [Applicant.CreatedBy], [p].[UpdatedAt] AS [Applicant.UpdatedAt], [p].[UpdatedBy] AS [Applicant.UpdatedBy],
[s].[Id] AS [ApplicationScore.Id], [s].[ApplicationId] AS [ApplicationScore.ApplicationId],[s].[CreatedAt] AS [ApplicationScore.CreatedAt], [s].[CreatedBy] AS [ApplicationScore.CreatedBy], [s].[UpdatedAt] AS [ApplicationScore.UpdatedAt], [s].[UpdatedBy] AS [ApplicationScore.UpdatedBy],
[s].[Score] AS [ApplicationScore.Score]

from [Applications] AS [a]
LEFT JOIN [Vacancies] AS [v] on [a].[VacancyId] = [v].Id
LEFT JOIN [JobProfiles] AS [j] on [v].[JobProfileId] = [j].Id
LEFT JOIN [Applicants] AS [p] on [a].[ApplicantId] = [p].Id
LEFT OUTER JOIN [ApplicationScores] AS [s] on [a].[Id] = [s].[ApplicationId]
WHERE [v].[CompanyId] = @p0 and [a].[Status] < 8 FOR JSON PATH", id);
            return JsonConvert.DeserializeObject<List<Application>>(data);
        }

        public async Task<int> GetApplicationCountByCompany(int id)
        {
            var result = await GetApplicationByCompany(id);
            return (result == null) ? 0 : result.Count;
        }

        public async Task RemoveApplication(int Id)
        {
            var data = await _context.Set<Application>().FindAsync(Id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }

            _context.Set<Application>().Remove(data);
            await _context.SaveChangesAsync();
        }


        public Task<Application> GetApplicationDetail(int ApplicationId)
        {
            return Task.FromResult(new Application());
        }

        public async Task AddApplicationFaceToView(ApplicationFaceToView model)
        {
            _context.Set<ApplicationFaceToView>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateApplicatioFaceToView(ApplicationFaceToView model, int Id)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        
        public async Task<ApplicationFaceToView> ReadApplicationFaceToView(int Id)
        {
            return await _context.Set<ApplicationFaceToView>().FindAsync(Id);
        }

        public async Task RemoveApplicationFaceToView(int Id)
        {
            var data = await _context.Set<ApplicationFaceToView>().FindAsync(Id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }

            _context.Set<ApplicationFaceToView>().Remove(data);
            await _context.SaveChangesAsync();
        }

        public async Task AddApplicationSkills(ApplicationSkills model)
        {
            _context.Set<ApplicationSkills>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateApplicationSkills(ApplicationSkills model, int Id)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<ApplicationSkills> ReadApplicationSkills(int Id)
        {
            return await _context.Set<ApplicationSkills>().FindAsync(Id);
        }
        
        public async Task RemoveApplicationSkills(int Id)
        {
            var data = await _context.Set<ApplicationSkills>().FindAsync();
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }

            _context.Set<ApplicationSkills>().Remove(data);
            await _context.SaveChangesAsync();
        }

        public async Task AddApplicationInterview(ApplicationInterview model)
        {
            _context.Set<ApplicationInterview>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateApplicationInterview(ApplicationInterview model, int Id)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task<ApplicationInterview> ReadApplicationInterview(int Id)
        {
            return await _context.Set<ApplicationInterview>().FindAsync(Id);
        }
        
        public async Task RemoveApplicationInterview(int Id)
        {
            var data = await _context.Set<ApplicationInterview>().FindAsync(Id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }

            _context.Set<ApplicationInterview>().Remove(data);
            await _context.SaveChangesAsync();
        }
        
        public async Task AddApplicationNegotiation(ApplicationNegotiation model)
        {
            _context.Set<ApplicationNegotiation>().Add(model);
            await _context.SaveChangesAsync();
        }
        
        public async Task UpdateApplicationNegotiation(ApplicationNegotiation model, int Id)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        
        public async Task<ApplicationNegotiation> ReadApplicationNegotiation(int Id)
        {
            return await _context.Set<ApplicationNegotiation>().FindAsync(Id);
        }
        
        public async Task RemoveApplicationNegotiation(int Id)
        {
            var data = await _context.Set<ApplicationNegotiation>().FindAsync(Id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }

            _context.Set<ApplicationNegotiation>().Remove(data);
            await _context.SaveChangesAsync();
        }
        
        public async Task AddApplicationScore(ApplicationScore model)
        {
            _context.Set<ApplicationScore>().Add(model);
            await _context.SaveChangesAsync();
        }
        
        public async Task UpdateApplicationScore(ApplicationScore model, int Id)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        
        public async Task<ApplicationScore> ReadApplicationScore(int Id)
        {
            return await _context.Set<ApplicationScore>().FindAsync(Id);
        }
        
        public async Task RemoveApplicationScore(int Id)
        {
            var data = await _context.Set<ApplicationScore>().FindAsync(Id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }

            _context.Set<ApplicationScore>().Remove(data);
            await _context.SaveChangesAsync();
        }
    }
}
