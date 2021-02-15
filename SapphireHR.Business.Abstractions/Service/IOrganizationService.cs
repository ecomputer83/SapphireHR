using SapphireHR.Business.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Abstractions.Service
{
    public interface IOrganizationService
    {
        Task<int> AddOrganization(OrganizationModel model);
        Task AddOrganizationHeader(OrganizationHeaderModel model);
        Task UpdateOrganization(OrganizationModel model, int Id);
        Task<OrganizationModel> GetOrganizationByHostHeader(string hostname);
        Task DeleteOrganization(int Id);
        Task AddLeaveType(LeaveTypeModel model);
        Task RemoveLeaveType(int id);
        Task<int> AddRank(RankModel model);
        Task AddRankPermission(RankPermissionModel model);
        Task<List<RankModel>> GetRanks(int orgId);
        Task<List<LeaveTypeModel>> GetLeaveTypes(int orgId);
        Task UpdateRank(RankModel model, int Id);
        Task UpdateRankPermission(RankPermissionModel model, int Id);
        Task RemoveRank(int Id);

    }
}
