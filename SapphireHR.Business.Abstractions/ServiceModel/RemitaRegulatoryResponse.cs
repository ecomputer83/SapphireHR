using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions
{
    public class RemitaRegulatoryResponse : BaseResponse
    {
        public RegulatoryData data { get; set; }
    }

    public class RegulatoryData
    {
        public string batchRef { get; set; }
        public string rrr { get; set; }
    }
}
