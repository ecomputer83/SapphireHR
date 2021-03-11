using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions
{
    public class SysAdminRequest : BaseRequest
    {
        public string hostHeader { get; set; }
        public string websiteName { get; set; }
    }
}
