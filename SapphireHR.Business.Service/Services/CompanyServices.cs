using AutoMapper;
using SapphireHR.Business.Abstractions.Models;
using SapphireHR.Business.Abstractions.Service;
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
        readonly IMapper _mapper;
        public CompanyServices(CompanyRepository companyRepository, IMapper mapper)
        {
            this._companyRepository = companyRepository;
            this._mapper = mapper;
        }
        public async Task AddCompany(CompanyModel model)
        {
            var datamodel = _mapper.Map<Database.EntityModels.CompanyInfo>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await this._companyRepository.Add(datamodel);
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
