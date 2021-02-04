using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class Application : BaseEntity
    {
        public int ApplicantId { get; set; }
        public int VacancyId { get; set; }
        public DateTime StartDate { get; set; }
        public string NoticePeriod { get; set; }
        public double ExpectedSalary { get; set; }
        public string Document { get; set; }
        public string CoverLetter { get; set; }
        public Applicant Applicant { get; set; }
        public Vacancy Vacancy { get; set; }
    }
}
