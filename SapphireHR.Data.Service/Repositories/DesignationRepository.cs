using Microsoft.EntityFrameworkCore;
using SapphireHR.Database;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Data.Service.Repositories
{
    public class DesignationRepository : GenericRepository<Designation, ApplicationDbContext>
    {
        public DesignationRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<DesignationPerformance> GetDesignationPerformance(int id)
        {
            return await _context.Set<DesignationPerformance>()
               .Include(c => c.Designation)
               .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<List<DesignationPerformance>> GetDesignationPerformances()
        {
            return await _context.Set<DesignationPerformance>()
               .Include(c => c.Designation)
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

    }
}
