using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions
{
    public class BaseResponse
    {
        public string status { get; set; }
        public string message { get; set; }
    }
}
