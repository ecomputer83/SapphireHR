using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class SkillType : BaseEntity
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public CompanyInfo CompanyInfo { get; set; }
    }
}
