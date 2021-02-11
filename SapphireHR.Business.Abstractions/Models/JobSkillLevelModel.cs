using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class JobSkillLevelModel: BaseModel
    {
        public int JobProfileId { get; set; }
        public int SkillsId { get; set; }
        public int SkillGradeId { get; set; }
        public JobProfileModel JobProfile { get; set; }
        public SkillModel Skill { get; set; }
        public SkillGradeModel SkillGrade { get; set; }
    }
}
