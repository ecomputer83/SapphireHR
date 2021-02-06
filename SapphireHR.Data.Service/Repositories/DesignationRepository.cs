using SapphireHR.Database;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Data.Service.Repositories
{
    public class DesignationRepository : GenericRepository<Designation, ApplicationDbContext>
    {
        public DesignationRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Task AddDesignation(Designation model)
        {
            return Task.CompletedTask;
        }

        public Task UpdateDesignation(Designation model)
        {
            return Task.CompletedTask;
        }

        public Task ReadDesignation(Designation model)
        {
            return Task.CompletedTask;
        }

        public Task RemoveDesignation(Designation model)
        {
            return Task.CompletedTask;
        }
    }
}
