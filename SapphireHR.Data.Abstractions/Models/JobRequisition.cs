using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class JobRequisition : BaseEntity
    {
        public int JobProfileId { get; set; }
        public string Duties { get; set; }
        public JobProfile JobProfile { get; set; }
    }
}
