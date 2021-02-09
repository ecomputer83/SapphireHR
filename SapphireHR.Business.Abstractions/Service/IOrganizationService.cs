using SapphireHR.Business.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Abstractions.Service
{
    public interface IOrganizationService
    {
        Task AddOrganization(OrganizationModel model);
        Task AddOrganizationHeader(OrganizationHeaderModel model);
        Task UpdateOrganization(OrganizationModel model, int Id);
        Task<OrganizationModel> GetOrganizationByHostHeader(string hostname);
        Task DeleteOrganization(int Id);
        Task AddLeaveType(LeaveTypeModel model);
        Task RemoveLeaveType(int id);
        Task AddRank(RankModel model);
        Task<List<RankModel>> GetRanks(int CompanyId);
        Task UpdateRank(RankModel model, int Id);
        Task RemoveRank(int Id);

    }
}
