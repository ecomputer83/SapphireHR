using SapphireHR.Database;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Data.Service.Repositories
{
    public class RankRepository : GenericRepository<RankPermission, ApplicationDbContext>
    {
        public RankRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Task AddRankPermission(RankPermission model)
        {
            return Task.CompletedTask;
        }

        public Task UpdateRankPermission(RankPermission model)
        {
            return Task.CompletedTask;
        }

        public Task ReadRankPermission(RankPermission model)
        {
            return Task.CompletedTask;
        }

        public Task RemoveRankPermission(RankPermission model)
        {
            return Task.CompletedTask;
        }
    }
}
