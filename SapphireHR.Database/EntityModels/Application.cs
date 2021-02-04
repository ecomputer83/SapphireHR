using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class Application : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public string NoticePeriod { get; set; }
        public double ExpectedSalary { get; set; }
        public string Document { get; set; }
        public string CoverLetter { get; set; }
        [ForeignKey("ApplicantId")]
        public Applicant Applicant { get; set; }
        [ForeignKey("VacancyId")]
        public Vacancy Vacancy { get; set; }
    }
}
