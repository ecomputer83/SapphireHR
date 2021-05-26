using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class Application : BaseEntity, IEntity
    {
        public int ApplicantId { get; set; }
        public int VacancyId { get; set; }
        public string Code { get; set; }
        public DateTime StartDate { get; set; }
        public string NoticePeriod { get; set; }
        public double ExpectedSalary { get; set; }
        public string Document { get; set; }
        public string CoverLetter { get; set; }

        [ForeignKey("ApplicantId")]
        public Applicant Applicant { get; set; }
        [ForeignKey("VacancyId")]
        [NotMapped]
        public Vacancy Vacancy { get; set; }

        public virtual ApplicationFaceToView ApplicationFaceToView { get; set; }
        public virtual ApplicationInterview ApplicationInterview { get; set; }
        public virtual ApplicationNegotiation ApplicationNegotiation { get; set; }
        public virtual ApplicationScore ApplicationScore { get; set; }
        public virtual IEnumerable<ApplicationSkills> ApplicationSkills { get; set; }
    }
}
