using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class JobSkillLevel : BaseEntity
    {
        public int JobProfileId { get; set; }
        public int SkillsId { get; set; }
        public int SkillGradeId { get; set; }
        public JobProfile JobProfile { get; set; }
        public Skills Skills { get; set; }
        public SkillGrade SkillGrade { get; set; }
    }
}

