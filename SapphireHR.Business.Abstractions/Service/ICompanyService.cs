using SapphireHR.Business.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Abstractions.Service
{
    public interface ICompanyService
    {
        Task AddCompany(CompanyModel model);
        Task UpdateCompany(CompanyModel model, int Id);
        Task RemoveCompany(int Id);
        Task AddLeaveSetting(LeaveSettingModel model);
        Task UpdateLeaveSetting(LeaveSettingModel model, int Id);
    }
}
