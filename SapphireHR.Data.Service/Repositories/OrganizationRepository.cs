using System;
using System.Collections.Generic;
using System.Text;
using SapphireHR.Database;
using SapphireHR.Database.EntityModels;

namespace SapphireHR.Data.Service.Repositories
{
    public class OrganizationRepository : GenericRepository<OrganizationInfo, ApplicationDbContext>
    {
        public OrganizationRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
