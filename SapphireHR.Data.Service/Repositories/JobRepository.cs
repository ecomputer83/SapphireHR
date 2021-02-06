using SapphireHR.Database;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Data.Service.Repositories
{
    public class JobRepository : GenericRepository<JobProfile, ApplicationDbContext>
    {
        public JobRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
