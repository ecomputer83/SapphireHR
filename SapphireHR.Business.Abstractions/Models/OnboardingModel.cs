using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class OnboardingModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public bool TemplateCreation { get; set; }
        public bool CollectionOfPersonalData { get; set; }
        public bool DataMigration { get; set; }
        public bool MeetingExecutives { get; set; }
        public bool MeetingColleagues { get; set; }
        public bool Collectible { get; set; }
    }
}
