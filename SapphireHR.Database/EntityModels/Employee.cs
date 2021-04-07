using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SapphireHR.Database.EntityModels
{
    public class Employee : BaseEntity, IEntity
    {
        public int OrganizationId { get; set; }
        public string UserId { get; set; }
        public int RankId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int DesignationId { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; } // "M" or "F"
        public string PassportIdentificationNumber { get; set; } // "Could be shortened to PIN for the model mappings or use like so"
        public string PassportPhoto { get; set; } // Url to Azure Blob store
        public string Nationality { get; set; }
        public string Religion { get; set; }
        public string MaritalStatus { get; set; } // "Single" "Married"

        [ForeignKey("DesignationId")]
        public Designation Designation { get; set; }

        [ForeignKey("RankId")]
        public Rank Rank { get; set; }

        [ForeignKey("DisciplinaryMeasuresId")]
        public DisciplinaryMeasures DisciplinaryMeasures { get; set; }

        public virtual List<EmployeeEducation> EmployeeEducations { get; set; }
        public virtual List<EmployeeEmergency> EmployeeEmergencies { get; set; }
        public virtual List<EmployeeExperience> EmployeeExperiences { get; set; }
        public virtual List<EmployeeFamily> EmployeeFamilies { get; set; }
        public virtual EmployeeBank EmployeeBank { get; set; }
        public virtual EmployeeStatutory EmployeeStatutory { get; set; }
        public virtual EmployeePension EmployeePension { get; set; }
    }
}