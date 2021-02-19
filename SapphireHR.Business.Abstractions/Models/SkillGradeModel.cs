using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class SkillGradeModel : BaseModel
    {
        public int CompanyId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
    }
}
