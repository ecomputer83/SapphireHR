using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class JobProfession : BaseEntity
    {
        public double Salary { get; set; }
        public string EducationRequirement { get; set; }
        public string EducationDegree { get; set; }
        [ForeignKey("JobProfileId")]
        public JobProfile JobProfile { get; set; }
    }
}
