using SapphireHR.Business.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Abstractions.Service
{
    public interface IMiscellaneousService
    {
        Task AddApplicant(ApplicantModel model);
        Task UpdateApplicant(ApplicantModel model, int id);
        Task<ApplicantModel> GetApplicant(int id);
        Task<List<ApplicantModel>> GetApplicants();
        Task RemoveApplicant(int id);

        Task<int> AddDepartment(DepartmentModel model);
        Task UpdateDepartment(DepartmentModel model, int id);
        Task<DepartmentModel> GetDepartment(int id);
        Task<DepartmentModel> GetDepartment(string name);
        Task RemoveDepartment(int id);

        Task<int> AddDesignation(DesignationModel model);
        Task UpdateDesignation(DesignationModel model, int id);
        Task<DesignationModel> GetDesignation(int id);
        Task<DesignationModel> GetDesignation(string name);
        Task RemoveDesignation(int id);
    }
}
