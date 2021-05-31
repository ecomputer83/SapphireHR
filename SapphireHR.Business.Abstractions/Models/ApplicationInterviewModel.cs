using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class ApplicationInterviewModel
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public DateTime StartDate { get; set; }
        public string NoticePeriod { get; set; }
        public string Remark { get; set; }
        public double ExpectedSalary { get; set; }
        public string SalaryType { get; set; }
        public int Status { get; set; }
    }
}
