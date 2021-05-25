using AutoMapper;
using Microsoft.Extensions.Configuration;
using SapphireHR.Business.Abstractions.Models;
using SapphireHR.Business.Abstractions.Service;
using SapphireHR.Business.DocumentManager.Documents;
using SapphireHR.Data.Abstractions.Models;
using SapphireHR.Data.Service.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Service.Services
{
    public class CompanyServices : ICompanyService
    {
        CompanyRepository _companyRepository;
        OrganizationRepository _organizationRepository;
        FileManager _fileManager;
        IConfiguration _configuration;
        readonly IMapper _mapper;
        public CompanyServices(CompanyRepository companyRepository, OrganizationRepository organizationRepository, FileManager fileManager, IMapper mapper, IConfiguration configuration)
        {
            this._companyRepository = companyRepository;
            this._organizationRepository = organizationRepository;
            this._fileManager = fileManager;
            this._mapper = mapper;
            this._configuration = configuration;
        }
        public async Task<int> AddCompany(CompanyModel model)
        {
            var org = await _organizationRepository.Get(model.OrganizationId);
            var storeToBlob = bool.Parse(_configuration.GetSection("FileSystem")["StoreToBlob"]);
            string directory = null;
            if (storeToBlob)
            {
                directory = await _fileManager.CreateCompanyDirectory(org.Directory, model.Name.Trim().ToLower().Replace(" ", ""));
            }
            var datamodel = _mapper.Map<Database.EntityModels.CompanyInfo>(model);
            if (storeToBlob)
            {
                datamodel.Directory = directory;
            }
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            datamodel = await this._companyRepository.Add(datamodel);
            return datamodel.Id;
        }

        public async Task AddCompanyAccount(CompanyAccountModel model)
        {
            
            var datamodel = _mapper.Map<Database.EntityModels.CompanyAccount>(model);
            //datamodel.Directory = directory;
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await this._companyRepository.AddCompanyAccount(datamodel);
        }

        public async Task<List<CompanyModel>> GetCompanies(int orgId)
        {
            var Orgs = await _companyRepository.ReadCompaniesById(orgId);
            return _mapper.Map<List<CompanyModel>>(Orgs);
        }

        public async Task<CompanyModel> GetCompany(int Id)
        {
            var Orgs = await _companyRepository.Get(Id);
            return _mapper.Map<CompanyModel>(Orgs);
        }

        public async Task<CompanyAccountModel> GetCompanyAccount(int Id)
        {
            var Orgs = await _companyRepository.ReadCompanyAccount(Id);
            return _mapper.Map<CompanyAccountModel>(Orgs);
        }

        public async Task<List<LeaveSettingModel>> GetLeaveSetting(int Id)
        {
            var Orgs = await _companyRepository.ReadLeaveSettings(Id);
            return _mapper.Map<List<LeaveSettingModel>>(Orgs);
        }

        public async Task<LeaveSettingModel> GetLeaveSettingByType(int Id, int CompanyId)
        {
            var Orgs = await _companyRepository.ReadLeaveSettingByTypeId(Id, CompanyId);
            return _mapper.Map<LeaveSettingModel>(Orgs);
        }

        public async Task AddLeaveSetting(LeaveSettingModel model)
        {
            var setting = await this._companyRepository.ReadLeaveSettingByTypeId(model.TypeId, model.CompanyId);
            if (setting == null)
            {
                var datamodel = _mapper.Map<Database.EntityModels.LeaveSetting>(model);
                datamodel.CreatedAt = DateTime.Now;
                datamodel.UpdatedAt = DateTime.Now;
                datamodel.CreatedBy = "SYSTEM";
                datamodel.UpdatedBy = "SYSTEM";
                await this._companyRepository.AddLeaveSetting(datamodel);
            }
        }

        public async Task<int> AddLeavePolicy(LeavePolicyModel model)
        {
            var datamodel = _mapper.Map<Database.EntityModels.LeavePolicy>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            return await this._companyRepository.AddCompanyLeavePolicy(datamodel);
        }

        public async Task UpdateLeavePolicy(LeavePolicyModel model, int Id)
        {
            var datamodel = await this._companyRepository.ReadCompanyLeavePolicy(Id);
            datamodel.Days = model.Days;
            datamodel.PolicyName = model.PolicyName;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.UpdatedBy = "SYSTEM";
            await this._companyRepository.UpdateCompanyLeavePolicy(datamodel);
        }
        public async Task RemoveLeavePolicy(int Id)
        {
            await this._companyRepository.RemoveCompanyLeavePolicy(Id);
        }
        public async Task RemoveCompany(int Id)
        {
            await this._companyRepository.Delete(Id);
        }

        public async Task UpdateCompany(CompanyModel model, int Id)
        {
            var company = await this._companyRepository.Get(Id);
            company.Name = model.Name;
            company.Abbrv = model.Abbrv;
            company.Phone = model.Phone;
            company.Email = model.Email;
            company.ContactPerson = model.ContactPerson;
            company.Address = model.Address;
            company.UpdatedAt = DateTime.Now;
            await this._companyRepository.Update(company);
        }

        public async Task UpdateCompanyAccount(CompanyAccountModel model, int Id)
        {
            var company = await this._companyRepository.FindCompanyAccount(Id);
            company.BankAccountForSalary = model.BankAccountForSalary;
            company.BankCodeForSalary = model.BankCodeForSalary;
            company.BankAccountForPension = model.BankAccountForPension;
            company.BankCodeForPension = model.BankCodeForPension;
            company.BankAccountForTax = model.BankAccountForTax;
            company.BankCodeForTax = model.BankCodeForTax;
            company.Currency = model.Currency;
            company.EmployerCodeForPension = model.EmployerCodeForPension;
            company.RemitaUserAccount = model.RemitaUserAccount;
            company.RemitaSecret = model.RemitaSecret;
            company.SalaryPayDay = model.SalaryPayDay;
            await this._companyRepository.UpdateCompanyAccount(company);
        }

        public async Task InactiveCompany(int Id)
        {
            var company = await this._companyRepository.Get(Id);
            company.Status = 8;
            await this._companyRepository.Update(company);
        }

        public async Task UpdateLeaveSetting(LeaveSettingModel model, int Id)
        {
            var setting = await this._companyRepository.ReadLeaveSettingById(Id);
            setting.CarryOver = model.CarryOver;
            setting.CarryOverMax = model.CarryOverMax;
            setting.Days = model.Days;
            setting.EarnedLeave = model.EarnedLeave;
            setting.Status = model.Status;
            await this._companyRepository.UpdateLeaveSetting(setting);
        }

        
    }
}
