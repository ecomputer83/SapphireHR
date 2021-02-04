using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class ApplicationInterview : BaseEntity
    {
        public int ApplicationId { get; set; }
        public DateTime StartDate { get; set; }
        public string NoticePeriod { get; set; }
        public string Remark { get; set; }
        public double ExpectedSalary { get; set; }
        public string SalaryType { get; set; }
        public Application Application { get; set; }
    }
}
