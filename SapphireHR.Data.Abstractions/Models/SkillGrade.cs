using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class SkillGrade : BaseEntity
    {
        public int SkillsId { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public Skills Skills { get; set; }
    }
}
