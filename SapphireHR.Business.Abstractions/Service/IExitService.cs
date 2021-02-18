using SapphireHR.Business.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Abstractions.Service
{
    public interface IExitService
    {
        Task<List<TerminationTypeModel>> GetTerminationTypes();
        Task<TerminationTypeModel> GetTerminationType(int id);
        Task AddTerminationType(TerminationTypeModel model);
        Task UpdateTerminationType(TerminationTypeModel model);
        Task RemoveTerminationType(int id);
    }
}
