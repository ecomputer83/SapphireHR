using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class JobSkillLevel : BaseEntity
    {
        public JobProfile JobProfile { get; set; }
        public Skills Skills { get; set; }
        public SkillGrade SkillGrade { get; set; }
    }
}

