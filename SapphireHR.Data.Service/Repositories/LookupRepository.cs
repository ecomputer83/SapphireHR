using SapphireHR.Database;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Data.Service.Repositories
{
    public class LookupRepository : GenericRepository<Lookup, ApplicationDbContext>
    {
        public LookupRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Task AddLookup(Lookup model)
        {
            return Task.CompletedTask;
        }

        public Task UpdateLookup(Lookup model)
        {
            return Task.CompletedTask;
        }

        public Task ReadLookup(Lookup model)
        {
            return Task.CompletedTask;
        }

        public Task RemoveLookup(Lookup model)
        {
            return Task.CompletedTask;
        }
    }
}
