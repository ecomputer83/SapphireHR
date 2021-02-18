using AutoMapper;
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
        readonly IMapper _mapper;
        public CompanyServices(CompanyRepository companyRepository, OrganizationRepository organizationRepository, FileManager fileManager, IMapper mapper)
        {
            this._companyRepository = companyRepository;
            this._organizationRepository = organizationRepository;
            this._fileManager = fileManager;
            this._mapper = mapper;
        }
        public async Task<int> AddCompany(CompanyModel model)
        {
            var org = await _organizationRepository.Get(model.OrganizationId);
            //var directory = await _fileManager.CreateCompanyDirectory(org.Directory, model.Name.Trim().ToLower().Replace(" ", ""));
            var datamodel = _mapper.Map<Database.EntityModels.CompanyInfo>(model);
            //datamodel.Directory = directory;
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            datamodel = await this._companyRepository.Add(datamodel);
            return datamodel.Id;
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

        public async Task AddLeaveSetting(LeaveSettingModel model)
        {
            var datamodel = _mapper.Map<Database.EntityModels.LeaveSetting>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await this._companyRepository.AddLeaveSetting(datamodel);
        }

        public async Task RemoveCompany(int Id)
        {
            await this._companyRepository.Delete(Id);
        }

        public async Task UpdateCompany(CompanyModel model, int Id)
        {
            var company = await this._companyRepository.Get(Id);
            company.Name = model.Name;
            company.Phone = model.Phone;
            company.Email = model.Email;
            company.ContactPerson = model.ContactPerson;
            company.Address = model.Address;
            company.UpdatedAt = DateTime.Now;
            await this._companyRepository.Update(company);
        }

        public async Task UpdateLeaveSetting(LeaveSettingModel model, int Id)
        {
            var setting = await this._companyRepository.ReadLeaveSettingById(Id);
            setting.CarryOver = model.CarryOver;
            setting.CarryOverMax = model.CarryOverMax;
            setting.Days = model.Days;
            setting.EarnedLeave = model.EarnedLeave;
            await this._companyRepository.UpdateLeaveSetting(setting);
        }

        
    }
}
