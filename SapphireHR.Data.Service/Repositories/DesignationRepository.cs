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
    public class DesignationRepository : GenericRepository<Designation, ApplicationDbContext>
    {
        public DesignationRepository(ApplicationDbContext context) : base(context)
        {
        }
        public Task<Designation> GetNoTrackingDesignation(int id)
        {
            return _context.Designations.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
        }
        public async Task<DesignationPerformance> GetDesignationPerformance(int id)
        {
            return await _context.Set<DesignationPerformance>()
               .Include(c => c.Designation).ThenInclude(d => d.Department)
               .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<DesignationPerformance> GetDesignationPerformanceByDesignationId(int id)
        {
            return await _context.Set<DesignationPerformance>()
               .Include(c => c.Designation).ThenInclude(d => d.Department)
               .FirstOrDefaultAsync(s => s.DesignationId == id);
        }

        public async Task<List<DesignationPerformance>> GetDesignationPerformances()
        {
            return await _context.Set<DesignationPerformance>()
               .Include(c => c.Designation).ThenInclude(d => d.Department)
               .ToListAsync();
        }

        public async Task AddDesignationPerformance(DesignationPerformance model)
        {
            _context.Set<DesignationPerformance>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateDesignationPerformance(DesignationPerformance model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task RemoveDesignationPerformance(int id)
        {
            var data = await _context.Set<DesignationPerformance>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }

            _context.Set<DesignationPerformance>().Remove(data);
            await _context.SaveChangesAsync();
        }


        public Task<Designation> GetDesignation(string name)
        {
            return _context.Set<Designation>().FirstOrDefaultAsync(c => c.Name.ToLower() == name.ToLower());
        }

        public Task<List<Designation>> GetDesignations(int orgId)
        {
            return _context.Set<Designation>().Include(c=>c.Department).Where(c => c.OrganizationId == orgId).ToListAsync();
        }
    }
}
