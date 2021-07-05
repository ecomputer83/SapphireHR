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
    public class EmployeePerfomanceAppraisalServices : IEmployeePerfomanceAppraisal
    {
        private readonly IMapper _mapper;
        private readonly EmployeePerfomanceAppraisalRepository _appraisalRepository;

        public EmployeePerfomanceAppraisalServices(IMapper mapper, EmployeePerfomanceAppraisalRepository appraisalRepository)
        {
            _mapper = mapper;
            _appraisalRepository = appraisalRepository;
        }

        public async Task AddEmployeePerfomanceAppraisal(EmployeePerfomanceAppraisalModel model)
        {
            var datamodel = _mapper.Map<EmployeePerfomanceAppraisal>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _appraisalRepository.Add(datamodel);
        }


        public async Task<List<EmployeePerfomanceAppraisalModel>> GetEmployeePerfomanceAppraisal(int Id)
        {
            var data = await _appraisalRepository.GetEmployeePerfomanceAppraisal(Id);
            var res = _mapper.Map<List<EmployeePerfomanceAppraisalModel>>(data);
            return res;
        }

        public async Task<List<EmployeePerfomanceAppraisalModel>> GetAllEmployeePerfomanceAppraisal(int Id)
        {
            var data = await _appraisalRepository.GetAllEmployeePerfomanceAppraisal(Id);
            var res = _mapper.Map<List<EmployeePerfomanceAppraisalModel>>(data);
            return res;
        }

        public async Task RemoveEmployeePerfomanceAppraisal(int id)
        {
            await _appraisalRepository.RemoveEmployeePerfomanceAppraisal(id);
        }


        public async Task UpdateEmployeePerfomanceAppraisal(EmployeePerfomanceAppraisalModel model, int id)
        {
            var _data = await _appraisalRepository.GetEmployeePerfomanceAppraisal(id);
            var data = _mapper.Map<EmployeePerfomanceAppraisal>(model);
            data.Id = _data.Id;
            data.CreatedAt = _data.CreatedAt;
            data.CreatedBy = _data.CreatedBy;
            data.UpdatedAt = DateTime.Now;
            data.UpdatedBy = "SYSTEM";
            await _appraisalRepository.UpdateEmployeePerfomanceAppraisal(data);
        }

    }
}
