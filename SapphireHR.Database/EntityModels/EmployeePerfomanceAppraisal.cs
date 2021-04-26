using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class EmployeePerfomanceAppraisal : BaseEntity, IEntity
    {
        public int DesignationPerformanceId { get; set; }
        public int EmployeeId { get; set; }
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
        public DateTime AppraisalDate { get; set; }

        [ForeignKey("DesignationPerformanceId")]
        public DesignationPerformance DesignationPerformance { get; set; }
                
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
