using System.ComponentModel.DataAnnotations.Schema;

namespace SapphireHR.Database.EntityModels
{
    public class CompanyEmployee : BaseEntity
    {
        public int CompanyId { get; set; }
        public int EmployeeId { get; set; }
        public int RankId { get; set; }

        [ForeignKey("CompanyId")]
        public CompanyInfo Company { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        [ForeignKey("RankId")]
        public Rank Rank { get; set; }
    }
}