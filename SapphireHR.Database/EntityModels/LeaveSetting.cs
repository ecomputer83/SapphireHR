using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class LeaveSetting : BaseEntity
    {
        public int TypeId { get; set; }
        public int Days { get; set; }
        public bool CarryOver { get; set; }
        public int CarryOverMax { get; set; }
        public bool EarnedLeave { get; set; }
    }
}
