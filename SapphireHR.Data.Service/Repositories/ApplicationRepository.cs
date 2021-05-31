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
            var app = await _context.Set<Application>().Include(c=>c.Applicant).Include(c=>c.ApplicationFaceToView)
                .Include(c => c.ApplicationInterview).Include(c => c.ApplicationNegotiation)
                .Include(c => c.ApplicationScore).AsNoTracking().FirstOrDefaultAsync(a => a.Id == Id);

            app.Vacancy = await _context.Set<Vacancy>().Include(c=>c.Vacancysettings).Include(c=>c.Designation).Include(v=>v.JobProfile)
                .ThenInclude(j=>j.Department).FirstOrDefaultAsync(v => v.Id == app.VacancyId);

            return app;
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
            var data = await _context.JsonFromSql(@"Declare @result NVARCHAR(max)
SET @result =(Select 
[a].[Id], [a].[ApplicantId], [a].[VacancyId],[a].[ExpectedSalary], [a].[CreatedAt],[a].[Status],
[v].[Id] AS [Vacancy.Id], [v].[JobProfileId] AS [Vacancy.JobProfileId], [v].[DesignationId] AS [Vacancy.DesignationId], [v].[PeriodFrom] AS [Vacancy.PeriodFrom],
[v].[PeriodTo] AS [Vacancy.PeriodTo],[j].[Id] AS [Vacancy.JobProfile.Id], [j].[CompanyId] AS [Vacancy.JobProfile.CompanyId], [j].[RankId] AS [Vacancy.JobProfile.RankId], [j].[DepartmentId] AS [Vacancy.JobProfile.DepartmentId], [j].[Title] AS [Vacancy.JobProfile.Title],
[p].[Id] AS [Applicant.Id], [p].[CompanyId] AS [Applicant.CompanyId], [p].[FirstName] AS [Applicant.FirstName], [p].[LastName] AS [Applicant.LastName],
[s].[Id] AS [ApplicationScore.Id], [s].[ApplicationId] AS [ApplicationScore.ApplicationId],[s].[Score] AS [ApplicationScore.Score]

from [Applications] AS [a]
LEFT JOIN [Vacancies] AS [v] on [a].[VacancyId] = [v].Id
LEFT JOIN [JobProfiles] AS [j] on [v].[JobProfileId] = [j].Id
LEFT JOIN [Applicants] AS [p] on [a].[ApplicantId] = [p].Id
LEFT OUTER JOIN [ApplicationScores] AS [s] on [a].[Id] = [s].[ApplicationId]
WHERE [v].[CompanyId] = 1 and [a].[Status] < 8 FOR JSON PATH)
SELECT @result", id);
            return JsonConvert.DeserializeObject<List<Application>>(data);
        }

        public async Task<List<Application>> GetAcceptedApplicationByCompany(int id)
        {
            var data = await _context.JsonFromSql(@"Declare @result NVARCHAR(max)
SET @result =(Select 
[a].[Id], [a].[ApplicantId], [a].[VacancyId],[a].[ExpectedSalary], [a].[CreatedAt],[a].[Status],
[v].[Id] AS [Vacancy.Id], [v].[JobProfileId] AS [Vacancy.JobProfileId], [v].[DesignationId] AS [Vacancy.DesignationId], [j].[Id] AS [Vacancy.Designation.Id], [j].[DepartmentId] AS [Vacancy.Designation.DepartmentId], [j].[OrganizationId] AS [Vacancy.Designation.OrganizationId], [j].[Name] AS [Vacancy.Designation.Name],
[p].[Id] AS [Applicant.Id], [p].[CompanyId] AS [Applicant.CompanyId], [p].[FirstName] AS [Applicant.FirstName], [p].[LastName] AS [Applicant.LastName],
[ps].[Id] AS [ApplicationInterview.Id], [ps].[ApplicationId] AS [ApplicationInterview.ApplicationId], [ps].[StartDate] AS [ApplicationInterview.StartDate], [ps].[ExpectedSalary] AS [ApplicationInterview.ExpectedSalary]

from [Applications] AS [a]
LEFT JOIN [Vacancies] AS [v] on [a].[VacancyId] = [v].Id
LEFT JOIN [Designations] AS [j] on [v].[DesignationId] = [j].Id
LEFT JOIN [Applicants] AS [p] on [a].[ApplicantId] = [p].Id
LEFT OUTER JOIN [ApplicationInterviews] AS [ps] on [a].[Id] = [ps].[ApplicationId]
WHERE [v].[CompanyId] = 1 and [a].[Status] = 1 FOR JSON PATH)
Select @result", id);
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
