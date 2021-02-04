using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class ApplicationSkills : BaseEntity
    {
        public Application Application { get; set; }
        public JobSkillLevel JobSkillLevel { get; set; }
        public SkillGrade SkillGrade { get; set; }
    }
}
