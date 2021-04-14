using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class EmployeeProffesionalExcellenceModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int ProffesionalExcellenceSettingsId { get; set; }
        public int SelfScore { get; set; }
        public int ROScore { get; set; }
    }
}
