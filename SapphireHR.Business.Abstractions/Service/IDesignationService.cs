using SapphireHR.Business.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Abstractions.Service
{
    public interface IDesignationService
    {
        Task<List<DesignationPerformanceModel>> GetDesignationPerformances();
        Task<DesignationPerformanceModel> GetDesignationPerformance(int id);
        Task AddDesignationPerformance(DesignationPerformanceModel model);
        Task UpdateDesignationPerformance(DesignationPerformanceModel model);
        Task RemoveDesignationPerformance(int id);
    }
}
