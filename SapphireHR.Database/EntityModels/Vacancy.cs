using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class Vacancy : BaseEntity
    {
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Scores { get; set; }
        [ForeignKey("JobProfileId")]
        public JobProfile JobProfile { get; set; }

        [ForeignKey("Designation")]
        public Designation Designation { get; set; }
    }
}
