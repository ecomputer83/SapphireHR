using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class SkillType : BaseEntity
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
    }
}
