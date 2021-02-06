using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SapphireHR.Database;
using SapphireHR.Database.EntityModels;

namespace SapphireHR.Data.Service.Repositories
{
    public class OrganizationRepository : GenericRepository<Database.EntityModels.OrganizationInfo, ApplicationDbContext>
    {
        
        public OrganizationRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Task GetOrgHeader(int orgId)
        {
            var orgHeader = this._context.OrganizationHeaders.FirstOrDefault(c => c.OrganizationId == orgId);
            return Task.FromResult(orgHeader);
        }

        public Task GetOrgHeader(string hostHeader)
        {
            var orgHeader = this._context.OrganizationHeaders.FirstOrDefault(c => c.HostName == hostHeader);
            return Task.FromResult(orgHeader);
        }

        public async Task AddOrgHeader(Database.EntityModels.OrganizationHeader model)
        {
            this._context.Set<Database.EntityModels.OrganizationHeader>().Add(model);
            await _context.SaveChangesAsync();
            
        }

        public async Task UpdateOrgHeader(Database.EntityModels.OrganizationHeader model)
        {
            this._context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            
        }

        public async Task DeleteOrgHeader(int Id)
        {
            var entity = await _context.Set<Database.EntityModels.OrganizationHeader>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            _context.Set<Database.EntityModels.OrganizationHeader>().Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
