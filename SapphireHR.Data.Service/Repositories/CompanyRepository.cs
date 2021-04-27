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
            return await _context.Set<LeaveSetting>().FindAsync(id);
        }

        public async Task UpdateLeaveSetting(LeaveSetting model)
        {
            this._context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<CompanyAccount> ReadCompanyAccount(int id)
        {

            return await _context.Set<CompanyAccount>().FirstOrDefaultAsync(c=>c.CompanyId == id);
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

        public async Task AddCompanyLeavePolicy(CompanyLeavePolicy model)
        {
            this._context.Set<Database.EntityModels.CompanyLeavePolicy>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCompanyLeavePolicy(CompanyLeavePolicy model)
        {
            this._context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<CompanyLeavePolicy> ReadCompanyLeavePolicy(int id)
        {
            return await _context.Set<CompanyLeavePolicy>().FindAsync(id);
        }

        public async Task RemoveCompanyLeavePolicy(int id)
        {
            var entity = await _context.Set<CompanyLeavePolicy>().FindAsync(id);
            if (entity == null)
            {
                await Task.FromException(new Exception("The Id provided doesn't exists"));
            }

            _context.Set<CompanyLeavePolicy>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        
    }
}
