using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class EmployeeInitiativeAchievementModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string BySelf { get; set; }
        public string ROComment { get; set; }
        public string HODComment { get; set; }
    }
}
