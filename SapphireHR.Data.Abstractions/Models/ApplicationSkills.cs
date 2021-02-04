using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class ApplicationSkills : BaseEntity
    {
        public int ApplicationId { get; set; }
        public int JobSkillLevelId { get; set; }
        public int SkillGradeId { get; set; }
        public Application Application { get; set; }
        public JobSkillLevel JobSkillLevel { get; set; }
        public SkillGrade SkillGrade { get; set; }
    }
}
