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
    public class CompanyRepository : GenericRepository<Database.EntityModels.CompanyInfo, ApplicationDbContext>
    {
        public CompanyRepository(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<List<CompanyInfo>> ReadCompaniesById(int id)
        {
            return await _context.Set<CompanyInfo>().Where(c=>c.OrganizationId == id && c.Status != 8).ToListAsync();
        }
        public async Task AddCompanyEmployee(CompanyEmployee model)
        {
            this._context.Set<Database.EntityModels.CompanyEmployee>().Add(model);
            await _context.SaveChangesAsync();
        }
        
        public async Task UpdateCompanyEmployee(CompanyEmployee model)
        {
            this._context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task AddCompanyAccount(CompanyAccount model)
        {
            this._context.Set<Database.EntityModels.CompanyAccount>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCompanyAccount(CompanyAccount model)
        {
            this._context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task AddLeaveSetting(LeaveSetting model)
        {
            this._context.Set<Database.EntityModels.LeaveSetting>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task<LeaveSetting> ReadLeaveSettingById(int id)
        {
            return await _context.Set<LeaveSetting>().AsNoTracking().FirstOrDefaultAsync(a=>a.Id == id);
        }

        public async Task<LeaveSetting> ReadLeaveSettingByTypeId(int id, int companyId)
        {
            return await _context.Set<LeaveSetting>().AsNoTracking().FirstOrDefaultAsync(a => a.TypeId == id && a.CompanyId == companyId);
        }

        public async Task<List<LeaveSetting>> ReadLeaveSettings(int id)
        {
            return await _context.Set<LeaveSetting>().Include(c => c.LeaveType).Include(c=>c.LeavePolicies).Where(c => c.CompanyId == id).ToListAsync();
        }

        public async Task UpdateLeaveSetting(LeaveSetting model)
        {
            this._context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<CompanyAccount> ReadCompanyAccount(int id)
        {

            return await _context.Set<CompanyAccount>().Include(c=>c.CompanyInfo).FirstOrDefaultAsync(c=>c.CompanyId == id);
        }

        public async Task<CompanyAccount> FindCompanyAccount(int id)
        {

            return await _context.Set<CompanyAccount>().AsNoTracking().FirstOrDefaultAsync(c=>c.Id == id);
        }

        public async Task<CompanyEmployee> ReadCompanyEmployee(int id)
        {

            return await _context.Set<CompanyEmployee>().FindAsync(id);
        }

        public async Task RemoveCompanyEmployee(int id)
        {
            var entity = await _context.Set<CompanyEmployee>().FindAsync(id);
            if (entity == null)
            {
                await Task.FromException(new Exception("The Id provided doesn't exists"));
            }

            _context.Set<CompanyEmployee>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<int> AddCompanyLeavePolicy(LeavePolicy model)
        {
            this._context.Set<Database.EntityModels.LeavePolicy>().Add(model);
            await _context.SaveChangesAsync();
            return model.Id;
        }

        public async Task UpdateCompanyLeavePolicy(LeavePolicy model)
        {
            this._context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<LeavePolicy> ReadCompanyLeavePolicy(int id)
        {
            return await _context.Set<LeavePolicy>().AsNoTracking().FirstOrDefaultAsync(c=>c.Id == id);
        }

        public async Task RemoveCompanyLeavePolicy(int id)
        {
            var entity = await _context.Set<LeavePolicy>().FindAsync(id);
            if (entity == null)
            {
                await Task.FromException(new Exception("The Id provided doesn't exists"));
            }

            _context.Set<LeavePolicy>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        
    }
}
