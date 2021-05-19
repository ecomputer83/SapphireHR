using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class Vacancy : BaseEntity, IEntity
    {
        public int CompanyId { get; set; }
        public int JobProfileId { get; set; }
        public int DesignationId { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Scores { get; set; }
        public string Type { get; set; }
        public int RequestedBy { get; set; }
        public DateTime RequestedOn { get; set; }
        public DateTime PeriodFrom { get; set; }
        public DateTime PeriodTo { get; set; }

        [ForeignKey("RequestedBy")]
        public Employee Requestor { get; set; }

        [ForeignKey("DesignationId")]
        public Designation Designation { get; set; }
        [ForeignKey("JobProfileId")]
        public JobProfile JobProfile { get; set; }
        public virtual JobRequisition JobRequisition { get; set; }
        public virtual Vacancysettings Vacancysettings { get; set; }
        [NotMapped]
        public virtual List<Application> FreshApplications { get; set; }
        [NotMapped]
        public virtual List<Application> PhoneInterviewApplications { get; set; }
        [NotMapped]
        public virtual List<Application> FaceToFaceInterviewApplications { get; set; }
        [NotMapped]
        public virtual List<Application> TestInterviewApplications { get; set; }
        [NotMapped]
        public virtual List<Application> AcceptedApplications { get; set; }
        [NotMapped]
        public virtual List<Application> RejectedApplications { get; set; }


    }

    public class VacancySummary : BaseEntity, IEntity
    {
        public int CompanyId { get; set; }
        public int JobProfileId { get; set; }
        public int DesignationId { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Scores { get; set; }
        public int RequestedBy { get; set; }
        public DateTime RequestedOn { get; set; }
        public DateTime PeriodFrom { get; set; }
        public DateTime PeriodTo { get; set; }
        public string Title { get; set; }
        public int NewApplicationCount { get; set; }
        public int RejectedApplicationCount { get; set; }
        public int AcceptedApplicationCount { get; set; }
        public int PhoneInterviewCount { get; set; }
        public int FaceToFaceInterviewCount { get; set; }
        public int AptitudeTestInterviewCount { get; set; }

        
    }
}
