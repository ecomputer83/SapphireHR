using System;
using System.Collections.Generic;
using System.Text;
using SapphireHR.Business.Abstractions.Models;
using System.Threading.Tasks;

namespace SapphireHR.Business.Abstractions.Service
{
    public interface IEmployeeService
    {
        Task AddEmployee(EmployeeModel model);
        Task UpdateEmployee(EmployeeModel model, int id);
        Task<EmployeeModel> GetEmployee(int id);
        Task<EmployeeModel> GetAllEmployees();
        Task RemoveEmployee(int id);
        Task AddCompanyEmployee(CompanyEmployeeModel model);
        Task<CompanyEmployeeModel> GetCompanyEmployeeByUserId(string UserId);
        Task AddEmployeeBank(EmployeeBankModel model);
        Task UpdateEmployeeBank(EmployeeBankModel model, int id);
        Task<EmployeeBankModel> GetEmployeeBank(int id);
        Task RemoveEmployeeBank(int id);
        Task AddEmployeeEducation(EmployeeEducationModel model);
        Task UpdateEmployeeEducation(EmployeeEducationModel model, int id);
        Task<EmployeeEducationModel> GetEmployeeEducation(int id);
        Task RemoveEmployeeEducation(int id);
        Task AddEmployeeEmergency(EmployeeEmergencyModel model);
        Task UpdateEmployeeEmergency(EmployeeEmergencyModel model, int id);
        Task<EmployeeEmergencyModel> GetEmployeeEmergency(int id);
        Task RemoveEmployeeEmergency(int id);
        Task AddEmployeeExp(EmployeeExperienceModel model);
        Task UpdateEmployeeExp(EmployeeExperienceModel model, int id);
        Task<EmployeeExperienceModel> GetEmployeExp(int id);
        Task RemoveEmployeeExp(int id);
        Task AddEmployeeFamily(EmployeeFamilyModel model);
        Task UpdateEmployeeFamily(EmployeeFamilyModel model, int id);
        Task<EmployeeFamilyModel> GetEmployeeFamily(int id);
        Task RemoveEMployeeFamily(int id);
        Task AddEmployeeLeave(EmployeeLeaveModel model);
        Task UpdateEmployeeLeave(EmployeeLeaveModel model, int id);
        Task<EmployeeLeaveModel> GetEMployeeLeave(int id);
        Task RemoveEmployeeLeave(int id);
        Task AddEmployeePension(EmployeePensionModel model);
        Task UpdateEmployeePension(EmployeePensionModel model, int id);
        Task<EmployeePensionModel> GetEmployeePension(int id);
        Task RemoveEmployeePension(int id);
        Task AddEmployeeStatutory(EmployeeStatutoryModel model);
        Task UpdateEmployeeStatutory(EmployeeStatutoryModel model, int id);
        Task<EmployeeStatutoryModel> GetEmployeeStatutory(int id);
        Task RemoveEmployeeStatutory(int id);
        Task AddEmployeeTimetable(EmployeeTimetableModel model);
        Task UpdateEmployeeTimetable(EmployeeTimetableModel model, int id);
        Task<EmployeeTimetableModel> GetEmployeeTimetable(int id);
        Task RemoveEmployeeTimetable(int id);
        Task AddEmployeeTransfer(EmployeeTransferModel model);
        Task UpdateEmployeeTransfer(EmployeeTransferModel model, int id);
        Task<EmployeeTransferModel> GetEmployeeTransfer(int id);
        Task RemoveEmployeeTransfer(int id);
    }
}
