using AutoMapper;
using SapphireHR.Business.Abstractions.Models;
using SapphireHR.Data.Service.Repositories;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Service.Services
{
    public class EmployeeServices
    {
        private readonly IMapper _mapper;
        private readonly EmployeeRepository _employeeRepository;

        public EmployeeServices(IMapper mapper, EmployeeRepository employeeRepository)
        {
            _mapper = mapper;
            _employeeRepository = employeeRepository;
        }

        public async Task AddEmployeeBank(EmployeeBankModel model)
        {
            var data = _mapper.Map<EmployeeBank>(model);
            data.CreatedAt = DateTime.Now;
            data.UpdatedAt = DateTime.Now;
            data.CreatedBy = "SYSTEM";
            data.UpdatedBy = "SYSTEM";
            //await _employeeRepository.(data);

        }
    }
}
