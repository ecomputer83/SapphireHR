using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class JobProfile : BaseEntity
    {
        public string Title { get; set; }
        public string Experience { get; set; }
        public string Description { get; set; }
        public decimal SalaryMin { get; set; }
        public decimal SalaryMax { get; set; }
        public decimal AverageSalary { get; set; }
        [ForeignKey("RankId")]
        public RankPermission RankPermission { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
    }
}
