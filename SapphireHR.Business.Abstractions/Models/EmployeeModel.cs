using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class EmployeeModel
    {
        public int RankId { get; set; }
        public int CompanyId { get; set; }
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
        
    }
}
