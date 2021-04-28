using Microsoft.EntityFrameworkCore;
using SapphireHR.Database;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Data.Service.Repositories
{
    
    public class LookupRepository : GenericRepository<Lookup, ApplicationDbContext>
    {
        ApplicationDbContext _context;
        public LookupRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public Task AddLookup(Lookup model)
        {
            return Task.CompletedTask;
        }

        public Task UpdateLookup(Lookup model)
        {
            return Task.CompletedTask;
        }

        public async Task<List<Lookup>> ReadLookup(string Type)
        {
            return await _context.Set<Lookup>().Where(l => l.LookupType == Type).ToListAsync();
        }

        public Task RemoveLookup(Lookup model)
        {
            return Task.CompletedTask;
        }
    }
}
