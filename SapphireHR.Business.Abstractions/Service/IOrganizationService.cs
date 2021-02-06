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

        Task DeleteOrganization(int Id);
        Task AddLeaveType(LeaveTypeModel model);
        Task RemoveLeaveType(int id);

    }
}
