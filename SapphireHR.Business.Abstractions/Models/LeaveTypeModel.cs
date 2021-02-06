using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class LeaveTypeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OrganizationId { get; set; }
    }
}
