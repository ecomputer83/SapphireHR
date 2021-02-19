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
    public class DepartmentRepository : GenericRepository<Department, ApplicationDbContext>
    {
        public DepartmentRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Task<Department> GetDepartment(string name)
        {
            return _context.Set<Department>().FirstOrDefaultAsync(c => c.Name.ToLower() == name.ToLower());
        }

        public Task<Department> GetNoTrackingDepartment(int id)
        {
            return _context.Departments.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
        }

        public Task<List<Department>> GetDepartments(int orgId)
        {
            return _context.Set<Department>().Where(c => c.OrganizationId == orgId).ToListAsync();
        }
    }
}
