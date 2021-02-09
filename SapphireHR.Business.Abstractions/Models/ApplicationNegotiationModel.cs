using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class ApplicationNegotiationModel
    {
        public int ApplicationId { get; set; }
        public bool RelatedTaskCompleted { get; set; }
        public bool NegotiationCompleted { get; set; }
        public string FinalDecision { get; set; }
    }
}
