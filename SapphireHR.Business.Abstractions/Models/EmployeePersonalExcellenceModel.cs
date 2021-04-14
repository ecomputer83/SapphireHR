using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class EmployeePersonalExcellenceModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int PersonalExcellenceSetting { get; set; }
        public string SelfScore { get; set; }
        public string ROScore { get; set; }
    }
}
