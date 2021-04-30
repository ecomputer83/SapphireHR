using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions
{
    public class PensionCodeResponse : BaseResponse
    {
        public List<PensionCode> data { get; set; }
    }

    public class PensionCode
    {
        public string pfaCode { get; set; }
        public string description { get; set; }
    }
}
