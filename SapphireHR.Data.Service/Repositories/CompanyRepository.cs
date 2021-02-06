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

        public Task AddCompanyEmployee(CompanyEmployee model)
        {
            return Task.CompletedTask;
        }
        
        public Task UpdateCompanyEmployee(CompanyEmployee model)
        {
            return Task.CompletedTask;
        }
        
        public Task ReadCompanyEmployee(CompanyEmployee model)
        {
            return Task.CompletedTask;
        }
        
        public Task RemoveCompanyEmployee(CompanyEmployee model)
        {
            return Task.CompletedTask;
        }

        public Task AddCompanyInfo(CompanyInfo model)
        {
            return Task.CompletedTask;
        }

        public Task UpdateCompanyInfo(CompanyInfo model)
        {
            return Task.CompletedTask;
        }

        public Task ReadCompanyInfo(CompanyInfo model)
        {
            return Task.CompletedTask;
        }

        public Task RemoveCompanyInfo(CompanyInfo model)
        {
            return Task.CompletedTask;
        }

        public Task AddCompanyLeavePolicy(CompanyLeavePolicy model)
        {
            return Task.CompletedTask;
        }

        public Task UpdateCompanyLeavePolicy(CompanyLeavePolicy model)
        {
            return Task.CompletedTask;
        }

        public Task ReadCompanyLeavePolicy(CompanyLeavePolicy model)
        {
            return Task.CompletedTask;
        }

        public Task RemoveCompanyLeavePolicy(CompanyLeavePolicy model)
        {
            return Task.CompletedTask;
        }

        public Task AddCompanyRank(CompanyRank model)
        {
            return Task.CompletedTask;
        }

        public Task UpdateCompanyRank(CompanyRank model)
        {
            return Task.CompletedTask;
        }

        public Task ReadCompanyRank(CompanyRank model)
        {
            return Task.CompletedTask;
        }

        public Task RemoveCompanyRank(CompanyRank model)
        {
            return Task.CompletedTask;
        }
    }
}
