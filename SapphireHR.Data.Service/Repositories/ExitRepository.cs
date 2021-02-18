using SapphireHR.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Data.Service.Repositories
{
    public class ExitRepository : GenericRepository<SapphireHR.Database.EntityModels.TerminationType, ApplicationDbContext>
    {
        public ExitRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
