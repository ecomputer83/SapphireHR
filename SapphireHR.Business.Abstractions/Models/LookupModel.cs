using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class LookupModel
    {
        public string LookupType { get; set; }
        public int LookupGroup { get; set; }
        public string LookupValue { get; set; }
        public string LookupDescription { get; set; }
        public int LookupSort { get; set; }
    }
}
