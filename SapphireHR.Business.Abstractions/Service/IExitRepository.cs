using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Abstractions.Service
{
    public interface IExitRepository
    {
        Task<List<TerminationType>> GetTerminationTypes();
        Task<TerminationType> GetTerminationType(int id);
        Task AddTerminationType(TerminationType model);
        Task UpdateTerminationType(TerminationType model);
        Task RemoveTerminationType(int id);
    }
}
