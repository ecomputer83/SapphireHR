using AutoMapper;
using SapphireHR.Business.Abstractions.Models;
using SapphireHR.Business.Abstractions.Service;
using SapphireHR.Data.Service.Repositories;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Service.Services
{
    public class MiscellaneousServices : IMiscellaneousService
    {
        private readonly IMapper _mapper;
        private readonly ApplicantRepository _applicantRepository;
        private readonly DepartmentRepository _departmentRepository;
        private readonly DesignationRepository _designationRepository;

        public MiscellaneousServices(IMapper mapper, ApplicantRepository applicantRepository, 
                                    DepartmentRepository departmentRepository, DesignationRepository designationRepository)
        {
            _mapper = mapper;
            _applicantRepository = applicantRepository;
            _departmentRepository = departmentRepository;
            _designationRepository = designationRepository;
        }

        public async Task AddApplicant(ApplicantModel model)
        {
            var data = _mapper.Map<Applicant>(model);
            data.CreatedAt = DateTime.Now;
            data.UpdatedAt = DateTime.Now;
            data.CreatedBy = "SYSTEM";
            data.UpdatedBy = "SYSTEM";
            await _applicantRepository.Add(data);
        }

        public async Task<int> AddDepartment(DepartmentModel model)
        {
            var data = _mapper.Map<Department>(model);
            data.CreatedAt = DateTime.Now;
            data.UpdatedAt = DateTime.Now;
            data.CreatedBy = "SYSTEM";
            data.UpdatedBy = "SYSTEM";
            data = await _departmentRepository.Add(data);
            return data.Id;
        }

        public async Task<int> AddDesignation(DesignationModel model)
        {
            var data = _mapper.Map<Designation>(model);
            data.CreatedAt = DateTime.Now;
            data.UpdatedAt = DateTime.Now;
            data.CreatedBy = "SYSTEM";
            data.UpdatedBy = "SYSTEM";
            data = await _designationRepository.Add(data);
            return data.Id;
        }

        public async Task<ApplicantModel> GetApplicant(int id)
        {
            var data = await _applicantRepository.Get(id);
            return _mapper.Map<ApplicantModel>(data);
        }

        public async Task<DepartmentModel> GetDepartment(int id)
        {
            var data = await _departmentRepository.Get(id);
            return _mapper.Map<DepartmentModel>(data);
        }

        public async Task<DesignationModel> GetDesignation(int id)
        {
            var data = await _designationRepository.Get(id);
            return _mapper.Map<DesignationModel>(data);
        }

        public async Task RemoveApplicant(int id)
        {
            await _applicantRepository.Delete(id);
        }

        public async Task RemoveDepartment(int id)
        {
            await _departmentRepository.Delete(id);
        }

        public async Task RemoveDesignation(int id)
        {
            await _designationRepository.Delete(id);
        }

        public async Task UpdateApplicant(ApplicantModel model, int id)
        {
            var data = _mapper.Map<Applicant>(model);
            data.Address = model.Address;
            data.Email = model.Email;
            data.FirstName = model.FirstName;
            data.Gender = model.Gender;
            data.LastName = model.LastName;
            data.Phone1 = model.Phone1;
            data.Phone2 = model.Phone2;
            await _applicantRepository.Update(data);
        }

        public async Task UpdateDepartment(DepartmentModel model, int id)
        {
            var data = _mapper.Map<Department>(model);
            data.Name = model.Name;
            await _departmentRepository.Update(data);
        }

        public async Task UpdateDesignation(DesignationModel model, int id)
        {
            var data = _mapper.Map<Designation>(model);
            data.Name = model.Name;
            await _designationRepository.Update(data);
        }
    }
}
