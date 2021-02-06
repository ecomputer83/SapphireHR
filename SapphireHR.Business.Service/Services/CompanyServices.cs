using SapphireHR.Business.Abstractions.Models;
using SapphireHR.Business.Abstractions.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Service.Services
{
    public class CompanyServices : ICompanyService
    {
        public Task AddCompany(CompanyModel model)
        {
            throw new NotImplementedException();
        }

        public Task AddLeaveSetting(LeaveSettingModel model)
        {
            throw new NotImplementedException();
        }

        public Task RemoveCompany(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCompany(CompanyModel model, int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateLeaveSetting(LeaveSettingModel model, int Id)
        {
            throw new NotImplementedException();
        }
    }
}
