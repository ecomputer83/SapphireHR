using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class Holiday : BaseEntity
    {
        public int OrganizationId { get; set; }
        public string Title { get; set; }
        public DateTime HolidayDate { get; set; }
        public string Day { get; set; }
        public OrganizationInfo Organization { get; set; }
    }
}
