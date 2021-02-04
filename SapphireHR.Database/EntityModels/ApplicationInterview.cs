using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class ApplicationInterview : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public string NoticePeriod { get; set; }
        public string Remark { get; set; }
        public double ExpectedSalary { get; set; }
        public string SalaryType { get; set; }
        [ForeignKey("ApplicationId")]
        public Application Application { get; set; }
    }
}
