using System;
using System.Collections.Generic;
using System.Text;
using SapphireHR.Database;
using SapphireHR.Database.EntityModels;

namespace SapphireHR.Data.Service.Repositories
{
    public class SkillsRepository : GenericRepository<Skill, ApplicationDbContext>
    {
        public SkillsRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
