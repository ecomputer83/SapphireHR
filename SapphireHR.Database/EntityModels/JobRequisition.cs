using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class JobRequisition : BaseEntity
    {
        public string Duties { get; set; }
        [ForeignKey("JobProfileId")]
        public JobProfile JobProfile { get;set; }
    }
}
