using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class LeaveSetting : BaseEntity
    {
        public int CompanyId { get; set; }
        public int TypeId { get; set; }
        public int Days { get; set; }
        public bool CarryOver { get; set; }
        public int CarryOverMax { get; set; }
        public bool EarnedLeave { get; set; }

        [ForeignKey("CompanyId")]
        public CompanyInfo CompanyInfo { get; set; }
    }
}
