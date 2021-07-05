using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class ProffesionalExcellenceSettingsModel
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string KeyResult { get; set; }
        public string KeyPerformanceIndicator { get; set; }
        public int Weightage { get; set; }
    }
}
