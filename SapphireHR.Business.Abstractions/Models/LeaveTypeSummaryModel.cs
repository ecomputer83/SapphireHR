using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class LeaveTypeSummaryModel
    {
        public int TypeId { get; set; }
        public string LeaveTypeName { get; set; }
        public int Eligible { get; set; }
        public int Used { get; set; }
    }
}
