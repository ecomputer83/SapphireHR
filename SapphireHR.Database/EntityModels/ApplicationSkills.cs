using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class ApplicationSkills : BaseEntity
    {
        public int ApplicationId { get; set; }
        public int JobSkillLevelId { get; set; }
        public int GradeId { get; set; }
        [ForeignKey("ApplicationId")]
        public Application Application { get; set; }
        [ForeignKey("GradeId")]
        public SkillGrade SkillGrade { get; set; }
    }
}
