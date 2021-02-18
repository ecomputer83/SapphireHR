using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class JobProfessionModel: BaseModel
    {
        public int JobProfileId { get; set; }
        public double Salary { get; set; }
        public string EducationRequirement { get; set; }
        public string EducationDegree { get; set; }
    }
}
