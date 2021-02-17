using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class SkillGradeModel : BaseModel
    {
        public int SkillTypeId { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
    }
}
