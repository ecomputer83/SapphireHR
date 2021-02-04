using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class ApplicationScore : BaseEntity
    {
        public int ApplicationId { get; set; }
        public Application Application { get; set; }
        public string Score { get; set; }
    }
}
