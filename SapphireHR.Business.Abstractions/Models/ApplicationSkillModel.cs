using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class ApplicationSkillModel
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public int JobSkillLevelId { get; set; }
        public int GradeId { get; set; }
        public int Status { get; set; }
    }
}
