using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class Vacancy : BaseEntity
    {
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Scores { get; set; }
        public JobProfile JobProfile { get; set; }
        public Designation Designation { get; set; }
    }
}
