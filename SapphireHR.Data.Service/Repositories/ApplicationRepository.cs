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
            var result = new List<Application>();
            var vacs = await _context.Set<Vacancy>()
                .Where(c => c.CompanyId == id && (c.Status == 1)).ToListAsync();
            vacs.ForEach(async c =>
            {
                var li = await this.GetApplicationsByVacancy(c.Id);
                result.AddRange(li.Where(c=>c.Status < 8).ToList());
            });
            return result;
        }

        public async Task<int> GetApplicationCountByCompany(int id)
        {
            var result = await GetApplicationByCompany(id);
            return result.Count;
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
