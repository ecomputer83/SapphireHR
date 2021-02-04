using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class ApplicationNegotiation : BaseEntity
    {
        public string RelatedTaskCompleted { get; set; }
        public string NegotiationCompleted { get; set; }
        public string FinalDecision { get; set; }
        [ForeignKey("ApplicationId")]
        public Application Application { get; set; }
    }
}
