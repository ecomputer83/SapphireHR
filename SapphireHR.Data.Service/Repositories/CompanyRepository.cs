using SapphireHR.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Data.Service.Repositories
{
    public class CompanyRepository : GenericRepository<Database.EntityModels.CompanyInfo, ApplicationDbContext>
    {
        public CompanyRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
