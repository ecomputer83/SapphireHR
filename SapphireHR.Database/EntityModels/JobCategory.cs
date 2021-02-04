using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class JobCategory : BaseEntity
    {
        public string Industry { get; set; }
        public string Experience { get; set; }
        public string EmployeeType { get; set; }
        public string ContractType { get; set; }
        [ForeignKey("JobProfileId")]
        public JobProfile JobProfile { get; set; }
    }
}
