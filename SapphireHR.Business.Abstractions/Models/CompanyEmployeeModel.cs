using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class CompanyEmployeeModel
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int EmployeeId { get; set; }
        public int RankId { get; set; }

        public CompanyModel Company { get; set; }

        public EmployeeModel Employee { get; set; }

        public RankModel Rank { get; set; }
    }
}
