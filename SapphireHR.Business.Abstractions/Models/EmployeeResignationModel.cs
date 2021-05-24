using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class EmployeeResignationModel
    {
        public int Id { get; set; }
        public DateTime NoticeDate { get; set; }
        public DateTime ResignationDate { get; set; }
        public string Reason { get; set; }
        public int EmployeeId { get; set; }
        public int Status { get; set; }
        public EmployeeModel Employee { get; set; }
        public ExitInterviewModel ExitInterview { get; set; }
    }

    public class ExitInterviewModel
    {
        public int Id { get; set; }
        public int ResignationId { get; set; }
        public DateTime InterviewDate { get; set; }
        public string Observation { get; set; }
        public string Remark { get; set; }

        public EmployeeResignationModel Resignation { get; set; }
    }
}
