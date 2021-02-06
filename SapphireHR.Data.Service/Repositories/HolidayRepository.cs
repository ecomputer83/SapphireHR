using SapphireHR.Database;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Data.Service.Repositories
{
    public class HolidayRepository : GenericRepository<Holiday, ApplicationDbContext>
    {
        public HolidayRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
