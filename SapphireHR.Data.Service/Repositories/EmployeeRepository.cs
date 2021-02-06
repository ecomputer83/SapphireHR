using SapphireHR.Data.Abstractions.Models;
using SapphireHR.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Data.Service.Repositories
{
    public class EmployeeRepository : GenericRepository<SapphireHR.Database.EntityModels.Employee, ApplicationDbContext>
    {
        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
