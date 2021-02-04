using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class JobProfession : BaseEntity
    {
        public double Salary { get; set; }
        public string EducationRequirement { get; set; }
        public string EducationDegree { get; set; }
        public JobProfile JobProfile { get; set; }
    }
}
