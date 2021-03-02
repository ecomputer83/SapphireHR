using Microsoft.EntityFrameworkCore;
using SapphireHR.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Data.Service.Repositories
{
    public class ExitRepository : GenericRepository<SapphireHR.Database.EntityModels.TerminationType, ApplicationDbContext>
    {
        public ExitRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Task<List<SapphireHR.Database.EntityModels.TerminationType>> GetTerminationTypes(int orgId)
        {
            return this._context.Set<SapphireHR.Database.EntityModels.TerminationType>().Where(t => t.OrganizationId == orgId).ToListAsync();
        }

        public Task<SapphireHR.Database.EntityModels.TerminationType> GetNoTrackingTerminationType(int id)
        {
            return this._context.Set<SapphireHR.Database.EntityModels.TerminationType>().AsNoTracking().FirstOrDefaultAsync(c=>c.Id == id);
        }
    }
}
