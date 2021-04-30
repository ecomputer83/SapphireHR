using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions
{
    public class TaxCodeResponse : BaseResponse
    {
        public List<TaxCode> data { get; set; }
    }

    public class TaxCode
    {
        public string taxOffice { get; set; }
        public string description { get; set; }
    }
}
