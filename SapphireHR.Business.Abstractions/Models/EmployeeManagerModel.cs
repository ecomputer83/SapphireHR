using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class EmployeeManagerModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int ManagerId { get; set; }
        public EmployeeModel Employee { get; set; }
        public EmployeeModel Manager { get; set; }
    }
}
