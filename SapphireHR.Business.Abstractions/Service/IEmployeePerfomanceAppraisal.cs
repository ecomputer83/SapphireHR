using SapphireHR.Business.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Abstractions.Service
{
    public interface IEmployeePerfomanceAppraisal
    {
        Task AddEmployeePerfomanceAppraisal(EmployeePerfomanceAppraisalModel model);

        Task<List<EmployeePerfomanceAppraisalModel>> GetEmployeePerfomanceAppraisal(int Id);

        Task<List<EmployeePerfomanceAppraisalModel>> GetAllEmployeePerfomanceAppraisal(int Id);

        Task RemoveEmployeePerfomanceAppraisal(int id);

        Task UpdateEmployeePerfomanceAppraisal(EmployeePerfomanceAppraisalModel model, int id);
    }
}
