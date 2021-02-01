using System.ComponentModel.DataAnnotations.Schema;

namespace SapphireHR.Database.EntityModels
{
    public class EmployeeBank :BaseEntity
    {
        public string BankAccountNumber { get; set; }
        public string BankName { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}