using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class Holiday : BaseEntity, IEntity
    {
        public int OrganizationId { get; set; }
        public string Title { get; set; }
        public DateTime HolidayDate { get; set; }
        public string Day { get; set; }
        [ForeignKey("OrganizationId")]
        public OrganizationInfo Organization { get; set; }
    }
}
