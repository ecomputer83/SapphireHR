using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class Skill : BaseEntity, IEntity
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
        [ForeignKey("Type")]
        public SkillType SkillType { get; set; }
        [ForeignKey("CompanyId")]
        public CompanyInfo CompanyInfo { get; set; }
    }
}
