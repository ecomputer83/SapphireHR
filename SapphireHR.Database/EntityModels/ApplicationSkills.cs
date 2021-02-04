using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class ApplicationSkills : BaseEntity
    {
        [ForeignKey("ApplicationId")]
        public Application Application { get; set; }
        [ForeignKey("JobSkillLevel")]
        public JobSkillLevel JobSkillLevel { get; set; }
        [ForeignKey("GradeId")]
        public SkillGrade SkillGrade { get; set; }
    }
}
