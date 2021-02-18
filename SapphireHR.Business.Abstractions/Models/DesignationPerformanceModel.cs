using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class DesignationPerformanceModel 
    {
        public string Tech_CE { get; set; }
        public string Tech_Marketing { get; set; }
        public string Tech_Management { get; set; }
        public string Tech_Administration { get; set; }
        public string Tech_Presentation { get; set; }
        public string Tech_QOW { get; set; }
        public string Tech_Efficiency { get; set; }
        public string Org_Integrity { get; set; }
        public string Org_Professionalism { get; set; }
        public string Org_Teamwork { get; set; }
        public string Org_CriticalThinking { get; set; }
        public string Org_Conflict { get; set; }
        public string Org_Attendance { get; set; }
        public string Org_ATMD { get; set; }
        public int DesignationId { get; set; }
        public DesignationModel Designation { get; set; }

    }
}
