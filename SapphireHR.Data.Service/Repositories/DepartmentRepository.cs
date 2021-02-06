using SapphireHR.Database;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Data.Service.Repositories
{
    public class DepartmentRepository : GenericRepository<Department, ApplicationDbContext>
    {
        public DepartmentRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Task AddDepartment(Department model)
        {
            return Task.CompletedTask;
        }

        public Task UpdateDepartment(Department model)
        {
            return Task.CompletedTask;
        }

        public Task ReadDepartment(Department model)
        {
            return Task.CompletedTask;
        }

        public Task RemoveDepartment(Department model)
        {
            return Task.CompletedTask;
        }
    }
}
