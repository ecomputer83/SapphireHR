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
