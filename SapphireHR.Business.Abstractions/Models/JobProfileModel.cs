using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class JobProfileModel: BaseModel
    {
        public int CompanyId { get; set; }
        public int RankId { get; set; }
        public int DepartmentId { get; set; }
        public string Title { get; set; }
        public string Experience { get; set; }
        public string Description { get; set; }
        public double SalaryMin { get; set; }
        public double SalaryMax { get; set; }
        public double AverageSalary { get; set; }

        public RankModel Rank { get; set; }
        public DepartmentModel Department { get; set; }
        public CompanyModel Company { get; set; }
    }
}
