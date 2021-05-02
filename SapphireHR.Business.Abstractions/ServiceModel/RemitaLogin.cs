using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions
{
    public class RemitaLogin : BaseRequest
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
