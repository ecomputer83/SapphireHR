using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class SkillGrade : BaseEntity
    {
        public int SkillTypeId { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }

        [ForeignKey("SkillTypeId")]
        public Skills Skills { get; set; }
    }
}
