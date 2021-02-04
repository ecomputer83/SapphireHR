using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class JobSkillLevel : BaseEntity
    {
        public int JobProfileId { get; set; }
        public int SkillsId { get; set; }
        public int SkillGradeId { get; set; }
        [ForeignKey("JobProfileId")]
        public JobProfile JobProfile { get; set; }
        [ForeignKey("SkillsId")]
        public Skills Skills { get; set; }
        [ForeignKey("SkillGradeId")]
        public SkillGrade SkillGrade { get; set; }
    }
}
