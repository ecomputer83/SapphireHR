using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class Onboarding : BaseEntity, IEntity
    {
        public int EmployeeId { get; set; }
        public bool TemplateCreation { get; set; }
        public bool CollectionOfPersonalData { get; set; }
        public bool DataMigration { get; set; }
        public bool MeetingExecutives { get; set; }
        public bool MeetingColleagues { get; set; }
        public bool Collectible { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
