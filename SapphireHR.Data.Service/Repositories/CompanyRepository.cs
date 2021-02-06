using Microsoft.EntityFrameworkCore;
using SapphireHR.Database;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Data.Service.Repositories
{
    public class CompanyRepository : GenericRepository<Database.EntityModels.CompanyInfo, ApplicationDbContext>
    {
        public CompanyRepository(ApplicationDbContext context) : base(context)
        {
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

        public async Task AddCompanyInfo(CompanyInfo model)
        {
            this._context.Set<Database.EntityModels.CompanyInfo>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCompanyInfo(CompanyInfo model)
        {
            this._context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<CompanyInfo> ReadCompanyInfo(int id)
        {
            return await _context.Set<CompanyInfo>().FindAsync(id);
        }

        public async Task RemoveCompanyInfo(int id)
        {
            var entity = await _context.Set<CompanyInfo>().FindAsync(id);
            if (entity == null)
            {
                await Task.FromException(new Exception("The Id provided doesn't exists"));
            }

            _context.Set<CompanyInfo>().Remove(entity);
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

        public async Task AddCompanyRank(CompanyRank model)
        {
            this._context.Set<Database.EntityModels.CompanyRank>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCompanyRank(CompanyRank model)
        {
            this._context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<CompanyRank> ReadCompanyRank(int id)
        {
            return await _context.Set<CompanyRank>().FindAsync(id);
        }

        public async Task RemoveCompanyRank(int id)
        {
            var entity = await _context.Set<CompanyRank>().FindAsync(id);
            if (entity == null)
            {
                await Task.FromException(new Exception("The Id provided doesn't exists"));
            }

            _context.Set<CompanyRank>().Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
