using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public int RankId { get; set; }
        public int CompanyId { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int DesignationId { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; } // "M" or "F"
        public string PassportIdentificationNumber { get; set; } // "Could be shortened to PIN for the model mappings or use like so"
        public string NationalIdentityNumber { get; set; }
        public DateTime PassportExpiryDate { get; set; }
        public string EmploymentOfSpouse { get; set; }
        public int NoOfChildren { get; set; }
        public byte[] PassportPhoto { get; set; } // Url to Azure Blob store
        public string Nationality { get; set; }
        public string Religion { get; set; }
        public string MaritalStatus { get; set; } // "Single" "Married"
        public DateTime CreatedAt { get; set; }
        public DesignationModel Designation { get; set; }
        public  List<EmployeeEducationModel> EmployeeEducations { get; set; }
        public  List<EmployeeEmergencyModel> EmployeeEmergencies { get; set; }
        public  List<EmployeeExperienceModel> EmployeeExperiences { get; set; }
        public  List<EmployeeFamilyModel> EmployeeFamilies { get; set; }
        public  EmployeeBankModel EmployeeBank { get; set; }
        public  EmployeeManagerModel EmployeeManager { get; set; }
        public EmployeeStatutoryModel EmployeeStatutory { get; set; }
        public EmployeePensionModel EmployeePension { get; set; }
        public EmployeeTaxModel EmployeeTax { get; set; }
    }
}
