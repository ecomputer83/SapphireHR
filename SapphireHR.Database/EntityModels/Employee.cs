namespace SapphireHR.Database.EntityModels
{
    public class Employee : BaseEntity, IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; } // "M" or "F"
        public string PassportIdentificationNumber { get; set; } // "Could be shortened to PIN for the model mappings or use like so"
        public string PassportPhoto { get; set; } // Url to Azure Blob store
        public string Nationality { get; set; }
        public string Religion { get; set; }
        public string MaritalStatus { get; set; } // "Single" "Married"
        public EmployeeBank EmployeeBank { get; set; }

    }
}