using SapphireHR.Database;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Data.Service.Repositories
{
    public class LeaveRepository : GenericRepository<LeaveType, ApplicationDbContext>
    {
        public LeaveRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
