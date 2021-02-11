using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class Vacancy : BaseEntity, IEntity
    {
        public int JobProfileId { get; set; }
        public int DesignationId { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Scores { get; set; }

        [ForeignKey("DesignationId")]
        public Designation Designation { get; set; }
        [ForeignKey("DesignationId")]
        public JobProfile JobProfile { get; set; }
    }
}
