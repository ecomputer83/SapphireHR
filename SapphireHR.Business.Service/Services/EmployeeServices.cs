using AutoMapper;
using SapphireHR.Business.Abstractions.Models;
using SapphireHR.Business.Abstractions.Service;
using SapphireHR.Data.Service.Repositories;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using SapphireHR.Business.Service;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace SapphireHR.Business.Service.Services
{
    public class EmployeeServices : IEmployeeService
    {
        private readonly IMapper _mapper;
        private readonly EmployeeRepository _employeeRepository;
        private readonly CompanyRepository _companyRepository;

        public EmployeeServices(IMapper mapper, EmployeeRepository employeeRepository, CompanyRepository companyRepository)
        {
            _mapper = mapper;
            _employeeRepository = employeeRepository;
            _companyRepository = companyRepository;
        }
        public async Task AddOnboarding(OnboardingModel model)
        {
            var datamodel = _mapper.Map<Onboarding>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _employeeRepository.AddOnboarding(datamodel);
        }
        public async Task AddCompanyEmployee(CompanyEmployeeModel model)
        {
            var datamodel = _mapper.Map<CompanyEmployee>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _employeeRepository.AddCompanyEmployee(datamodel);
        }

        public async Task AddEmployeeSalary(EmployeeSalaryModel model)
        {
            var company = _employeeRepository.GetCompanyEmployee(model.EmployeeId);
            var datamodel = _mapper.Map<EmployeeSalary>(model);
            datamodel.SalaryDate = DateTime.Now;
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            datamodel.Reference = DateTime.Now.ToString("yyyyMMddhhmmss") + company.Id + model.EmployeeId;
            await _employeeRepository.AddEmployeeSalary(datamodel);
        }

        public async Task AddEmployeeResignation(EmployeeResignationModel model)
        {
            var datamodel = _mapper.Map<EmployeeResignation>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _employeeRepository.AddEmployeeResignation(datamodel);
        }

        public async Task AddExitInterview(ExitInterviewModel model)
        {
            var datamodel = _mapper.Map<ExitInterview>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _employeeRepository.AddExitInterface(datamodel);
        }

        public async Task AddEmployeeTravel(EmployeeTravelModel model)
        {
            var datamodel = _mapper.Map<EmployeeTravel>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _employeeRepository.AddEmployeeTravel(datamodel);
        }

        public async Task AddEmployeeTermination(EmployeeTerminationModel model)
        {
            //if Employee has been terminated before
            var datamodel = _mapper.Map<EmployeeTermination>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _employeeRepository.AddEmployeeTermination(datamodel);
        }
                        
        public async Task<EmployeeModel> AddEmployee(EmployeeModel model)
        {
            var Company = await _companyRepository.Get(model.CompanyId);
            var datamodel = _mapper.Map<Employee>(model);
            datamodel.OrganizationId = Company.OrganizationId;
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            datamodel = await _employeeRepository.Add(datamodel);

            var companyemployee = new CompanyEmployee
            {
                EmployeeId = datamodel.Id,
                CompanyId = model.CompanyId,
                RankId = model.RankId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                CreatedBy = "SYSTEM",
                UpdatedBy = "SYSTEM"
            };

            await _employeeRepository.AddCompanyEmployee(companyemployee);

            return _mapper.Map<EmployeeModel>(datamodel);
        }

        public async Task<EmployeeModel> AddPhoto(IFormFile file, int id)
        {
            EmployeeModel model = null;
            var employee = await _employeeRepository.GetNoTrackingEmployee(id);
            if(file.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await file.CopyToAsync(memoryStream);
                    if(memoryStream.Length > 0)
                    {
                        employee.PassportPhoto = memoryStream.ToArray();
                    }

                    var result = await _employeeRepository.Update(employee);
                    model = _mapper.Map<EmployeeModel>(result);
                }
            }
            return model;
        }
        public async Task AddEmployeeBank(EmployeeBankModel model)
        {
            var datamodel = _mapper.Map<EmployeeBank>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _employeeRepository.AddEmployeeBank(datamodel);
        }

        public async Task AddEmployeeEducation(EmployeeEducationModel model)
        {
            var datamodel = _mapper.Map<EmployeeEducation>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _employeeRepository.AddEmployeeEducation(datamodel);
        }

        public async Task AddEmployeeEmergency(EmployeeEmergencyModel model)
        {
            var datamodel = _mapper.Map<EmployeeEmergency>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _employeeRepository.AddEmployeeEmergency(datamodel);
        }

        public async Task AddEmployeeExp(EmployeeExperienceModel model)
        {
            var datamodel = _mapper.Map<EmployeeExperience>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _employeeRepository.AddEmployeeExp(datamodel);
        }

        public async Task AddEmployeeFamily(EmployeeFamilyModel model)
        {
            var datamodel = _mapper.Map<EmployeeFamily>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _employeeRepository.AddEmployeeFamily(datamodel);
        }

        public async Task AddEmployeeLeave(EmployeeLeaveModel model)
        {
            var days = (model.ToDate - model.FromDate).TotalDays;
            var datamodel = _mapper.Map<EmployeeLeave>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            datamodel.Days = Convert.ToInt32(days);
            await _employeeRepository.AddEmployeeLeave(datamodel);
        }

        public async Task AddEmployeeLeavePolicy(List<int> EmployeeIds, int PolicyId)
        {
            foreach (var id in EmployeeIds)
            {
                var datamodel = new CompanyLeavePolicy { PolicyId = PolicyId, EmployeeId = id };
                datamodel.CreatedAt = DateTime.Now;
                datamodel.UpdatedAt = DateTime.Now;
                datamodel.CreatedBy = "SYSTEM";
                datamodel.UpdatedBy = "SYSTEM";
                await _employeeRepository.AddEmployeeLeavePolicy(datamodel);
            }
        }

        public async Task AddEmployeePension(EmployeePensionModel model)
        {
            var datamodel = _mapper.Map<EmployeePension>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _employeeRepository.AddEmployeePension(datamodel);
        }

        public async Task AddEmployeeStatutory(EmployeeStatutoryModel model)
        {
            var datamodel = _mapper.Map<EmployeeStatutory>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _employeeRepository.AddEmployeeStatutory(datamodel);
        }

        public async Task AddEmployeeTax(EmployeeTaxModel model)
        {
            var datamodel = _mapper.Map<EmployeeTax>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _employeeRepository.AddEmployeeTax(datamodel);
        }

        public async Task AddEmployeeTimetable(EmployeeTimetableModel model)
        {
            var datamodel = _mapper.Map<EmployeeTimetable>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _employeeRepository.AddEmployeeTimetable(datamodel);
        }

        public async Task AddEmployeeTransfer(EmployeeTransferModel model)
        {
            var datamodel = _mapper.Map<EmployeeTransfer>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _employeeRepository.AddEmployeeTransfer(datamodel);
        }

        public async Task AddDisciplinaryMeasures(DisciplinaryMeasuresModel model)
        {
            var datamodel = _mapper.Map<DisciplinaryMeasures>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _employeeRepository.AddDisciplinaryMeasures(datamodel);
        }

        public async Task AddQuery(QueryModel model)
        {
            var datamodel = _mapper.Map<Query>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _employeeRepository.AddQuery(datamodel);
        }

        public async Task<CompanyEmployeeModel> GetCompanyEmployeeByUserId(string UserId)
        {
            var data = await _employeeRepository.GetCompanyEmployeeByUserId(UserId);
            return _mapper.Map<CompanyEmployeeModel>(data);
        }

        public async Task<CompanyEmployeeModel> GetCompanyEmployee(int EmployeeId)
        {
            var data = await _employeeRepository.GetCompanyEmployee(EmployeeId);
            return _mapper.Map<CompanyEmployeeModel>(data);
        }

        public async Task<CompanyLeavePolicyModel> GetEmployeeLeavePolicy(int EmployeeId, int TypeId)
        {
            var data = await _employeeRepository.GetEmployeePolicy(EmployeeId, TypeId);
            return _mapper.Map<CompanyLeavePolicyModel>(data);
        }

        public async Task<EmployeeBankModel> GetEmployeeBank(int id)
        {
            var bank = await _employeeRepository.GetEmployeeBank(id);
            var res = _mapper.Map<EmployeeBankModel>(bank);
            return res;
        }

        public async Task<List<EmployeeBankModel>> GetEmployeeBanks(int id)
        {
            var banks = await _employeeRepository.GetEmployeeBanks(id);
            var res = _mapper.Map<List<EmployeeBankModel>>(banks);
            return res;
        }

        public async Task<List<EmployeePensionModel>> GetEmployeePensions(int id)
        {
            var banks = await _employeeRepository.GetEmployeePensions(id);
            var res = _mapper.Map<List<EmployeePensionModel>>(banks);
            return res;
        }

        public async Task<List<EmployeeTaxModel>> GetEmployeeTaxes(int id)
        {
            var banks = await _employeeRepository.GetEmployeeTaxes(id);
            var res = _mapper.Map<List<EmployeeTaxModel>>(banks);
            return res;
        }

        public async Task<List<EmployeeSalaryModel>> GetAllEmployeeSalaries(int id)
        {
            var start = DateTime.Now.GetFirstDayOfMonth();
            var end = DateTime.Now.GetLastDayOfMonth();
            var data = await _employeeRepository.GetEmployeeSalaries(id, start, end);
            var res =  _mapper.Map<List<EmployeeSalaryModel>>(data);
            return res;
        }

        public async Task<List<EmployeeSalaryModel>> GetEmployeePaidSalaries(int id)
        {
            var start = DateTime.Now.GetFirstDayOfMonth().AddMonths(-1);
            var end = DateTime.Now.GetLastDayOfMonth().AddMonths(-1);
            var data = await _employeeRepository.GetEmployeePaidSalaries(id, start, end);
            var res = _mapper.Map<List<EmployeeSalaryModel>>(data);
            return res;
        }

        public async Task<List<EmployeeSalaryModel>> GetEmployeeSalariesByMonth(int id, string Period)
        {
            var sp = Period.Split('/');
            var dateofMonth = new DateTime(int.Parse(sp[1]), int.Parse(sp[0]), 15);
            var start = dateofMonth.GetFirstDayOfMonth();
            var end = dateofMonth.GetLastDayOfMonth().AddHours(23).AddMinutes(59);
            var data = await _employeeRepository.GetEmployeeSalaries(id, start, end);
            var res = _mapper.Map<List<EmployeeSalaryModel>>(data);
            return res;
        }

        public async Task<EmployeeSalaryModel> GetEmployeeSalary(int id)
        {
            var data = await _employeeRepository.GetEmployeeSalary(id);
            var res = _mapper.Map<EmployeeSalaryModel>(data);
            return res;
        }

        public async Task<List<EmployeeSalaryModel>> GetEmployeePayslip(int id)
        {
            var data = await _employeeRepository.GetEmployeePaidSalary(id);
            var res = _mapper.Map<List<EmployeeSalaryModel>>(data);
            return res;
        }

        public async Task<List<EmployeeResignationModel>> GetEmployeeResignations(int id)
        {
            var bank = await _employeeRepository.GetEmployeeResignations(id);
            var res = _mapper.Map<List<EmployeeResignationModel>>(bank);
            return res;
        }

        public async Task<List<CompanyLeavePolicyModel>> GetCompanyLeavePolicies(int id)
        {
            var bank = await _employeeRepository.ReadCompanyLeavePolicies(id);
            var res = _mapper.Map<List<CompanyLeavePolicyModel>>(bank);
            return res;
        }

        public async Task<List<EmployeeResignationModel>> GetEmployeeResignationsByEmployee(int id)
        {
            var bank = await _employeeRepository.GetEmployeeResignationByEmployeeId(id);
            var res = _mapper.Map<List<EmployeeResignationModel>>(bank);
            return res;
        }

        public async Task<EmployeeResignationModel> GetEmployeeResignation(int id)
        {
            var bank = await _employeeRepository.GetEmployeeResignationById(id);
            var res = _mapper.Map<EmployeeResignationModel>(bank);
            return res;
        }

        public async Task<List<EmployeeTerminationModel>> GetEmployeeTerminations(int id)
        {
            var bank = await _employeeRepository.GetEmployeeTerminations(id);
            var res = _mapper.Map<List<EmployeeTerminationModel>>(bank);
            return res;
        }

        public async Task<EmployeeTerminationModel> GetEmployeeTermination(int id)
        {
            var bank = await _employeeRepository.GetEmployeeTerminationById(id);
            var res = _mapper.Map<EmployeeTerminationModel>(bank);
            return res;
        }

        public async Task<EmployeeTravelModel> GetEmployeeTravel(int id)
        {
            var bank = await _employeeRepository.Get(id);
            var res = _mapper.Map<EmployeeTravelModel>(bank);
            return res;
        }
        public async Task<List<EmployeeModel>> GetAllEmployees(int companyId)
        {
            var emp = await _employeeRepository.GetEmployees(companyId);
            var res = _mapper.Map<List<EmployeeModel>>(emp);
            return res;
        }

        public async Task<int> GetTotalEmployees(int companyId)
        {
            return await _employeeRepository.GetTotalEmployees(companyId);
        }

        public async Task<EmployeeModel> GetEmployee(int id)
        {
            var emp =  await _employeeRepository.GetEmployeeDetail(id);
            var res = _mapper.Map<EmployeeModel>(emp);
            return res;
        }

        public async Task<EmployeeModel> GetNoTrackingEmployee(int id)
        {
            var emp =  await _employeeRepository.GetEmployeeDetail(id);
            var res = _mapper.Map<EmployeeModel>(emp);
            return res;
        }

        public async Task<EmployeeEducationModel> GetEmployeeEducation(int id)
        {
            var edu = await _employeeRepository.GetEmployeeEducation(id);
            var res = _mapper.Map<EmployeeEducationModel>(edu);
            return res;
        }

        public async Task<EmployeeEmergencyModel> GetEmployeeEmergency(int id)
        {
            var emg = await _employeeRepository.GetEmployeeEmergency(id);
            var res = _mapper.Map<EmployeeEmergencyModel>(emg);
            return res;
        }

        public async Task<EmployeeFamilyModel> GetEmployeeFamily(int id)
        {
            var fam = await _employeeRepository.GetEmployeeFamily(id);
            var res = _mapper.Map<EmployeeFamilyModel>(fam);
            return res;
        }

        public async Task<EmployeeLeaveModel> GetEMployeeLeave(int id)
        {
            var leave = await _employeeRepository.GetEMployeeLeave(id);
            var res = _mapper.Map<EmployeeLeaveModel>(leave);
            return res;
        }

        public async Task<CompanyLeavePolicyModel> GetEmployeeLeavePolicy(int id)
        {
            var leave = await _employeeRepository.GetEmployeeLeavePolicy(id);
            var res = _mapper.Map<CompanyLeavePolicyModel>(leave);
            return res;
        }

        public async Task<List<EmployeeLeaveModel>> GetEmployeeLeaves(int id)
        {
            var leaves = await _employeeRepository.GetEMployeeLeaves(id);
            var res = _mapper.Map<List<EmployeeLeaveModel>>(leaves);
            return res;
        }

        public async Task<int> GetTotalPendingLeaves(int id)
        {
            var leaves = await _employeeRepository.GetTotalPendingLeaves(id);
            return leaves;
        }

        public async Task<List<EmployeeLeaveModel>> GetEmployeeLeavesSummaries(int id, bool isToday)
        {
            List<EmployeeLeave> leaves = null;
            if(isToday)
            {
                leaves = await _employeeRepository.GetEMployeeTodayLeaves(id);
            }
            else
            {
                leaves = await _employeeRepository.GetEMployeeUpcomingLeaves(id);
            }
            var res = _mapper.Map<List<EmployeeLeaveModel>>(leaves);
            return res;
        }

        public async Task<List<EmployeeLeaveModel>> GetEmployeeLeavesByEmployee(int id)
        {
            var leaves = await _employeeRepository.GetEMployeeLeavesByEmployee(id);
            var res = _mapper.Map<List<EmployeeLeaveModel>>(leaves);
            return res;
        }

        public async Task<List<EmployeeLeaveModel>> GetEmployeeLeavesByTypeId(int id, int typeId)
        {
            var leaves = await _employeeRepository.GetEmployeeLeavesByTypeId(id, typeId);
            var res = _mapper.Map<List<EmployeeLeaveModel>>(leaves);
            return res;
        }

        public async Task<EmployeePensionModel> GetEmployeePension(int id)
        {
            var pen = await _employeeRepository.GetEmployeePension(id);
            var res = _mapper.Map<EmployeePensionModel>(pen);
            return res;
        }

        public async Task<List<MonthlyAttendanceReviewModel>> GetMonthlyAttendanceReview(int id, string Period)
        {
            var sp = Period.Split('/');
            var dateofMonth = new DateTime(int.Parse(sp[1]), int.Parse(sp[0]), 15);
            var start = dateofMonth.GetFirstDayOfMonth();
            var end = dateofMonth.GetLastDayOfMonth().AddHours(23).AddMinutes(59);
            var pen = await _employeeRepository.GetMonthlyAttendanceReview(id, start, end);
            var res = _mapper.Map<List<MonthlyAttendanceReviewModel>>(pen);
            return res;
        }

        public async Task<EmployeeStatutoryModel> GetEmployeeStatutory(int id)
        {
            var stat = await _employeeRepository.GetEmployeeStatutory(id);
            var res = _mapper.Map<EmployeeStatutoryModel>(stat);
            return res;
        }

        public async Task<EmployeeTaxModel> GetEmployeeTax(int id)
        {
            var stat = await _employeeRepository.GetEmployeeTax(id);
            var res = _mapper.Map<EmployeeTaxModel>(stat);
            return res;
        }

        public async Task<List<EmployeeTimetableModel>> GetEmployeeTimetable(int employeeId)
        {
            var tt = await _employeeRepository.GetEmployeeTimetables(employeeId);
            var res = _mapper.Map<List<EmployeeTimetableModel>>(tt);
            return res;
        }

        public async Task<EmployeeTransferModel> GetEmployeeTransfer(int id)
        {
            var trans = await _employeeRepository.GetEmployeeTransfer(id);
            var res = _mapper.Map<EmployeeTransferModel>(trans);
            return res;
        }

        public async Task<EmployeeExperienceModel> GetEmployeExp(int id)
        {
            var exp = await _employeeRepository.GetEmployeeExp(id);
            var res = _mapper.Map<EmployeeExperienceModel>(exp);
            return res;
        }

        public async Task<List<DisciplinaryMeasuresModel>> GetDisciplinaryMeasureByEmployee(int id)
        {
            var dm = await _employeeRepository.GetDisciplinaryMeasure(id);
            var res = _mapper.Map<List<DisciplinaryMeasuresModel>>(dm);
            return res;
        }

        public async Task<List<DisciplinaryMeasuresModel>> GetDisciplinaryMeasures(int id)
        {
            var dm = await _employeeRepository.GetDisciplinaryMeasures(id);
            var res = _mapper.Map<List<DisciplinaryMeasuresModel>>(dm);
            return res;
        }

        public async Task<List<QueryModel>> GetQueriesByEmployee(int id)
        {
            var dm = await _employeeRepository.GetQueriesByEmployeeId(id);
            var res = _mapper.Map<List<QueryModel>>(dm);
            return res;
        }

        public async Task<List<QueryModel>> GetQueries(int id)
        {
            var dm = await _employeeRepository.GetQueries(id);
            var res = _mapper.Map<List<QueryModel>>(dm);
            return res;
        }

        public async Task RemoveEmployee(int id)
        {
            await _employeeRepository.RemoveEmployee(id);
        }

        public async Task RemoveEmployeeBank(int id)
        {
            await _employeeRepository.RemoveEmployeeBank(id);
        }

        public async Task RemoveEmployeeLeavePolicy(List<int> EmployeeIds, int Id)
        {
            foreach(var id in EmployeeIds)
                await _employeeRepository.RemoveEmployeeLeavePolicyByEmployee(id, Id);
        }

        public async Task RemoveEmployeeSalary(int id)
        {
            await _employeeRepository.RemoveEmployeeSalary(id);
        }

        public async Task RemoveEmployeeEducation(int id)
        {
            await _employeeRepository.RemoveEmployeeEducation(id);
        }

        public async Task RemoveEmployeeEmergency(int id)
        {
            await _employeeRepository.RemoveEmployeeEmergency(id);
        }

        public async Task RemoveEmployeeExp(int id)
        {
            await _employeeRepository.RemoveEmployeeExp(id);
        }

        public async Task RemoveEMployeeFamily(int id)
        {
            await _employeeRepository.RemoveEMployeeFamily(id);
        }

        public async Task RemoveEmployeeLeave(int id)
        {
            await _employeeRepository.RemoveEmployeeLeave(id);
        }

        public async Task RemoveEmployeePension(int id)
        {
            await _employeeRepository.RemoveEmployeePension(id);
        }

        public async Task RemoveEmployeeStatutory(int id)
        {
            await _employeeRepository.RemoveEmployeeStatutory(id);
        }

        public async Task RemoveEmployeeTimetable(int id)
        {
            await _employeeRepository.RemoveEmployeeTimetable(id);
        }

        public async Task RemoveEmployeeTransfer(int id)
        {
            await _employeeRepository.RemoveEmployeeTransfer(id);
        }

        public async Task RemoveEmployeeTravel(int id)
        {
            await _employeeRepository.RemoveEmployeeTravel(id);
        }

        public async Task RemoveEmployeeResignation(int id)
        {
            await _employeeRepository.RemoveEmployeeResignation(id);
        }

        public async Task RemoveEmployeeTermination(int id)
        {
            await _employeeRepository.RemoveEmployeeTermination(id);
        }


        public async Task RemoveDisciplinaryMeasures(int id)
        {
            await _employeeRepository.RemoveDisciplinaryMeasures(id);
        }

        public async Task RemoveQuery(int id)
        {
            await _employeeRepository.RemoveQueries(id);
        }


        public async Task UpdateEmployee(EmployeeModel model, int id)
        {
            if(model.EmployeeManager != null)
            {
                var m = _mapper.Map<EmployeeManager>(model.EmployeeManager);
                if(m.Id == 0)
                {
                    await _employeeRepository.AddEmployeeManager(m);
                }
                else
                {
                    await _employeeRepository.UpdateEmployeeManager(m);
                }
            }
            var data = await _employeeRepository.GetNoTrackingEmployee(id);
            var n_data = _mapper.Map<Employee>(model);
            n_data.Id = data.Id;
            n_data.UserId = data.UserId;
            n_data.DesignationId = data.DesignationId;
            n_data.CreatedAt = data.CreatedAt;
            n_data.CreatedBy = data.CreatedBy;
            n_data.UpdatedAt = data.UpdatedAt;
            n_data.UpdatedBy = data.UpdatedBy;
            await _employeeRepository.Update(n_data);
        }

        public async Task UpdateEmployeeSalary(EmployeeSalaryModel model, int id)
        {
            var data = await _employeeRepository.GetNoTrackingEmployeeSalary(id);
            var datamodel = _mapper.Map<EmployeeSalary>(model);
            datamodel.Id = data.Id;
            datamodel.SalaryDate = data.SalaryDate;
            datamodel.CreatedAt = data.CreatedAt;
            datamodel.CreatedBy = data.CreatedBy;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.UpdatedBy = "SYSTEM";
            await _employeeRepository.UpdateCompanySalary(datamodel);
        }

        public async Task UpdateEmployeeBank(EmployeeBankModel model, int id)
        {
            var data = await _employeeRepository.GetEmployeeBank(id);
            data.BankAccountNumber = model.BankAccountNumber;
            data.BankName = model.BankName;
            await _employeeRepository.UpdateEmployeeBank(data);
        }

        public async Task UpdateEmployeeEducation(EmployeeEducationModel model, int id)
        {
            var data = await _employeeRepository.GetEmployeeEducation(id);
            data.Discipline = model.Discipline;
            data.EndYear = model.EndYear;
            data.StartYear = model.StartYear;
            data.Institute = model.Institute;
            await _employeeRepository.UpdateEmployeeEducation(data);
        }

        public async Task UpdateEmployeeEmergency(EmployeeEmergencyModel model, int id)
        {
            var data = await _employeeRepository.GetEmployeeEmergency(id);
            data.Name = model.Name;
            data.Phone1 = model.Phone1;
            data.Phone2 = model.Phone2;
            data.Relationship = model.Relationship;
            await _employeeRepository.UpdateEmployeeEmergency(data);
        }

        public async Task UpdateEmployeeExp(EmployeeExperienceModel model, int id)
        {
            var data = await _employeeRepository.GetEmployeeExp(id);
            data.Position = model.Position;
            data.StartYear = model.StartYear;
            data.EndYear = model.EndYear;
            data.CompanyName = model.CompanyName;
            await _employeeRepository.UpdateEmployeeExp(data);
        }

        public async Task UpdateEmployeeFamily(EmployeeFamilyModel model, int id)
        {
            var data = await _employeeRepository.GetEmployeeFamily(id);
            data.Name = model.Name;
            data.PhoneNo = model.PhoneNo;
            data.Relationship = model.Relationship;
            await _employeeRepository.UpdateEmployeeFamily(data);
        }

        public async Task UpdateEmployeeLeave(EmployeeLeaveModel model, int id)
        {
            var days = (model.ToDate - model.FromDate).TotalDays;
            var data = await _employeeRepository.GetEMployeeLeave(id);
            data.ApprovedBy = model.ApprovedBy;
            data.FromDate = model.FromDate;
            data.Reason = model.Reason;
            data.ToDate = model.ToDate;
            data.ApprovedBy = model.ApprovedBy;
            data.Status = model.Status;
            data.Days = Convert.ToInt32(days);
            await _employeeRepository.UpdateEmployeeLeave(data);
        }

        public async Task UpdateEmployeePension(EmployeePensionModel model, int id)
        {
            var data = await _employeeRepository.GetEmployeePension(id);
            data.EmployeeRate = model.EmployeeRate;
            data.EmployerRate = model.EmployerRate;
            data.PensionManager = model.PensionManager;
            data.PensionNo = model.PensionNo;
            await _employeeRepository.UpdateEmployeePension(data);
        }

        public async Task UpdateEmployeeStatutory(EmployeeStatutoryModel model, int id)
        {
            var data = await _employeeRepository.GetEmployeeStatutory(id);
            data.SalaryAmount = model.SalaryAmount;
            data.SalaryBasis = model.SalaryBasis;
            await _employeeRepository.UpdateEmployeeStatutory(data);
        }

        public async Task UpdateEmployeeTax(EmployeeTaxModel model, int id)
        {
            var data = await _employeeRepository.GetEmployeeTax(id);
            data.Tin = model.Tin;
            data.TaxCode = model.TaxCode;
            data.TaxOffice = model.TaxOffice;
            await _employeeRepository.UpdateEmployeeTax(data);
        }

        public async Task UpdateEmployeeTimetable(EmployeeTimetableModel model, int id)
        {
            var data = await _employeeRepository.GetEmployeeTimetable(id);
            data.AttendedDate = model.AttendedDate;
            data.PunchInTime = model.PunchInTime;
            data.PunchOutTime = model.PunchOutTime;
            await _employeeRepository.UpdateEmployeeTimetable(data);
        }

        public async Task UpdateEmployeeTransfer(EmployeeTransferModel model, int id)
        {
            var data = await _employeeRepository.GetEmployeeTransfer(id);
            data.DateJoined = model.DateJoined;
            data.FromCompany = model.FromCompany;
            data.ToCompany = model.ToCompany;
            await _employeeRepository.UpdateEmployeeTransfer(data);
        }

        public async Task UpdateEmployeeTravel(EmployeeTravelModel model, int id)
        {
            var datamodel = _mapper.Map<EmployeeTravel>(model);
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.UpdatedBy = "SYSTEM";
            await _employeeRepository.UpdateEmployeeTravel(datamodel);
        }

        public async Task UpdateEmployeeResignation(EmployeeResignationModel model, int id)
        {
            var datamodel = _mapper.Map<EmployeeResignation>(model);
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.UpdatedBy = "SYSTEM";
            await _employeeRepository.UpdateEmployeeResignation(datamodel);
        }

        public async Task UpdateExitInterview(ExitInterviewModel model, int id)
        {
            var datamodel = _mapper.Map<ExitInterview>(model);
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.UpdatedBy = "SYSTEM";
            await _employeeRepository.UpdateExitInterview(datamodel);
        }

        public async Task UpdateEmployeeTermination(EmployeeTerminationModel model, int id)
        {
            var datamodel = _mapper.Map<EmployeeTermination>(model);
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.UpdatedBy = "SYSTEM";
            await _employeeRepository.UpdateEmployeeTermination(datamodel);
        }

        public async Task UpdateDisciplinaryMeasures(DisciplinaryMeasuresModel model, int id)
        {
            var datamodel = _mapper.Map<DisciplinaryMeasures>(model);
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.UpdatedBy = "SYSTEM";
            await _employeeRepository.UpdateDisciplinaryMeasures(datamodel);
        }

        public async Task UpdateQuery(QueryModel model, int id)
        {
            var datamodel = _mapper.Map<Query>(model);
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.UpdatedBy = "SYSTEM";
            await _employeeRepository.UpdateQuery(datamodel);
        }
    }
}
