using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class EmployeePensionModel
    {
        public int EmployeeId { get; set; }
        public string PensionNo { get; set; }
        public int EmployeeRate { get; set; }
        public int EmployerRate { get; set; }
        public string PensionManager { get; set; }
    }
}
