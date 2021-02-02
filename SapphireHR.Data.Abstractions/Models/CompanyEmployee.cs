using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class CompanyEmployee : BaseEntity
    {
        public int CompanyId { get; set; }
        public int EmployeeId { get; set; }
        public int RankId { get; set; }
    }
}
