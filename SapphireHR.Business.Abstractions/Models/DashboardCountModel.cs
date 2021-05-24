using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class DashboardCountModel
    {
        public int TotalEmployees { get; set; }
        public int TotalApplications { get; set; }
        public double TotalSalaries { get; set; }
        public double TotalPrevSalaries { get; set; }
    }

    public class LeaveCountModel
    {
        public int TotalEmployees { get; set; }
        public int TotalAbsence { get; set; }
        public double TotalPendingLeave { get; set; }
    }
}
