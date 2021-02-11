using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class ApplicationNegotiation : BaseEntity
    {
        public int ApplicationId { get; set; }
        public bool RelatedTaskCompleted { get; set; }
        public bool NegotiationCompleted { get; set; }
        public string FinalDecision { get; set; }
        public Application Application { get; set; }
    }
}
