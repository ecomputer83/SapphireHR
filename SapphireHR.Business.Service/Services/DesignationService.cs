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
    public class DesignationService : IDesignationService
    {
        private readonly IMapper _mapper;
        private readonly DesignationRepository _designationRepository;
        private readonly EmployeeRepository _employeeRepository;
        public DesignationService(DesignationRepository designationRepository, EmployeeRepository employeeRepository, IMapper mapper)
        {
            _mapper = mapper;
            _designationRepository = designationRepository;
            _employeeRepository = employeeRepository;
        }
        public async Task AddDesignationPerformance(DesignationPerformanceModel model)
        {
            var datamodel = _mapper.Map<DesignationPerformance>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _designationRepository.AddDesignationPerformance(datamodel);
        }

        public async Task<DesignationModel> GetDesignationByEmployee(int id)
        {
            var employee = await _employeeRepository.Get(id);
            var res = await _designationRepository.Get(employee.DesignationId);
            var datamodel = _mapper.Map<DesignationModel>(res);
            return datamodel;
        }

        public async Task<DesignationPerformanceModel> GetDesignationPerformance(int id)
        {
            var res = await _designationRepository.GetDesignationPerformance(id);
            var datamodel = _mapper.Map<DesignationPerformanceModel>(res);
            return datamodel;
        }

        public async Task<DesignationPerformanceModel> GetDesignationPerformanceByDesignationId(int id)
        {
            var res = await _designationRepository.GetDesignationPerformanceByDesignationId(id);
            var datamodel = _mapper.Map<DesignationPerformanceModel>(res);
            return datamodel;
        }

        public async Task<List<DesignationPerformanceModel>> GetDesignationPerformances()
        {
            var res = await _designationRepository.GetDesignationPerformances();
            var datamodel = _mapper.Map<List<DesignationPerformanceModel>>(res);
            return datamodel;
        }

        public async Task RemoveDesignationPerformance(int id)
        {
            await _designationRepository.RemoveDesignationPerformance(id);
        }

        public async Task UpdateDesignationPerformance(DesignationPerformanceModel model)
        {
            var datamodel = _mapper.Map<DesignationPerformance>(model);
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.UpdatedBy = "SYSTEM";
            await _designationRepository.UpdateDesignationPerformance(datamodel);
        }
    }
}
