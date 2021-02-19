using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class SkillGrade : BaseEntity
    {
        public int CompanyId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        [ForeignKey("CompanyId")]
        public CompanyInfo Company { get; set; }
    }
}
