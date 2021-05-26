using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class ApplicationModel
    {
        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public int VacancyId { get; set; }
        public DateTime StartDate { get; set; }
        public string NoticePeriod { get; set; }
        public double ExpectedSalary { get; set; }
        public string Document { get; set; }
        public string CoverLetter { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public int Status { get; set; }
        public ApplicantModel Applicant { get; set; }
        public VacancyModel Vacancy { get; set; }
        public virtual ApplicationFaceToViewModel ApplicationFaceToView { get; set; }
        public virtual ApplicationInterviewModel ApplicationInterview { get; set; }
        public virtual ApplicationNegotiationModel ApplicationNegotiation { get; set; }
        public virtual ApplicationScoreModel ApplicationScore { get; set; }
        public virtual IEnumerable<ApplicationSkillModel> ApplicationSkills { get; set; }
    }
}
