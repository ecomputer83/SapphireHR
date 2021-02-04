using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class JobCategory : BaseEntity
    {
        public int JobProfileId { get; set; }
        public string Industry { get; set; }
        public string Experience { get; set; }
        public string EmployeeType { get; set; }
        public string ContractType { get; set; }
        public JobProfile JobProfile { get; set; }
    }
}
