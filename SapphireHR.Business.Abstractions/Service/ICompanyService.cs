using SapphireHR.Business.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Abstractions.Service
{
    public interface ICompanyService
    {
        Task<int> AddCompany(CompanyModel model);
        Task AddCompanyAccount(CompanyAccountModel model);
        Task<CompanyModel> GetCompany(int Id);
        Task<List<CompanyModel>> GetCompanies(int orgId);
        Task<CompanyAccountModel> GetCompanyAccount(int Id);
        Task UpdateCompany(CompanyModel model, int Id);
        Task UpdateCompanyAccount(CompanyAccountModel model, int Id);
        Task RemoveCompany(int Id);
        Task InactiveCompany(int Id);
        Task AddLeaveSetting(LeaveSettingModel model);
        Task UpdateLeaveSetting(LeaveSettingModel model, int Id);
    }
}
