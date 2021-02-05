using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class JobProfile : BaseEntity, IEntity
    {
        public int RankId { get; set; }
        public int DepartmentId { get; set; }
        public string Title { get; set; }
        public string Experience { get; set; }
        public string Description { get; set; }
        public double SalaryMin { get; set; }
        public double SalaryMax { get; set; }
        public double AverageSalary { get; set; }
        [ForeignKey("RankId")]
        public CompanyRank Rank { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
    }
}
