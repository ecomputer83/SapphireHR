using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class JobProfile : BaseEntity
    {
        public string Title { get; set; }
        public string Experience { get; set; }
        public string Description { get; set; }
        public decimal SalaryMin { get; set; }
        public decimal SalaryMax { get; set; }
        public decimal AverageSalary { get; set; }
        public RankPermission RankPermission { get; set; }
        public Department Department { get; set; }
    }
}
