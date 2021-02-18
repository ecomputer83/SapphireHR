using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class SkillModel: BaseModel
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }

        public SkillTypeModel SkillType { get; set; }
    }
}
