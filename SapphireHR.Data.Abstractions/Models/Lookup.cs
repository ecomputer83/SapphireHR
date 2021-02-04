using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class Lookup : BaseEntity
    {
        public string LookupType { get; set; }
        public string LookupValue { get; set; }
        public string LookupDescription { get; set; }
        public int LookupSort { get; set; }
    }
}
