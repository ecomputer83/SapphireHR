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

        public async Task<OrganizationInfo> GetOrganizationByHostHeader(string hostHeader)
        {
            var header = await _context.OrganizationHeaders.Include("Organization").FirstOrDefaultAsync(c => c.HostName == hostHeader);
            return header?.Organization;
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
            var entity = await _context.Set<Database.EntityModels.OrganizationHeader>().FindAsync(Id);
            if (entity == null)
            {
                await Task.FromException(new Exception("The Id provided doesn't exists"));
            }

            _context.Set<Database.EntityModels.OrganizationHeader>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<int> AddRank(Rank model)
        {
            this._context.Set<Database.EntityModels.Rank>().Add(model);
            await _context.SaveChangesAsync();
            return model.Id;
        }

        public async Task UpdateRank(Rank model)
        {
            this._context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<List<Rank>> ReadRanks(int OrgId)
        {
            return await _context.Set<Rank>().Where(c => c.OrganizationId == OrgId).ToListAsync();
        }

        public async Task<Rank> ReadRank(int Id)
        {
            return await _context.Set<Rank>().FindAsync(Id);
        }

        public async Task RemoveRank(int id)
        {
            var entity = await _context.Set<Rank>().FindAsync(id);
            if (entity == null)
            {
                await Task.FromException(new Exception("The Id provided doesn't exists"));
            }

            _context.Set<Rank>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task AddLeaveType(LeaveType model)
        {
            this._context.Set<Database.EntityModels.LeaveType>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveLeaveType(int id)
        {
            var entity = await _context.Set<LeaveType>().FindAsync(id);
            if (entity == null)
            {
                await Task.FromException(new Exception("The Id provided doesn't exists"));
            }

            _context.Set<LeaveType>().Remove(entity);
            await _context.SaveChangesAsync();
        }
        public async Task<List<LeaveType>> ReadLeaveTypes(int orgId)
        {
            return await _context.Set<LeaveType>().Where(c => c.OrganizationId == orgId).ToListAsync();
        }

        public async Task<LeaveType> ReadLeaveType(int Id)
        {
            return await _context.Set<LeaveType>().FindAsync(Id);
        }

        public async Task AddRankPermission(RankPermission model)
        {
            this._context.Set<Database.EntityModels.RankPermission>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRankPermission(RankPermission model)
        {
            this._context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task RemoveRankPermission(int id)
        {
            var entity = await _context.Set<RankPermission>().FindAsync(id);
            if (entity == null)
            {
                await Task.FromException(new Exception("The Id provided doesn't exists"));
            }

            _context.Set<RankPermission>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<RankPermission> ReadRankPermission(int Id)
        {
            return await _context.Set<RankPermission>().FindAsync(Id);
        }
    }
}
