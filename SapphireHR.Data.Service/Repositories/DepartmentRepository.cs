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

        public Task<List<Policy>> GetPolicies(int orgId)
        {
            return _context.Set<Policy>().Include(d=>d.DepartmentPolicy).ThenInclude(e=>e.Department).Where(c=>c.OrganizationId == orgId).ToListAsync();
        }

        public Task<Policy> GetPolicy(int Id)
        {
            return _context.Set<Policy>().AsNoTracking().Include(d => d.DepartmentPolicy).FirstOrDefaultAsync(c => c.Id == Id);
        }

        public Task<DepartmentPolicy> GetDepartmentPolicy(int policyId)
        {
            return _context.Set<DepartmentPolicy>().AsNoTracking().FirstOrDefaultAsync(c => c.PolicyId == policyId);
        }

        public async Task<int> AddPolicy(Policy policy)
        {
            var m =_context.Set<Policy>().Add(policy);
            await _context.SaveChangesAsync();
            return m.Entity.Id;
        }

        public async Task<int> UpdatePolicy(Policy policy)
        {
            _context.Set<Policy>().Update(policy);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateDepartmentPolicy(DepartmentPolicy policy)
        {
            _context.Set<DepartmentPolicy>().Update(policy);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> AddDepartmentPolicy(DepartmentPolicy policy)
        {
            _context.Set<DepartmentPolicy>().Add(policy);
            return await _context.SaveChangesAsync();
        }

        public async Task DeletePolicy(int id)
        {
            var data = await _context.Set<Policy>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }

            _context.Set<Policy>().Remove(data);
            await _context.SaveChangesAsync();
        }
    }
}
