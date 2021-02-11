using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class LeaveSetting : BaseEntity
    {
        public int CompanyId { get; set; }
        public int TypeId { get; set; }
        public int Days { get; set; }
        public bool CarryOver { get; set; }
        public int CarryOverMax { get; set; }
        public bool EarnedLeave { get; set; }
        public CompanyInfo CompanyInfo { get; set; }
    }
}
