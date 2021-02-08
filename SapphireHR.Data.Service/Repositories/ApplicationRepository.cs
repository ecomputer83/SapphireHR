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
