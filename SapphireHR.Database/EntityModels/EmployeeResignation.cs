using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class EmployeeResignation : BaseEntity
    {
        public DateTime NoticeDate { get; set; }
        public DateTime ResignationDate { get; set; }
        public string Reason { get; set; }

        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public virtual ExitInterview ExitInterview { get; set; }
    }

    public class ExitInterview : BaseEntity
    {
        public int ResignationId { get; set; }
        public DateTime InterviewDate { get; set; }
        public string Observation { get; set; }
        public string Remark { get; set; }

        [ForeignKey("ResignationId")]
        public EmployeeResignation Resignation { get; set; }
    }
}
